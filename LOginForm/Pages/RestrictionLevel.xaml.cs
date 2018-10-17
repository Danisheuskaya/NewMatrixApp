using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LOginForm
{
    /// <summary>
    /// Interaction logic for RestrictionLevel.xaml
    /// </summary>
    public partial class RestrictionLevel : UserControl
    {
        DBConnection db;
        private ComboBox cbox;

        public RestrictionLevel()
        {
            InitializeComponent();
            db =  new DBConnection();
            cbox = new ComboBox();

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }


        #region Load methods

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
                    //comboBox1.Items.Add(fullName);
                    cbox.Items.Add(fullName);
                    
                    

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


        #endregion
    }
}
