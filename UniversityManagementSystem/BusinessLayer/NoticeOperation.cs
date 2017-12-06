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
    public class NoticeOperation
    {
        public DbConnection DBcon = new DbConnection();
        public Notice notice = new Notice();

        //Notice Infromation
        public int InsertNotice(Notice notice)
        {
        SqlCommand cmd = new SqlCommand("insert into Notice ( NoticeTitle, DateOfNotice, NoticeDescription ) values ( @NoticeTitle, @DateOfNotice, @NoticeDescription )");

            cmd.Parameters.AddWithValue("@NoticeTitle", notice.NoticeTitle);
            cmd.Parameters.AddWithValue("@DateOfNotice", notice.DateOfNotice);
            cmd.Parameters.AddWithValue("@NoticeDescription", notice.NoticeDescription);

            return DBcon.ExeNonQuery(cmd);
        }

        public void UpdateNotice(Notice notice)
        {
            SqlCommand cmd = new SqlCommand(" Update Notice set NoticeTitle=@NoticeTitle, DateOfNotice=@DateOfNotice, NoticeDescription=@NoticeDescription where NoticeID=@NoticeID ");


            cmd.Parameters.AddWithValue("@NoticeID", notice.NoticeID);
            cmd.Parameters.AddWithValue("@NoticeTitle", notice.NoticeTitle);
            cmd.Parameters.AddWithValue("@DateOfNotice", notice.DateOfNotice);
            cmd.Parameters.AddWithValue("@NoticeDescription", notice.NoticeDescription);

            DBcon.ExeNonQuery(cmd);
        }

        // Delete Notice record
        public void DeleteNotice_Record(Notice notice)
        {
            SqlCommand cmd = new SqlCommand("Delete from notice where NoticeID = @NoticeID");
            cmd.Parameters.AddWithValue("@NoticeID", notice.NoticeID);

            DBcon.ExeNonQuery(cmd);
        }

        // To load all NoticeId in comboBox
        public SqlDataReader Load_CourseID(Notice notice)
        {
            SqlCommand cmd = new SqlCommand("select NoticeID from Notice", DBcon.GetCon());
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        // To load all information against BookId in text Book
        public SqlDataReader Load_AllCourses(Notice notice, int temp)
        {
            SqlCommand cmd = new SqlCommand("Select * from Notice where NoticeID = @NoticeID", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@NoticeID", temp);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


        //Notice Show in Table
        public DataTable NoticeViewTabel(Notice notice)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Notice";

            return DBcon.ExeReader(cmd);
        }

        //SearchByTitle
        public DataTable SearchByTitle(Notice NoticeInfo)
        {
            SqlCommand cmd = new SqlCommand("Select * from Notice where NoticeTitle = @NoticeTitle");
            cmd.Parameters.AddWithValue("@NoticeTitle", NoticeInfo.NoticeTitle);

            return DBcon.ExeReader(cmd);
        }


    }
}
