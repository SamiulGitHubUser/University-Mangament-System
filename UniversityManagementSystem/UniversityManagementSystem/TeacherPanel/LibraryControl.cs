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

namespace UniversityManagementSystem.TeacherPanel
{
    public partial class LibraryControl : UserControl
    {
        Library lib = new Library();
        LibraryOperation libOperation = new LibraryOperation();

        public LibraryControl()
        {
            InitializeComponent();
        }

        private void LibraryControl_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();

                table = libOperation.ViewTabel(lib);
                metroGrid.DataSource = table;

                metroGrid.DataSource = table;
            }
            catch
            {
                MetroMessageBox.Show(this, "Error", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
