using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CourseAssignOperation
    {
        //CourseAssign information = new CourseAssign();
        DbConnection con = new DbConnection();

        // Insert
        public int AddCourseAssign(CourseAssign information)
        {
            SqlCommand cmd = new SqlCommand("Insert into CourseAssign (StudentID, TeacherID, " +
                "CourseName, CourseTime) values (@StudentID, @TeacherID, @CourseName, @CourseTime)");

            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);
            cmd.Parameters.AddWithValue("@TeacherID", information.TeacherID);
            cmd.Parameters.AddWithValue("@CourseName", information.CourseName);
            cmd.Parameters.AddWithValue("@CourseTime", information.CourseTime);


            return con.ExeNonQuery(cmd);
        }


        //Update
        public void UpdateCourseAssign(CourseAssign information)
        {
            SqlCommand cmd = new SqlCommand("Update CourseAssign set StudentID=@StudentID, TeacherID=@TeacherID, CourseName=@CourseName, CourseTime=@CourseTime");

            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);
            cmd.Parameters.AddWithValue("@TeacherID", information.TeacherID);
            cmd.Parameters.AddWithValue("@CourseName", information.CourseName);
            cmd.Parameters.AddWithValue("@CourseTime", information.CourseTime);

            con.ExeNonQuery(cmd);
        }


        //SelectBy TeacherID
        public DataTable SearchByTeacherID(CourseAssign information)
        {
            SqlCommand cmd = new SqlCommand("Select * from CourseAssign where TeacherID = @TeacherID");
            cmd.Parameters.AddWithValue("@TeacherID", information.TeacherID);
            return con.ExeReader(cmd);
        }

        //SelectBy StudentID
        public DataTable SearchByStudentID(CourseAssign information)
        {
            SqlCommand cmd = new SqlCommand("Select * from CourseAssign where StudentID = @StudentID");
            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);
            return con.ExeReader(cmd);
        }

        //SelectBy CourseByName
        public SqlDataReader SearchCourseByName(CourseAssign information, string name)
        {
            SqlCommand cmd = new SqlCommand("Select * from CourseAssign where CourseName = @CourseName", con.GetCon());
            cmd.Parameters.AddWithValue("@CourseName", name);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public SqlDataReader SearchCourseByNameTID(CourseAssign information, string id)
        {
            SqlCommand cmd = new SqlCommand("select CourseName from CourseAssign where TeacherID = @TeacherID", con.GetCon());
            cmd.Parameters.AddWithValue("@TeacherID", id);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;

        }


        //GetStudent
        public SqlDataReader GetStudent(string temp)
        {
            SqlCommand cmd = new SqlCommand("Select StudentID from CourseAssign where CourseName = @CourseName", con.GetCon());
            cmd.Parameters.AddWithValue("@CourseName", temp);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
    }
}
