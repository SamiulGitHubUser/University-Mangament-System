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
    public class RegistrationOperation
    {
        public DbConnection DBcon = new DbConnection();
        public Registration reg = new Registration();


        //Registration Infromation
        public int InsertRegistrationInfo(Registration reg)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Registration ( BatchNo, Section, Department, CourseName_1, CourseName_2, CourseName_3, CourseName_4, Sehdule, TeacherName ) values ( @BatchNo, @Section, @Department, @CourseName_1, @CourseName_2, @CourseName_3, @CourseName_4, @Sehdule, @TeacherName)";

            cmd.Parameters.AddWithValue("@BatchNo", reg.BatchNo);
            cmd.Parameters.AddWithValue("@Section", reg.Section);
            cmd.Parameters.AddWithValue("@Department", reg.Department);
            cmd.Parameters.AddWithValue("@CourseName_1", reg.CourseName_1);
            cmd.Parameters.AddWithValue("@CourseName_2", reg.CourseName_2);
            cmd.Parameters.AddWithValue("@CourseName_3", reg.CourseName_3);
            cmd.Parameters.AddWithValue("@CourseName_4", reg.CourseName_4);
            cmd.Parameters.AddWithValue("@Sehdule", reg.Sehdule);
            cmd.Parameters.AddWithValue("@TeacherName", reg.TeacherName);



            return DBcon.ExeNonQuery(cmd);
        }

        // To load all Registration in comboBox
        public SqlDataReader Load_RegistrationID(Registration reg)
        {
            SqlCommand cmd = new SqlCommand("select RegistrationNo from Registration", DBcon.GetCon());
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        // To load all information against RegistrationNo in text Book
        public SqlDataReader Load_AllRegistrationTemp(Registration reg, int temp)
        {
            SqlCommand cmd = new SqlCommand("Select * from Registration where RegistrationNo = @RegistrationNo", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@RegistrationNo", temp);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public SqlDataReader Load_AllRegistration(Registration reg, string session)
        {
            SqlCommand cmd = new SqlCommand("Select * from Registration where Session=@Session", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@Session", session);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


    }
}
