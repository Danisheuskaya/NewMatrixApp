using MySql.Data.MySqlClient;
using System;
using System.Windows;
using System.Windows.Input;

/***************************************************************************
 * 
 * RIGHT NOW NEW USER ADDED TO THE LIST RIGHT AWAY WITHOUT ANY APPROWAL
 * ALSO, THERE IS NO CERTAIN REQUIREMENTS FOR THE PASSWORD AND NO SEQURITY
 * MEASURES ARE IMPLEMENTED. ALL PASSWORDS STORED IN THE DB AS PLAIN TEXT
 * 
 * *************************************************************************/

namespace LOginForm.Pages
{
    /// <summary>
    /// Interaction logic for RegisterPage
    /// </summary>
    public partial class RegisterPage : Window
    {
        public RegisterPage()
        {
            InitializeComponent();
            db = new DBConnection();
        }

        #region Variables

        /// <summary>
        /// Variables for the person object and form values
        /// </summary>

        private string Fname;
        private string Lname;
        private string login;
        private string password;
        private string passwordConfirm;

        //Getting DB object
        private DBConnection db;

        #endregion


        /// <summary>
        /// This method completes all checks required 
        /// If all fields complete, and user is not accepted nor pending record, 
        /// new record added to the "temp_person" teable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            //Check if all fields filled and login name is available
            if (CheckFilled())
            {   
                //Check if passwords match and combination Name and Login is unique
                if(CheckPasswordsMatch() && CheckUniqueUser())
                    AddUser();
            }

        }


        #region Check Functions

        /// <summary>
        /// This method checks if all the field in the form are field
        /// </summary>
        private bool CheckFilled()
        {
            //If any of the fields is empty, flag would be false.
            bool flag = true;

            //Clear all the warnings before new check, method described in the Helpers region
            clearWarnings();

            //Get first name value
            Fname = FirstN.Text;
            if (string.IsNullOrEmpty(Fname))
            {
                FirstW.Visibility = Visibility.Visible;
                flag = false;
            }

            //Get last name value
            Lname = LastN.Text;
            if (string.IsNullOrEmpty(Lname))
            {
                LastW.Visibility = Visibility.Visible;
                flag = false;
            }            

            ///Get login value
            login = LoginR.Text;
            if (string.IsNullOrEmpty(login))
            {
                LoginWorning.Visibility = Visibility.Visible;
                flag = false;
            }
            else
            {   //Check if the login name is not taken
                flag = CheckLoginAvailable();
            }

            //Get Password
            password = PasswordR.Password;
            if (string.IsNullOrEmpty(password))
            {
                PasswordW.Visibility = Visibility.Visible;
                flag = false;
            }


            //Get Password Conformation
            passwordConfirm = PassworConf.Password;
            if (string.IsNullOrEmpty(passwordConfirm))
            {
                PasswordConformW.Visibility = Visibility.Visible;
                flag = false;
            }



            //If no warnings assign, return true
            return flag;

        }

        #endregion

        /// <summary>
        /// This method will check if this user is already in the system
        /// </summary>
        /// <returns></returns>

        private bool CheckUniqueUser()
        {
            bool unique = true;


            //Query to retrieve a retrieve a record with user first and last name
            string query = "SELECT * FROM `temp_person` WHERE Fname = '"+Fname+"' AND Lname = '"+Lname+"' AND Login = '"+login+"'";

            //process query
            MySqlDataReader reader = db.Reader(query);

            //If there is any results
            while (reader.Read())
            {
                //If there is a line in the reader => user is not unique
                unique = false;
            }

            //close connection
            db.CloseConnection();

            /*********************************************************************************
             * Also check if user is already approwed to be in the permanent table "person"
             * ******************************************************************************/

            //Query to retrieve a retrieve a record with user first and last name
            string query2 = "SELECT * FROM `person` WHERE Fname = '" + Fname + "' AND Lname = '" + Lname + "' AND Login = '" + login + "'";

            //process query
            MySqlDataReader reader2 = db.Reader(query);

            //If there is any results
            while (reader2.Read())
            {
                //If there is a line in the reader => user is not unique
                unique = false;
            }

            //close connection
            db.CloseConnection();

            return unique;
        }

        /// <summary>
        /// This method adds user to the db and redirects to the login page
        /// </summary>
        private void AddUser()
        {
            //the insertion query
            string query = "INSERT INTO person (`Fname`, `Lname`, `Login`, `Password`)" +
                            " VALUES('"+ Fname + "', '" + Lname + "',  '" + login + "', '" + password + "');";
            db.InsertDeleteQuery(query);

            //Show success message           
            MessageBox.Show("You have been added to the system!");


            //redirect to the login page
            MainWindow loginForm = new MainWindow();

            loginForm.Show();


            //Close this page
            Close();


        }


        #region boolean checks

        

        /// <summary>
        /// This method checks if the login name is available
        /// </summary>
        private bool CheckLoginAvailable()
        {
            bool unique = true;           

            
            //Due to existance of the temporary table, we need to check if ....

            string q = "select * from person where Login = '" + login + "'";

            //create reader
            MySqlDataReader reader =  db.Reader(q);

            while (reader.Read())
            {
                //reading value of login from db
                unique = false;
            }

            //Close connection
            db.CloseConnection();

            //if login name is taken, showing warning
            if (!unique)
            {
                LoginDanger.Visibility = Visibility.Visible;                
            }
            else
            {
                LoginDanger.Visibility = Visibility.Collapsed;
            }

            return unique;
        }

        #endregion

        #region Helpers

        /// <summary>
        /// This method clears all the warnings
        /// </summary>
        private void clearWarnings()
        {
            //clear first name warning
            FirstW.Visibility = Visibility.Collapsed;

            //clear last name warning
            LastN.Visibility = Visibility.Collapsed;

            //clear login warning if there is one
            LoginWorning.Visibility = Visibility.Collapsed;

            //clear password warning if there is one
            PasswordW.Visibility = Visibility.Collapsed;

            //Clear password conformation warning if there is one
            PasswordConformW.Visibility = Visibility.Collapsed;

        }

        /// <summary>
        /// This method checks if the passwords match
        /// </summary>
        private bool CheckPasswordsMatch()
        {
            
            if (password.Equals(passwordConfirm))
            {
                //clear warning if there is one
                WorningBox.Visibility = Visibility.Collapsed;
                return true;
            }
            else
            {
                //assign warning message
                WorningBox.Visibility = Visibility.Visible;
                return false;
            }
        }

        #endregion


        /// <summary>
        /// This function will open login page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterBtn_Copy_Click(object sender, RoutedEventArgs e)
        {
            //get instance of the login page
            MainWindow mw = new MainWindow();

            //close register page
            Close();

            //redirect to the login page
            mw.Show();
           
        }

        /// <summary>
        /// This method handels the press of Enter. It will run all the checks,
        /// that is done by the Register button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //Fire the register button pressed function
                RegisterBtn_Click(sender, e);

            }
        }
    }
}
