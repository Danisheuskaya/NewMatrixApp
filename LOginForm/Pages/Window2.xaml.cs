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

        public Window2()
        {
            InitializeComponent();
            DataGridView dgv = new DataGridView();
            fillDGV(dgv);
            
        }

        private void fillDGV(DataGridView dgv)
        {
            DataTable table = tc.FillTable();

            testForTabel.ItemsSource = table.DefaultView;
            //Placing it inside the datagrid view
            

            //tc.AddControls(dgv);

        }

        /// <summary>
        /// Experementing wirh columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testForTabel_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MessageBox.Show("I captured something: ");

            DependencyObject dep = (DependencyObject)e.OriginalSource;

            while ((dep != null) && !(dep is DataGridCell) && !(dep is DataGridColumnHeader))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

            if (dep == null)
                return;

            if (dep is DataGridColumnHeader)
            {
                DataGridColumnHeader columnHeader = dep as DataGridColumnHeader;
                // do something
            }

            if (dep is DataGridCell)
            {
                DataGridCell cell = dep as DataGridCell;

                // navigate further up the tree
                while ((dep != null) && !(dep is DataGridRow))
                {
                    dep = VisualTreeHelper.GetParent(dep);
                }

                DataGridRow row = dep as DataGridRow;

                
            }
        }

        private int FindRowIndex(DataGridRow row)
        {
            DataGrid dataGrid = ItemsControl.ItemsControlFromItemContainer(row)
                as DataGrid;

            int index = dataGrid.ItemContainerGenerator.
                IndexFromContainer(row);

            return index;
        }
    }
}
