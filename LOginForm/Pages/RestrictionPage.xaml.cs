using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace LOginForm.Pages
{
    /// <summary>
    /// Interaction logic for ResrtrictionPage.xaml
    /// </summary>
    public partial class ResrtrictionPage : Window
    {
        DBConnection db = new DBConnection();
        Person User;

        #region Variabels

        string Login = "";
        string tableGroups = "0";
        string newAdminGroups = "0";
        string oldGroups = "";
        string oldAdminGroups = "";

        #endregion

        public ResrtrictionPage(Person user)
        {
            InitializeComponent();
            User = user;
            LoadComboBox();
            CheckPermission();
           
        }

        /// <summary>
        /// This method will block regular user from acessing 
        /// Admin buttons
        /// </summary>
        private void CheckPermission()
        {
            if (User.Role.Equals("user"))
            {
                RoutedEventArgs e = new RoutedEventArgs();
                //Press my status button
                MyStatusButton_Click(this, e);
                MyStatusButton.Visibility = Visibility.Collapsed;
                ComboName.Content = "USER NAME : ";

                //Hide save changes button
                SaveChangesButton.Visibility = Visibility.Collapsed;
                userNamesComboBox.IsEnabled = false;
            }
        }



        #region Load ComboBox
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
            List<string> a = new List<string> { " ", " ", " " };
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
        #endregion

        #region Boxes
        /// <summary>
        /// This method will assign new value when selection of comboBox changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userNamesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClearCheckBoxes();

            //Retrieve info about selected person
            List<string> userInformation = (List<string>)userNamesComboBox.SelectedValue;

            if (userInformation != null)
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
        /// This method clears previous selcetions
        /// </summary>
        private void ClearCheckBoxes()
        {
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

            //Unckeck checkBoxes
            //By default everything is unchecked
            group1CheckBox.IsChecked = false;
            group2CheckBox.IsChecked = false;
            group3CheckBox.IsChecked = false;
            group4CheckBox.IsChecked = false;
            group5CheckBox.IsChecked = false;
        }

        /// <summary>
        /// This method shows what tabels User can see, 
        /// and what status they have
        /// </summary>
        private void ShowUsersGroups()
        {
            //Get button groups list
            List<string> groups = oldGroups.Split('_').OfType<string>().ToList();

            //Get admin list
            List<string> admin = oldAdminGroups.Split('_').OfType<string>().ToList();

            //For some reson Controls do not exist
            //Hence, hard code

            if (groups.IndexOf("1") != -1)
            {
                group1CheckBox.IsChecked = true;
                
                //set radioButton value, showing if user is Admin or Viewer
                if (admin.IndexOf("1") != -1)
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

        #endregion

        #region Buttons

        /// <summary>
        /// This method will Change Users groups
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            ConstructGenerateGroupString();

            string UpdateUsersTableGroups = "UPDATE `person` SET `Admin_group_list` = '" + newAdminGroups + "', `tabel_groups` = '" + tableGroups + "' WHERE Login = '" + Login + "';";

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

                if (adminRadio1.IsChecked == true)
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
        /// This method will close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            //Create window  dialog for conformation
            DialogResult dialog = System.Windows.Forms.MessageBox.Show("Do you want to close application?", "Exit", MessageBoxButtons.YesNo);

            //If yes, close application
            if (dialog == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }
            //If not, cancel
            e.Handled = true;
        }

        #endregion


        #region Event Listeners

        private void InformationButton_Click(object sender, RoutedEventArgs e)
        {
            InformationPopUp.IsOpen = true;
        }

        private void CloseInfoButton_Click(object sender, RoutedEventArgs e)
        {
            InformationPopUp.IsOpen = false;
        }


        #endregion

        /// <summary>
        /// This method will show information about logged in user:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyStatusButton_Click(object sender, RoutedEventArgs e)
        {
            
            SearchForName();
            
        }

        /// <summary>
        /// This method will find User's name from the comboBox list
        /// </summary>
        private void SearchForName()
        {
            string userName = User.Fname + " " + User.Lname;


            int i = 0;
            bool found = false;
            while(i < userNamesComboBox.Items.Count && !found)
            {
                var Item = userNamesComboBox.Items[i];
                if (Item is KeyValuePair<List<string>, string>)
                {
                    //Retrieve key:
                    List<string> key = ((KeyValuePair<List<string>, string>)Item).Key;

                    //Check if login from comboBox is the same as user's
                    if (key[0].Equals(User.Login))
                    {
                        found = true;
                        userNamesComboBox.SelectedIndex = i;
                    }
                }

                i++;
                //

            }
        }
    }
}
