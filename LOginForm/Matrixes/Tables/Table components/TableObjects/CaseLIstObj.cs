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

        #region Override

        /// <summary>
        /// This method will help to collect User Input that is dates related
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public override bool ButtonInsideTableHandler(DataGridView dg, DataGridViewCellEventArgs e)
        {
            //Get the index of the column, and if it is Dates (column 2)
            //Show prompt to collect user's input

            if (e.ColumnIndex == 2 )
            {
                //Get User's Input. Method described in TableCore
                DateOrTeamSelectionThroughTheTableHandelr(dg, e, 1);
                //Since it was collected, return true
                return true;
            }

            //No user's input was collected => return false
            return false;
        }

        #endregion



    }


}
