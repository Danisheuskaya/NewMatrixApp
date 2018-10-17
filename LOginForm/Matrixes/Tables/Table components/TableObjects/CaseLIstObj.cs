using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOginForm
{
    class CaseLIstObj : TableCore
    {
        public CaseLIstObj()
        {
            TableName = "Case List";

            //Data Base table name
            DbTable = "case_list";

            //key field
            keyField = "Case_No";

            //key field index
            KeyFieldIndex = 0;

            DisplayQuery = "SELECT * FROM case_list ";

            //Fields in DB
            DbFields = new string[] { "Case_No", "Case_Name", "date_filed", "date_served", "date_of_death" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case Number", "Case Name", "Date Complaint Filed", "Date Complaint Served", "Date Of Death" };

            //Delete query
            DeliteQuery = "DELETE FROM `case_list` WHERE Case_No = ";

            MyRecord = new CaseListRecord();
        }

        /// <summary>
        /// This method coverts string value of the date into the Date type for MySQL
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newValue"></param>
        /// <param name="key"></param>
        public override void UpdateStringConstructor(int index, string newValue, string key)
        {

            


            //convert to the DateTime value if index = 2
            /*
            if (index == 2)
            {              

                if (CheckDate(newValue))
                {
                    newValue = ConvertToDateFormat(newValue);
                }
                else
                {
                    newValue = "0000-00-00";
                }
            }*/ 

            if(index == 2)
            {
                newValue = Convert.ToDateTime(newValue).ToString("yyyy-mm-dd");
            }


            //create update string
            string querey = "UPDATE " + DbTable + " SET " + DbFields[index] + " = '" + newValue + "' WHERE " + keyField + " = '" + key + "' ";


            //update UpdateQuery
            UpdateQuery = querey;
        }

       


    }

    
}
