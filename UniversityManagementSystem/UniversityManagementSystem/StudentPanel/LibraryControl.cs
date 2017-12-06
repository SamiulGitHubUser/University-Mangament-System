using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using EntityLayer;

namespace SmartUniversity.Student
{
    public partial class LibraryControl : UserControl
    {
        Library information = new Library();
        LibraryOperation operation = new LibraryOperation();
        private string stuID;

        public LibraryControl()
        {
            InitializeComponent();
        }

        public LibraryControl(string p)
        {
            // TODO: Complete member initialization
            this.stuID = p;
            InitializeComponent();
        }

        private void LibraryControl_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = operation.ShowLibraryTable(information);

            metroGridLibrary.DataSource = table;
        }
    }
}
