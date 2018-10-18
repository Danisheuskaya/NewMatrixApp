using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LOginForm
{
    public partial class SetteledJudgesRecord : FormPrototype
    {
        #region Variables

        DBConnection db = new DBConnection();

        string Judge = "";
        string County = "";
        string CaseName = "";
        string YearSatteled = "";
        string Notes = "";

        #endregion

        public SetteledJudgesRecord()
        {
            InitializeComponent();

            //On load make a comboBox year selected a current year
            setteledYearComboBox.DataSource = Enumerable.Range(1950, 100).ToList();
            setteledYearComboBox.SelectedIndex = setteledYearComboBox.Items.IndexOf(DateTime.Now.Year);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
                //create query
                string q = "INSERT INTO `settled_judges`(`Judge`, `County`, `Case_Name`, `Year_Settled`, `Notes`) " +
                            "VALUES ('"+Judge+"','"+County+"','"+CaseName+"','"+YearSatteled+"','"+Notes+"')";

                AddNewRecord(q);
            }
        }

        /// <summary>
        /// This method checks if Judge, County and Case Name have been entered
        /// </summary>
        /// <returns></returns>
        private bool CheckAllFields()
        {
            //Get values
            Judge = judgeNameHolder.Text;
            CaseName = caseNameHolder.Text;
            County = countyNameHolder.Text;

            if (string.IsNullOrEmpty(Judge) || string.IsNullOrEmpty(CaseName) || string.IsNullOrEmpty(County))
            {
                //Show warning
                warningLabel.ForeColor = Color.Red;

                return false;
            }

            //Get missing values:
            YearSatteled = setteledYearComboBox.Text;
            Notes = notesHolder.Text;

            //Hide warning
            warningLabel.ForeColor = Color.Black;
            return true;
        }

        /// <summary>
        /// This method clears form if user presses Clar Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            CleanForm();

            //Set selected year as today's Year
            setteledYearComboBox.SelectedIndex = setteledYearComboBox.Items.IndexOf(DateTime.Now.Year);
        }
    }
}
