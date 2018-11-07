
using MySql.Data.MySqlClient;
using System;
using LOginForm.Pages;
using System.Windows;
using System.Windows.Input;

namespace LOginForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DBConnection db;
        public MainWindow()
        {
            InitializeComponent();
            db = new DBConnection();            
        }

        #region Person & Person's attributes

        //Holder for the person obj
        public Person person;

        //holder for the ID
        int ID;

        //holder for the first name
        string Fname = "";

        //Holder for th elast name
        string Lname = "";


        //Holder for the admin list
        string AdminGroupList = "";

        string TableGroups = "";

        #endregion

        #region Login logic

        /// <summary>
        /// This method is fired when the login button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            //Check if all the required fields are filled,
            //If so, can perside to the login
            if (CheckIfEmpty())
            {
                //This function checks if the pair Login - Password is correct
                //If password and login correct => redirect to the new window
                if (CheckLoginInfo())
                {
                    // creating HomePage instance
                   // Window1 hp = new Window1(person);

                    //Closing Login window
                    //Application.Current.Windows[0].Close();

                    //Redirect to the new Page
                    //hp.ShowDialog();

                    NewMainPage NMP = new NewMainPage();

                    NMP.ShowDialog();

                    

                }
            }
            
        }

        #endregion

        #region Helpers

        /// <summary>
        /// This method checks if the login form is filed up, if not it is shows a warning message.
        /// </summary>
        /// <returns></returns>
        private bool CheckIfEmpty()
        {
            //Get the login value
            var login = LoginX.Text;

            //Get the password value
            var password = PasswordX.Password;

            //If something is empty, show warning message
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                //Showing a worning message
                WorningBox.Visibility = Visibility.Visible;

                //refreshing the input
                PasswordX.Password = "";

                //returning to the starting point
                return false;
            }
            
            //If login and password was enetered, perside to the login check
            WorningBox.Visibility = Visibility.Hidden;
            
            return true;


        }


        /// <summary>
        /// This function is checking if the pair Login - Password exists
        /// </summary>
        private bool CheckLoginInfo()
        {
            //Get the login value
            var login = LoginX.Text;

            //Get the password value
            string password = PasswordX.Password;

            //holder for the value from db
            string DBpassword = "";

           
            //querey
            string q = "select * from person where Login = '" + login + "'"; 

            MySqlDataReader reader = db.Reader(q);
            
            //Assigning pasword if it is exists
            while (reader.Read())
            {
                DBpassword = reader["Password"].ToString();
                ID = Convert.ToInt32(reader["ID"]);
                Fname = reader["Fname"].ToString();
                Lname = reader["Lname"].ToString();
                AdminGroupList = reader["Admin_group_list"].ToString();
                TableGroups = reader["tabel_groups"].ToString();
            }
            Console.ReadLine();

            //Close connection
            db.CloseConnection();

           

            //Compare passwords

            //If password correct, redirect to the different page
            if (password.Equals(DBpassword))
            { 

                ErrorBox.Visibility = Visibility.Hidden;

                //Create a person obj
                person = new Person(ID, Fname, Lname, login, AdminGroupList, TableGroups);

                return true;
            }
            //If not, show error message
            else
            {
                ErrorBox.Visibility = Visibility.Visible;
                return false;
            }

        }

        /// <summary>
        /// This function redirects user to the register form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            // Creating instance of the registration page
            RegisterPage rp = new RegisterPage();

            //Close login page
            Close();

            //Open redirecting page
            rp.Show();


        }





        #endregion

        /// <summary>
        /// This method handels the press of Enter. It will run all the checks,
        /// that is done by the Login button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //Fire the loggin button pressed function
                LoginBtn_Click(sender, e);

            }
        }
    }
}
