using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;


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

        string newAdminGroups = "0";

        string oldGroups = "";

        string oldAdminGroups = "";
        #endregion

        public RestrictionLevelPage()
        {
            InitializeComponent();

            LoadComboBox();

            SetDefaultControls();
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
            List<string> a = new List<string> { " ", " ", " "};
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
                userKey.Add(reader["Admin_group_list"].ToString());


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

                //Get value of Admin permissions
                oldAdminGroups = userInformation[2];

                ShowUsersGroups();
            }
            
        }

       
        /// <summary>
        /// This method will show what groups User can Access NOW
        /// </summary>
        private void ShowUsersGroups()
        {            

            SetDefaultControls();


            //Move get button groups list
            List<string> groups = oldGroups.Split('_').OfType<string>().ToList();

            //Get admin list
            List<string> admin = oldAdminGroups.Split('_').OfType<string>().ToList();

            //For some reson Controls do not exist
            //Hence, hard code

            if (groups.IndexOf("1") != -1)
            {
                group1CheckBox.IsChecked = true;
                //Unlock radio ButtonGroup:
                gridGroup1.IsEnabled = true;

                //set radioButton value, showing if user is Admin or Viewer
                if(admin.IndexOf("1") != -1)
                {
                    adminRadio1.IsChecked = true;
                }
                else
                {
                    viewerRadio1.IsChecked = true;
                }
            }           
            if (groups.IndexOf("2") != -1)
            {
                group2CheckBox.IsChecked = true;
                //Unlock radio ButtonGroup:
                gridGroup2.IsEnabled = true;

                //set radioButton value, showing if user is Admin or Viewer
                if (admin.IndexOf("2") != -1)
                {
                    adminRadio2.IsChecked = true;
                }
                else
                {
                    viewerRadio2.IsChecked = true;
                }
            }
            if (groups.IndexOf("3") != -1)
            {
                group3CheckBox.IsChecked = true;
                //Unlock radio ButtonGroup:
                gridGroup3.IsEnabled = true;

                //set radioButton value, showing if user is Admin or Viewer
                if (admin.IndexOf("3") != -1)
                {
                    adminRadio3.IsChecked = true;
                }
                else
                {
                    viewerRadio3.IsChecked = true;
                }
            }
            if (groups.IndexOf("4") != -1)
            {
                group4CheckBox.IsChecked = true;
                //Unlock radio ButtonGroup:
                gridGroup4.IsEnabled = true;

                //set radioButton value, showing if user is Admin or Viewer
                if (admin.IndexOf("4") != -1)
                {
                    adminRadio4.IsChecked = true;
                }
                else
                {
                    viewerRadio4.IsChecked = true;
                }
            }
            if (groups.IndexOf("5") != -1)
            {
                group5CheckBox.IsChecked = true;
                //Unlock radio ButtonGroup:
                gridGroup5.IsEnabled = true;

                //set radioButton value, showing if user is Admin or Viewer
                if (admin.IndexOf("5") != -1)
                {
                    adminRadio5.IsChecked = true;
                }
                else
                {
                    viewerRadio5.IsChecked = true;
                }
            }
        }

       

  

        /// <summary>
        /// This method Unchecks all CheckBoxes
        /// And blocks all radio buttons groups by default
        /// </summary>
        private void SetDefaultControls()
        {
            //By default everything is unchecked
            group1CheckBox.IsChecked = false;
            group2CheckBox.IsChecked = false;
            group3CheckBox.IsChecked = false;
            group4CheckBox.IsChecked = false;
            group5CheckBox.IsChecked = false;

            //Block all ragioButton groups:
            gridGroup1.IsEnabled = false;
            gridGroup2.IsEnabled = false;
            gridGroup3.IsEnabled = false;
            gridGroup4.IsEnabled = false;
            gridGroup5.IsEnabled = false;

            //Uncheck All radio buttons
            adminRadio1.IsChecked = false;
            adminRadio2.IsChecked = false;
            adminRadio3.IsChecked = false;
            adminRadio4.IsChecked = false;
            adminRadio5.IsChecked = false;

            
            viewerRadio1.IsChecked = false;
            viewerRadio2.IsChecked = false;
            viewerRadio3.IsChecked = false;
            viewerRadio4.IsChecked = false;
            viewerRadio5.IsChecked = false;
          
        }


        /// <summary>
        /// This method saves all the setting for the User
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            ConstructGenerateGroupString();

            string UpdateUsersTableGroups = "UPDATE `person` SET `Admin_group_list` = '"+newAdminGroups+"', `tabel_groups` = '"+tableGroups+"' WHERE Login = '"+Login+"';";

            //TEST
            System.Windows.MessageBox.Show(UpdateUsersTableGroups);

            db.InsertDeleteQuery(UpdateUsersTableGroups);

            //TEST
            System.Windows.MessageBox.Show("Record Updated");

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

            newAdminGroups = "0";

            //Mark what group user can modefy
            if (group1CheckBox.IsChecked == true)
            {
                tableGroups += "_1";

                if(adminRadio1.IsChecked == true)
                {
                    newAdminGroups += "_1";
                }
            }            
            if (group2CheckBox.IsChecked == true)
            {
                tableGroups += "_2";
                if (adminRadio2.IsChecked == true)
                {
                    newAdminGroups += "_2";
                }
            }
            
            if (group3CheckBox.IsChecked == true)
            {
                tableGroups += "_3";
                if (adminRadio3.IsChecked == true)
                {
                    newAdminGroups += "_3";
                }
            }

            if (group4CheckBox.IsChecked == true)
            {
                tableGroups += "_4";
                if (adminRadio4.IsChecked == true)
                {
                    newAdminGroups += "_4";
                }
            }
            if (group5CheckBox.IsChecked == true)
            {
                tableGroups += "_5";
                if (adminRadio5.IsChecked == true)
                {
                    newAdminGroups += "_5";
                }
            }
        }

        /// <summary>
        /// This will handel the radio Buttons appearnece
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void group1CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if(group1CheckBox.IsChecked == true)
            {
                //Show radio buttons
                gridGroup1.IsEnabled = true;
            }
            else
            {
                //Show radio buttons
                gridGroup1.IsEnabled = false;

            }
        }

        private void group2CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (group2CheckBox.IsChecked == true)
            {
                //Show radio buttons
                gridGroup2.IsEnabled = true;
            }
            else
            {
                //Show radio buttons
                gridGroup2.IsEnabled = false;

                
            }
        }

        private void group3CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (group3CheckBox.IsChecked == true)
            {
                //Show radio buttons
                gridGroup3.IsEnabled = true;
            }
            else
            {
                //Show radio buttons
                gridGroup3.IsEnabled = false;
            }
        }

        private void group4CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (group4CheckBox.IsChecked == true)
            {
                //Show radio buttons
                gridGroup4.IsEnabled = true;
            }
            else
            {
                //Show radio buttons
                gridGroup4.IsEnabled = false;
            }
        }

        private void group5CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (group5CheckBox.IsChecked == true)
            {
                //Show radio buttons
                gridGroup5.IsEnabled = true;
            }
            else
            {
                //Show radio buttons
                gridGroup5.IsEnabled = false;
            }
        }

        
    }
}
