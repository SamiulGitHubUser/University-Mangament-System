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
    public class CourseOperation
    {

        public DbConnection DBcon = new DbConnection();
        public Course course = new Course();


        //Parent Infromation
        public int InsertCourseInfo(Course course)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Course ( CourseName, Department, AvailableSection, Pre_Reqsite, CourseCredits, CourseFee, CourseDescription, CourseStatus, CourseProgramme ) values (@CourseName, @Department, @AvailableSection, @Pre_Reqsite, @CourseCredits, @CourseFee, @CourseDescription, @CourseStatus, @CourseProgramme )";
            
            cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
            cmd.Parameters.AddWithValue("@Department", course.Department);
            cmd.Parameters.AddWithValue("@AvailableSection", course.AvailableSection);
            cmd.Parameters.AddWithValue("@Pre_Reqsite", course.Pre_Reqsite);
            cmd.Parameters.AddWithValue("@CourseCredits", course.CourseCredits);
            cmd.Parameters.AddWithValue("@CourseFee", course.CourseFee);
            cmd.Parameters.AddWithValue("@CourseDescription", course.CourseDescription);
            cmd.Parameters.AddWithValue("@CourseStatus", course.CourseStatus);
            cmd.Parameters.AddWithValue("@CourseProgramme", course.CourseProgramme);
            

            return DBcon.ExeNonQuery(cmd);
        }

        public void UpdateCourseInfo(Course course)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Course set CourseName = @CourseName, Department = @Department, AvailableSection = @AvailableSection,  Pre_Reqsite = @Pre_Reqsite , CourseCredits = @CourseCredits, CourseFee = @CourseFee, CourseDescription=@CourseDescription, CourseStatus=@CourseStatus, CourseProgramme=@CourseProgramme   where CourseID = @CourseID";

            cmd.Parameters.AddWithValue("@CourseID", course.CourseID);
            cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
            cmd.Parameters.AddWithValue("@Department", course.Department);
            cmd.Parameters.AddWithValue("@AvailableSection", course.AvailableSection);
            cmd.Parameters.AddWithValue("@Pre_Reqsite", course.Pre_Reqsite);
            cmd.Parameters.AddWithValue("@CourseCredits", course.CourseCredits);
            cmd.Parameters.AddWithValue("@CourseFee", course.CourseFee);
            cmd.Parameters.AddWithValue("@CourseDescription", course.CourseDescription);
            cmd.Parameters.AddWithValue("@CourseStatus", course.CourseStatus);
            cmd.Parameters.AddWithValue("@CourseProgramme", course.CourseProgramme);

            DBcon.ExeNonQuery(cmd);
        }


        // Delete Library record
        public void DeleteCourse_Record(Course course)
        {
            SqlCommand cmd = new SqlCommand("Delete from Course where CourseID = @CourseID");
            cmd.Parameters.AddWithValue("@CourseID", course.CourseID);

            DBcon.ExeNonQuery(cmd);
        }



        // To load all BookId in comboBox
        public SqlDataReader Load_CourseID(Course course)
        {
            SqlCommand cmd = new SqlCommand("select CourseID from Course", DBcon.GetCon());
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        // To load all information against BookId in text Book
        public SqlDataReader Load_AllCourses(Course course, int temp)
        {
            SqlCommand cmd = new SqlCommand("Select * from Course where CourseID = @CourseID", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@CourseID", temp);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }



        public DataTable CourseViewTabel(Course course)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Course";

            return DBcon.ExeReader(cmd);
        }

        public DataTable CourseViewTabel_CSE(Course course)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Course where Department = 'CSE' and CourseProgramme = 'Graduate' ";

            return DBcon.ExeReader(cmd);
        }

        //Search
        public DataTable SearchByCourseName(Course courseInfo)
        {
            SqlCommand cmd = new SqlCommand("Select * from Course where CourseName = @CourseName");
            cmd.Parameters.AddWithValue("@CourseName", courseInfo.CourseName);

            return DBcon.ExeReader(cmd);
        }

    }
}
