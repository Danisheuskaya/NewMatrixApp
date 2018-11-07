
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace LOginForm.Pages
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Person person;
        public Window1(Person p)
        {
            InitializeComponent();
           // CheckRestriction(p.Priority);
            person = p;

            //On load show User's name
            userNameLabel.Content = p.Fname + " " + p.Lname;
        }

        /// <summary>
        /// This Method shows restricted buttons depending on the person priority
        /// </summary>
        /// <param name="Priority"></param>
        private void CheckRestriction(int Priority)
        {
            if(Priority > 1)
            {
                CaseTRucking.Visibility = Visibility.Visible;
                Settings.Visibility = Visibility.Visible;
            }
            
        }


        


       
       

        /*-----------------------------------------------------------
         * This region contains logic for every Matrix Related Button
         * ---------------------------------------------------------*/

        #region Buttons and Queryes

        /// <summary>
        /// This function Opens a form with Active Case Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActCase_Click(object sender, RoutedEventArgs e)
        {

            //create ActiveCase object
            TableCore tc = new ActiveClassObj();
            
            //Open Form with Active Case Data
            OpenForm(tc);          

        }

        /// <summary>
        /// This function Opens a form with Sateled Case Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SatldCase_Click(object sender, RoutedEventArgs e)
        {
            //create Sateled Case obj
            TableCore tc = new SateledCasesObj();
            
            //Open form
            OpenForm(tc);
        }

        /// <summary>
        /// This function Opens a form with Case List Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseList_Click(object sender, RoutedEventArgs e)
        {

            //Create case list object
            TableCore tc = new CaseLIstObj();

            //Open Form with Case List Data
            OpenForm(tc);

        }

        /// <summary>
        /// This function opens a form with Client List Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientList_Click(object sender, RoutedEventArgs e)
        {
            TableCore tc = new ClientListDataObj();

            //Open Form with Client List Data
            OpenForm(tc);
        }

        /// <summary>
        /// This function opens a form with Court List Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CourList_Click(object sender, RoutedEventArgs e)
        {
            TableCore tc = new CourtListObj();

            //Open Form with Court List Data
            OpenForm(tc);
        }


        /// <summary>
        /// This function opens a form with Trial Dates Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrialDates_Click(object sender, RoutedEventArgs e)
        {
            TableCore tc = new TrialDatesObj();

            //Open Form with Trial Dates Data
            OpenForm(tc);
        }

        /// <summary>
        /// This function opens a form with NOT Sutteled Case Trucking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseTRucking_Click(object sender, RoutedEventArgs e)
        {

            TableCore tc = new CaseTruckingObj();

            //Open Form with NOT Sutteled Case Trucking
            OpenForm(tc);
        }

        /// <summary>
        /// This button will open a page with Medical record Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseTRucking_Copy_Click(object sender, RoutedEventArgs e)
        {
            //create Medical record object
            TableCore tc = new MedicalRecordObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }

        /// <summary>
        /// This button will open a page with Medical Matrix Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediclMatrixButton_Click(object sender, RoutedEventArgs e)
        {
            //create Medical Matrix record object
            TableCore tc = new MedicalMatrixObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }

        /// <summary>
        /// This button will open a page with Settaled Attorneys List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SatteledAttorneysButton_Click(object sender, RoutedEventArgs e)
        {
            //create Setteled Attorney record object
            TableCore tc = new SetteledAttorneysObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }

        /// <summary>
        /// This button will open a page with Setteled Judges List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SatteledJudjesButton_Click(object sender, RoutedEventArgs e)
        {
            //create Setteled Judge record object
            TableCore tc = new SetteledJudgesObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }

        /// <summary>
        /// This button will open a page with Motion Matrix
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MotionMatrixButton_Click(object sender, RoutedEventArgs e)
        {
            //create Motion Matrix record object
            TableCore tc = new MotionMatrixObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }


        /// <summary>
        /// This button will open a page with Discovery Matrix
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiscoveryMatrixButton_Click(object sender, RoutedEventArgs e)
        {
            //create Motion Matrix record object
            TableCore tc = new DiscoveryMatrixObj();

            //Open Form with Active Case Data
            OpenForm(tc);
        }


        #endregion


        #region Helper

        /// <summary>
        /// This method opens up a form view with requested Table
        /// </summary>
        /// <param name="query"></param>
        private void OpenForm(TableCore tc)
        {
            if (PersonCanOpen(tc))
            {
                //Creating instance of the new page and sending corespondent query
                MatrixForm mf = new MatrixForm(tc, person);
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
            List<string> groups = person.TableGroups.Split('_').OfType<string>().ToList();

            if (groups.IndexOf(tableTag) == -1)
            {
                System.Windows.MessageBox.Show("Sorry, the access is denyed!");

                return false;
            }

            return true;
        }



        /// <summary>
        /// This is the function for the exit button. 
        /// It is displays exit dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
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


        //This function makes window dragable
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }





        #endregion

        /// <summary>
        /// Log out Button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogOut_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Create window  dialog for conformation
            DialogResult dialog = System.Windows.Forms.MessageBox.Show("Do you want to log out?", "Exit", MessageBoxButtons.YesNo);

            //If yes, return to the login page
            if (dialog == System.Windows.Forms.DialogResult.Yes)
            {
                //creating login form instance
                MainWindow mw = new MainWindow();

                mw.Show();

                Close();

                //System.Windows.Application.Current.Shutdown();
            }
            //If not, cancel
            e.Handled = true;

        }

        /// <summary>
        /// This method will open a settings form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            //Creating an instance of the setting page
            //Settings st = new Settings();

            //st.Show();

            RestrictionLevelPage restrictionPage = new RestrictionLevelPage();

            restrictionPage.ShowDialog();
           
            
        }

        /// <summary>
        /// This button will allow user to change his/her password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePassword cp = new ChangePassword(person);

            cp.ShowDialog();
        }
    }
}
