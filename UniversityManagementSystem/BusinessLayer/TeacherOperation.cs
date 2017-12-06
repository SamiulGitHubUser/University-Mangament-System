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
    public class TeacherOperation
    {


        TeacherInformation information = new TeacherInformation();
        DbConnection con = new DbConnection();

        // To insert into Teacher Table
        public int AddTeacher(TeacherInformation information)
        {
            SqlCommand cmd = new SqlCommand("Insert into Teacher (FirstName, LastName, DateOfBirth, Gender, TeacherType, Age, MaritalStatus, " +
             "Email, PhoneNo, BloodGroup, Salary, JoinDate, Department, Address, TeacherID, Password) values (@FirstName, @LastName, @DateOfBirth," +
            "@Gender, @TeacherType, @Age, @MaritalStatus, @Email, @PhoneNo, @BloodGroup, @Salary, @JoinDate, @Department, @Address, @TeacherID, @Password)");

            cmd.Parameters.AddWithValue("@FirstName", information.FirstName);
            cmd.Parameters.AddWithValue("@LastName", information.LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", information.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", information.Gender);
            cmd.Parameters.AddWithValue("@TeacherType", information.TeacherType);
            cmd.Parameters.AddWithValue("@Age", information.Age);
            cmd.Parameters.AddWithValue("@MaritalStatus", information.MaritalStatus);
            cmd.Parameters.AddWithValue("@Email", information.Email);
            cmd.Parameters.AddWithValue("@PhoneNo", information.PhoneNo);
            cmd.Parameters.AddWithValue("@BloodGroup", information.BloodGroup);
            cmd.Parameters.AddWithValue("@Salary", information.Salary);
            cmd.Parameters.AddWithValue("@JoinDate", information.JoinDate);
            cmd.Parameters.AddWithValue("@Department", information.Department);
            cmd.Parameters.AddWithValue("@Address", information.Address);
            cmd.Parameters.AddWithValue("@TeacherID", information.TeacherID);
            cmd.Parameters.AddWithValue("@Password", information.Password);

            return con.ExeNonQuery(cmd);
        }


        //UpdateTeacher
        public void UpdateTeacher(TeacherInformation information)
        {
            SqlCommand cmd = new SqlCommand("Update Teacher set FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth,"
            + "Gender = @Gender, Age = @Age, Email = @Email, PhoneNo = @PhoneNo, BloodGroup = @BloodGroup , JoinDate = @JoinDate,  Department = @Department,"
            + " Address = @Address where TeacherID = @TeacherID");


            cmd.Parameters.AddWithValue("@TeacherID", information.TeacherID);
            cmd.Parameters.AddWithValue("@FirstName", information.FirstName);
            cmd.Parameters.AddWithValue("@LastName", information.LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", information.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", information.Gender);
            cmd.Parameters.AddWithValue("@Age", information.Age);
            cmd.Parameters.AddWithValue("@Email", information.Email);
            cmd.Parameters.AddWithValue("@PhoneNo", information.PhoneNo);
            cmd.Parameters.AddWithValue("@BloodGroup", information.BloodGroup);
            cmd.Parameters.AddWithValue("@JoinDate", information.JoinDate);
            cmd.Parameters.AddWithValue("@Department", information.Department);
            cmd.Parameters.AddWithValue("@Address", information.Address);;

            con.ExeNonQuery(cmd);
        }

        //UpdatePassword
        public void UpdatePassword(TeacherInformation information)
        {
            SqlCommand cmd = new SqlCommand(" Update Teacher set Password=@Password ");


            cmd.Parameters.AddWithValue("@Password", information.Password);

            con.ExeNonQuery(cmd);
        }

        public DataTable GetCurrentPassword(TeacherInformation information)
        {
            SqlCommand cmd = new SqlCommand("Select * from Teacher where TeacherID = @TeacherID and Password = @Password");
            cmd.Parameters.AddWithValue("@TeacherID", information.TeacherID);
            cmd.Parameters.AddWithValue("@Password", information.Password);

            return con.ExeReader(cmd);
        }

        public SqlDataReader Load_TeacherProfile(TeacherInformation information)
        {
            SqlCommand cmd = new SqlCommand("Select * from Teacher where TeacherID = @TeacherID", con.GetCon());
            cmd.Parameters.AddWithValue("@TeacherID", information.TeacherID);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public DataTable SerchTeacher(TeacherInformation information)
        {
            SqlCommand cmd = new SqlCommand("Select * from Teacher where FirstName = @FirstName");
            cmd.Parameters.AddWithValue("@FirstName", information.FirstName);
            return con.ExeReader(cmd);
        }

        public void Change_TeacherPassword(TeacherInformation information)
        {
            SqlCommand cmd = new SqlCommand("Update Teacher set Password = @Password where TeacherID = @TeacherID");
            cmd.Parameters.AddWithValue("@TeacherID", information.TeacherID);
            cmd.Parameters.AddWithValue("@Password", information.Password);

            con.ExeNonQuery(cmd);
        }

        public DataTable Check_TeacherTable(TeacherInformation teaInformation)
        {
            SqlCommand cmd = new SqlCommand("Select * from Teacher where TeacherID = @TeacherID and Password = @Password");
            cmd.Parameters.AddWithValue("@TeacherID", teaInformation.TeacherID);
            cmd.Parameters.AddWithValue("@Password", teaInformation.Password);

            return con.ExeReader(cmd);
        }

        // To load TeacherID in comboBox
        public SqlDataReader Load_TeacherID(TeacherInformation information)
        {
            SqlCommand cmd = new SqlCommand("select TeacherID from Teacher", con.GetCon());
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


        // To load TeacherName in comboBox
        public SqlDataReader Load_TeacherName(TeacherInformation information, string dept)
        {
            SqlCommand cmd = new SqlCommand("Select FirstName, LastName  from Teacher where Department = @Department", con.GetCon());
            cmd.Parameters.AddWithValue("@Department", dept);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        //To load all ietm in update form
        public SqlDataReader Load_AllItem(TeacherInformation information, string id)
        {
            SqlCommand cmd = new SqlCommand("Select * from Teacher where TeacherID = @TeacherID", con.GetCon());
            cmd.Parameters.AddWithValue("@TeacherID", id);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


        //View Table
        public DataTable View_TeacherTable(TeacherInformation information)
        {
            SqlCommand cmd = new SqlCommand("Select * from Teacher");
            return con.ExeReader(cmd);
        }

        // To delete tecaher record
        public void Delete_Record(TeacherInformation information)
        {
            SqlCommand cmd = new SqlCommand("Delete from Teacher where TeacherID = @TeacherID");
            cmd.Parameters.AddWithValue("@TeacherID", information.TeacherID);

            con.ExeNonQuery(cmd);
        }
    }
}
