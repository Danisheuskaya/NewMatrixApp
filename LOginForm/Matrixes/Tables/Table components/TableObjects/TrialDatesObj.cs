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
            DbFields = new string[] { "Record_ID", "Start_Date", "End_Date", "Case_Name", "Place", "Tag", "Tag" };

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

            //Add checkBox that will show if dates show "team member out of office"
            AddCheckBoxColumn(dg, "Out of Office?", DisplayQuery, "Tag", 6);

            dg.Columns[5].Visible = false;
            dg.Columns[0].Visible = false;

            DataTable dt = (DataTable)dg.DataSource;
           
        }

        /// <summary>
        /// This method Sets an Update query depending on the value user changed
        /// if User selected a checkBox, UpdateStringForCheckBoxInput() will
        /// convert value to the SQL format
        /// </summary>
        /// <param name="index">indecates column</param>
        /// <param name="newValue">new User's input</param>
        /// <param name="key">SQL key field for this record</param>
        public override void UpdateStringConstructor(int index, string newValue, string key)
        {
            //Check if the column is a checkBox
            if(index == 6)
            {
                //Override update string for the checkBox input value
                UpdateStringForCheckBoxInput(index, newValue, key);
            }
            else
            {
                // create update string
                UpdateQuery = "UPDATE " + DbTable + " SET " + DbFields[index] + " = '" + newValue + "' WHERE " + keyField + " = '" + key + "' ;";
            }
        }

        /// <summary>
        /// This method will help to collect User Input that is dtaes related
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public override bool ButtonInsideTableHandler(DataGridView dg, DataGridViewCellEventArgs e)
        {
            //Get the index of the column, and if it is Dates (column 1, and 2)
            //Show prompt to collect user's input

            if(e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                //Get User's Input. Method described in TableCore
                DateOrTeamSelectionThroughTheTableHandelr(dg, e, 1);
                //Since it was collected, return true
                return true;
            }

            //No user's input was collected => return false
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
