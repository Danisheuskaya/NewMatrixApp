
using System;
using System.Windows.Forms;

namespace LOginForm
{
    public partial class CaseTruckingRecord : FormPrototype
    {
        DBConnection db;

        //Query needed to select all team options for the dropBox
        string teamQ = "SELECT * FROM `team` ORDER BY Team_ID";

        //Key field for the team_ID - Team Name pare
        string keyV = "Team_ID";

        //Value field for the team_ID - Team Name pare
        string valueV = "Name";

        //Query to retrieve a retrieve a record with case name if it is not unique
        string uniqueQ = "SELECT * FROM case_list WHERE Case_No = '";

        string dbKey = "Case_No";


        #region Varables

        string caseNo = "";
        string name = "";
        string venue = "";
        string team = "0";
        string dateServed = "";
        string initDisc = "";
        string attorney = "";
        string trialDate = "";
        string attLvl = "";
        string demand = "";
        string offer = "";
        string issue = "";
        string medRewiew = "";

        #endregion



       

        public CaseTruckingRecord()
        {
            InitializeComponent();
            db = new DBConnection();

            //On load clear date
            trialDateTimePicker.CustomFormat = " ";
            trialDateTimePicker.Format = DateTimePickerFormat.Custom;

            generateTeamOptions(teamComboBox, teamQ, keyV, valueV);
        }

        #region Event Handelers

       

        /// <summary>
        /// When user tryes to select date, return to the standart format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            //Get value for the SQL
            trialDate = trialDateTimePicker.Value.ToString("yyyy-MM-dd");

            //Show user this format
            trialDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        /// <summary>
        /// This function will assign a new team value when usere selects new drop box index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            team = teamComboBox.SelectedIndex.ToString();
        }

        #endregion

        #region Add Button

        /// <summary>
        /// This function runs some checks, and then adds a new row to the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, System.EventArgs e)
        {
            //check if the case number is unique
            if (CheckUniqueKeyField(caseNumber, warning, uniqueQ, dbKey))
            {
                //get all the info
                getFormValues();

                //create query
                string q = "INSERT INTO  `case_trucking`(`Case_Number`, `Case_Name`, `Venue`, `Team_ID`, `Date_Served`, `Initial_Discovery`, `Attorney`, `Trial_Date`, `Attorney_lvl`, `Demand`, `Offer`, `Issues`, `Medical_Rewiever`) VALUES ";

                q += "( '" + caseNo + "', '" + name + "', '" + venue + "' ,'" + team + "' ,'" + dateServed + "' ,'" + initDisc + "' ,'" + attorney + "' ,'" + trialDate + "' ,'" + attLvl + "' ,'" + demand + "' ,'" + offer + "' ,'" + issue + "' ,'" + medRewiew + "')";


                AddNewRecord(q);

                //Clean the date
                trialDate = "";

            }
        }

        private void getFormValues()
        {
             caseNo = caseNumber.Text;
             name = caseName.Text;
             venue = VenueText.Text;
            //Team is handeled by event Handeler
             dateServed = ComplaintServed.Text;
             initDisc = intDiscovery.Text;
             attorney = attorneyText.Text;
             //Trial date is handeled by the event handeler
             attLvl = AttorneyLevel.Text;
             demand = DemandText.Text;
             offer = offerText.Text;
             issue = IssuesText.Text;
             medRewiew = review.Text;
        }

        #endregion

        #region Clear button
        /// <summary>
        /// Clear button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        

        #endregion

       
    }
}
