using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace LOginForm
{
    public partial class MatrixForm: FormPrototype 
    {

        #region Variables
        /// <summary>
        /// Variables containers
        /// </summary>
        private TableCore tc; //Holder for the table object
        private DBConnection db; //data base connection
        private List<string> updateQueryes;  //Container of queryes, that would be created when table is modefyed

        /// <summary>
        /// Flag that would allow rto modefy table by 
        /// adding controls such as dropbox column, button coulmns 
        /// only once
        /// </summary>
        private bool controlWasAdded = false;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="tableCore"> Is the type of table object that was passed through the button</param>
        /// <param name="restrictionLvl">Restriction of the user, that was passed trough the information about logged in user</param>
        public MatrixForm(TableCore tableCore, int restrictionLvl)
        {

            InitializeComponent();
            
            //Create data base connection
            db = new DBConnection();

            //invoce table object
            tc = tableCore;

            //Change name of the table that correspond to the name of the table object
            ChangeName();

            //Load the table
            LoadTable();

            //Adding special controls if there any
            //such as dropdown options, check marks, buttons...
            tc.AddControls(dataGridView1, controlWasAdded);

            //Eddit flag, in order to prevent multiple controll additing
            controlWasAdded = true;

            //Cleare a query holder
            updateQueryes = new List<string>();

            //Block buttons if user is not allowed to modefy/add new records
            BlockRestrictedButtons(restrictionLvl);
    }

        #endregion

        #region Load Table Helpers

        /// <summary>
        /// This method will block Add/Delete/Modefy record buttons
        /// according to the user restriction level
        /// </summary>
        /// <param name="priority"></param>
        private void BlockRestrictedButtons(int restrictionLvl)
        {
            //All buttons are blocked by default

            //level 0: user can only view tables,
            //no changes needed

            //level 1: user can view and modefy table
            if(restrictionLvl >= 1)
            {
                modefyTableRecordBtn.Visible = true;
            }
            //level 2: user can view, add and modefy table
            if (restrictionLvl >= 2)
            {
                addNewRecordBtn.Visible = true;
            }
            //level 3: user can view, add,modefy and delete table
            if (restrictionLvl == 3)
            {
                deleteRecordBtn.Visible = true;
            }
        }

        /// <summary>
        /// This method loads the table
        /// </summary>
        public void LoadTable()
        {
            //Creating a table object
            DataTable table = tc.FillTable();

            //Placing itr inside the datagrid view
            dataGridView1.DataSource = table;
            
            //Blocking the key value column from being modefyed
            blockKeyColumn();
        }

        
        /// <summary>
        /// This function blocks key value column from being modefyed
        /// </summary>
        private void blockKeyColumn()
        {
            dataGridView1.Columns[tc.KeyFieldIndex].ReadOnly = true;
        }


    
        /// <summary>
        /// This method sets the header for the page
        /// </summary>
        /// <param name="tableName"></param>
        private void ChangeName()
        {
            label1.Text = tc.TableName;
        }


        #endregion

        /*
        * To add a new record to the database, user will fill out a supporting 
        * form that would pup-up after pressing button.
        * Since each table is unique, every table object has a corresponding record table.
        * */

        #region Add Record Helpers      

        /// <summary>
        /// This function will open a supporting form for adding new record to the db, if there is one
        /// Else, it would show a message that explaince what form is a parent one for current table
        /// </summary>
        /// <param name="sender">is the parent, or correspondig table core object</param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
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


        #endregion

        /*
        * Deletion of the record will remove selected by user row 
        * from the database table based on the key value of that row
        * */

        #region Delete record       

        /// <summary>
        /// Logic for the delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteRecord_Click(object sender, EventArgs e)
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
                MessageBox.Show(tc.UpdateQuery);

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
            MessageBox.Show("The column index is :  " + columnIndex);

            //Get the row index
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            //TEST
            MessageBox.Show("The row index is :  " + rowIndex);

            //Get new value
            string newValue = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString();

            //TEST
            MessageBox.Show("The new value is :  " + newValue);

            //Get the key value for this row
            string keyValue = dataGridView1.Rows[rowIndex].Cells[tc.KeyFieldIndex].Value.ToString();

            //TEST
            MessageBox.Show("The key is :  " + keyValue);

            //create update query
            tc.UpdateStringConstructor(columnIndex, newValue, keyValue);

            //add query to the list
            updateQueryes.Add(tc.UpdateQuery);

            //TEST
            MessageBox.Show(tc.UpdateQuery);
            

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
                ControlBox = false;
            }
            else
            {
                //Discard an event
                e.Cancel = true;
            }

           
        }

        /// <summary>
        /// TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            Interaction.InputBox("What is Defendant Name?", "Satteled Case", "Default Text");
        }


        /// <summary>
        /// This method handels Buttons inside the table
        /// This method will be handeled in TableCoreObject according to the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
}
