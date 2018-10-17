using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOginForm
{
    class ClientListDataObj : TableCore
    {
        public ClientListDataObj()
        {
            TableName = "Client List";

            //Name of the table in the db
            DbTable = "client_list";

            //key field
            keyField = "Case_No";

            DisplayQuery = "SELECT * FROM client_list ";

            //Fields in DB
            DbFields = new string[] { "Case_No", "Case_Name", "Client_Info", "Attorney_Info" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case Number", "Case Name", "Client Information", "Attorney Information" };

            //Delete query
            DeliteQuery = "DELETE FROM `client_list` WHERE Case_No = ";

            //Add record form
            MyRecord = new ClientListRecord();
        }
    }
}
