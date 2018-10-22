using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace LOginForm
{
    /// <summary>
    /// This is an interface for the table object
    /// </summary>
    public class TableCore
    {

        #region values
        private DataTable dt = new DataTable();
        private DBConnection db = new DBConnection();
        

        #endregion

        #region Getters/setters
        /// <summary>
        /// The names of the fields in db
        /// </summary>
        public string[] DbFields { get; set; }

        /// <summary>
        /// The name of the column headers that will be displayed in the tables
        /// </summary>
        public string[] ColumnHeaders { get; set; }

        /// <summary>
        /// Table name in database
        /// </summary>
        public string DbTable { get; set; }

        public string keyField { get; set;}

        public int KeyFieldIndex { get; set;}

        /// <summary>
        /// The name of the Matrix
        /// </summary>
        public string TableName { get; set; }


        /// <summary>
        /// Query to display the table
        /// </summary>
        public string DisplayQuery { get; set; }

        /// <summary>
        /// Query to update values in the row
        /// </summary>
        public string UpdateQuery { get; set; }

        /// <summary>
        /// Query to delite row
        /// </summary>
       public string DeliteQuery { get; set; }

        /// <summary>
        /// Query to insert row
        /// </summary>
        public string AddQuery { get; set; }

        /// <summary>
        /// Query to insert row
        /// </summary>
        public string AddNewRecordMessage { get; set; }

        public Form MyRecord { get; set;}

        public string DateFromTheFormHolder { get; set; }

        #endregion       


        #region Functions

        public virtual DataTable FillTable()
        {
            //Getting table records
            dt = db.fillTheTable(DisplayQuery);

            //rename headers
            for (int i = 0; i < ColumnHeaders.Length; i++)
            {
                dt.Columns[i].ColumnName = ColumnHeaders[i];
            }


            return dt;
        }

       

        /// <summary>
        /// This function deletes the row freom the db
        /// </summary>
        public virtual void DeleteRow(string key)
        {
            //get updated key value
            string dinamicQuery = DeliteQuery + "'" + key + "'";

            //run query
            db.InsertDeleteQuery(dinamicQuery);
        }

        


        public virtual void UpdateStringConstructor(int index, string newValue, string key)
        {            
            //create update string
            string   querey = "UPDATE " + DbTable + " SET " + DbFields[index] + " = '" + newValue + "' WHERE " + keyField + " = '" + key + "' ";           
          

            //update UpdateQuery
            UpdateQuery = querey;
        }

        #endregion

        /*****************************************************************************
         * 
         * This functios handel user input that is done through the DataGridView Table
         * And Dates related. This methods called from the ButtonInsideCell();
         * 
         * **************************************************************************/
        #region Date Formating Handelers


        public void UserDateInputThrougtTableHaneler(DataGridView dg, DataGridViewCellEventArgs e)
        {
            //Get the index of the column, and if it is Dates (column 1, and 2)
            //Show prompt to collect user's input

            
                //Get new Value coordinates
                int column = e.ColumnIndex;
                int row = e.RowIndex;

                //A holder for user's input
                string newValue = "";

                //Get the value from the tabel
                string defaultValue = dg.Rows[row].Cells[column].Value.ToString();

                //Trim the time stamp off
                defaultValue = defaultValue.Split(' ')[0];

                //Run checks, and if input is correct => convert to date
                newValue = UserDateInputHandeler();

            //if input is correct, show it in the table and update query
            if (!string.IsNullOrEmpty(newValue))
            {

                //Update string for this record
                UpdateStringConstructor(e.ColumnIndex, newValue, dg.Rows[row].Cells[KeyFieldIndex].Value.ToString());

                //Show value in the table:                   
                dg.Rows[row].Cells[column].Value = newValue;
                
            }

          
        }

        /// <summary>
        /// This method helps to retrive a new date from the user
        /// through helping form
        /// </summary>
        /// <param name="newValue"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public string UserDateInputHandeler()
        {
            DateFromTheFormHolder = "";
            //Open form for user to enter new date
            DateConverterForm dateForm = new DateConverterForm(this);

            dateForm.ShowDialog();

            MessageBox.Show("User input after form closed is : " + DateFromTheFormHolder);

            return DateFromTheFormHolder;
        }


        /// <summary>
        /// This method checks if the string is a date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool CheckDate(String date)

        {
            DateTime dt;
            if (DateTime.TryParseExact(date, "M/d/yyyy", null, DateTimeStyles.None, out dt) == true)
            {
                return true;
            }

            return false;

        }

        /// <summary>
        /// This method converts string into date format
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public string ConvertToDateFormat(string date)
        {
            //Check if string is a date
            if (CheckDate(date))
            {
                               
                //convert date to the DateTime type
                DateTime dateValue = Convert.ToDateTime(date);

                string formatForMySql = dateValue.ToString("yyyy-MM-dd");

                return formatForMySql;   
            }
            else
            {
                MessageBox.Show("Please, enter the date in format : mm/dd/yyyy");
                return " ";
            }
        }



        #endregion


        #region Helpers

        




        /// <summary>
        /// This method is used to add comboBoxes and CheckBoxes to the existing dataGrid
        /// </summary>
        /// <param name="dg"></param>
        public virtual void AddControls(DataGridView dg, bool controlWasAdded) { }


        public virtual void ColorTable(DataGridView dg) { }

        public virtual bool ButtonInsideTableHandler(DataGridView dg, DataGridViewCellEventArgs e) { return false; }


        #endregion

    }
}
