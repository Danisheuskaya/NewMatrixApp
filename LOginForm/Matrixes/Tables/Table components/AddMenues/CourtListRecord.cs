
using System;
using System.Windows.Forms;

namespace LOginForm
{
    public partial class CourtListRecord : FormPrototype
    {
        DBConnection db;


        //Query to retrieve a retrieve a record with case name if it is not unique
        string uniqueQ = "SELECT * FROM court_list WHERE Case_Number = '";

        string dbKey = "Case_Number";

        #region Varables
        string caseNo = "";
        string name = "";
        string judge = "";
        string Court = "";
        string Reporter = "";
        string Rullings = "";
        string Motion = "";

        #endregion
        public CourtListRecord()
        {
            InitializeComponent();
            db = new DBConnection();
        }

        #region Add button
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
                string q = "INSERT INTO `court_list`(`Case_Number`, `Case_Name`, `Judge_dpmt`, `Court_Info`, `Reporter`, `Rullings`, `Motion_Info`) VALUES ";

                q += "( '" + caseNo + "', '" + name + "', '" + judge + "' ,'" + Court + "' ,'" + Reporter + "' ,'" + Rullings + "' ,'" + Motion + "')";


                //Create window  dialog for conformation
                DialogResult dialog = MessageBox.Show("Are you sure to add a new record?", "Add", MessageBoxButtons.YesNo);

                //If yes, return to the login page
                if (dialog == DialogResult.Yes)
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
       
        #endregion

        #region Clear/ Get All

        /// <summary>
        /// Clear button will cleare all fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void clearBtn_Click(object sender, System.EventArgs e)
        {
            CleanForm();
        }


        

        /// <summary>
        /// This function gets all the values from teh form
        /// </summary>
        private void GetAllValues()
        {
            caseNo = caseNumber.Text;
            name = caseName.Text;
            judge = JudjeDept.Text;
            Court = court.Text;
            Reporter = report.Text;
            Rullings = rullings.Text;
            Motion = motion.Text;

        }




        #endregion

        /// <summary>
        /// This will prevent an error on load of one or more Records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CourtListRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }
    }
}
