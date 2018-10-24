
using System;
using System.Windows.Forms;

namespace LOginForm
{
    class DiscoveryMatrixObj : TableCore
    {
        public DiscoveryMatrixObj()
        {
            TableName = "Discovery Matrix";

            //db table name
            DbTable = "discovery_matrix";

            //key field
            keyField = "Case_ID";

            //key field index
            KeyFieldIndex = 0;

            //This query will move to the top unfinished cases
            DisplayQuery = "SELECT DM.*, T.Name FROM discovery_matrix DM Inner JOIN team T ON DM.Team_ID = T.Team_ID";

            //Fields in DB, Team_ID is repeated due to the joined tables
            DbFields = new string[] { "Case_ID", "Case_Name", "Team_ID", "Discovery", "Due_date", "Flag_served", "Notes", "Team_ID", "Flag_served" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case ID", "Case Name", "Team", "Discovery ", "Due date", "Served ", "Notes", "Attorney" };

            //Delete query
            DeliteQuery = "DELETE FROM `settled_attorneys` WHERE ID = ";

            //Add Controle Form
            MyRecord = new DiscoveryMatrixRecord();
        }

        #region Overrides

        /// <summary>
        /// Move columns display, so Attorney is displayed 
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="controlWasAdded"></param>
        public override void AddControls(DataGridView dg, bool controlWasAdded)
        {
            AddNewColumn(dg);

            dg.Columns[7].DisplayIndex = 3;
        }

        /// <summary>
        /// This method will add a checkBox column
        /// </summary>
        /// <param name="dg"></param>
        private void AddNewColumn(DataGridView dg)
        {
            //Query to get the "Printed" column
            string q1 = " SELECT `Flag_served` from discovery_matrix ORDER By `Team_ID`";

            AddCheckBoxColumn(dg, "Served?", q1, "Flag_served", 8);

            dg.Columns["Served?"].DisplayIndex = 5;

            //Hide the ID column:
            dg.Columns[0].Visible = false;

            //Hide TeamId Column
            dg.Columns[2].Visible = false;

            //Hide Served_Flag Column
            dg.Columns[5].Visible = false;
        }

        /// <summary>
        /// This method will help to collect User Input that is dates related
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public override bool ButtonInsideTableHandler(DataGridView dg, DataGridViewCellEventArgs e)
        {
            //Get the index of the column, and if it is Dates (column 4)
            //Show prompt to collect user's input

            if (e.ColumnIndex == 4)
            {
                //Get User's Input. Method described in TableCore
                DateOrTeamSelectionThroughTheTableHandelr(dg, e, 1);
                //Since it was collected, return true
                return true;
            }

            /*******************************
             * Handel TeamMembers DropBox:
             * *****************************/

            if(e.ColumnIndex == 7)
            {
                //Get User's Input. Method described in TableCore
                DateOrTeamSelectionThroughTheTableHandelr(dg, e, 2);
                //Since it was collected, return true
                return true;
            }

            //No user's input was collected => return false
            return false;
        }

        public override void UpdateStringConstructor(int index, string newValue, string key)
        {
            if(index == 8)
            {
                UpdateStringForCheckBoxInput(index, newValue, key);
            }

            // create update string
            UpdateQuery = "UPDATE " + DbTable + " SET " + DbFields[index] + " = '" + newValue + "' WHERE " + keyField + " = '" + key + "' ;";
        }

        #endregion
    }
}
