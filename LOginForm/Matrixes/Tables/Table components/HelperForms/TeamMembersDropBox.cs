using System;
using System.Windows.Forms;

namespace LOginForm
{
    public partial class TeamMembersDropBox : FormPrototype
    {
        TableCore tc;

        string query = "SELECT * FROM `team` ORDER BY Team_ID";

        string keyV = "Team_ID";

        string valueV = "Name";

        string UsersChoice = "";

        public TeamMembersDropBox(TableCore parentForm, string SelectedTeam)
        {
            InitializeComponent();
            tc = parentForm;

            //Populate comboBox
            generateTeamOptions(attorneyComboBox, query, keyV, valueV);

            SetDeafultComboBoxChoise(SelectedTeam);
        }

        /// <summary>
        /// This method will display old team choice as defaoult
        /// </summary>
        /// <param name="selectedTeam"></param>
        private void SetDeafultComboBoxChoise(string selectedTeam)
        {
            attorneyComboBox.SelectedIndex = attorneyComboBox.FindString(selectedTeam);
        }


        /// <summary>
        /// This method will svae user's chice in the holder 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void attorneyComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UsersChoice = attorneyComboBox.SelectedIndex.ToString();
        }

        private void clearButton_Click(object sender, System.EventArgs e)
        {
            CleanForm();
            UsersChoice = "0";
        }

        /// <summary>
        /// This method will save user's choice in the global variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addAttorneyButton_Click(object sender, System.EventArgs e)
        {
            tc.TeamIndexFromTheFormHolder = UsersChoice;

            Close();
        }
    }
}
