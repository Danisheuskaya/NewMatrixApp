
using System.Windows.Forms;

namespace LOginForm
{
    class MotionMatrixObj : TableCore
    {
        public MotionMatrixObj()
        {
            TableName = "Motion Matrix";

            //db table name
            DbTable = "motion_matrix";

            //key field
            keyField = "Case_ID";

            //key field index
            KeyFieldIndex = 0;

            //This query will move to the top unfinished cases
            DisplayQuery = "SELECT * FROM `motion_matrix`";

            //Fields in DB
            DbFields = new string[] { "Case_ID", "Case_Name", "Motions", "Hearing_Dates", "Trial_Date", "Last_Date_To_File", "Reply", "Notes", "Calendar_Days", "Attorney"};

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case ID", "Case Name", "Motions ", "Hearing Dates", "Trial Date", "Last Date To File", "Reply ", "Notes ", "Calendar Days", "Attorney " };

            //Delete query
            DeliteQuery = "DELETE FROM `motion_matrix` WHERE Case_ID = ";

            TableGroupNumber = "3";

            //Add Controle Form
            MyRecord = new MotionMatrixRecord();
        }

        #region Override method
        public override void AddControls(DataGridView dg)
        {
            //Hide ID column
            dg.Columns[0].Visible = false;
        }


        #endregion
    }
}
