using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using EntityLayer;
using MetroFramework;

namespace SmartUniversity.Teacher
{
    public partial class ProfileControl : UserControl
    {
        TeacherInformation information = new TeacherInformation();
        TeacherOperation operation = new TeacherOperation();

        private string teaID;

        public ProfileControl()
        {
            InitializeComponent();
        }

        public ProfileControl(string p)
        {
            // TODO: Complete member initialization
            this.teaID = p;
            InitializeComponent();
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
            try
            {
                information.TeacherID = this.teaID;
                SqlDataReader reader;
                reader = operation.Load_TeacherProfile(information);

                while (reader.Read())
                {
                    string[] address = (reader["Address"].ToString()).Split(',');

                    metroLabelTeacherID.Text = (reader["TeacherID"].ToString());
                    //metroLabelRegNo.Text = (reader["RegistrationNo"].ToString());
                    metroLabelFirstName.Text = (reader["FirstName"].ToString());
                    metroLabelLastName.Text = (reader["LastName"].ToString());
                    metroLabelDOB.Text = (reader["DateOfBirth"].ToString());
                    metroLabelGander.Text = (reader["Gender"].ToString());
                    metroLabelBGroup.Text = (reader["BloodGroup"].ToString());
                    metroLabelAge.Text = (reader["Age"].ToString());
                    metroLabelPhone.Text = (reader["PhoneNo"].ToString());
                    metroLabelEmail.Text = (reader["Email"].ToString());
                    metroLabelSalary.Text = (reader["Salary"].ToString());
                    metroLabelJoinDate.Text = (reader["JoinDate"].ToString());
                    metroLabelTeaType.Text = (reader["TeacherType"].ToString());
                    metroLabelMaStatus.Text = (reader["MaritalStatus"].ToString());
                    metroLabelVillege.Text = address[0];
                    metroLabelPost.Text = address[1];
                    metroLabelPoliStation.Text = address[2];
                    metroLabelDistrict.Text = address[3];
                    metroLabelDept.Text = (reader["Department"].ToString());
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "" + ex, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

    }
}
