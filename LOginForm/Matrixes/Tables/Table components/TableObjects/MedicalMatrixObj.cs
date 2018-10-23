using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LOginForm
{
    class MedicalMatrixObj : TableCore
    {
        #region values
        private DataTable dt = new DataTable();
        private DBConnection db = new DBConnection();

        #endregion

        #region Constructr
      
        public MedicalMatrixObj()
        {
            TableName = "Medical Matrix";

            //db table name
            DbTable = "medical_matrix";

            //key field
            keyField = "Case_Pair_ID";

            //key field index
            KeyFieldIndex = 0;

            DisplayQuery = "SELECT * FROM `medical_matrix`";

            //Fields in DB
            DbFields = new string[] { "Case_Pair_ID", "Case_Name", "Case_Number", "Facility_recod", "Request_date",
                                      "Date_to_copy", "Order_notes", "Date_recieved", "Flag_hard_copy", "Hard_copy_by",
                                      "Hard_copy_recieved", "Sent_for_review", "Bates_range", "Flag_printed", "Flag_notebooked","Flag_printed", "Flag_notebooked" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case ID", "Client", "Case Number", "Facility Recod", "Request Date",
                                            "Supboena Date to Copy", "SDT Work Order No. / Notes", "Date Electronic File Received",
                                            "Were Hard Copies Provided", "Hard Copy Provided By",  "Date Hard Copy Received",
                                            "Date Sent for Review", "Bates Stamp Number Range", "printed", "notebooked"};

            //Delete query
            DeliteQuery = "DELETE FROM `medical_matrix` WHERE `Case_Pair_ID` = ";

            //Add Controle Form
            MyRecord = new MedicalMatrixRecord();
        }

        #endregion

        #region Override Functions

        /**************************************************
         *  HIDE ID COLUMN AND FLAGS, ADD CHECKBOX COLUMNS,
         *  OVERRIDE UPDATE STRING FOR CHECKBOXES         
         *  **********************************************/

        #region Hide coulmns
        /// <summary>
        /// This method hides flag columns and
        /// calls method to add checkBoxColumns instead
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="flag"></param>
        public override void AddControls(DataGridView dg, bool flag)
        {
           
            

            //Hide flag columns where 13 is printed and 14 is noteboo
            dg.Columns[13].Visible = false;
            dg.Columns[14].Visible = false;

            AddNewColumns(dg);

            //Hide ID column
            dg.Columns[0].Visible = false;

        }
        #endregion


        #region Add CheckBox Columns
        /// <summary>
        /// This method adds a checkBox columns for user to mark if record is 
        /// printed or if record is notebooked
        /// </summary>
        /// <param name="dg"></param>
        private void AddNewColumns(DataGridView dg)
        {
            //Query to get the "Printed" column
            string q1 = "SELECT `Flag_printed` FROM `medical_matrix` ";

            //Query to get the "Notebooked" column
            string q2 = "SELECT `Flag_notebooked` FROM `medical_matrix` ";

            //This method will add CheckBox coulm. It is described in TableCore class
            AddCheckBoxColumn(dg, "Printed?", q1, "Flag_printed", 15);
            AddCheckBoxColumn(dg, "Notebooked?", q2, "Flag_notebooked", 16);
        }

        #endregion


        #region Override for the Update of Boolean Values
        /// <summary>
        /// This method overrides an Update string due to the fact that check box values in column 15 and 16
        /// are boolean and not corespond to the SQL format
        /// column 15 is the flag if file was printed
        /// column 16 is the flag if file was notebooked
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newValue"></param>
        /// <param name="key"></param>
        public override void UpdateStringConstructor(int index, string newValue, string key)
        {
            //Check if the index is 15 or 16
            if(index == 15 || index == 16)
            {
                if (newValue.Equals("True"))
                {
                    newValue = "" + 1;
                }
                else
                {
                    newValue = "" + 0;
                }
            }

            //Now construct a normal add query:
            //create update string
            string querey = "UPDATE " + DbTable + " SET " + DbFields[index] + " = '" + newValue + "' WHERE " + keyField + " = '" + key + "' ";


            //update UpdateQuery
            UpdateQuery = querey;

        }

        #endregion


        #region Color Rows Based on Flag
        /// <summary>
        /// This method colors the table
        /// If record is Printed, the row is Green
        /// If record is Notebooked, the row is Red
        /// If record is Printed and Notebooked, the row is Yellow
        /// </summary>
        /// <param name="dg"></param>
        public override void ColorTable(DataGridView dg)
        {
            foreach (DataGridViewRow row in dg.Rows)
            {
                //Get row index
                int rowIndex = row.Index;

                //Escape the last, empty row
                if (rowIndex == dg.RowCount - 1) { return; }

                //Get copy of the Printed flag value
                string printedFlag = row.Cells[13].Value.ToString();

                //Get copy of the Notebooked flag value
                string notebookedFlag = row.Cells[14].Value.ToString();

                if (!string.IsNullOrEmpty(printedFlag) && !string.IsNullOrEmpty(notebookedFlag))
                {                   
                    //Check if file is only printed
                    if (printedFlag.Equals("1") && notebookedFlag.Equals("0"))
                    {
                        //Color Row Green
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    //Check if file is only notebooked
                    else if (printedFlag.Equals("0") && notebookedFlag.Equals("1"))
                    {
                        //Color Row Red
                       row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    //Check if file is printed & notebooked
                    else if (printedFlag.Equals("1") && notebookedFlag.Equals("1"))
                    {
                        //Color Row Yellow
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        //Color Row White
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }

           

        }

        #endregion


        #endregion
    }
}
