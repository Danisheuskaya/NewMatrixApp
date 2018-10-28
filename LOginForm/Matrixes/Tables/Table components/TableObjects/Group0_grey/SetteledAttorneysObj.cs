

using System.Windows.Forms;

namespace LOginForm
{
    class SetteledAttorneysObj : TableCore
    {
        public SetteledAttorneysObj()
        {

            TableName = "Satteled Attorneys";

            //db table name
            DbTable = "settled_attorneys";

            //key field
            keyField = "ID";

            //key field index
            KeyFieldIndex = 0;

            //This query will move to the top unfinished cases
            DisplayQuery = "SELECT * FROM `settled_attorneys`";

            //Fields in DB
            DbFields = new string[] { "ID", "Attorneys", "Case_Name", "Year_Closed" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "ID ", "Attorney", "Case Name", "Year Closed" };

            //Delete query
            DeliteQuery = "DELETE FROM `settled_attorneys` WHERE ID = ";

            TableGroupNumber = "0";

            //Add Controle Form
            MyRecord = new SettelesdAttorneys();
        }

        #region Override Methods

        /// <summary>
        /// This method will hide ID column
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="controlWasAdded"></param>
        public override void AddControls(DataGridView dg)
        {
            dg.Columns[0].Visible = false;   
        }

        #endregion
    }
}
