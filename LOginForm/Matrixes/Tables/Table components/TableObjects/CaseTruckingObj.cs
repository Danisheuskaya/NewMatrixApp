

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

            DisplayQuery = "SELECT c.Case_Number, c.Case_Name, c.Venue, t.Name, c.Date_Served, c.Initial_Discovery, c.Attorney, c.Trial_Date, c.Attorney_lvl, c.Demand, c.Offer, c.Issues, c.Medical_Rewiever FROM `case_trucking` c JOIN team t ON c.Team_ID = t.Team_ID";

            //Fields in DB
            DbFields = new string[] {"Case_Number", "Case_Name", "Venue", "Team_ID", "Date_Served", "Initial_Discovery", "Attorney", "Trial_Date", "Attorney_lvl", "Demand", "Offer", "Issues", "Medical_Rewiever", "Satteled" };

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case Number", "Case Name", "Venue", "Team", "Date Served", "Initial Discovery", "Attorney", "Trial Date", "Attorney Level", "Demand", "Offer", "Issues", "Medical Rewiever"};

            //Delete query
            DeliteQuery = "DELETE FROM `case_trucking` WHERE Case_Number = ";

            //Add Controle Form
            MyRecord = new CaseTruckingRecord();
        }

        public override void AddControls(DataGridView dg, bool flag)
        {
             
            // add checkboxes
            DataGridViewCheckBoxColumn col_chkbox = new DataGridViewCheckBoxColumn();
            {
                col_chkbox.HeaderText = "Move to Satteled Case?";
                col_chkbox.Name = "checked";

            }
            dg.Columns.Insert(13, col_chkbox);
        
    }

    }
}
