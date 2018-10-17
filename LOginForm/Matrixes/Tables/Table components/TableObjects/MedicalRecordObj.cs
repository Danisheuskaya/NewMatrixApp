
using System;
using System.Data;
using System.Windows.Forms;

namespace LOginForm
{
    class MedicalRecordObj : TableCore
    {
        DBConnection db = new DBConnection();

        private DataTable dt = new DataTable();

        public MedicalRecordObj()
        {

            TableName = "Medical Records Requests";

            //db table name
            DbTable = "medical_record";

            //key field
            keyField = "Case_Pair_ID";

            //key field index
            KeyFieldIndex = 0;

            DisplayQuery = "SELECT * FROM `medical_record` ";

            //Fields in DB
            DbFields = new string[] { "Case_Pair_ID", "Case_Name", "Case_Number", "Facility", "Address", "Letter_Type", "Date_Requested", "Expiration_Date", "Date_Recieved", "Notes", "Requested_flag" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case ID","Name","Case Number", "Facility ", "Address ", "Letter Type", "Date Requested", "Expiration Date", "Date Records Received", "Notes ", "Flag"};

            //Delete query
            DeliteQuery = "DELETE FROM `medical_record` WHERE `Case_Pair_ID` = ";

            //Add Controle Form
            MyRecord = new MedicalRecord();
        }

        #region Override functions


       

        /// <summary>
        /// This method hids ID and Flag columns
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="flag"></param>
        public override void AddControls(DataGridView dg, bool flag)
        {
            //Hide ID column
            dg.Columns[0].Visible = false;

            //Hide flag column
            dg.Columns[10].Visible = false;
        }

        #endregion
    }
}
