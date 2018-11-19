using MySql.Data.MySqlClient;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

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

        private string Fname = "";
        private string Lname = "";
        private string login ="";
        private string password = "";
        private string passwordConfirm = "";

        //Getting DB object
        private DBConnection db;
        private RoutedEventArgs e;

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


        #region Check Filled functions

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
            Fname = FirstNameHolder.Text;
            if (string.IsNullOrEmpty(Fname))
            {
                //Color field border:
                FirstNameHolder.BorderBrush = Brushes.OrangeRed;
                //Add message
                FirstNameHolder.ToolTip = "Please, enter your name";
                flag = false;
            }

            //Get last name value
            Lname = LastNameHolder.Text;
            if (string.IsNullOrEmpty(Lname))
            {
                //Color field border:
                LastNameHolder.BorderBrush = Brushes.OrangeRed;
                //Add message
                LastNameHolder.ToolTip = "Please, enter your last name";
                flag = false;
            }            

            ///Get login value
            login = LoginHolder.Text;
            if (string.IsNullOrEmpty(login))
            {
                //Color field border:
                LoginHolder.BorderBrush = Brushes.OrangeRed;
                //Add message
                LoginHolder.ToolTip = "Please, create your login";
                flag = false;
            }
            else
            {   //Check if the login name is not taken
                flag = CheckLoginAvailable();
            }

            //Get Password
            password = PasswordHolder.Password;
            if (string.IsNullOrEmpty(password))
            {
                //Color field border:
                PasswordHolder.BorderBrush = Brushes.OrangeRed;
                //Add message
                PasswordHolder.ToolTip = "Please, enter your password";
                flag = false;
            }


            //Get Password Conformation
            passwordConfirm = PasswordConformationHolder.Password;
            if (string.IsNullOrEmpty(passwordConfirm))
            {
                //Color field border:
                PasswordConformationHolder.BorderBrush = Brushes.OrangeRed;
                //Add message
                PasswordConformationHolder.ToolTip = "Please, confirm your password";
                flag = false;
            }



            //If no warnings assign, return true
            return flag;

        }

        /// <summary>
        /// This method checks if the login name is available
        /// </summary>
        private bool CheckLoginAvailable()
        {
            bool unique = true;

            //First, check if login is available among approved users:
            string approvedUsers = "select * from person where Login = '" + login + "'";

            //Now, check if this login is available among users in the wait list:
            string waitListUsers = "SELECT * FROM `person_wait_list` where Login = '" + login + "'";

            string[] listOfUsers = new string[] { approvedUsers, waitListUsers };

            foreach (string query in listOfUsers)
            {
                //create reader
                MySqlDataReader reader = db.Reader(query);

                //If there is a record => login taken
                while (reader.Read())
                {
                    //reading value of login from db
                    unique = false;
                }

                //Close connection
                db.CloseConnection();

            }

            //if login name is taken, showing warning
            if (!unique)
            {
                //Color field border:
                LoginHolder.BorderBrush = Brushes.OrangeRed;
                //Add message
                LoginHolder.ToolTip = "Sorry, this login is already taken";
            }

            return unique;
        }


        #endregion

        #region Password Match and Unique User
        /// <summary>
        /// This method checks if the passwords match
        /// </summary>
        private bool CheckPasswordsMatch()
        {
            clearWarnings();

            if (!password.Equals(passwordConfirm))
            {
                //Color field border:
                PasswordConformationHolder.BorderBrush = Brushes.OrangeRed;
                //Add message
                PasswordConformationHolder.ToolTip = "Your passwords do not match.";

                return false;

            }

            return true;
        }
        /// <summary>
        /// This method will check if this user is already in the system
        /// </summary>
        /// <returns></returns>
        /// 
        private bool CheckUniqueUser()
        {
            bool unique = true;
            
            //Query to retrieve a retrieve a record with user first and last name
            string waitListQuery = "SELECT * FROM `person_wait_list` WHERE Fname = '" + Fname+"' AND Lname = '"+Lname+"' AND Login = '"+login+"'";

            string aprovedUsersQuery = "SELECT * FROM `person` WHERE Fname = '" + Fname + "' AND Lname = '" + Lname + "' AND Login = '" + login + "'";

            string[] tabelsCheck = new string[]{ waitListQuery, aprovedUsersQuery };

            //process query

            foreach(string query in tabelsCheck)
            {
                MySqlDataReader reader = db.Reader(query);

                //If there is any results
                while (reader.Read())
                {
                    //If there is a line in the reader => user is not unique
                    unique = false;
                }

                //close connection
                db.CloseConnection();
            }

            //If combination already exist, return to login page:
            if (!unique)
            {
                MessageBox.Show("User: " + Fname + " " + Lname + " with this login already exist");

                //Redirect user to the Login Page
                LoginPageButton_Click(this, e as RoutedEventArgs);
            }
            return unique;
        }

        #endregion
        /// <summary>
        /// This method adds user to the db and redirects to the login page
        /// </summary>
        private void AddUser()
        {
            //If this user does not exist, it will be placed to the wait list

            //the insertion query
            string query = "INSERT INTO `person_wait_list`(`Fname`, `Lname`, `Login`, `Password`) " +
                "VALUES ('"+Fname+ "','"+Lname+ "','"+login+ "','"+password+"')";
            db.InsertDeleteQuery(query);

            //Show success message           
            MessageBox.Show("You have been added to the waitlist. It might take some time, before you will be able to access the forms.");


            //redirect to the login page
            MainWindow loginForm = new MainWindow();

            loginForm.Show();


            //Close this page
            Close();


        }


        

        #region Helpers

        /// <summary>
        /// This method clears all the warnings
        /// Every warning will change border brush and add a toolTip with warning message
        /// </summary>
        private void clearWarnings()
        {
            FirstNameHolder.ToolTip = LastNameHolder.ToolTip = LoginHolder.ToolTip = PasswordConformationHolder.ToolTip = "";

            FirstNameHolder.ClearValue(BorderBrushProperty);
            LastNameHolder.ClearValue(BorderBrushProperty);
            LoginHolder.ClearValue(BorderBrushProperty);
            PasswordConformationHolder.ClearValue(BorderBrushProperty);
        }

       

        #endregion


        #region Redirect to login and Enter key

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

        /// <summary>
        /// This function will return user to the login page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginPageButton_Click(object sender, RoutedEventArgs e)
        {
            //get instance of the login page
            MainWindow mw = new MainWindow();

            //close register page
            Close();

            //redirect to the login page
            mw.Show();
        }

        #endregion
    }
}
