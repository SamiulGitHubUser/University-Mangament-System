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
    public class CurriculumOperation
    {
        public DbConnection DBcon = new DbConnection();
        public Curriculum curriculum = new Curriculum();


        //Curriculum Infromation
        public int InsertRegistrationInfo(Curriculum reg)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Curriculum (SemisterNo, CourseName_1, CourseName_2, CourseName_3, CourseName_4) values (@SemisterNo, @CourseName_1, @CourseName_2, @CourseName_3, @CourseName_4)";

            cmd.Parameters.AddWithValue("@SemisterNo", reg.SemisterNo);
            cmd.Parameters.AddWithValue("@CourseName_1", reg.CourseName_1);
            cmd.Parameters.AddWithValue("@CourseName_2", reg.CourseName_2);
            cmd.Parameters.AddWithValue("@CourseName_3", reg.CourseName_3);
            cmd.Parameters.AddWithValue("@CourseName_4", reg.CourseName_4);

            return DBcon.ExeNonQuery(cmd);
        }

        // To load all Curriculum in comboBox
        public SqlDataReader Load_CurriculumID(Curriculum curriculum)
        {
            SqlCommand cmd = new SqlCommand("select SemisterNo from Curriculum", DBcon.GetCon());
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        // To load all information against Curriculum in text Book
        public SqlDataReader Load_AllCurriculum(Curriculum curriculum, int temp)
        {
            SqlCommand cmd = new SqlCommand("Select * from Curriculum where SemisterNo = @SemisterNo", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@SemisterNo", temp);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

    }
}
