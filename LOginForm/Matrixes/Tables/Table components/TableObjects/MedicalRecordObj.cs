
using System;
using System.Data;
using System.Drawing;
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

            //Block expiration date column from modification
            dg.Columns[7].ReadOnly = true;
        }

        /// <summary>
        /// This method helps to handel interactive cells inside the table by openning supporting forms
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public override bool ButtonInsideTableHandler(DataGridView dg, DataGridViewCellEventArgs e)
        {

            //Handel Recieved date time cells
            if (e.ColumnIndex == 8)
            {
                //Get User's Input. Method described in TableCore
                DateOrTeamSelectionThroughTheTableHandelr(dg, e, 1);

                return true;
            }
            //Handel request time cells
            else if (e.ColumnIndex == 6)
            {
                //Get User's Input. Method described in TableCore
                DateOrTeamSelectionThroughTheTableHandelr(dg, e, 1);


                CheckIfExpirationDateUpdates(dg, e);

                //Since it was collected, return true
                return true;
            }

            //Handel letter type cells
            else if (e.ColumnIndex == 5)
            {
                // Get User's Input. Method described in TableCore
                DateOrTeamSelectionThroughTheTableHandelr(dg, e, 3);

                CheckIfExpirationDateUpdates(dg, e);
                //Since it was collected, return true
                return true;
            }

            return false;   
        }

        /// <summary>
        /// If user changes letter type, this method will check if Expiration date needs to be updated
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="e"></param>
        private void CheckIfExpirationDateUpdates(DataGridView dg, DataGridViewCellEventArgs e)
        {
            //Check if affected row has Date Requested
            string DateRequested = dg.Rows[e.RowIndex].Cells[6].Value.ToString();

            //Get letter type:
            string letterType = dg.Rows[e.RowIndex].Cells[5].Value.ToString();

            //If there is a request date, get its value
            if (!string.IsNullOrEmpty(DateRequested))
            {
                DateTime request = DateTime.Parse(DateRequested);

                DateTime expiration = new DateTime();

                if (letterType.Equals("48"))
                {
                    //adding 2 days
                    expiration = request.AddDays(2);
                }
                else if (letterType.Equals("1158"))
                {
                    //Adding 6 days
                    expiration = request.AddDays(6);
                }

                //Convert new string to the SQL format
                string newExpirationDate = expiration.ToString("yyyy-MM-dd");

                //Get key for this record:
                string key = dg.Rows[e.RowIndex].Cells[KeyFieldIndex].Value.ToString();

                //Add new line to the UpdateString:
                UpdateQuery += "UPDATE " + DbTable + " SET " + DbFields[7] + " = '" + newExpirationDate + "' WHERE " + keyField + " = '" + key + "'; ";
            }
            
        }

        public override void ColorTable(DataGridView dg)
        {
            
            foreach (DataGridViewRow row in dg.Rows)
            {

                //Color Expiration date column:
                row.Cells[7].Style.BackColor = Color.Red;
            }
        }

        #endregion
    }
}
