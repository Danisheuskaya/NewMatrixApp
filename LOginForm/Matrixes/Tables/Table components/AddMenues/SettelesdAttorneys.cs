using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LOginForm
{
    public partial class SettelesdAttorneys : FormPrototype
    {

        #region Variables

        DBConnection db = new DBConnection();

        string Attorney = "";
        string CaseName = "";
        string YearClosed = "";

        #endregion

        public SettelesdAttorneys()
        {
            InitializeComponent();

            //On load make a comboBox year selected a current year
            closedYearComboBox.DataSource = Enumerable.Range(1950, 100).ToList();
            closedYearComboBox.SelectedIndex = closedYearComboBox.Items.IndexOf(DateTime.Now.Year);

        }

        /// <summary>
        /// This Method runs checks and ads a new record to the dataBase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CheckIfValid())
            {
                //create query
                string q = "INSERT INTO `settled_attorneys`( `Attorneys`, `Case_Name`, `Year_Closed`) " +
                            "VALUES ('"+Attorney+"','"+CaseName+"','"+YearClosed+"')";

                //TEST
                MessageBox.Show(q);

                //Create window  dialog for conformation
                DialogResult dialog = MessageBox.Show("Are you sure you want to add a new record?", "Yes", MessageBoxButtons.YesNo);

                //If yes, return to the login page
                if (dialog == DialogResult.Yes)
                {
                    //Inserting record
                    db.InsertDeleteQuery(q);

                    //Show message
                    MessageBox.Show("Record was added to the table");


                    var myParent = (MatrixForm)Owner;

                    myParent.LoadTable();

                    //Cleare form
                    CleanForm();

                    //Make a comboBox year selected a current year
                    closedYearComboBox.SelectedIndex = closedYearComboBox.Items.IndexOf(DateTime.Now.Year);
                }

            }
        }

        /// <summary>
        /// This method checks if all the filds have values
        /// </summary>
        /// <returns></returns>
        private bool CheckIfValid()
        {
            //Get values
            Attorney = attorneyNameHolder.Text;
            CaseName = caseNameHolder.Text;
            YearClosed = closedYearComboBox.Text;

            if(string.IsNullOrEmpty(Attorney) || string.IsNullOrEmpty(CaseName) || string.IsNullOrEmpty(YearClosed))
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
        /// This method clears user's input on clicl of clear button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            CleanForm();

            //Make a comboBox year selected a current year
            closedYearComboBox.SelectedIndex = closedYearComboBox.Items.IndexOf(DateTime.Now.Year);
        }
    }
}
