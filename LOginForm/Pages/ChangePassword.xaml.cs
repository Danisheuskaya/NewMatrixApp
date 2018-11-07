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
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        Person loggedInUser;
        string oldPassword = "";
        string newPassword = "";
        string passwordConformation = "";

        DBConnection db = new DBConnection();

        public ChangePassword(Person person)
        {
            InitializeComponent();
            loggedInUser = person;
        }

        /// <summary>
        /// This method will save user's new password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckFormValues())
            {
                // Update query
                string UpdateUserPassword = "UPDATE `person` SET `Password` = '" + newPassword + "' WHERE `Login` = '" + loggedInUser.Login + "'";

                db.InsertDeleteQuery(UpdateUserPassword);

                MessageBox.Show("Password updated");

                Close();
            }
        }

        /// <summary>
        /// This method will check if all the values are field
        /// </summary>
        private bool CheckFormValues()
        {
            GetValues();

            //When all values entered:
            if(!string.IsNullOrEmpty(oldPassword) && !string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(passwordConformation))
            { 
                //Check if it is this user's old password:
                if (IsUsersPassword())
                {
                    if (!newPassword.Equals(passwordConformation))
                    {
                        //Show some worning
                        MessageBox.Show("Passwords do not match");

                        return false;
                    }

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// This method gets values from the form
        /// </summary>
        private void GetValues()
        {
            //Show warning if all the fields
            oldPassword = OldPasswordHolder.Password;
            newPassword = NewPasswordHolder.Password;
            passwordConformation = NewPasswordConformation.Password;
        }

        /// <summary>
        /// This method checks if Login and Password belong to the same user
        /// </summary>
        /// <returns>true if user is authentified</returns>
        private bool IsUsersPassword()
        {
            //Constructing query to get password that corresponds to this User
            string query = "SELECT * FROM `person` WHERE `Login` = '"+loggedInUser.Login+"'";

            //Run the query and save result in the reader
            MySqlDataReader reader = db.Reader(query);

            //Holder for the db value
            string passwordFromDB = "";

            while (reader.Read())
            {  
                //If record with this login is found, retrieve password
                passwordFromDB = reader["Password"].ToString();
            }
            db.CloseConnection();

            //If passwords match, user is authenticated 
            if (passwordFromDB.Equals(oldPassword))
            {                
                return true;
            }

            MessageBox.Show("Old password and Login do not match");
            return false;
        }

       
        /// <summary>
        /// This method will show "Save changes" button
        /// after all passwords are not null.
        /// </summary>
        private void CheckShowButton()
        {
            //Get form values
            GetValues();

            //Check if all fields are not null or empty
            if (!string.IsNullOrEmpty(oldPassword) && !string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(passwordConformation))
            {
                //Show User a button
                SaveChangesButton.IsEnabled = true;
            }
        }

        // This region holds event listeners for each form field
        
        #region Event listeners

        private void OldPasswordHolder_PasswordChanged_1(object sender, RoutedEventArgs e)
        {
            CheckShowButton();
        }

        private void NewPasswordHolder_PasswordChanged(object sender, RoutedEventArgs e)
        {
            CheckShowButton();
        }

        private void NewPasswordConformation_PasswordChanged(object sender, RoutedEventArgs e)
        {
            CheckShowButton();
        }

        #endregion
    }
}
