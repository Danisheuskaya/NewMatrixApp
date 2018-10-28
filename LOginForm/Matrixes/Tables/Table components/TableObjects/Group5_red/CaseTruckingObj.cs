

using System.Drawing;
using System.Windows.Forms;

namespace LOginForm
{
    class CaseTruckingObj : TableCore
    {
        public CaseTruckingObj()
        {
            TableName = "Case Trucking";

            //db table name
            DbTable = "case_trucking";

            //key field
            keyField = "Case_Number";

            //key field index
            KeyFieldIndex = 0;

            //"SELECT c.Case_Number, c.Case_Name, c.Venue, t.Name, c.Date_Served, c.Initial_Discovery, c.Attorney, c.Trial_Date, c.Attorney_lvl, c.Demand, c.Offer, c.Issues, c.Medical_Rewiever FROM `case_trucking` c JOIN team t ON c.Team_ID = t.Team_ID"
            DisplayQuery = "SELECT C.*, T.Name FROM `case_trucking` C JOIN team T on C.Team_ID = T.Team_ID ORDER By Archived  ";

            //Fields in DB
            DbFields = new string[] {"Case_Number", "Case_Name", "Venue", "Team_ID", "Date_Served", "Initial_Discovery", "Attorney", "Trial_Date", "Attorney_lvl", "Demand", "Offer", "Issues", "Medical_Rewiever", "Archived", "Team_ID", "Archived" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case Number", "Case Name", "Venue", "Team ", "Date Served", "Initial Discovery", "Attorney", "Trial Date", "Attorney Level", "Demand", "Offer", "Issues", "Medical Rewiever", "Satteled?", "Team"};

            //Delete query
            DeliteQuery = "DELETE FROM `case_trucking` WHERE Case_Number = ";

            TableGroupNumber = "6";

            //Add Controle Form
            MyRecord = new CaseTruckingRecord();
        }

        public override void AddControls(DataGridView dg)
        {
            //Add check Box column that will show which case is satteled
            AddCheckBoxColumn(dg, "Mark as Settaled?", DisplayQuery, "Archived", 15);

            //Hide column that numericaly shows team index
            dg.Columns[3].Visible = false;

            //Hide archived flagm index
            dg.Columns[13].Visible = false;

            //Move Names of the team to the 4th column
            dg.Columns[14].DisplayIndex = 3;


        }

        /// <summary>
        /// This method will help to collect User Input that is dates related
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public override bool ButtonInsideTableHandler(DataGridView dg, DataGridViewCellEventArgs e)
        {
            //Get the index of the column, and if it is Dates (column 8)
            //Show prompt to collect user's input

            /*********************
             * Handel date input:
             * *******************/

            if (e.ColumnIndex == 7)
            {
                //Get User's Input. Method described in TableCore
                DateOrTeamSelectionThroughTheTableHandelr(dg, e, 1);
                //Since it was collected, return true
                return true;
            }

            /**********************
             * Handel Team input
             * *******************/
            if (e.ColumnIndex == 14)
            {
                //Get User's Input. Method described in TableCore
                DateOrTeamSelectionThroughTheTableHandelr(dg, e, 2);
                //Since it was collected, return true
                return true;
            }

            //No user's input was collected => return false
            return false;
        }

        /// <summary>
        /// This method handels the updateQuery within the table
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newValue"></param>
        /// <param name="key"></param>
        public override void UpdateStringConstructor(int index, string newValue, string key)
        {
           if(index == 15)
            {
                //This method will convert boolean input into SQL format
                UpdateStringForCheckBoxInput(index, newValue, key);
                
            }
            else
            {
                //create update string
                UpdateQuery = "UPDATE " + DbTable + " SET " + DbFields[index] + " = '" + newValue + "' WHERE " + keyField + " = '" + key + "' ;";
            }
        }

        public override void ColorTable(DataGridView dg)
        {
            foreach (DataGridViewRow row in dg.Rows)
            {
                //Get flag:
                string flag = row.Cells[13].Value.ToString();

                if (flag.Equals("1"))
                {
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
