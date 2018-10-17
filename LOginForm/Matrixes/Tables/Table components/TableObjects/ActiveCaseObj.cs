using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Windows.Forms;

namespace LOginForm
{
    /*************************************************************************************
     * 
     * This class Has a bug regarding column index reading after adding a button column
     * 
     * ***********************************************************************************/
    public class ActiveClassObj : TableCore
    {

        #region values
        private DataTable dt = new DataTable();
        private DBConnection db = new DBConnection();


        #endregion

        #region Constructr

        public ActiveClassObj()
        {
            TableName = "Active Case List";

            //db table name
            DbTable = "active_case";

            //key field
            keyField = "Case_No";

            //key field index
            KeyFieldIndex = 1;

            DisplayQuery = "SELECT Case_No, Case_Name , Trial_Date, Name, Note From active_case a JOIN team t On a.Team_ID = t.Team_ID WHERE Satteled = 0";

            /*****************************************************************
             *          BUG DUE TO THE BUTTONS!, NEED TO ADD AN EMPTY FIELD
             * **************************************************************/

            //Fields in DB
            DbFields = new string[] { "", "Case_No", "Case_Name",  "Trial_Date", "Team_ID", "Note", "Satteled"};

            //Headers for the table columns
            ColumnHeaders = new string[] { "Case Number", "Case Name", "Trial Date", "Team", "Notes"};

            //Delete query
            DeliteQuery = "DELETE FROM `active_case` WHERE Case_No = ";

            //Add Controle Form
            MyRecord = new ActiveCaseRecord();


        }

        #endregion

        #region Override Methods

        /// <summary>
        /// This method coverts string value of the date into the Date type for MySQL
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newValue"></param>
        /// <param name="key"></param>
        public override void UpdateStringConstructor(int index, string newValue, string key)
        {
            //convert to the DateTime value if index = 3
            if(index == 2)
            {
                newValue = ConvertToDateFormat(newValue);                              
            }           
            //create update string
            string querey = "UPDATE " + DbTable + " SET " + DbFields[index] + " = '" + newValue + "' WHERE " + keyField + " = '" + key + "' "; 

            //update UpdateQuery
            UpdateQuery = querey;
        }

        /// <summary>
        /// This method will add a comboBox as a column with team members
        /// </summary>
        /// <param name="dg"></param>
        public override void AddControls(DataGridView dg, bool controlWasAdded)
        {

            if (!controlWasAdded)
            {
                AddButtonColumn(dg);
                controlWasAdded = true;
            }


        }

        /// <summary>
        /// This method Adds a button column in order to move
        /// Cases to the Archive
        /// </summary>
        /// <param name="dg"></param>       
        private void AddButtonColumn(DataGridView dg)
        {

            //Creating a column:
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();

            
            btnColumn.HeaderText = "Move to Archive?";
            btnColumn.Name = "buttonColumn";
            btnColumn.Text = "Move to Archive";
            

            btnColumn.UseColumnTextForButtonValue = true;

            dg.Columns.Insert(5, btnColumn);
        }


        /// <summary>
        /// This method will mark method as setteled and add flag  
        /// that will mark if record is finished
        /// </summary>
        /// <param name="dg"></param>
        public override bool ButtonInsideTableHandler(DataGridView dg, DataGridViewCellEventArgs e)
        {
            
            //Check if clicked cell is a button
            if(e.ColumnIndex == 0)
            {
                //Ask user, if this record is finished
                int isFinished = 1;

                //Create window  dialog for conformation, in case delet button is pressed by mistake
                DialogResult dialog = MessageBox.Show("Is this case complete (NO EXTRA paperwork needed)?", "Cancel", MessageBoxButtons.YesNoCancel);

                if(dialog == DialogResult.No)
                {
                    isFinished = 0;
                }

                //Variables for the updateQuery 
                string keyValue = dg.Rows[e.RowIndex].Cells[KeyFieldIndex].Value.ToString();

                UpdateQuery = "UPDATE `active_case` SET `Satteled` = '1', `Flag_Finished` = '"+isFinished+"' WHERE `active_case`.`Case_No` = '"+keyValue+"';";

                return true;
            }

            return false;
        }






        #endregion

    }
}
