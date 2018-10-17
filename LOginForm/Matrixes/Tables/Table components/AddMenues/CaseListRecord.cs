
using System;
using System.Windows.Forms;

namespace LOginForm
{
    public partial class CaseListRecord : FormPrototype
    {
        DBConnection db;
       

        #region Varables
        string caseNo = "";
        string name = "";
        string dateFiled = "";
        string dateServed = "";
        string DOD = "";

        #endregion

        //Query to retrieve a retrieve a record with case name if it is not unique
        string uniqueQ = "SELECT * FROM case_list WHERE Case_No = '";

        string dbKey = "Case_No";


        public CaseListRecord()
        {
            InitializeComponent();
            db = new DBConnection();
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }



        /// <summary>
        /// Add button click will check input and add add new record to the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            //Check if the case number is enetered and is unique
            if (CheckUniqueKeyField(caseNumber, warning, uniqueQ, dbKey))
            {
                //If key is unique, get all the values
                GetAllValues();

                //create query
                string q = "INSERT INTO `case_list`(`Case_No`, `Case_Name`, `date_filed`, `date_served`, `date_of_death`) VALUES ";

                q += "( '" + caseNo + "', '" + name + "', '" + dateFiled + "' ,'" + dateServed + "' ,'" + DOD + "')";


                //Create window  dialog for conformation
                DialogResult dialog = System.Windows.Forms.MessageBox.Show("Are you sure to add a new record?", "Add", MessageBoxButtons.YesNo);

                //If yes, return to the login page
                if (dialog == System.Windows.Forms.DialogResult.Yes)
                {
                    //Inserting record
                    db.InsertDeleteQuery(q);

                    //Show message
                    MessageBox.Show("Record was added to the table");


                    var myParent = (MatrixForm)this.Owner;

                    myParent.LoadTable();

                    //Cleare form
                    CleanForm();
                }

            }
        }


        private void GetAllValues()
        {
            caseNo = caseNumber.Text;
            name = caseName.Text;
            dateFiled = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            dateServed = ComplaintServed.Text;
            DOD = dateOfDeath.Text;
        }

       


        #region Clear button
     

        /// <summary>
        /// Clear button will cleare all fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            CleanForm();
        }


        #endregion

        /// <summary>
        /// By default date is empty, on change t6he format would be back to standart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        /// <summary>
        /// This will prevent an error on load of one or more Records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseListRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }
    }
}
