
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
        int team = 0;
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
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        #region Load Functions

        /// <summary>
        /// On form load, generate oprions for the team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseTruckingRecord_Load(object sender, System.EventArgs e)
        {
            generateTeamOptions(comboBox1, teamQ,  keyV, valueV);
        }

        /// <summary>
        /// When user tryes to select date, return to the standart format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
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

        private void getFormValues()
        {
             caseNo = caseNumber.Text;
             name = caseName.Text;
             venue = VenueText.Text;
             team = Convert.ToInt32(comboBox1.SelectedValue);
             dateServed = ComplaintServed.Text;
             initDisc = intDiscovery.Text;
             attorney = attorneyText.Text;
             trialDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
             attLvl = AttorneyLevel.Text;
             demand = DemandText.Text;
             offer = offerText.Text;
             issue = IssuesText.Text;
             medRewiew = review.Text;
        }

        #endregion

        #region clear button
        /// <summary>
        /// Clear button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        /// <summary>
        /// This will prevent a bug when the form closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseTruckingRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }

        #endregion
    }
}
