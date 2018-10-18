
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
            DbFields = new string[] { "Case_ID", "Case_Name", "Team_ID", "Discovery", "Due_date", "Flag_served", "Notes", "Team_ID" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case ID", "Case Name", "Team", "Discovery ", "Due date", "Served?", "Notes", "Attorney" };

            //Delete query
            DeliteQuery = "DELETE FROM `settled_attorneys` WHERE ID = ";

            //Add Controle Form
            MyRecord = new SettelesdAttorneys();
        }

        #region Overrides

        /// <summary>
        /// Move columns display, so Attorney is displayed 
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="controlWasAdded"></param>
        public override void AddControls(DataGridView dg, bool controlWasAdded)
        {
            dg.Columns[7].DisplayIndex = 3;
        }

        #endregion
    }
}
