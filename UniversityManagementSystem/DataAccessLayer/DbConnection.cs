using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DbConnection
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Document\Downloads\UniversityManagementSystem\UniversityManagementSystem\UniversityDB.mdf;Integrated Security=True");

        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        
        //to perform insert, update and delete

        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = GetCon();


            int rowsAffected = -1;
            rowsAffected = cmd.ExecuteNonQuery();

            con.Close();

            return rowsAffected;
        }

        //to retrive a single value from DB or query

        public object ExeScalar(SqlCommand cmd)
        {
            cmd.Connection = GetCon();

            object obj = -1;
            obj = cmd.ExecuteScalar();

            con.Close();

            return obj;
        }

        //to perform select query

        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = GetCon();

            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);

            con.Close();

            return dt;
        }
    }
}

