using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EntityLayer;
using BusinessLayer;

namespace UniversityManagementSystem
{
    public partial class LibraryBookUpdate : MetroFramework.Forms.MetroForm
    {
        Library lib = new Library();
        LibraryOperation libOpertion = new LibraryOperation();


    public LibraryBookUpdate()
        {
            InitializeComponent();
        }

        private void BookUpdate_Load(object sender, EventArgs e)
        {
            SqlDataReader reader;
            reader = libOpertion.Load_BookId(lib);
            while (reader.Read())
            {
                BookIDComboBox.Items.Add(reader["BookID"].ToString());
            }
            reader.Close();

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            lib.BookID = Convert.ToInt32(BookIDComboBox.SelectedItem);
            lib.BookName = bookName.Text;
            lib.BookDescription = bookDesc.Text;
            lib.AuthorName = authorName.Text;
            lib.BookPrice = Convert.ToDouble(bookPrice.Text);

            libOpertion.UpdateLibraryBook(lib);

            this.Dispose();
        }

        private void BookIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader;
            int temp = Convert.ToInt32(BookIDComboBox.SelectedItem);

            reader = libOpertion.Load_AllItem(lib, temp);

            while (reader.Read())
            {
                bookName.Text = (reader["BookName"].ToString());
                authorName.Text = (reader["AuthorName"].ToString());
                bookPrice.Text = (reader["BookPrice"].ToString());
                bookDesc.Text = (reader["BookDescription"].ToString());
                bookQuantity.Text= (reader["BookQuantity"].ToString());
            }

            reader.Close();
        }
    }
}
