using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class LibraryOperation
    {
        string status;
        public DbConnection DBcon = new DbConnection();
        public Library lib = new Library();
       

        public int InsertBookInfo(Library lib)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Library (BookName, AuthorName, BookDescription, BookPrice, Status,  BookQuantity) values (@BookName, @AuthorName, @BookDescription, @BookPrice, @Status, @BookQuantity)";

            cmd.Parameters.AddWithValue("@BookName", lib.BookName);
            cmd.Parameters.AddWithValue("@AuthorName", lib.AuthorName);
            cmd.Parameters.AddWithValue("@BookDescription", lib.BookDescription);
            cmd.Parameters.AddWithValue("@BookPrice", lib.BookPrice);
            cmd.Parameters.AddWithValue("@BookQuantity", lib.BookQuantity);
            if (lib.BookQuantity == 0)
            {
                status = "Unavailable";
                cmd.Parameters.AddWithValue("@Status", status);
            }
            else
            {
                status = "Available";
                cmd.Parameters.AddWithValue("@Status", status);
            }

            return DBcon.ExeNonQuery(cmd);
        }

        public DataTable ShowLibraryTable(object information)
        {
            SqlCommand cmd = new SqlCommand("Select * from Library");

            return DBcon.ExeReader(cmd);
        }

        public void UpdateLibraryBook(Library lib)
        {
            SqlCommand cmd = new SqlCommand("Update Library set BookName = @BookName, AuthorName = @AuthorName, BookPrice = @BookPrice,  BookDescription = @BookDescription ,  BookQuantity = @BookQuantity, Status = @Status where BookID = @BookID");

            cmd.Parameters.AddWithValue("@BookName", lib.BookName);
            cmd.Parameters.AddWithValue("@AuthorName", lib.AuthorName);
            cmd.Parameters.AddWithValue("@BookPrice", lib.BookPrice);
            cmd.Parameters.AddWithValue("@BookDescription", lib.BookDescription);
            cmd.Parameters.AddWithValue("@BookQuantity", Convert.ToInt32(lib.BookQuantity));
            if (lib.BookQuantity == 0)
            {
                status = "Unavailable";
                cmd.Parameters.AddWithValue("@Status", status);
            }
            else
            {
                status = "Available";
                cmd.Parameters.AddWithValue("@Status", status);
            }

            cmd.Parameters.AddWithValue("@BookID", Convert.ToInt32(lib.BookID));

            DBcon.ExeNonQuery(cmd);
        }

        public DataTable SerchLibrary(Library lib)
        {
            SqlCommand cmd = new SqlCommand("Select * from Library where BookName = @BookName");
            cmd.Parameters.AddWithValue("@BookName", lib.BookName);
            return DBcon.ExeReader(cmd);
        }


        // Delete Library record
        public void DeleteBook_Record(Library lib)
        {
            SqlCommand cmd = new SqlCommand("Delete from Library where BookID = @BookID");
            cmd.Parameters.AddWithValue("@BookID", lib.BookID);

            DBcon.ExeNonQuery(cmd);
        }



        // To load all BookId in comboBox
        public SqlDataReader Load_BookId(Library libInfo)
        {
            SqlCommand cmd = new SqlCommand("select BookID from Library", DBcon.GetCon());
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        // To load all information against BookId in text Book
        public SqlDataReader Load_AllItem(Library libInfo, int temp)
        {
            SqlCommand cmd = new SqlCommand("Select * from Library where BookID = @BookID", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@BookID", temp);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }



        public DataTable ViewTabel(Library lib)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Library";
            
            return DBcon.ExeReader(cmd);
        }
    }
}
