using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LOginForm
{
    public class FormPrototype : Form
    {
        public string[] variables { get; set;}

        DBConnection db = new DBConnection();

        public void CleanForm()
        {
            traverseControlsAndSetTextEmpty(this);
           
        }

        /// <summary>
        /// This method clears all the form values
        /// </summary>
        /// <param name="control"></param>
        private void traverseControlsAndSetTextEmpty(Control control)
        {

            foreach (var c in control.Controls)
            {
                //This would clear all textBoxes
                if (c is TextBox) ((TextBox)c).Text = String.Empty;
                
                //This would clear dateTime picker, and set the value to empty string
                if (c is DateTimePicker) ((DateTimePicker)c).CustomFormat = " ";

                //This would clear comboBox value if selected
                if (c is ComboBox) ((ComboBox)c).Text = String.Empty;
                
            }
        }


        #region Load helpers
        /// <summary>
        /// This function adds the team options as the comboBox menue
        /// </summary>
        public void generateTeamOptions(ComboBox combo, string query, string key, string value)
        {
            
            //Creating a Map object in order to save a team_id value
            Dictionary<string, string> options = new Dictionary<string, string>();


            //Get the values from db into reader
            MySqlDataReader reader = db.Reader(query);


            //For each line in the table
            while (reader.Read())
            {
                //Add team member's names as Value, and team_ID as the key
                options.Add(reader[key].ToString(), reader[value].ToString());
            }

            //close connection
            db.CloseConnection();

            //Add collection to the comboBox
            combo.DataSource = new BindingSource(options, null);

            //Show the names
            combo.DisplayMember = "Value";

            //hide the key
           combo.ValueMember = "Key";

            combo.SelectedIndex = 0;
        }


        #endregion


        #region Bollean checkers

        /// <summary>
        /// This method checks if user inserted a unique case number
        /// </summary>
        /// <returns></returns>

        public bool CheckUniqueKeyField(TextBox tb, Label warning, string query, string dbKey)
        {
           //Get the case number value
           string keyField = tb.Text;

            //If number is not inserted, show warning and return false
            if (string.IsNullOrEmpty(keyField))
            {
                //show warning
                warning.Visible = true;

                return false;
            }
            //if there is a number, check if it unuque
            else
            {
                //select a row from the db with selected case name
                query += keyField + "'";

                //run query
                MySqlDataReader reader = db.Reader(query);

                //read the line
                while (reader.Read())
                {
                    if (!string.IsNullOrEmpty(reader[dbKey].ToString()))
                    {
                        //show warning
                        warning.Visible = true;

                        return false;
                    }
                }
                //close connection
                db.CloseConnection();
            }

            //if thhe case number is not empty and unique...

            //clear warning
            warning.Visible = false;

            return true;
        }


        #endregion


        /// <summary>
        /// This method adds new query to the Form's Data Table
        /// </summary>
        /// <param name="addQuery"></param>
        public void AddNewRecord(string addQuery)
        {
            
            //TEST
            MessageBox.Show(addQuery);

            //Create window  dialog for conformation
            DialogResult dialog = MessageBox.Show("Are you sure you want to add a new record?", "Yes", MessageBoxButtons.YesNo);

            //If yes, return to the login page
            if (dialog == DialogResult.Yes)
            {
                //Inserting record
                db.InsertDeleteQuery(addQuery);

                //Show message
                MessageBox.Show("Record was added to the table");


                var myParent = (MatrixForm)Owner;

                myParent.LoadTable();

                //Cleare form
                CleanForm();
                
            }
        }
        
    }
}
