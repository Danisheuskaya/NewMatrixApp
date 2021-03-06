﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DGVPrinterHelper;


namespace LOginForm
{
    public partial class MatrixForm: FormPrototype 
    {

        #region Variables

        private TableCore tc; //Holder for the table object
        private DBConnection db = new DBConnection(); //Create data base connection
        
        private List<string> updateQueryes;  //Container of queryes, that would be created when table is modefyed by user

        bool admin = true; //This is a flag, indicating if user can do any changes

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="tableCore"> Type of the table object that was passed through the button</param>
        /// <param name="person">Instance of the current User</param>
        public MatrixForm(TableCore tableCore,  Person person)
        {

            InitializeComponent();

            //invoke table object
            tc = tableCore;

            //Changethe name of table holder 
           

            //This method will determine what user can do with the table
            CheckUserPemition(person);

            //Show tabel name
            TabelNameLabel.Text = tc.TableName;

            //Load the table
            LoadTable();

            //Cleare a query holder
            updateQueryes = new List<string>();

            
    }

     


        /// <summary>
        /// This method will determine what user can do with the table based
        /// on the Admin previlages
        /// if User is an admin, the Tag of the table will be in the DB 
        /// As an admin, user can modefy table, as wiever - only see and print
        /// </summary>
        /// <param name="person"></param>
        private void CheckUserPemition(Person person)
        {
            //Get the tag of the loaded table table
            var tableTag = tc.TableGroupNumber;

            //retrieve the list of groups where this person is admin
            List<string> groups = person.AdminGroupList.Split('_').OfType<string>().ToList();

            //If user is not an admin of this group, add some restrictions:
            if (groups.IndexOf(tableTag) == -1)
            {
                //Block dataGridView from being modefyed:
                dataGridView1.ReadOnly = true;
                //Mark user as viewer
                admin = false;

                UserMenuStrip.Visible = true;
                AdminMenuStrip.Visible = false;
            }

            
        }




        #endregion

        #region Load Table Helpers

        /// <summary>
        /// This method loads the table in the DataGridView
        /// </summary>
        public void LoadTable()
        {
            //Creating a table object that corspont to the DataBase Table
            DataTable table = tc.FillTable();

            //Placing it inside the datagrid view
            dataGridView1.DataSource = table;

            //Blocking the DBkey value column from being modefyed b y User
            dataGridView1.Columns[tc.KeyFieldIndex].ReadOnly = true;

            //Adding special controls if there is any
            //such as dropdown options, check marks, buttons...
            tc.AddControls(dataGridView1);
        }



        #endregion

        
        /*
         * Modefecation of the record is done by processing all the queryes that
         * accumulated in the updateQueryes List.
         * Each time user clicks on the table cell and modefyes the cell value, 
         * new query added to the update List. 
         * The column with the key value is blocked
         * */

        #region Modefy Record

        /// <summary>
        /// This button will run a series of queryes that have been 
        /// created on every cell change and saved in the array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void modefyBtn_Click(object sender, EventArgs e)
        {
            //if list of queryes is not empty
            if(updateQueryes.Count() != 0)
            {
                //run each query
                foreach(string query in updateQueryes)
                {
                    try
                    {
                        db.InsertDeleteQuery(query);

                        //close conection
                        db.CloseConnection();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }

                }

                //For debug purposes show what update query was runned
                //MessageBox.Show(tc.UpdateQuery);

                //Inform user that changes have been made
                MessageBox.Show("All changes have been saved");

                //Cleare data Grid in order to load a new, updated table
                dataGridView1.DataSource = null;

                //Load updated table
                LoadTable();
            }

            //After done updating, cleare update query list
            updateQueryes = new List<string>();
        }


      
        
        /// <summary>
        /// After value of the cell have been modefied, add corresponding querey to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Get the column index which is equals to the index
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            

            //TEST
            //MessageBox.Show("The column index is :  " + columnIndex);

            //Get the row index
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            //TEST
            //MessageBox.Show("The row index is :  " + rowIndex);

            //Get new value
            string newValue = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString();

            //TEST
            //MessageBox.Show("The new value is :  " + newValue);

            //Get the key value for this row
            string keyValue = dataGridView1.Rows[rowIndex].Cells[tc.KeyFieldIndex].Value.ToString();

            //TEST
            //MessageBox.Show("The key is :  " + keyValue);

            //create update query
            tc.UpdateStringConstructor(columnIndex, newValue, keyValue);

            //add query to the list
            updateQueryes.Add(tc.UpdateQuery);

            //TEST
            //MessageBox.Show(tc.UpdateQuery);
            

        }

        #endregion

        /// <summary>
        /// This method colors the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            tc.ColorTable(dataGridView1);
            
            return;
        }


        

        


        /// <summary>
        /// This method handels Buttons inside the table
        /// This method will be handeled in TableCoreObject according to the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //If user can modefy table : 
            if (admin)
            {
                if (tc.ButtonInsideTableHandler(dataGridView1, e))
                {
                    //add query to the list
                    updateQueryes.Add(tc.UpdateQuery);

                    //TEST
                    MessageBox.Show(tc.UpdateQuery);

                    //Run all updates
                    modefyBtn_Click(sender, e);

                }
            }
           
        }

        #region Menu Bar
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// This method lets the user to close any opend table
        /// by pressing [X] button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MatrixForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Create window  dialog for conformation, in case exit button is pressed by mistake
            DialogResult dialog = MessageBox.Show("Do you want to close this table?", "Exit", MessageBoxButtons.YesNo);

            //If yes, close this instance of a table
            if (dialog == DialogResult.Yes)
            {

                //Run all updates
                modefyBtn_Click(sender, e);

                //Close the form
                ControlBox = false;
            }
            else
            {
                //Discard an event
                e.Cancel = true;
            }


        }

        /// <summary>
        /// This method will print the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = tc.TableName;//Header
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString());
            printer.SubTitleFormatFlags = System.Drawing.StringFormatFlags.LineLimit | System.Drawing.StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = System.Drawing.StringAlignment.Near;
            printer.Footer = "Some Footer Titel";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            //printer.PrintDataGridView(dataGridView1);
            printer.PrintPreviewDataGridView(dataGridView1);
        }

        /// <summary>
        /// This method will save 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modefyBtn_Click(sender, e);
        }

        /*
        * To add a new record to the database, user will fill out a supporting 
        * form that would pup-up after pressing button.
        * Since each table is unique, every table object has a corresponding record table.
        * */

        /// <summary>
        /// This function will open a supporting form for adding new record to the db, if there is one
        /// Else, it would show a message that explaince what form is a parent one for current table
        /// </summary>
        /// <param name="sender">is the parent, or correspondig table core object</param>
        /// <param name="e"></param>
        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get the instance of the record Object
            var addRecord = tc.MyRecord;

            if (addRecord == null)
            {
                MessageBox.Show(tc.AddNewRecordMessage);
            }
            else
            {
                //Open record object
                addRecord.ShowDialog(this);
            }
        }

        /*
        * Deletion of the record will remove selected by user row 
        * from the database table based on the key value of that row
        * */
       
        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get row values
            int rowindex = dataGridView1.CurrentCell.RowIndex;

            //get key value for that row
            string key = dataGridView1.Rows[rowindex].Cells[tc.KeyFieldIndex].Value.ToString();


            //Create window  dialog for conformation, in case delet button is pressed by mistake
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this record", "Delete", MessageBoxButtons.YesNo);

            //If yes, return to the login page
            if (dialog == DialogResult.Yes)
            {
                //Delete row
                tc.DeleteRow(key);

                MessageBox.Show("The record was successfully removed");

                //Cleare data Grid
                dataGridView1.DataSource = null;

                //Load updated table
                LoadTable();

            }
        }

        #endregion


    }
}
