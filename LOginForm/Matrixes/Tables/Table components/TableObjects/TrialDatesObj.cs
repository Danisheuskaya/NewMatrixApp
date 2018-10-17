﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOginForm
{
    class TrialDatesObj : TableCore
    {
        public TrialDatesObj()
        {
            TableName = "Trial Dates";

            //db table name
            DbTable = "trial_dates";

            //key field
            keyField = "Case_Name";

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