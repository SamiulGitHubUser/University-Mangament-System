using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class LibraryBookAdd : MetroFramework.Forms.MetroForm
    {
        AdminDashboard adminDash = new AdminDashboard();

        public Library lib = new Library();
        public LibraryOperation opertion = new LibraryOperation();

        public LibraryBookAdd()
        {
            InitializeComponent();
        }

        private void BookAdd_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            lib.BookName = bookName.Text;
            lib.AuthorName = authorName.Text;
            lib.BookDescription = bookDesc.Text;
            lib.BookPrice = Convert.ToDouble(bookPrice.Text);
            lib.BookQuantity =Convert.ToInt32(bookQuantity.Text);

            int row = opertion.InsertBookInfo(lib);

            this.Close();
        }
    }
}
