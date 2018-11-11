using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LOginForm.Matrixes;
using DataGrid = System.Windows.Controls.DataGrid;
using DataGridCell = System.Windows.Controls.DataGridCell;
using MessageBox = System.Windows.Forms.MessageBox;

namespace LOginForm.Pages
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        DBConnection db = new DBConnection();

        TableCore tc = new ActiveClassObj();

        //Holder for the Tabel instance
        DataTable tabel;

        public Window2()
        {
            InitializeComponent();
           
            fillDataGrid();

            GetDataTabel();
            
        }

        /// <summary>
        /// This method will save an instance of the current table
        /// </summary>
        private void GetDataTabel()
        {
            tabel = ((DataView)this.testDataGrid.ItemsSource).Table;
        }

        private void fillDataGrid()
        {
            DataTable table = tc.FillTable();

            table.AcceptChanges();

            testDataGrid.ItemsSource = table.DefaultView;
            //Placing it inside the datagrid view
            

            //tc.AddControls(dgv);

        }

        private void testDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            //The way to get cell coordinates:
            //Get row:
            //1. Find selected Item
            DataGrid dg = (DataGrid)sender;
            DataRowView row_selected = dg.SelectedItem as DataRowView;

            //Get its index:
            //Row =  tabel.Rows.IndexOf(row_selected.Row);


            //Get Column index:
            int Column = testDataGrid.CurrentCell.Column.DisplayIndex;



            int Row = 1000;

            if (row_selected != null)
            {
                Row = tabel.Rows.IndexOf(row_selected.Row);

            }

            MessageBox.Show("The cell coordinates are: Row : " + Row + " and Column : " + Column);

            string CellValue = tabel.Rows[Row][Column].ToString();

            MessageBox.Show("The cell value is : " + CellValue);


        }
    }
}
