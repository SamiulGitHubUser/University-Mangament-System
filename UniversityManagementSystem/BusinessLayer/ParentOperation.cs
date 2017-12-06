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
    public class ParentOperation
    {
        public DbConnection DBcon = new DbConnection();
        public Parents parent = new Parents();


        //Parent Infromation
        public int InsertParentInfo(Parents parent)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into StudentParent (FatherName, MotherName, FatherPhoneNo, MotherPhoneNo, FatherOccupation, MotherOccupation, FatherOccupationDetail, StudentID) values (  @FatherName, @MotherName, @FatherPhoneNo, @MotherPhoneNo, @FatherOccupation, @MotherOccupation, @FatherOccupationDetail, @StudentID)";

            cmd.Parameters.AddWithValue("@FatherName", parent.FatherName);
            cmd.Parameters.AddWithValue("@MotherName", parent.MotherName);
            cmd.Parameters.AddWithValue("@FatherPhoneNo", parent.FatherPhoneNo);
            cmd.Parameters.AddWithValue("@MotherPhoneNo", parent.MotherPhoneNo);
            cmd.Parameters.AddWithValue("@FatherOccupation", parent.FatherOccupation);
            cmd.Parameters.AddWithValue("@MotherOccupation", parent.MotherOccupation);
            cmd.Parameters.AddWithValue("@FatherOccupationDetail", parent.FatherOccupationDetail); 
            cmd.Parameters.AddWithValue("@StudentID", parent.StudentID);

            return DBcon.ExeNonQuery(cmd);
        }


        //Parent Infromation Update
        public void UpdateParentInfo(Parents parent)
        {
            SqlCommand cmd = new SqlCommand("Update StudentParent set FatherName = @FatherName, MotherName = @MotherName, FatherPhoneNo = @FatherPhoneNo, MotherPhoneNo = @MotherPhoneNo, FatherOccupation = @FatherOccupation, MotherOccupation = @MotherOccupation , FatherOccupationDetail = @FatherOccupationDetail where ParentID = @ParentID");


            cmd.Parameters.AddWithValue("@ParentID", parent.ParentID);
            cmd.Parameters.AddWithValue("@FatherName", parent.FatherName);
            cmd.Parameters.AddWithValue("@MotherName", parent.MotherName);
            cmd.Parameters.AddWithValue("@FatherPhoneNo", parent.FatherPhoneNo);
            cmd.Parameters.AddWithValue("@MotherPhoneNo", parent.MotherPhoneNo);
            cmd.Parameters.AddWithValue("@FatherOccupation", parent.FatherOccupation);
            cmd.Parameters.AddWithValue("@MotherOccupation", parent.MotherOccupation);
            cmd.Parameters.AddWithValue("@FatherOccupationDetail", parent.FatherOccupationDetail);

            

            DBcon.ExeNonQuery(cmd);
            
        }

        public SqlDataReader Load_ParentInfo(Parents parentInfo)
        {
            SqlCommand cmd = new SqlCommand("Select * from StudentParent where StudentID = @StudentID", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@StudentID", parentInfo.StudentID);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


        //SearchByStudentID
        public DataTable SearchByStudentID(Parents Info)
        {
            SqlCommand cmd = new SqlCommand("Select * from StudentParent where StudentID = @StudentID");
            cmd.Parameters.AddWithValue("@StudentID", Info.StudentID);

            return DBcon.ExeReader(cmd);
        }


        //Delete Parent Infromation
        public void DeleteParent_Record(Parents parent)
        {
            SqlCommand cmd = new SqlCommand("Delete from StudentParent where StudentID = @StudentID");
            cmd.Parameters.AddWithValue("@StudentID", parent.StudentID);

            DBcon.ExeNonQuery(cmd);
        }


        //Load all ParentID in comboBox
        public SqlDataReader Load_ParentID(Parents parent)
        {
            SqlCommand cmd = new SqlCommand("select ParentID from StudentParent", DBcon.GetCon());
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        //Load all ParentID in comboBox
        public SqlDataReader Load_StudentID(Parents parent)
        {
            SqlCommand cmd = new SqlCommand("select StudentID from StudentParent", DBcon.GetCon());
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        //Load all information under ParentID in text Book
        public SqlDataReader Load_ParentINFO(Parents parent, int temp)
        {
            SqlCommand cmd = new SqlCommand("Select * from StudentParent where ParentID = @ParentID", DBcon.GetCon());
            cmd.Parameters.AddWithValue("@ParentID", temp);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


        //View Table
        public DataTable ParentsViewTabel(Parents parent)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from StudentParent";

            return DBcon.ExeReader(cmd);
        }
    }
}
