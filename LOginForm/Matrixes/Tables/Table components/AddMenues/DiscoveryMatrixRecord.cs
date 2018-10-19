using System;
using System.Drawing;
using System.Windows.Forms;

namespace LOginForm
{
    public partial class DiscoveryMatrixRecord : FormPrototype
    {

        #region Variables
        //Values needed to populate comboBox with teams
        string query = "SELECT * FROM `team` ORDER BY Team_ID";
        string keyV = "Team_ID";
        string valueV = "Name";

        string CaseName = "";
        string AttorneyID = "0";
        string Discovery = "";
        string DueDate = "";
        string Served = "0"; //By default, record is not served
        string Notes = "";


        #endregion

        public DiscoveryMatrixRecord()
        {
            InitializeComponent();

            //This mkethod wil populate comboBox with attorney teams
            generateTeamOptions(teamIdComboHolder, query, keyV, valueV);

            /*Set default format for the date pickers */
            dueDateTimePicker.CustomFormat = " ";
            dueDateTimePicker.Format = DateTimePickerFormat.Custom;

            
        }


        /// <summary>
        /// This method will add anew record to the db tanle after all checks done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidToAdd())
            {
                //Collect the rest of the values
                CollectValues();

                //Creating Add query
                string addQuery = "INSERT INTO `discovery_matrix`(`Case_Name`, `Team_ID`, `Discovery`, `Due_date`, `Flag_served`, `Notes`)" +
                                                        " VALUES ('"+CaseName+ "','"+AttorneyID+ "','"+Discovery+ "','"+DueDate+ "','"+Served+ "','"+Notes+"')";

                AddNewRecord(addQuery);

                CleanForm();

                //ClearDates
                DueDate = "";

                //Uncheck RadioButtons
                yesRadioButton.Checked = false;
                noRadioButton.Checked = false;
            }
        }

        

        /// <summary>
        /// This method will check if User entered Case name and selected not empty Attorney Team
        /// </summary>
        /// <returns></returns>
        private bool ValidToAdd()
        {
            //Get Values:            
            CaseName = caseNameHolder.Text;
            AttorneyID = teamIdComboHolder.SelectedIndex.ToString();

            //Check if User entered CaseName and team ID is not 0
            if (string.IsNullOrEmpty(CaseName) || AttorneyID.Equals("0") )
            {
                //Show warning
                warningLabel.ForeColor = Color.Red;

                return false;
            }

            //Hide warning
            warningLabel.ForeColor = Color.Black;
            return true;
        }

        /// <summary>
        /// This method will collect the rest of the table's values
        /// </summary>
        private void CollectValues()
        {
            // CaseName & Attorney ID has been collected earlyer

            Discovery = discoveryHolder.Text;

            //Due date has been collected in DateTimePickerHandeler


            if (yesRadioButton.Checked)
            {
                Served = "1";
            }
            else
            {
                Served = "0";
            }

            Notes = notesHolder.Text;

        }

        /// <summary>
        /// This method will collect value of the due date when Users selected it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dueDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //Collect date for the SQL
            DueDate = dueDateTimePicker.Value.ToString("yyyy-MM-dd");

            //Show user this format:
            dueDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        /// <summary>
        /// This method will reasign Attorney ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teamIdComboHolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            AttorneyID = teamIdComboHolder.SelectedIndex.ToString();
        }

        /// <summary>
        /// This method will cler all form input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            CleanForm();

            //Uncheck RadioButtons
            yesRadioButton.Checked = false;
            noRadioButton.Checked = false;

            //Clear date
            DueDate = "";
        }
    }
}
