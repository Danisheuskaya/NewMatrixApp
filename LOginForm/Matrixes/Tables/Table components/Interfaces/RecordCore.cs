using MySql.Data.MySqlClient;


namespace LOginForm
{
    public class RecordCore
    {
        DBConnection db = new DBConnection();

        /// <summary>
        /// This is the names of each form field from the top to teh bottom
        /// </summary>
        public string[] FormFieldNames { get; set; }

        public string[] FormFieldValues { get; set; }

        public string KeyField { get; set; }


        /// <summary>
        /// This method is checking if the new key field value is unique
        /// </summary>
        /// <param name="tc"></param>
        /// <param name="caseNo"></param>
        /// <returns></returns>
        private bool KeyIsUnique(TableCore tc, string caseNo)
        {
            //make a flag value
            bool unique = true;

            //Get table name
            string tableName = tc.DbTable;

            //Get the key field name
            string keyField = tc.keyField;

            //Query to retrieve a retrieve a record with case name if it is not unique
            string query = "SELECT * FROM " + tableName + " WHERE " + keyField + " = '" + caseNo + "'";

            //process query
            MySqlDataReader reader = db.Reader(query);

            //If there is a value
            while (reader.Read())
            {
                //If there is a line in the reader => name is not unique
                unique = false;
            }

            //close connection
            db.CloseConnection();

            return unique;
        }

    }
}
