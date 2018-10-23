
namespace LOginForm
{
    class CourtListObj : TableCore
    {
        public CourtListObj()
        {
            TableName = "Court List";

            //db table name
            DbTable = "court_list";

            DisplayQuery = "SELECT * FROM court_list ";

            //key field
            keyField = "Case_Number";

            //key field index
            KeyFieldIndex = 0;

            //Fields in DB
            DbFields = new string[] { "Case_Number", "Case_Name", "Judge_dpmt", "Court_Info", "Reporter", "Rullings", "Motion_Info"};

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case Number", "Case Name", "Judge/Department", "Court Information", "Reporter Information", "Tenatative Rullings", "Motion Information" };

            //Delete query
            DeliteQuery = "DELETE FROM `court_list` WHERE Case_Number = ";

            //Adding Record object
            MyRecord = new CourtListRecord();
        }
    }
}
