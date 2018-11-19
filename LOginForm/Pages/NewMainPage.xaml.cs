using MaterialDesignThemes.Wpf;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Windows.Forms;
using LOginForm.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Windows.Media.Animation;
using MessageBox = System.Windows.Forms.MessageBox;

namespace LOginForm
{
    /// <summary>
    /// Interaction logic for NewMainPage.xaml
    /// </summary>
    public partial class NewMainPage : Window
    {
        Person user;
        DBConnection db = new DBConnection();

        public NewMainPage(Person person)
        {
            InitializeComponent();
            user = person;
            CheckStatus();
        }

        /// <summary>
        /// This method will hida a button that shows
        /// admin menu if user is NOT an admin
        /// </summary>
        private void CheckStatus()
        {
            if (user.Role.Equals("user"))
            {
                ButtonCloseMenu.Visibility = Visibility.Hidden;
                ButtonOpenMenu.Visibility = Visibility.Hidden;
            }
        }

        /// <summary>
        /// This method closes an application
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



        #region Animation handelers
        /// <summary>
        /// This method will open mwnu sideBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// This method will close menu sideBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        #endregion

        #region Change password logic

        //Variabels that will be used:
        string oldPassword = "";
        string newPassword = "";
        string passwordConformation = "";

        /// <summary>
        /// This method will update user's password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckFormValues())
            {
                // Update query
                string UpdateUserPassword = "UPDATE `person` SET `Password` = '" + newPassword + "' WHERE `Login` = '" + user.Login + "'";

                db.InsertDeleteQuery(UpdateUserPassword);

                System.Windows.MessageBox.Show("Password updated");

                //Clear the form:
                OldPasswordHolder.Password = NewPasswordHolder.Password = NewPasswordConformationHolder.Password = "";
                ChangePasswordButton.IsEnabled = false;
            }
        }

     

        /// <summary>
        /// This method will check if all the values in the form are field
        /// </summary>
        private bool CheckFormValues()
        {
            GetValues();

            //When all values entered:
            if (!string.IsNullOrEmpty(oldPassword) && !string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(passwordConformation))
            {
                //Check if it is this user's old password:
                if (IsUsersPassword())
                {
                    if (newPassword.Equals(passwordConformation))
                    {
                        NewPasswordConformationHolder.ClearValue(BorderBrushProperty);
                        return true;
                    }

                    //Passwords do not match, color conformation border 
                    NewPasswordConformationHolder.BorderBrush = Brushes.OrangeRed;
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
            passwordConformation = NewPasswordConformationHolder.Password;

            
        }

        /// <summary>
        /// This method checks if Login and Password belong to the same user
        /// </summary>
        /// <returns>true if user is authentified</returns>
        private bool IsUsersPassword()
        {
            //Constructing query to get password that corresponds to this User
            string query = "SELECT * FROM `person` WHERE `Login` = '" + user.Login + "'";

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
                OldPasswordHolder.ClearValue(BorderBrushProperty);
                return true;
            }

            //System.Windows.MessageBox.Show("Old password and Login do not match");
            OldPasswordHolder.BorderBrush = Brushes.OrangeRed;
            return false;
        }


        #endregion
        
        #region Event listeners
        /// <summary>
        /// Thrying to open dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ChangePasswordPopUp.IsOpen = true;

            ChangePasswordPopUp.PlacementTarget = sender as UIElement;
            ChangePasswordPopUp.IsOpen = true;
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
                ChangePasswordButton.IsEnabled = true;
                
            }
        }

        private void OldPasswordHolder_PasswordChanged(object sender, RoutedEventArgs e)
        {
            CheckShowButton();
        }

        private void NewPasswordHolder_PasswordChanged(object sender, RoutedEventArgs e)
        {
            CheckShowButton();
        }

        private void NewPasswordConformationHolder_PasswordChanged(object sender, RoutedEventArgs e)
        {
            CheckShowButton();
        }



        private void CloseChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ChangePasswordPopUp.IsOpen = false;
        }

        #endregion


        /// <summary>
        /// This will show a restriction page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestrictionButton_Click(object sender, RoutedEventArgs e)
        {
            Pages.ResrtrictionPage Restriction = new ResrtrictionPage(user);

            Restriction.ShowDialog();
        }


        #region Tabels Buttons 

        
        #region Group 1
        private void ActiveCaseButton_Click(object sender, RoutedEventArgs e)
        {
            //create ActiveCase object
            TableCore tc = new ActiveClassObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }

        private void TrialDatesButton_Click(object sender, RoutedEventArgs e)
        {
            TableCore tc = new TrialDatesObj();

            //Open Form with Trial Dates Data
            OpenForm(tc);
        }

        private void SettledCasesButton_Click(object sender, RoutedEventArgs e)
        {
            //create Sateled Case obj
            TableCore tc = new SateledCasesObj();

            //Open form
            OpenForm(tc);
        }
        #endregion

        #region Group 2
        private void CaseListButton_Click(object sender, RoutedEventArgs e)
        {
            //Create case list object
            TableCore tc = new CaseLIstObj();

            //Open Form with Case List Data
            OpenForm(tc);
        }

        private void ClientListButton_Click(object sender, RoutedEventArgs e)
        {
            TableCore tc = new ClientListDataObj();

            //Open Form with Client List Data
            OpenForm(tc);
        }

        private void CourtListButton_Click(object sender, RoutedEventArgs e)
        {
            TableCore tc = new CourtListObj();

            //Open Form with Court List Data
            OpenForm(tc);
        }
        #endregion

        #region Group 3
        private void DiscoveryMatrixButton_Click(object sender, RoutedEventArgs e)
        {
            //create Motion Matrix record object
            TableCore tc = new DiscoveryMatrixObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }

        private void MotionMatrixButton_Click(object sender, RoutedEventArgs e)
        {
            //create Motion Matrix record object
            TableCore tc = new MotionMatrixObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }
        #endregion

        #region Group 4
        private void MedicalRecordButton_Click(object sender, RoutedEventArgs e)
        {
            //create Medical record object
            TableCore tc = new MedicalRecordObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }

        private void MedicalMatrixButton_Click(object sender, RoutedEventArgs e)
        {
            //create Medical Matrix record object
            TableCore tc = new MedicalMatrixObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }
        #endregion

        #region Group 5
        private void CaseTruckingButton_Click(object sender, RoutedEventArgs e)
        {
            //create Medical record object
            TableCore tc = new CaseTruckingObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }
        #endregion

        #region Group 0 (Archive)
        private void SettledAttorneysButton_Click(object sender, RoutedEventArgs e)
        {
            //create Setteled Attorney record object
            TableCore tc = new SetteledAttorneysObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }

        private void SettledJudjesButton_Click(object sender, RoutedEventArgs e)
        {
            //create Setteled Judge record object
            TableCore tc = new SetteledJudgesObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }
        #endregion

        /// <summary>
        /// This method opens up a form view with requested Table
        /// </summary>
        /// <param name="query"></param>
        private void OpenForm(TableCore tc)
        {
            if (PersonCanOpen(tc))
            {
                //Creating instance of the new page and sending corespondent query
                MatrixForm mf = new MatrixForm(tc, user);

                mf.Text = tc.TableName;

                mf.ShowDialog();
            }


        }

        /// <summary>
        /// This method will determine if this person can modefy this form
        /// </summary>
        /// <param name="tc"></param>
        /// <returns></returns>
        private bool PersonCanOpen(TableCore tc)
        {

            //Get the tag of the table
            var tableTag = tc.TableGroupNumber;

            //retrieve persons group list
            List<string> groups = user.TableGroups.Split('_').OfType<string>().ToList();

            if (groups.IndexOf(tableTag) == -1)
            {
                System.Windows.MessageBox.Show("Sorry, the access is denyed!");

                return false;
            }

            return true;
        }












        #endregion

        #region Right corner munu buttons
        /// <summary>
        /// This method will open a password change popUp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            
            ChangePasswordPopUp.PlacementTarget = sender as UIElement;
            ChangePasswordPopUp.IsOpen = true;
        }

        /// <summary>
        /// This method will display a Restriction page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InformationButton_Click(object sender, RoutedEventArgs e)
        {
            RestrictionButton_Click(sender, e);
        }

        #endregion

        /// <summary>
        /// This method will open a page with wait list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaitListButton_Click(object sender, RoutedEventArgs e)
        {
            UserWaitList waitList = new UserWaitList();
            waitList.ShowDialog();
        }
    }
}
