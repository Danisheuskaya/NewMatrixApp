using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
            Dictionary<string, string> options = new Dictionary<string, string>();

            string SelectAllUsers = "SELECT * FROM `person`";

            //Get the values from db into reader
            MySqlDataReader reader = db.Reader(SelectAllUsers);


            //For each line in the table
            while (reader.Read())
            {
                //Create string of user's first and last name:
                string UserName = reader["Fname"].ToString() + " " + reader["Lname"].ToString();

                //Add team member's names as Value, and team_ID as the key
                options.Add(reader["Login"].ToString(), UserName);
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
            //Get get login
            string login = userNamesComboBox.SelectedValue.ToString();

            MessageBox.Show("The login of the person is : " + login);
        }

        /// <summary>
        /// This method saves all the setting for the User
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save button was pressed ");
        }
    }
}
