using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOginForm
{
    class TrialDatesObj : TableCore
    {
        DBConnection db = new DBConnection();
        public TrialDatesObj()
        {
            TableName = "Trial Dates";

            //db table name
            DbTable = "trial_dates";

            //key field
            keyField = "Record_ID";

            //key field index
            KeyFieldIndex = 0;

            DisplayQuery = "SELECT * FROM `trial_dates` ORDER by Start_Date";

            //Fields in DB
            DbFields = new string[] { "Record_ID", "Start_Date", "End_Date", "Case_Name", "Place", "Tag" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "Record ID","Start Date", "End Date", "Case Name", "Place", "Tag"};


            //Delete query
            DeliteQuery = "DELETE FROM `trial_dates` WHERE `Record_ID` = ";

            //Add Controle Form
            MyRecord = new TrialDatesRecord();
        }


        #region Override Function



       


        /// <summary>
        /// This method hides the flag column
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="flag"></param>
        public override void AddControls(DataGridView dg, bool flag)
        {

            dg.Columns[5].Visible = false;
            dg.Columns[0].Visible = false;

            DataTable dt = (DataTable)dg.DataSource;
           
        }


        public override bool ButtonInsideTableHandler(DataGridView dg, DataGridViewCellEventArgs e)
        {
            //Get the index of the column, and if it is Dates (column 1, and 2)
            //Show prompt to collect user's input

            if(e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                //Get new Value coordinates
                int column = e.ColumnIndex;
                int row = e.RowIndex;

                //A holder for user's input
                string newValue = "";

                //Get the value from the tabel
                string defaultValue = dg.Rows[row].Cells[column].Value.ToString();

                //Trim the time stamp off
                defaultValue = defaultValue.Split(' ')[0];

                //Run checks, and if input is correct - convert to date
               newValue = UserDateInputHandeler(newValue, defaultValue);

                //if input is correct, show it in the table and update query
                if (!string.IsNullOrEmpty(newValue))
                {
                  
                    //Update string for this record
                    UpdateStringConstructor(e.ColumnIndex, newValue, dg.Rows[row].Cells[KeyFieldIndex].Value.ToString());

                    //Show value in the table:                   
                    dg.Rows[row].Cells[column].Value = newValue;

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// This method will change row color depending on the flag
        /// If flag == 1, that means a team member is out of office,
        /// If flag == 0, that menas the row is just a trial dtae
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
                string flag = row.Cells[5].Value.ToString();

                //Color row in red if member out of office
                if (flag.Equals("1"))
                {
                    row.DefaultCellStyle.BackColor = _color;
                }
                else
                {
                    //Color row white, if it is just a trial
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }

        }







        



        #endregion
    }
}
