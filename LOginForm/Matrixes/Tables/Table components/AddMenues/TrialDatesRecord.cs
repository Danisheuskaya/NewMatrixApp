using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOginForm
{
    public partial class TrialDatesRecord : FormPrototype
    {
        DBConnection db;

        public TrialDatesRecord()
        {
            //get database object
            db = new DBConnection();

            InitializeComponent();

            //Set start date format to empty by default
            startDateTimePicker.CustomFormat = " ";
            startDateTimePicker.Format = DateTimePickerFormat.Custom;

            //Set end date format to empty by default
            endDateTimePicker.CustomFormat = " ";
            endDateTimePicker.Format = DateTimePickerFormat.Custom;
        }

        #region Variables

        string RecordType = "";

        string StartDate = "";

        string EndDate = "";

        string CaseNoteInfo = "";

        string Place = "";

        #endregion

        #region Add Record Logic and Methods

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            //First, need to check if all required filleds have been filled
            if (CheckRequiredFields())
            {
                //Hide warnings
                typeWarning.Visible = false;
                startDateWarning.Visible = false;
                noteWarning.Visible = false;

                //Get all the values, Method described in Helpers Region
                GetFormValues();

                //construct add record query
                string addRecorQuery = "INSERT INTO `trial_dates`(`Start_Date`, `End_Date`, `Case_Name`, `Place`, `Tag`) " +
                               "VALUES ('" + StartDate + "','" + EndDate + "','" + CaseNoteInfo + "','" + Place + "','"+RecordType+"')";

                //TEST
                MessageBox.Show(addRecorQuery);


                //Create window  dialog for conformation
                DialogResult dialog = MessageBox.Show("Are you sure to add a new record?", "Add", MessageBoxButtons.YesNo);

                //If yes, return to the login page
                if (dialog == DialogResult.Yes)
                {
                    //Inserting record for MRC
                    db.InsertDeleteQuery(addRecorQuery);

                    //Show message
                    MessageBox.Show("Record was added to the table");


                    var myParent = (MatrixForm)Owner;

                    myParent.LoadTable();

                    //Cleare form
                    CleanForm();


                    //Update calendar dates, for some reason there is a bug
                    StartDate = "";
                    EndDate = "";

                    //Uncheck radio buttons
                    travelRadioButton.Checked = false;
                    trialRadioButton.Checked = false;
                }

            }
        }

       


        /// <summary>
        /// This method checks if all required fields have been field
        /// User must select record typy and enter starting date and leave some comments
        /// </summary>
        /// <returns></returns>
        private bool CheckRequiredFields()
        {
            bool valid = true;

            //Start date would be collected on the date cange event handeler                        

            //Get note
            CaseNoteInfo = caseNoteTextHolder.Text;

            //In case when both buttons unchecked, validations fails
            if (!trialRadioButton.Checked && !travelRadioButton.Checked)
            {
                //Show warning
                typeWarning.Visible = true;
                return false;
            }

            //Now checking if user selected start date
            if (string.IsNullOrEmpty(StartDate))
            {
                //Show warning
                startDateWarning.Visible = true;
                return false;
            }
            //Now checking if user entered any notes
            if (string.IsNullOrEmpty(CaseNoteInfo))
            {
                //Show warning
                noteWarning.Visible = true;
                return false;
            }

            //If user selected
            return valid;
        }

        #endregion

        #region Helpers

        /// <summary>
        /// This method retrieves all form values
        /// </summary>
        private void GetFormValues()
        {
            /* Get record type
             * if type is Trial, flag should be 0
             * if type is Travel. flag should be 1 */

            if (trialRadioButton.Checked) { RecordType = "0"; }
            if (travelRadioButton.Checked) { RecordType = "1"; }

            //Start date was collected during form check

            //End date was collected during datePickerEventHandler

            //CaseNoteInfo was collected during form check

            Place = placeTextHolder.Text;             
            
        }


        /// <summary>
        /// This method clears all the input from the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            CleanForm();

            //Uncheck radio buttons
            travelRadioButton.Checked = false;
            trialRadioButton.Checked = false;
        }


        #endregion


        #region Date Changed Handlers and End Date verefication

        /// <summary>
        /// This method get the start date value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //Start date collected when the Fom chacked
            //Change calendar display, so user sees date they selected
            startDateTimePicker.CustomFormat = "dd/MM/yyyy";

            //Get start date in SQL format
            StartDate = startDateTimePicker.Value.ToString("yyyy-MM-dd");

            //If end date was entered before, check if dates in valid range
            if (!string.IsNullOrEmpty(EndDate)) { CheckIfDatesInValidRange(); }

        }

        /// <summary>
        /// This method displays end date selected by user only
        /// if it is later then start date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //Get end date
            EndDate = endDateTimePicker.Value.ToString("yyyy-MM-dd");

            //If end dtae is later than the start date, retriew end date with SQL format
            if (CheckIfDatesInValidRange())
            {
                //remove warning
                endDateWarning.Visible = false;

                //Show user selected date
                endDateTimePicker.CustomFormat = "dd/MM/yyyy";
            }

                       

        }


        /// <summary>
        /// This method shows warnings if the end date is later then the start date
        /// </summary>
        /// <returns></returns>
        private bool CheckIfDatesInValidRange()
        {
            //show warning by default
            endDateWarning.Visible = true;

            if (!string.IsNullOrEmpty(EndDate))
            {
                //Compare two dates
                DateTime start = startDateTimePicker.Value;
                DateTime end = endDateTimePicker.Value;

                //if recieved earlier than request, it is an error
                if (start > end)
                {
                    //cleare end date
                    EndDate = "";
                    endDateTimePicker.CustomFormat = " ";
                    endDateTimePicker.Format = DateTimePickerFormat.Custom;
                    return false;
                }

            }
                //if dates are fine, return true
                return true;    

                 
        }

        #endregion



    }
}
