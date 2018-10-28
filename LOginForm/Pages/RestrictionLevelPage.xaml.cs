using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
namespace LOginForm.Pages
{
    /// <summary>
    /// Interaction logic for RestrictionLevelPage.xaml
    /// </summary>
    public partial class RestrictionLevelPage : Window
    {

        #region variabels
        DBConnection db = new DBConnection();

        string Login = "";

        string tableGroups = "0";

        string oldGroups = "";
        #endregion

        public RestrictionLevelPage()
        {
            InitializeComponent();

            LoadComboBox();
        }

        /// <summary>
        /// This method will populate comboBox with all the user's from "Person" dataTable
        /// </summary>
        private void LoadComboBox()
        {
            //Creating a Map object in order to save a team_id value
            Dictionary<List<string>, string> options = new Dictionary<List<string>, string>();

            string SelectAllUsers = "SELECT * FROM `person`";

            //Get the values from db into reader
            MySqlDataReader reader = db.Reader(SelectAllUsers);

            //Add empty list
            List<string> a = new List<string> { " ", " "};
            options.Add(a, "");

            //For each line in the table
            while (reader.Read())
            {
                //Create string of user's first and last name:
                string UserName = reader["Fname"].ToString() + " " + reader["Lname"].ToString();

                //Get User's Login and old groups so they can be displayed to Admin
                List<string> userKey = new List<string>();

                userKey.Add(reader["Login"].ToString());
                userKey.Add(reader["tabel_groups"].ToString());


                //Add team member's names as Value, and team_ID as the key
                options.Add(userKey, UserName);
            }

            //close connection
            db.CloseConnection();

            //Add collection to the comboBox
            userNamesComboBox.ItemsSource = options;

            //Show user persons full name
            userNamesComboBox.DisplayMemberPath = "Value";

            //Save value of person's login
            userNamesComboBox.SelectedValuePath = "Key";
            
        }

        /// <summary>
        /// This method will assign new value when selection of comboBox changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userNamesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Retrieve info about selected person
            List<string> userInformation = (List<string>)userNamesComboBox.SelectedValue;

            if(userInformation != null)
            {
                //Get login value
                Login = userInformation[0];

                //Get value of old groups permission
                oldGroups = userInformation[1];

                ShowUsersGroups();
            }
            
        }

        /// <summary>
        /// This method will show what groups User can Access NOW
        /// </summary>
        private void ShowUsersGroups()
        {

            //By default everything is unchecked
            group1CheckBox.IsChecked = false;
            group2CheckBox.IsChecked = false;
            group3CheckBox.IsChecked = false;
            group4CheckBox.IsChecked = false;
            group5CheckBox.IsChecked = false;


            //Move get old groups values
            List<string> groups = oldGroups.Split('_').OfType<string>().ToList();

            
            //For some reson Controls do not exist
            //Hence, hard code

            if (groups.IndexOf("1") != -1)
            {
                group1CheckBox.IsChecked = true;
            }           
            if (groups.IndexOf("2") != -1)
            {
                group2CheckBox.IsChecked = true;
            }
            if (groups.IndexOf("3") != -1)
            {
                group3CheckBox.IsChecked = true;
            }
            if (groups.IndexOf("4") != -1)
            {
                group4CheckBox.IsChecked = true;
            }
            if (groups.IndexOf("5") != -1)
            {
                group5CheckBox.IsChecked = true;
            }
        }

      

        /// <summary>
        /// This method saves all the setting for the User
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            ConstructGenerateGroupString();

            string UpdateUsersTableGroups = "UPDATE `person` SET `tabel_groups` = '" + tableGroups + "' where `Login` = '" + Login + "'";

            //TEST
            MessageBox.Show(UpdateUsersTableGroups);

            db.InsertDeleteQuery(UpdateUsersTableGroups);

            //TEST
            MessageBox.Show("Record Updated");

            //Update table groups in comboBox values
            LoadComboBox();
            userNamesComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// This method will construct a string that will represent what 
        /// tabel groups user can modefy.
        /// </summary>
        private void ConstructGenerateGroupString()
        {
            //By default, user can access and modefy Archive groups
            tableGroups = "0";

            //Mark what group user can modefy
            if (group1CheckBox.IsChecked == true)
            {
                tableGroups += "_1";
            }            
            if (group2CheckBox.IsChecked == true)
            {
                tableGroups += "_2";
            }
            
            if (group3CheckBox.IsChecked == true)
            {
                tableGroups += "_3";
            }

            if (group4CheckBox.IsChecked == true)
            {
                tableGroups += "_4";
            }
            if (group5CheckBox.IsChecked == true)
            {
                tableGroups += "_5";
            }
        }
    }
}
