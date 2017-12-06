using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class AdminOperation
    {
        public DbConnection DBcon = new DbConnection();
        public AdminInformation adminInfo = new AdminInformation();

        //Student Infromation
        public int InsertStudentInfo(AdminInformation information)
        {
            SqlCommand cmd = new SqlCommand("Insert into Admin (AdminID, FirstName, LastName, DateOfBirth, Gender, Age," +
             "Email, PhoneNo, BloodGroup, RegistrationDate, Department, Address, Salary, UserID, Password, Type) values " +
             "(@AdminID, @FirstName, @LastName, @DateOfBirth, @Gender, @Age," +
            "@Email, @PhoneNo, @BloodGroup, @RegistrationDate, @Department, @Address, @Salary, @UserID, @Password, @Type)");

            cmd.Parameters.AddWithValue("@AdminID", information.AdminID);
            cmd.Parameters.AddWithValue("@FirstName", information.FirstName);
            cmd.Parameters.AddWithValue("@LastName", information.LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", information.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", information.Gender);
            cmd.Parameters.AddWithValue("@Salary", information.Salary);
            cmd.Parameters.AddWithValue("@Age", information.Age);
            cmd.Parameters.AddWithValue("@Email", information.Email);
            cmd.Parameters.AddWithValue("@PhoneNo", information.PhoneNo);
            cmd.Parameters.AddWithValue("@BloodGroup", information.BloodGroup);
            cmd.Parameters.AddWithValue("@Department", information.Department);
            cmd.Parameters.AddWithValue("@Address", information.Address);
            cmd.Parameters.AddWithValue("@RegistrationDate", information.RegistrationDate);
            cmd.Parameters.AddWithValue("@Type", information.Type);
            cmd.Parameters.AddWithValue("@UserID", information.UserID);
            cmd.Parameters.AddWithValue("@Password", information.Password);

            return DBcon.ExeNonQuery(cmd);
        }


        //Search by FirstName
        public DataTable SearchAdmin(AdminInformation Info)
        {
            SqlCommand cmd = new SqlCommand("Select * from Admin where FirstName = @FirstName");
            cmd.Parameters.AddWithValue("@FirstName", Info.FirstName);

            return DBcon.ExeReader(cmd);
        }


        //GetAdmin
        public SqlDataReader Load_AdminProfile(AdminInformation information)
        {
            SqlCommand cmd = new SqlCommand("Select * from Admin where AdminID = @AdminID", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@AdminID", information.AdminID);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        //LoginCheckBy(UserID&Password)
        public DataTable Check_AdminTable(AdminInformation information)
        {
            SqlCommand cmd = new SqlCommand("Select * from Admin where AdminID = @AdminID and Password = @Password");
            cmd.Parameters.AddWithValue("@AdminID", information.AdminID);
            cmd.Parameters.AddWithValue("@Password", information.Password);

            return DBcon.ExeReader(cmd);
        }


        //UpdatePassword
        public void UpdatePassword(AdminInformation information)
        {
            SqlCommand cmd = new SqlCommand(" Update Admin set Password=@Password ");


            cmd.Parameters.AddWithValue("@Password", information.Password);

            DBcon.ExeNonQuery(cmd);
        }
    }
}
