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
            ActiveCaseRecord_Load();


        }      

        #region variables
        private string CaseNumber = "";
        private string CaseName = "";
        private string TrialDate = "";
        private int TeamId = 0;
        private string Note = "";
        #endregion

        private void ActiveCaseRecord_Load()
        {
            generateTeamOptions(comboBox1, query, keyV, valueV);

            dateTimePicker1.CustomFormat = " ";

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }


       


        #region Add button and checks
        /// <summary>
        /// This function is fierd on the Add button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //check if the case number is unique
            if (CheckUniqueKeyField(caseNumber, warning, uniqueQ, dbKey))
            {
                //get all the info
                getFormValues();

                //create query
                string q = "INSERT INTO `active_case`(`Case_No`, `Case_Name`, `Trial_Date`, `Team_ID`, `Note`) VALUES ";

                q += "( '" + CaseNumber + "', '" + CaseName + "', '" + TrialDate + "' ,'" + TeamId + "' ,'" + Note +"')";

                //TEST
                MessageBox.Show(q);
                
                //Create window  dialog for conformation
                DialogResult dialog = MessageBox.Show("Are you sure to add a new record?", "Add", MessageBoxButtons.YesNo);

                //If yes, return to the login page
                if (dialog == DialogResult.Yes)
                {
                    //Inserting record
                    db.InsertDeleteQuery(q);

                    //Show message
                    MessageBox.Show("Record was added to the table");

                   
                    var myParent = (MatrixForm)Owner;

                    myParent.LoadTable();

                    //Cleare form
                    CleanForm();
                }                
                
            }

        }

       





        /// <summary>
        /// This method assigns form's values to the private values
        /// </summary>
        private void getFormValues()
        {
            //get case number
            CaseNumber = caseNumber.Text;

            //get Case Name value if there is one
            CaseName = caseName.Text;

            //get Trial date if there is any
            TrialDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            //get Team Id
            TeamId = Convert.ToInt32(comboBox1.SelectedValue);

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
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
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


        /// <summary>
        /// This will prevent an error on load of more that one Record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ActiveCaseRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }
    }
}
