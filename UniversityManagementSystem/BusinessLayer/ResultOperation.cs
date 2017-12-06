using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ResultOperation
    {
        DbConnection DBcon = new DbConnection();
        public SqlDataReader Load_StudentID(ResultInformation information)
        {
            SqlCommand cmd = new SqlCommand("select StudentID from Result", DBcon.GetCon());
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public SqlDataReader Load_GetMidResult(ResultInformation information)
        {
            SqlCommand cmd = new SqlCommand("select MidMark from Result where StudentID = @StudentID", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public void Update_FinalMark(ResultInformation information)
        {
            SqlCommand cmd = new SqlCommand("Update Result set FinalMark = @FinalMark, CGPA = @CGPA where StudentID = @StudentID");

            cmd.Parameters.AddWithValue("@FinalMark", information.FinalMark);
            cmd.Parameters.AddWithValue("@CGPA", information.CGPA);
            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);

            DBcon.ExeNonQuery(cmd);
        }

        public void UpdateMidResult(ResultInformation information, string id, string courseName)
        {
            SqlCommand cmd = new SqlCommand("Update Result set MidMark = @MidMark where StudentID = @StudentID and CourseName=@CourseName");

            cmd.Parameters.AddWithValue("@MidMark", information.MidMark);
            cmd.Parameters.AddWithValue("@StudentID", id);
            cmd.Parameters.AddWithValue("@CourseName", courseName);

            DBcon.ExeNonQuery(cmd);
        }

        public SqlDataReader Load_GetFinalResult(ResultInformation information)
        {

            SqlCommand cmd = new SqlCommand("select FinalMark from Result where StudentID = @StudentID", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
    }
}
