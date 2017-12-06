using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EntityLayer;
using BusinessLayer;

namespace UniversityManagementSystem
{
    public partial class ParentUpdate : MetroFramework.Forms.MetroForm
    {
        public Parents parent = new Parents();
        public ParentOperation parentOperation = new ParentOperation();


        public ParentUpdate()
        {
            InitializeComponent();
        }

        private void ParentUpdate_Load(object sender, EventArgs e)
        {
            SqlDataReader reader;
            reader = parentOperation.Load_ParentID(parent);
            while (reader.Read())
            {
                ParentIDComboBox.Items.Add(reader["ParentID"].ToString());
            }
            reader.Close();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            parent.ParentID = Convert.ToInt32( ParentIDComboBox.SelectedItem );
            parent.FatherName = fatherName.Text;
            parent.MotherName = motherName.Text;
            parent.FatherPhoneNo = fatherPhoneNo.Text;
            parent.MotherPhoneNo = motherPhoneNo.Text;
            parent.FatherOccupation = fatherOccupation.Text;
            parent.MotherOccupation = motherOccupation.Text;
            parent.FatherOccupationDetail = fatherOccupationDetail.Text;


            parentOperation.UpdateParentInfo(parent);

            this.Dispose();
        }

        private void ParentIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader;
            int temp = Convert.ToInt32(ParentIDComboBox.SelectedItem);

            reader = parentOperation.Load_ParentINFO(parent, temp);

            while (reader.Read())
            {
                fatherName.Text = (reader["FatherName"].ToString());
                motherName.Text = (reader["MotherName"].ToString());
                fatherPhoneNo.Text = (reader["FatherPhoneNo"].ToString());
                motherPhoneNo.Text = (reader["MotherPhoneNo"].ToString());
                fatherOccupation.Text = (reader["FatherOccupation"].ToString());
                motherOccupation.Text = (reader["MotherOccupation"].ToString());
                fatherOccupationDetail.Text = (reader["FatherOccupationDetail"].ToString());
            }

            reader.Close();
        }
    }
}
