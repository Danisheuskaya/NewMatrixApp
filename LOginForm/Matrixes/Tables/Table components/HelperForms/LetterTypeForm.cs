
namespace LOginForm
{
    public partial class LetterTypeForm : FormPrototype
    {
        TableCore tc = new TableCore();

        string UsersChoice = "";
        public LetterTypeForm(TableCore parentMatrix, string oldValue)
        {
            InitializeComponent();
            tc = parentMatrix;

            //Show User what was the old value
            letterTypeComboBox.SelectedIndex = letterTypeComboBox.FindString(oldValue);

            //Save old value, in case user will close form without changes 
            UsersChoice = UsersChoice = letterTypeComboBox.SelectedItem.ToString();
        }

        /// <summary>
        /// When user select's new value, it will be saved in the variable holder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void letterTypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UsersChoice = letterTypeComboBox.SelectedItem.ToString();
        }

        /// <summary>
        /// When user presses save changes, form will save user's chece to the
        /// global variable and shut down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, System.EventArgs e)
        {
            tc.LetterTypeFromTheForm = UsersChoice;

            Close();
        }
    }
}
