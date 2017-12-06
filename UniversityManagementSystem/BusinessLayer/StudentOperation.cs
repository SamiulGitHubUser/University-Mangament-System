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
    public class StudentOperation
    {
        public DbConnection DBcon = new DbConnection();
        public StudentInfromation std = new StudentInfromation();

        //Student Infromation
        public int InsertStudentInfo(StudentInfromation information)
        {
            SqlCommand cmd = new SqlCommand("Insert into Student (StudentID, FirstName, LastName, DateOfBirth, Gender, Age," +
             "Email, PhoneNo, BloodGroup, RegistrationDate, Department, Address, BatchNo, UserID, Password, CGPA, Section) values (@StudentID, @FirstName, @LastName, @DateOfBirth, @Gender, @Age," +
            "@Email, @PhoneNo, @BloodGroup, @RegistrationDate, @Department, @Address, @BatchNo, @UserID, @Password, @CGPA, @Section)");

            cmd.Parameters.AddWithValue("@FirstName", information.FirstName);
            cmd.Parameters.AddWithValue("@LastName", information.LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", information.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", information.Gender);
            cmd.Parameters.AddWithValue("@Age", information.Age);
            cmd.Parameters.AddWithValue("@Email", information.Email);
            cmd.Parameters.AddWithValue("@PhoneNo", information.PhoneNo);
            cmd.Parameters.AddWithValue("@BloodGroup", information.BloodGroup);
            cmd.Parameters.AddWithValue("@RegistrationDate", information.RegistrationDate);
            cmd.Parameters.AddWithValue("@Department", information.Department);
            cmd.Parameters.AddWithValue("@Address", information.Address);
            cmd.Parameters.AddWithValue("@BatchNo", information.BatchNo);
            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);
            cmd.Parameters.AddWithValue("@Password", information.Password);
            cmd.Parameters.AddWithValue("@CGPA", information.CGPA);
            cmd.Parameters.AddWithValue("@UserID", information.UserID);
            cmd.Parameters.AddWithValue("@Section", information.Section);

            return DBcon.ExeNonQuery(cmd);
        }


        //Search
        public DataTable SerchStudent(StudentInfromation stdInfo)
        {
            SqlCommand cmd = new SqlCommand("Select * from Student where FirstName = @FirstName");
            cmd.Parameters.AddWithValue("@FirstName", stdInfo.FirstName);

            return DBcon.ExeReader(cmd);
        }

        public SqlDataReader GetBachNo(StudentInfromation information)
        {
            SqlCommand cmd = new SqlCommand("Select BatchNo from Student where StudentID = @StudentID", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);

            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public SqlDataReader Load_StudentProfile(StudentInfromation information)
        {
            SqlCommand cmd = new SqlCommand("Select * from Student where StudentID = @StudentID", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        // To check login
        public DataTable Check_StudentTable(StudentInfromation stuInformation)
        {
            SqlCommand cmd = new SqlCommand("Select * from Student where StudentID = @StudentID and Password = @Password");
            cmd.Parameters.AddWithValue("@StudentID", stuInformation.StudentID);
            cmd.Parameters.AddWithValue("@Password", stuInformation.Password);

            return DBcon.ExeReader(cmd);
        }

        public void UpdateStudent(StudentInfromation information)
        {
            SqlCommand cmd = new SqlCommand("Update Student set FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth,"
            + "Gender = @Gender, Age = @Age, Email = @Email, PhoneNo = @PhoneNo, BloodGroup = @BloodGroup , RegistrationDate = @RegistrationDate,  Department = @Department,"
            + " Address = @Address, BatchNo = @BatchNo , Section= @Section "
            + "where StudentID = @StudentID");


            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);
            cmd.Parameters.AddWithValue("@FirstName", information.FirstName);
            cmd.Parameters.AddWithValue("@LastName", information.LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", information.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", information.Gender);
            cmd.Parameters.AddWithValue("@Age", information.Age);
            cmd.Parameters.AddWithValue("@Email", information.Email);
            cmd.Parameters.AddWithValue("@PhoneNo", information.PhoneNo);
            cmd.Parameters.AddWithValue("@BloodGroup", information.BloodGroup);
            cmd.Parameters.AddWithValue("@RegistrationDate", information.RegistrationDate);
            cmd.Parameters.AddWithValue("@Department", information.Department);
            cmd.Parameters.AddWithValue("@Address", information.Address);
            cmd.Parameters.AddWithValue("@BatchNo", information.BatchNo);
            cmd.Parameters.AddWithValue("@Section", information.Section);

            DBcon.ExeNonQuery(cmd);
        }

        public void Delete_Record(StudentInfromation information)
        {
            SqlCommand cmd = new SqlCommand("Delete from Student where StudentID = @StudentID");
            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);

            DBcon.ExeNonQuery(cmd);
        }

        //UpdatePassword
        public void UpdatePassword(StudentInfromation information)
        {
            SqlCommand cmd = new SqlCommand(" Update Student set Password=@Password ");


            cmd.Parameters.AddWithValue("@Password", information.Password);

            DBcon.ExeNonQuery(cmd);
        }




        // To load StudentId in comboBox
        public SqlDataReader Load_StudentID(StudentInfromation information)
        {
            SqlCommand cmd = new SqlCommand("select StudentID from Student", DBcon.GetCon());
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        // To load StudentId in comboBox
        public SqlDataReader Load_StudentInformation(StudentInfromation information)
        {
            SqlCommand cmd = new SqlCommand("select BatchNo, Department, Section  from Student", DBcon.GetCon());
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        // To load all Item
        public SqlDataReader Load_AllItem(StudentInfromation information, string id)
        {
            SqlCommand cmd = new SqlCommand("Select * from Student where StudentID = @StudentID", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@StudentID", id);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
        //Teacher
        public SqlDataReader StudentFromRegistration(StudentInfromation information, string batchNo, string section)
        {
            SqlCommand cmd = new SqlCommand("Select * from Student where BatchNo = @BatchNo and Section=@Section ", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@BatchNo", batchNo);
            cmd.Parameters.AddWithValue("@Section", section);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


        public void SearchStudentInfo(StudentInfromation stdInfo)
        {
            SqlCommand cmd = new SqlCommand("select * from Student where FirstName = @FirstName");
            cmd.Parameters.AddWithValue("@FirstName", stdInfo.FirstName);
            
            DBcon.ExeNonQuery(cmd);

        }

        public DataTable StudentViewTabel_CES(StudentInfromation std)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student where Department = 'CSE' ";

            return DBcon.ExeReader(cmd);
        }

        public DataTable StudentViewTabel_EEE(StudentInfromation std)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student where Department = 'EEE' ";

            return DBcon.ExeReader(cmd);
        }


        public DataTable StudentViewTabel(StudentInfromation std)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student ";

            return DBcon.ExeReader(cmd);
        }


        public DataTable GetCurrentPassword(StudentInfromation information)
        {
            SqlCommand cmd = new SqlCommand("Select * from Student where StudentID = @StudentID and Password = @Password");
            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);
            cmd.Parameters.AddWithValue("@Password", information.Password);

            return DBcon.ExeReader(cmd);
        }
        public void Change_StudentPassword(StudentInfromation information)
        {
            SqlCommand cmd = new SqlCommand("Update Student set Password = @Password where StudentID = @StudentID");
            cmd.Parameters.AddWithValue("@StudentID", information.StudentID);
            cmd.Parameters.AddWithValue("@Password", information.Password);

            DBcon.ExeNonQuery(cmd);
        }
    }
}
