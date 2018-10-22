
using System.Windows.Forms;

namespace LOginForm
{
    /// <summary>
    /// This form will be used when user needs to change a date withing DataGridForm
    /// New walue will be saved globaly and used by the parent form
    /// </summary>
    public partial class DateConverterForm : Form
    {
        #region Variables
        //By default this holder has to be not empty, in order to make DataGridView Changes
        string UsersDate = " ";

        //Holder in order to update global variable
        TableCore tc = new TableCore();
        #endregion

        #region Constructor
        public DateConverterForm(TableCore parentForm)
        {
            InitializeComponent();
            tc = parentForm;
            //Set an empty date by Default:
            newDateTimePicker.CustomFormat = " ";
            newDateTimePicker.Format = DateTimePickerFormat.Custom;
        }
        #endregion

        #region Buttons and Dates Hanelers
        /// <summary>
        /// When user selectes date, assign it to the UsersDate variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newDateTimePicker_ValueChanged(object sender, System.EventArgs e)
        {
            //Get value for the SQL
            UsersDate = newDateTimePicker.Value.ToString("yyyy-MM-dd");

            //Show user the format:
            newDateTimePicker.CustomFormat = "MM/dd/yyyy";
        }

        /// <summary>
        /// This method will save selected date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveDateButton_Click(object sender, System.EventArgs e)
        {
            //Save user's input in the global holder
            tc.DateFromTheFormHolder = UsersDate;

            //Close this form
            Close();
        }

        /// <summary>
        /// This method will clear entered date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, System.EventArgs e)
        {
            //Clear holder
            UsersDate = " ";

            //Clear Calendar
            newDateTimePicker.CustomFormat = " ";

        }

        #endregion
    }
}
