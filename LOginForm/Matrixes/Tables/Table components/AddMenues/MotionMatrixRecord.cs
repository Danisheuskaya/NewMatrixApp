using System;
using System.Drawing;
using System.Windows.Forms;

namespace LOginForm
{
    public partial class MotionMatrixRecord: FormPrototype
    {
        #region Variables
        DBConnection db = new DBConnection();

        string CaseName = "";
        string Motions = ""; 
        string HearingDates = "";
        string TrialDates = "";
        string LastDateToFile = "";
        string Reply = "";
        string CalendarDays = "";
        string Attorney = "";
        string Notes = "";


        #endregion
        public MotionMatrixRecord()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method Adds a new record to the dataTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, System.EventArgs e)
        {
            if (CheckIfValidToAdd())
            {
                GetFormValues();

                string AddQuery = "INSERT INTO `motion_matrix`(`Case_Name`, `Motions`, `Hearing_Dates`, `Trial_Date`, `Last_Date_To_File`, `Reply`, `Notes`, `Calendar_Days`, `Attorney`)" +
                                                " VALUES ('"+CaseName+ "','"+Motions+ "','"+HearingDates+ "','"+TrialDates+ "','"+LastDateToFile+ "','"+Reply+ "','"+Notes+ "','"+CalendarDays+ "','"+Attorney+"')";

                AddNewRecord(AddQuery);
            }
        }

       

        /// <summary>
        /// This metod checks if form is not empty
        /// </summary>
        /// <returns></returns>
        private bool CheckIfValidToAdd()
        {
            //Get values
            CaseName = caseNameHolder.Text;            
            Motions = motionsHolder.Text;

            if (string.IsNullOrEmpty(CaseName) || string.IsNullOrEmpty(Motions))
            {
                //Show warning
                warningLabel.ForeColor = Color.Red;

                return false;
            }

            //Hide warning
            warningLabel.ForeColor = Color.Black;
            return true;
        }

        /// <summary>
        /// This method collects the rest of the form values
        /// </summary>
        private void GetFormValues()
        {
            // CaseName & Motions has been collected previously

            HearingDates = hearidgDatesHolder.Text;
            TrialDates = trialDateHolder.Text;
            LastDateToFile = lastDateToFileHolder.Text;
            Reply = replyHolder.Text;
            CalendarDays = calendarDaysHolder.Text;
            Attorney = attorneyHolder.Text;
            Notes = notesHolder.Text;
        }

        /// <summary>
        /// This method cleans the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            CleanForm();
        }
    }
}
