using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LOginForm
{
    /*************************************************************************************
     * 
     * This class Has a bug regarding column index reading after adding a button column
     * 
     * ***********************************************************************************/
    public class ActiveClassObj : TableCore
    {

        #region values
        private DataTable dt = new DataTable();
        private DBConnection db = new DBConnection();


        #endregion

        #region Constructr

        public ActiveClassObj()
        {
            TableName = "Active Case List";

            //db table name
            DbTable = "active_case";

            //key field
            keyField = "Case_No";

            //key field index
            KeyFieldIndex = 0;

            DisplayQuery = "SELECT Case_No, Case_Name , Trial_Date, Name, a.Team_ID, Note, Satteled From active_case a JOIN team t On a.Team_ID = t.Team_ID WHERE Satteled = 0";

        
            //Fields in DB
            DbFields = new string[] { "Case_No", "Case_Name",  "Trial_Date", "Team_ID", "Team_ID", "Note", "Satteled", "Satteled" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case Number", "Case Name", "Trial Date", "Team ID", "Team", "Notes", "Satteled ?"};

            //Delete query
            DeliteQuery = "DELETE FROM `active_case` WHERE Case_No = ";

            //Add Controle Form
            MyRecord = new ActiveCaseRecord();

            TableGroupNumber = "1";


        }

        #endregion

        #region Override Methods

        

        /// <summary>
        /// This method will add a comboBox as a column with team members
        /// </summary>
        /// <param name="dg"></param>
        public override void AddControls(DataGridView dg)
        {
            //Add checkBox Column that will Unable User to move record to the satteled case:
            AddCheckBoxColumn(dg, "Mark Case as Settled? ", DisplayQuery, "Satteled", 7);

            //Hide column that shows team id
            dg.Columns[4].Visible = false;

            //Hide column that shows SQL values for Satteled flag
            dg.Columns[6].Visible = false;
        }


        /// <summary>
        /// This method will Override boolean input from checkBox
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newValue"></param>
        /// <param name="key"></param>
        public override void UpdateStringConstructor(int index, string newValue, string key)
        {
           
            if (index == 7)
            {
                //This method will convert chackBox value into SQL valu and update UpdateQueryString
                UpdateStringForCheckBoxInput(index, newValue, key);

                //When user marks record as Sattaled,
                //They need to specify that it is complete
                //Or has some stuff left
                DialogResult dialog = MessageBox.Show("Does this record needs further modefications? (It is setteled, but has unfinished paperwork)", "Incomplete", MessageBoxButtons.YesNoCancel);

               //if record is not finished, we need to add one more line to the Update Quey
                if (dialog == DialogResult.No)
                {
                    UpdateQuery += "UPDATE " + DbTable + " SET `Flag_Finished`= '1'  WHERE " + keyField + " = '" + key + "' ;";
                }
            
            }
            else
            { 
                UpdateQuery = "UPDATE " + DbTable + " SET " + DbFields[index] + " = '" + newValue + "' WHERE " + keyField + " = '" + key + "' ;";
            }
        }

        /// <summary>
        /// This method will mark method as setteled and add flag  
        /// that will mark if record is finished
        /// Also, this method will Handel Date inputs from the user in Column 3
        /// </summary>
        /// <param name="dg"></param>
        public override bool ButtonInsideTableHandler(DataGridView dg, DataGridViewCellEventArgs e)
        {
          
            /************************
             *   Part to handel date
             * **********************/
            
            //Get the index of the column, and if it is Dates (column 3, index 2)
            //Show prompt to collect user's input

            if (e.ColumnIndex == 2)
            {
                //Get User's Input. Method described in TableCore
                DateOrTeamSelectionThroughTheTableHandelr(dg, e, 1);
                //Since it was collected, return true
                return true;
            }

            /**********************************
            *   Part to handel Team Members
            * ********************************/

            //Get the index of the column, and if it is Dates (column 4, index 3)
            //Show prompt to collect user's input

            if (e.ColumnIndex == 3)
            {
                //Get User's Input. Method described in TableCore
                DateOrTeamSelectionThroughTheTableHandelr(dg, e, 2);
                //Since it was collected, return true
                return true;
            }

            return false;
        }

        /// <summary>
        /// This method will color case name and case number
        /// According to the team that is working on it.
        /// </summary>
        /// <param name="dg"></param>
        public override void ColorTable(DataGridView dg)
        {
            //Assign colors
            string team1 = "#a8f7f0";
            string team2 = "#baf7a8";
            string team3 = "#d2d8d0";
            string team4 = "#eeefb8";

            string colorHolder = "";

            foreach (DataGridViewRow row in dg.Rows)
            {
                //Get team_id
                string team_id = row.Cells[4].Value.ToString();

                if (team_id.Equals("1"))
                {
                    colorHolder = team1; 
                }
                else if(team_id.Equals("2"))
                {
                    colorHolder = team2;
                }
                else if (team_id.Equals("3"))
                {
                    colorHolder = team3;
                }
                else if (team_id.Equals("4"))
                {
                    colorHolder = team4;
                }
                else 
                {
                    colorHolder = "White";
                }

                //Convert color
                Color _color = ColorTranslator.FromHtml(colorHolder);

                row.Cells[0].Style.BackColor = _color;
                row.Cells[1].Style.BackColor = _color;
            }
        }




        #endregion

    }
}
