using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LOginForm
{
    public partial class ClientListRecord : FormPrototype
    {
        DBConnection db;

        #region Variables

        string caseNo = "";
        string cName = "";
        string client = "";
        string attorney = "";
        #endregion

        //Query to retrieve a retrieve a record with case name if it is not unique
        string uniqueQ = "SELECT * FROM client_list WHERE Case_No = '";

        string dbKey = "Case_No";


        public ClientListRecord()
        {
            InitializeComponent();
            db = new DBConnection();
        }



        /// <summary>
        /// Will run some checks and add new line to the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            //Check if the key value is not empty and unique
            //Check if the case number is enetered and is unique
            if (CheckUniqueKeyField(caseNumber, warning, uniqueQ, dbKey))
            {
                //If key is unique, get all the values
                GetAllValues();

                //create query
                string q = "INSERT INTO `client_list`(`Case_No`, `Case_Name`, `Client_Info`, `Attorney_Info`) VALUES ";

                q += "( '" + caseNo + "', '" + cName + "', '" + client + "' ,'" + attorney + "')";


                AddNewRecord(q);

            }
        }

        /// <summary>
        /// This method gets all valuesfrom the form
        /// </summary>
        private void GetAllValues()
        {
            caseNo = caseNumber.Text;
            cName = caseName.Text;
            client = clientInfo.Text;
            attorney = attorneyInfo.Text;
        }

       

        #region clear button


        private void clearBtn_Click(object sender, EventArgs e)
        {
            CleanForm();
        }


        #endregion

        
       
    }
}
