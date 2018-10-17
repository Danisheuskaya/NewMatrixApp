using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;

namespace LOginForm
{
    /// <summary>
    /// This is class for the db connection 
    /// </summary>
    public class DBConnection
    {
        //DB connection string
        private string connectionString = "SERVER=localhost;DATABASE=garcia_law;UID=root;PASSWORD=;SslMode=none;Convert Zero Datetime=True;";

        //Holder for the connection
        public MySqlConnection conn;

        //Holder for the command
        public MySqlCommand cmd;

        public DBConnection()
        {
            //Try to open connection
            try
            {
                conn = new MySqlConnection(connectionString);               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// This function creates a data reader to process string
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
        public MySqlDataReader Reader(string Query)
        {
            //Open Connection
            conn.Open();

            //Creating command
            MySqlCommand cmd = conn.CreateCommand();

            //Assigning string
            cmd.CommandText = Query;

            //Creating reader
            MySqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        /// <summary>
        /// This function closes connection
        /// </summary>
        public void CloseConnection()
        {
            conn.Close();
        }

        public void InsertDeleteQuery(string query)
        {
            try
            {
                //Open Connection
                conn.Open();

                //Creating command
                MySqlCommand cmd = conn.CreateCommand();

                //Assigning string
                cmd.CommandText = query;

                //run query
                cmd.ExecuteNonQuery();                

            }
            catch(Exception e)
            {
                //Show error message
                MessageBox.Show(e.Message);
            }
            finally
            {
                //close connection
                conn.Close();
            }
            
           
        }

       

        public DataTable fillTheTable(string query)
        {
            DataTable table = new DataTable();
                       

            try
            {
                //Opening connection
                conn.Open();

                //creating adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);                

                //Reading data from the database to the adapter
                adapter.Fill(table);                

                //Close connection
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

           
            return table;
            

        }
    }



    }   

