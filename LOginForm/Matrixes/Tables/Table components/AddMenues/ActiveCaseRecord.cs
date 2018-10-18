using System;
using System.Windows.Forms;


namespace LOginForm
{
    public partial class ActiveCaseRecord : FormPrototype
    {
        private DBConnection db;

        string query = "SELECT * FROM `team` ORDER BY Team_ID";

        string keyV = "Team_ID";

        string valueV = "Name";

        string uniqueQ = "SELECT Case_No from active_case where Case_No = '";

        string dbKey = "Case_No";

        public ActiveCaseRecord()
        {
            db = new DBConnection();
            InitializeComponent();

            generateTeamOptions(teamIdComboHolder, query, keyV, valueV);

            trialDateTimePicker.CustomFormat = " ";
            trialDateTimePicker.Format = DateTimePickerFormat.Custom;

        }      

        #region variables
        private string CaseNumber = "";
        private string CaseName = "";
        private string TrialDate = "";
        private string TeamId = "0";
        private string Note = "";
        #endregion

        


       


        #region Add button and checks
        /// <summary>
        /// This function is fierd on the Add button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //get all the info
            getFormValues();
            //check if the case number is unique
            if (CheckUniqueKeyField(caseNumber, warning, uniqueQ, dbKey))
            {
                //get all the info
                //getFormValues();

                //create query
                string q = "INSERT INTO `active_case`(`Case_No`, `Case_Name`, `Trial_Date`, `Team_ID`, `Note`) VALUES ";

                q += "( '" + CaseNumber + "', '" + CaseName + "', '" + TrialDate + "' ,'" + TeamId + "' ,'" + Note +"')";

                AddNewRecord(q);

                //Clear Dates
                TrialDate = "";
                TeamId = "0";
                
            }

        }

       





        /// <summary>
        /// This method assigns form's values to the private values
        /// </summary>
        private void getFormValues()
        {
            //Case Number has been collected earlyer

            CaseNumber = caseNumber.Text;

            //get Case Name value if there is one
            CaseName = caseName.Text;

           //Trial Date Has been handeled in calendarValue change event

            //Team Id Has been handeled
            

            //get Note
            Note = note.Text;
        }


       


        #endregion


        #region Other Helpers

        /// <summary>
        /// By default date is empty, on change t6he format would be back to standart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Get calendar value in SQL format
            TrialDate = trialDateTimePicker.Value.ToString("yyyy-MM-dd");

            //Show user selected value in this format
            trialDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        /// <summary>
        /// This Method reasigns the selected Team Id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeamId = teamIdComboHolder.SelectedIndex.ToString();
        }

        #endregion

        #region clear button
        /// <summary>
        /// When the clear button clicked, all the fields would be cleared
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
