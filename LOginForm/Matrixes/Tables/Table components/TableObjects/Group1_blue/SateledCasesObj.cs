using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LOginForm
{
    class SateledCasesObj : TableCore
    {

        DBConnection db = new DBConnection();

        public SateledCasesObj()
        {
            TableName = "Satteled Cases";

            //db table name
            DbTable = "active_case";

            //key field
            keyField = "Case_No";

            //key field index
            KeyFieldIndex = 0;

            //This query will move to the top unfinished cases
            DisplayQuery = "SELECT * FROM `active_case` WHERE `Satteled` ORDER By `Flag_Finished`";

            //Fields in DB
            DbFields = new string[] {"Case_No", "Case_Name", "Trial_Date", "Team_ID", "Note", "Satteled", "Flag_Finished", "Flag_Finished" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case Number", "Case Name", "Trial Dtae", "Team", "Note", "Satteled ", "Finished " };

            //Delete query
            DeliteQuery = "DELETE FROM `settled_cases` WHERE Case_ID = ";

            AddNewRecordMessage = "Sorry, you can only move existing record from the table 'Active Cases'";

            TableGroupNumber = "1";

        }

        #region Override

        public override void AddControls(DataGridView dg)
        {
            
            //This method ads a checkbox in order for user to mark a case when it is done
            AddCheckBoxColumn(dg);

            HideColumns(dg);
        }

        private void HideColumns(DataGridView dg)
        {
            //Hide Flag columns:
            
            //Flag satteled case column
            dg.Columns[5].Visible = false;

            //Flag finished case column
            dg.Columns[6].Visible = false;

            //Hide team column
            dg.Columns[3].Visible = false;
        }

        /// <summary>
        /// This method adds a checkBox column to the datagrid
        /// So, user can mark the record hen it is done
        /// </summary>
        /// <param name="dg"></param>
        private void AddCheckBoxColumn(DataGridView dg)
        {
            //Get the instance of the dataTable
            DataTable dt = (DataTable)dg.DataSource;

            //Add the checkBoxColumn
            dt.Columns.Add("Record Complete?", typeof(bool));            

            //String to get values of flags
            string q = "SELECT `Flag_Finished` from active_case where `Satteled` order by `Flag_Finished` ";

            //Cololect result into the reader
            MySqlDataReader reader = db.Reader(q);

            int i = 0;

            //For each row, add value from the db to the new column
            while (reader.Read())
            {
                dt.Rows[i][7] = reader["Flag_Finished"];
               
                i++;
            }
            //Close connection
            db.CloseConnection();

            //assign new, modefyed table to the dataGridView
            dg.DataSource = dt;
        }

        /// <summary>
        /// This method will color records that are not finished
        /// </summary>
        /// <param name="dg"></param>
        public override void ColorTable(DataGridView dg)
        {
            //Asiign colors
            string hex = "#eab6a4";
            Color _color = ColorTranslator.FromHtml(hex);

            foreach (DataGridViewRow row in dg.Rows)
            {
                //For some reason, the last row of the table is empty, Hence we need to stop
                if (row.Index == dg.RowCount - 1) { return; }

                //Get flag value
                string flag = row.Cells[6].Value.ToString();

                //Color row in red if case is not finished (0)
                if (flag.Equals("0"))
                {
                    row.DefaultCellStyle.BackColor = _color;
                }
                else
                {
                    //Color row white, if case is complete
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        public override void UpdateStringConstructor(int index, string newValue, string key)
        {
            
            //Check if the indes is 7, then convert new value to number
            if(index == 7)
            {
                //Check if new value is true, convert to 1
                if (newValue.Equals("True")) { newValue = "" + 1; }
                else { newValue = "" + 0; }
            }

        
            // create update string
            UpdateQuery = "UPDATE " + DbTable + " SET " + DbFields[index] + " = '" + newValue + "' WHERE " + keyField + " = '" + key + "' ;";
        }

        /// <summary>
        /// This method will handel the date input modefication through the DataGridView
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public override bool ButtonInsideTableHandler(DataGridView dg, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                DateOrTeamSelectionThroughTheTableHandelr(dg, e, 1);
                return true;
            }

            return false;
        }
        #endregion
    }
}
