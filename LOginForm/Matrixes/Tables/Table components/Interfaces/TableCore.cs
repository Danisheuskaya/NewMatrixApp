using MySql.Data.MySqlClient;
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

        public string TeamIndexFromTheFormHolder { get; set; }
        public string LetterTypeFromTheForm { get; set; }

        public string TableGroupNumber { get; set; }

        #endregion       


        #region Query Related Functions

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

            MessageBox.Show("Old UpdateString!");
            //create update string
            string   querey = "UPDATE " + DbTable + " SET " + DbFields[index] + " = '" + newValue + "' WHERE " + keyField + " = '" + key + "' ;";           
          

            //update UpdateQuery
            UpdateQuery = querey;
        }

        #endregion

        /*****************************************************************************
         * 
         * This functios handel user input that is done through the DataGridView Table
         * And Dates or Team member related. This methods called from the ButtonInsideCell();
         * 
         * **************************************************************************/
        #region Date Formating Handelers

        /// <summary>
        /// This method will help to gater User's input through the specific forms
        /// </summary>
        /// <param name="dg">dataGridView of the current table</param>
        /// <param name="e"></param>
        /// <param name="HelpingFunction">if index == 1, it is a date; if index == 2 it is a teamMember</param>
        public void DateOrTeamSelectionThroughTheTableHandelr(DataGridView dg, DataGridViewCellEventArgs e, int functionIndex)
        {
            //Get the index of the cell
            //Get new Value coordinates
            int column = e.ColumnIndex;
            int row = e.RowIndex;

            //Get an old Value for the Team Option case

            string oldValue = dg.Rows[row].Cells[column].Value.ToString();
            
            //A holder for user's input
            string newValue = "";

            //If index == 1, Open form to colect date, if index == 2
            //Open form to get a teamMember index

            if(functionIndex == 1)
            {
                newValue = UserDateInputHandeler();
            }
            else if (functionIndex == 2)
            {
                newValue = UserTeamMemberInput(oldValue);
            }
            //User is deling with MedicalRecord, which means Expiration date might need to change
            else if (functionIndex == 3)
            {
                newValue = LetterTypeInput(oldValue);
            }


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
        /// This method helps to collect User's input regarding
        /// team members through the form.
        /// </summary>
        /// <param name="OldValue">String that shows current team member(s)</param>
        /// <returns></returns>
        public string UserTeamMemberInput(string OldValue)
        {
            //Clear holder for the TeamId
            TeamIndexFromTheFormHolder = "";

            //Open Form, so User can select new team:
            TeamMembersDropBox teamDropBox = new TeamMembersDropBox(this, OldValue);

            //Get input from the user
            teamDropBox.ShowDialog();

            return TeamIndexFromTheFormHolder;

        }

      

        /// <summary>
        /// This method converts boolean into SQL numeric format
        /// </summary>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public void UpdateStringForCheckBoxInput(int index, string newValue, string key)
        {
            
            if (newValue.Equals("True"))
            {
                newValue = "" + 1;
            }
            else if(newValue.Equals("True"))
            {
                newValue = "" + 0;
            }

            //create update string
            UpdateQuery = "UPDATE " + DbTable + " SET " + DbFields[index] + " = '" + newValue + "' WHERE " + keyField + " = '" + key + "' ;";
                                  
        }



        /// <summary>
        /// This method helps to retrive a new date from the user
        /// through helping form
        /// </summary>
        /// <returns></returns>
        public string UserDateInputHandeler()
        {
            DateFromTheFormHolder = "";
            //Open form for user to enter new date
            DateConverterForm dateForm = new DateConverterForm(this);

            //Collect input from the user through the form
            dateForm.ShowDialog();

            //return collected value
            return DateFromTheFormHolder;
        }


        
  

        public string LetterTypeInput(string OldValue)
        {
            //Clear holder for the letter type
            LetterTypeFromTheForm = "";

            //Open Form, so User can select new team:
            LetterTypeForm LetterForm = new LetterTypeForm(this, OldValue);

            //Get input from the user
            LetterForm.ShowDialog();

            return LetterTypeFromTheForm;
        }


        #endregion

        /// <summary>
        /// This method will add a checkBox column to the dataGridView Table
        /// </summary>
        /// <param name="dg">current tabel's dataGridView instance</param>
        /// <param name="columnName">Name that will be displayed to the User</param>
        /// <param name="SQLQuery">Query to get needed column</param>
        /// <param name="fieldName">Name of the field from the database</param>
        /// <param name="columnIndex">Index of the checkBox column in the DataTable</param>
        #region Add Controls Functions
        public void AddCheckBoxColumn(DataGridView dg, string columnName, string SQLQuery, string fieldName, int columnIndex)
        {
            //Get the instance of the dataTable
            DataTable dt = (DataTable)dg.DataSource;

            //Add 2 columns
            dt.Columns.Add(columnName, typeof(bool));            

            //Cololect result into the reader
            MySqlDataReader reader = db.Reader(SQLQuery);

            int i = 0;

            //For each row, add value from the db to the new columns
            while (reader.Read())
            {
                dt.Rows[i][columnIndex] = reader[fieldName];
                i++;
            }
            //Close connection
            db.CloseConnection();

            //assign new, modefyed table to the dataGridView
            dg.DataSource = dt;
        }


        #endregion


        #region "Interface" functions

        /// <summary>
        /// This method is used to add comboBoxes and CheckBoxes to the existing dataGrid
        /// </summary>
        /// <param name="dg"></param>
        public virtual void AddControls(DataGridView dg) { }

        /// <summary>
        /// This method will color Tabel's rows
        /// </summary>
        /// <param name="dg"></param>
        public virtual void ColorTable(DataGridView dg) { }

        /// <summary>
        /// This method will handel interactive cells incide the table
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public virtual bool ButtonInsideTableHandler(DataGridView dg, DataGridViewCellEventArgs e) { return false; }

        #endregion

    }
}
