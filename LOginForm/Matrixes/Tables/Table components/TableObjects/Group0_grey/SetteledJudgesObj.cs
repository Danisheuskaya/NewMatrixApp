using System.Windows.Forms;

namespace LOginForm
{ 
       class SetteledJudgesObj : TableCore
    {
        public SetteledJudgesObj()
        {
            TableName = "Satteled Judges";

            //db table name
            DbTable = "settled_judges";

            //key field
            keyField = "ID";

            //key field index
            KeyFieldIndex = 0;

            //This query will move to the top unfinished cases
            DisplayQuery = "SELECT * FROM `settled_judges`";

            //Fields in DB
            DbFields = new string[] { "ID", "Judge", "County", "Case_Name", "Year_Settled", "Notes" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "ID ", "Judge", "County ", "Case Name", "Year Settled", "Notes " };

            //Delete query
            DeliteQuery = "DELETE FROM `settled_judges` WHERE ID = ";

            TableGroupNumber = "0";

            //Add Controle Form
            MyRecord = new SetteledJudgesRecord();
        }

        #region Override

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
