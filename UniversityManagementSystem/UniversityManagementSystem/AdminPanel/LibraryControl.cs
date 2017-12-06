using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;
using MetroFramework;

namespace UniversityManagementSystem
{
    public partial class LibraryControl : UserControl
    {
        int deleteId;
        public Library lib = new Library();
        public LibraryOperation operation = new LibraryOperation();

        public LibraryControl()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            LibraryBookAdd bookForm = new LibraryBookAdd();
            bookForm.ShowDialog();
        }

        private void LibraryControl_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = operation.ViewTabel(lib);

            LibraryGrid.DataSource = dt;
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            LibraryBookUpdate update = new LibraryBookUpdate();
            update.ShowDialog();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lib.BookID = deleteId;
            operation.DeleteBook_Record(lib);
        }


        private void LibraryGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                if (e.Button == MouseButtons.Right)
                {
                    deleteId = Convert.ToInt32(LibraryGrid.Rows[e.RowIndex].Cells["BookID"].Value.ToString());
                    this.DeleteContextMenu.Show(this.LibraryGrid, e.Location);
                    DeleteContextMenu.Show(Cursor.Position);
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "You Can't Click Here!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            lib.BookName = metroTextBox1.Text;

            DataTable table = new DataTable();
            table = operation.SerchLibrary(lib);

            LibraryGrid.DataSource = table;
        }
    }
}
