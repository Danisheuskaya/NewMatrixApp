using MySql.Data.MySqlClient;
using System;

using System.Windows.Forms;

namespace LOginForm
{
    public partial class Settings: Form
    {
        //Database connection object
        private DBConnection db;

        //User's first name
        string Fname;

        //User's last name
        string Lname;

        public Settings()
        {
            InitializeComponent();
            db = new DBConnection();
            fillComboBox();
        }

        /// <summary>
        /// This method will populate the values in the comboBox with the names of people from the db
        /// </summary>
        private void fillComboBox()
        {
            //creating string to get all the people from the db
            string q = "SELECT * FROM person";

            //Run the querey
            try
            {
                //Getting data from the database
                MySqlDataReader reader = db.Reader(q);

                //While we can read anything..
                while (reader.Read())
                {
                    //..forming a string with First and Last Name
                    string fullName = reader["Fname"].ToString() + " " + reader["Lname"].ToString();

                    //Adding the name to the comboBox option
                    comboBox1.Items.Add(fullName);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }


        /// <summary>
        /// When the name was selected, we need to display a users level in the textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the value from teh comboBox
            string name = comboBox1.Text;
           
            string[] words = name.Split(' ');

            Fname = words[0];

            Lname = words[1];


            //creating string to get all the people from the db
            string q = "SELECT * FROM person WHERE Fname = '" + Fname + "' and Lname = '" + Lname + "'";

            //Run the querey
            try
            {
                //Getting data from the database
                MySqlDataReader reader = db.Reader(q);

                //While we can read anything..
                while (reader.Read())
                {
                    //Add the level of restriction to the level window
                    level.Text = reader["Priority"].ToString();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }





        }


        /// <summary>
        /// This method will update user's Priority level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Create window  dialog for conformation
            DialogResult dialog = System.Windows.Forms.MessageBox.Show("Do you want to update user's restriction level? ", "Exit", MessageBoxButtons.YesNo);

            //If yes, update data in the table
            if (dialog == System.Windows.Forms.DialogResult.Yes)
            {
                //get new value
                

                //creating string to update users level
                string q = "UPDATE person SET Priority = " + level.Text + " WHERE Fname = '" + Fname + "' and Lname = '" + Lname + "'";

                //Run the querey
                try
                {
                    //running query
                    MySqlDataReader reader = db.Reader(q);

                    MessageBox.Show("Level was changed");

                    //Reload form
                    Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }




            }
            //If not, cancel
            
        }

        /// <summary>
        /// When the value of the level changed, this method will validate if the level is in the range
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void level_TextChanged(object sender, EventArgs e)
        {
            //If number is not a number between 0 and 3, show error message and block
            //the submit button
            if (!checkIfValid())
            {
                //Show message
                ErMessage.Visible = true;

                //block the button
                button1.Enabled = false;
            }
            else
            {
                //Hide message
                ErMessage.Visible = false;

                //Unblock the button
                button1.Enabled = true;
            }

            
        }

        private bool checkIfValid()
        {
            //get the input value
            string lvl = level.Text;
            int value;

            //Check if it is a number between 0 and 3
            if (int.TryParse(lvl, out value) && value >= 0 && value <= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      
    }
}
