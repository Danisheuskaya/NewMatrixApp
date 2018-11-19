using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using LOginForm;
using MySql.Data.MySqlClient;
using System.Data;

namespace LOginForm.Pages
{
    /// <summary>
    /// Interaction logic for UserWaitList.xaml
    /// </summary>
    public partial class UserWaitList : Window
    {
        DBConnection db = new DBConnection();

        public UserWaitList()
        {
            InitializeComponent();
            LoadWaitListTabel();
        }

        private void LoadWaitListTabel()
        {
            //Get the list of people in the waitlist
            string getAllPeople = "SELECT * FROM `person_wait_list`";

            MySqlDataReader reader = db.Reader(getAllPeople);

            bool tabelEmpty = true;

            DataTable table = new DataTable();
            

            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Login", typeof(string));

            while (reader.Read())
            {
                tabelEmpty = false;

                //Generate row
                table.Rows.Add(reader["Fname"].ToString(), reader["Lname"].ToString(), reader["Login"].ToString());
            }

            db.CloseConnection();

            if (!tabelEmpty)
            {

                //WaitListDataGrid.AutoGenerateColumns = false;


                WaitListDataGrid.ItemsSource = table.AsDataView();
            }
        }
    }
}
