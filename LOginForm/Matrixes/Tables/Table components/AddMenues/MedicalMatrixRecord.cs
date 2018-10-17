using System;
using System.Drawing;
using System.Windows.Forms;

namespace LOginForm
{
    public partial class MedicalMatrixRecord : FormPrototype
    {
        //Get database connection
        DBConnection db = new DBConnection();

        #region Variables

        string ClientName = "";
        string CaseNumber = "";
        string FacilityRecord = "";
        string RequestDate = "";
        string DateToCopy = "";
        string OrderNotes = "";
        string DateEFileRecieved = "";
        string FlagHardCopy = "";
        string HardCopyBy = "";
        string DateHardCopyRecieved = "";
        string DateSentForReview = "";
        string BatesRange = "";
        int FlagPrinted = 0;
        int FlagNotebooked = 0;


        #endregion

        public MedicalMatrixRecord()
        {
            InitializeComponent();

            /*Set default format for the date pickers */

            //For the EFile
            dateElFileRecievedTimePicker.CustomFormat = " ";
            dateElFileRecievedTimePicker.Format = DateTimePickerFormat.Custom;

            //For the HardCopy
            dateHCopyResievedTimePicker.CustomFormat = " ";
            dateHCopyResievedTimePicker.Format = DateTimePickerFormat.Custom;

            /* Set unchecked checkBoxes */
            flagNoteBooked.Checked = false;
            flagPrinted.Checked = false;
        }


        #region Add button logic
        /// <summary>
        /// This method runs all the checks, and ads the record to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            if (RecordIsValid())
            {
                GetFormValues();

                //Create insert query
                string addQueryForMedicalMatrix = "INSERT INTO `medical_matrix`" +
                    "(`Case_Name`, `Case_Number`, `Facility_recod`, `Request_date`, `Date_to_copy`, `Order_notes`, `Date_recieved`, " +
                    "`Flag_hard_copy`, `Hard_copy_by`, `Hard_copy_recieved`, `Sent_for_review`, `Bates_range`, `Flag_printed`, `Flag_notebooked`)" +
                    " VALUES " +
                    "('" + ClientName + "','" + CaseNumber + "','" + FacilityRecord + "','" + RequestDate + "','" + DateToCopy + "','" + OrderNotes + "','" + DateEFileRecieved + "','" +
                    FlagHardCopy + "','" + HardCopyBy + "','" + DateHardCopyRecieved + "','" + DateSentForReview + "','" + BatesRange + "'," + FlagPrinted + "," + FlagNotebooked + ")";

                //TEST
                MessageBox.Show(addQueryForMedicalMatrix);


                //Create window  dialog for conformation
                DialogResult dialog = MessageBox.Show("Are you sure to add a new record?", "Add", MessageBoxButtons.YesNo);

                //If yes, return to the login page
                if (dialog == DialogResult.Yes)
                {
                    //Inserting record to the database Table
                    db.InsertDeleteQuery(addQueryForMedicalMatrix);

                    //Show message
                    MessageBox.Show("Record was added to the table");


                    var myParent = (MatrixForm)Owner;

                    myParent.LoadTable();

                    //Cleare form
                    CleanForm();

                    //clean dates
                    DateEFileRecieved = " ";
                    DateHardCopyRecieved = " ";
                }

            }
        }

        #endregion

        #region Helpers

        /// <summary>
        /// For right now, since records do not have a prime key that make sence,
        /// Record considered Valid as long as user entered ClientName and CaseNumber
        /// </summary>
        /// <returns></returns>
        private bool RecordIsValid()
        {


            //Get value of the client name
            ClientName = clientNameHolder.Text;

            //Get value of the case number
            CaseNumber = caseNumberHolder.Text;

            //If either of the fields is empty, show RED warning and return false
            if (string.IsNullOrEmpty(ClientName) || string.IsNullOrEmpty(CaseNumber))
            {
                warningLable.ForeColor = Color.Red;
                return false;
            }

            //Change warning color to black
            warningLable.ForeColor = Color.Black;

            return true;
        }

        /// <summary>
        /// This method retrieves all the walues from the form
        /// </summary>
        private void GetFormValues()
        {
            // ClientName has been collected in RecordIsValid() 
            // CaseNumber has been collected in RecordIsValid()

            FacilityRecord = facilityRecordHolder.Text;
            RequestDate = requestDateHolder.Text;

            //DateToCopy has been collected in datePickerHandeler

            OrderNotes = orderNotesHolder.Text;
            //DateEFileRecieved has been collected in datePickerHandeler

            FlagHardCopy = hardCopyFlagHolder.Text;
            HardCopyBy = hardCopyByHolder.Text;

            //DateHardCopyRecieved has been collected in datePickerHandeler

            DateSentForReview = dateSentForReviewHolder.Text;
            BatesRange = batesRangeHolder.Text;

            // FlagPrinted has been collected in checkBoxHandeler
            //FlagNotebooked has been collected in checkBoxHandeler
        }



        #endregion

        #region DatePicker and CheckBox Handelers
        /// <summary>
        /// This method changes datePicker format and shows user when Date Electronic File Received
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateElFileRecievedTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //Chane format to show user selected date
            dateElFileRecievedTimePicker.CustomFormat = "dd/MM/yyyy";

            //Save selected value in the SQL format
            DateEFileRecieved = dateElFileRecievedTimePicker.Value.ToString("yyyy-MM-dd");
        }


        /// <summary>
        /// This method changes datePicker format and shows user when Date Hard Copy File Received
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateHCopyResievedTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //Chane format to show user selected date
            dateHCopyResievedTimePicker.CustomFormat = "dd/MM/yyyy";

            //Save selected value in the SQL format
            DateHardCopyRecieved = dateHCopyResievedTimePicker.Value.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// This method assigns FalgPrinted Value depening on the checkBox value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flagPrinted_CheckedChanged(object sender, EventArgs e)
        {
            if (flagPrinted.Checked) { FlagPrinted = 1; }
            else { FlagPrinted = 0; }
        }

        /// <summary>
        /// This method assigns FlagNotebooked Value depening on the checkBox value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flagNoteBooked_CheckedChanged(object sender, EventArgs e)
        {
            if (flagNoteBooked.Checked) { FlagNotebooked = 1; }
            else { FlagNotebooked = 0; }
        }

        #endregion


        /// <summary>
        /// This method clears the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearFormBtn_Click(object sender, EventArgs e)
        {
            //This would clear all the text values
            CleanForm();

            //Clear warning 
            warningLable.ForeColor = Color.Black;

            //Uncheck checkBoxes
            flagNoteBooked.Checked = false;
            flagPrinted.Checked = false;

            //Clear datePickers
            //For the EFile
            dateElFileRecievedTimePicker.CustomFormat = " ";
            dateElFileRecievedTimePicker.Format = DateTimePickerFormat.Custom;

            //For the HardCopy
            dateHCopyResievedTimePicker.CustomFormat = " ";
            dateHCopyResievedTimePicker.Format = DateTimePickerFormat.Custom;
        }
    }
}
