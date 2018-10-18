using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LOginForm
{
    public partial class MedicalRecord : FormPrototype
    {
        #region Variables

        private DBConnection db;

        //Defaoult values for the add query;
        int casePairID = 0;
        string caseName = "";
        string caseNumber = "";
        string facility = "";
        string address = "";
        string letterType = ""; //possible hardcoded dropBox
        string dateRequested = ""; //calendar
        string expirationDate = "";
        string dateRecieved = ""; //calendar
        string notes = "";


        #endregion

        public MedicalRecord()
        {
            //create database connection obj
            db = new DBConnection();

            InitializeComponent();

            //Show the id for this record
            ShowIdOfTheRecord();

            //Fill the letter type options: 48(2 days) and 1158??(6 days)
            FillLetterTypeOptions();

            //Set requested date format to empty by default
            dateRequestedTimePicker.CustomFormat = " ";

            dateRequestedTimePicker.Format = DateTimePickerFormat.Custom;

            //Set recieved date format to empty by default
            dateRecievdTimePicker.CustomFormat = " ";

            dateRecievdTimePicker.Format = DateTimePickerFormat.Custom;
        }


        #region Load Helpers

        /// <summary>
        /// This method will calculate the unique id of the pair, 
        /// save the result in the casePairID,
        /// and display the value in the form for user to know.
        /// </summary>
        private void ShowIdOfTheRecord()
        {
            //Get the value of the largest id in the table at the moment:

            //run the query
            MySqlDataReader reader = db.Reader("SELECT MAX(Case_Pair_ID) from medical_record");

            //read the line
            reader.Read();

            //convert value into the integer and add one, to make value unique
            casePairID = Convert.ToInt32(reader["MAX(Case_Pair_ID)"].ToString()) + 1;

            db.CloseConnection();

            //Display future ID in the form holder
            caseIDHolder.Text = "" + casePairID;
        }


        /// <summary>
        /// This method adds options of the letter type.
        /// 48 meand that letter supposed to be received in 2 days and 1158 for some reason means 6 days
        /// </summary>
        private void FillLetterTypeOptions()
        {
            //Creating a Map object in order to create selection options
            Dictionary<int, string> options = new Dictionary<int, string>();

            //Right now there is an option to have an empty letter type
            options.Add(0, "");
            options.Add(1, "48");
            options.Add(2, "1158");

            //adding a datasource to the comboBox
            letterTypeDropBox.DataSource = new BindingSource(options, null);

            //Show the value
            letterTypeDropBox.DisplayMember = "Value";

            //retriv the value
            letterTypeDropBox.ValueMember = "Value";
            
        }


        #endregion
               
        #region Process Helpers
        /// <summary>
        /// This method saves all the values from the form into their holders
        /// </summary>
        private void getFormValues()
        {
            //Case_pair_ID was collected on teh load of the form

            //Case name is gathered when form validates partial key

            //Case number is gathered when form validates partial key

           //Facility gathered when form validates partial key

            address = addressHolder.Text;

            //LetterType is gathered when user changes selected value

            //Date requested is gathered after datePicker event fierd

            //Expiration date is calculated with helper function

            //Date record recievd is gathered after datePicker event fierd

            notes = notesHolder.Text;

            //TEST
            MessageBox.Show(caseName + " " + caseNumber + " " + facility + " " + address + " " + letterType + " " + dateRequested +
                " " + expirationDate + " " + dateRecieved + " " + notes );
            

        }

        #endregion

        #region Add Record Button and Methods

        private void AddRecordButton_Click(object sender, EventArgs e)
        {

            //By default partial key is not correct, show warning
            uniqueComboWarning.ForeColor = Color.OrangeRed;

            if (CheckIfValidToAdd())
            {
                //Change warning color back to black
                uniqueComboWarning.ForeColor = Color.Black;

                //Get all the values
                getFormValues();

                //create queryes           

                string queryForMedicalRecord = "INSERT INTO `medical_record`(`Case_Pair_ID`, `Case_Name`, `Case_Number`, `Facility`, `Adderess`, `Letter_Type`, `Date_Requested`, `Expiration_Date`, `Date_Recieved`, `Notes`, `Requested_flag`) " +
                                                "VALUES ('" + casePairID + "', '" + caseName + "', '" + caseNumber + "', '" + facility + "', '" + address + "', '" + letterType + "', '" + dateRequested + "', '" + expirationDate + "', '" + dateRecieved + "', '" + notes + "', '');";

                AddNewRecord(queryForMedicalRecord);

                    //Update the ID
                    ShowIdOfTheRecord();

                    //Update calendar dates, for some reason there is a bug
                    dateRecieved = "";
                    dateRequested = "";
                    expirationDate = "";
                


            }


        }
        /// <summary>
        /// Since table can have multiple record on the same name,
        /// The partial key consist of: Case Name, Case Number and Facility
        /// This method will check if entered combination is unique
        /// </summary>
        private bool CheckIfValidToAdd()
        {
            bool unique = true;
            
            //Get case Name
            caseName = caseNameHolder.Text;

            //Get case number
            caseNumber = caseNumberHolder.Text;

            //Get facility
            facility = facilityHolder.Text;

            //Create a query that will retrieve a row from the table that corrsepond this combination
            string query = "SELECT * from medical_record WHERE " +
                "`Case_Name` = '"+caseName+"' AND `Case_Number` = '"+caseNumber+"' AND `Facility` = '"+facility+"'";

            //process query
            MySqlDataReader reader = db.Reader(query);

            //If there is a value
            while (reader.Read())
            {
                //If there is a line in the reader => name is not unique
                unique = false;
            }

            //close connection
            db.CloseConnection();

            return unique;

        }

        #endregion


        #region Letter Type and Dates

        /// <summary>
        /// This method will assign a letterType after user changes selected value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void letterTypeDropBox_SelectedValueChanged(object sender, EventArgs e)
        {
            letterType = letterTypeDropBox.SelectedValue.ToString();

            //If request date was previously selected, calculate expiration date
            if (!string.IsNullOrEmpty(dateRequested))
            {
                CalculateExpirationDate();
            }
        }


        /// <summary>
        /// This method will updated requested date value and calculate expiration date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateRequestedTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //assign request date
            dateRequested = dateRequestedTimePicker.Value.ToString("yyyy-MM-dd");

            //change display value
            dateRequestedTimePicker.CustomFormat = "dd/MM/yyyy";

            //calculate expiration date only if letter tipe is selected 
            if (!string.IsNullOrEmpty(letterType))
            {
                CalculateExpirationDate();
            }
            
        }

        /// <summary>
        /// This method calculates expiration date based on the letter type and date when letter was requested
        /// 1) leter type 48h : Expiration date = requested date + 2 days;
        /// 2) leter type 1158: Expiration date = requested date + 6 days;
        /// 3) leter type " ": Expiration date is not determined.
        /// </summary>
        private void CalculateExpirationDate()
        {
            DateTime request = dateRequestedTimePicker.Value;

            DateTime expiration = new DateTime();            

            
            if (letterType.Equals("48"))
            {
                //adding 2 days
                expiration = request.AddDays(2);

                //format that will be displayed to the user
                expirationDateHolder.Text = expiration.ToString("dddd, dd MMMM yyyy");

                //format for the sql
                expirationDate = expiration.ToString("yyyy-mm-dd");

                //change display color
                expirationDateHolder.ForeColor = System.Drawing.Color.Black;
            }
            else if (letterType.Equals("1158"))
            {
                //Adding 6 days
                expiration = request.AddDays(6);

                //date format for user
                expirationDateHolder.Text = expiration.ToString("dddd, dd MMMM yyyy");

                //date format for SQL
                expirationDate = expiration.ToString("yyyy-MM-dd");

                //change display color
                expirationDateHolder.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                //Warning for user
                expirationDateHolder.Text = "Select letter type and request date";

                //no expiration date
                expirationDate = "";

                //change color
                expirationDateHolder.ForeColor = System.Drawing.Color.DarkRed;
            }

        }

        #endregion


        #region Recievd date and Dates Check

        /// <summary>
        /// This method will retrieve the date when letter recieved from the dtae time picker
        /// It will also check, that date of recieveng the letter is later then the request date,
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateRecievdTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //Get the date value for the sql
            dateRecieved = dateRecievdTimePicker.Value.ToString("yyyy-MM-dd");

            //Make a check if recieved date is in allowed range
            if (RequestRecievedDatesChecker())
            {
                //Set recieved date format to show on the calendar
                dateRecievdTimePicker.CustomFormat = "dd/MM/yyyy";

                //remove warning
                recieveDateWarningLable.Visible = false;
            }
            else //discard selected date
            {
                //Set recieved date format to empty by default
                dateRecievdTimePicker.CustomFormat = " ";

                dateRecievdTimePicker.Format = DateTimePickerFormat.Custom;
            }
            
            
        }


        /// <summary>
        /// This method will check that the reciving date is later than request date
        /// </summary>
        private bool RequestRecievedDatesChecker()
        {
            //By default show warning, it will be elimiunated if method returns true
            recieveDateWarningLable.Visible = true;

            //First, if request date is not specified, it is imposible to get a reciving date
            if (string.IsNullOrEmpty(dateRequested)) { return false; }

            //check if reciving date is later than request date
            else
            {
                DateTime request = dateRequestedTimePicker.Value;
                DateTime recieved = dateRecievdTimePicker.Value;

                //if recieved earlier than request, it is an error
                if (recieved < request) { return false; }

                //if dates are fine, return true
                return true;
            }
            
        }

        #endregion

        #region Clear button

        private void clearButton_Click(object sender, EventArgs e)
        {
            CleanForm(); //Method from the FormPrototype
        }

        #endregion
    }
}
