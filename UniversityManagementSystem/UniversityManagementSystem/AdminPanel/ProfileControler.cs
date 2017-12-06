using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;
using System.Data.SqlClient;

namespace UniversityManagementSystem.AdminPanel
{
    public partial class ProfileControler : UserControl
    {
        AdminInformation information = new AdminInformation();
        AdminOperation operation = new AdminOperation();
        private string adminID;

        public ProfileControler(string Id)
        {
            // TODO: Complete member initialization
            this.adminID = Id;
            InitializeComponent();
        }

        private void ProfileControler_Load(object sender, EventArgs e)
        {
            try
            {
                information.AdminID = this.adminID;
                SqlDataReader reader;
                reader = operation.Load_AdminProfile(information);

                while (reader.Read())
                {
                    string[] address = (reader["Address"].ToString()).Split(',');

                    metroLabelAdminID.Text = (reader["AdminID"].ToString());
                    metroLabelFirstName.Text = (reader["FirstName"].ToString());
                    metroLabelLastName.Text = (reader["LastName"].ToString());
                    metroLabelDOB.Text = (reader["DateOfBirth"].ToString());
                    metroLabelGander.Text = (reader["Gender"].ToString());
                    metroLabelBGroup.Text = (reader["BloodGroup"].ToString());
                    metroLabelAge.Text = (reader["Age"].ToString());
                    metroLabelPhone.Text = (reader["PhoneNo"].ToString());
                    metroLabelEmail.Text = (reader["Email"].ToString());
                    metroLabelVillege.Text = address[0];
                    metroLabelPost.Text = address[1];
                    metroLabelPoliStation.Text = address[2];
                    metroLabelDistrict.Text = address[3];
                    metroLabelDept.Text = (reader["Department"].ToString());
                    metroLabelBatchNo.Text = (reader["Salary"].ToString());
                    metroLabelRegDate.Text = (reader["RegistrationDate"].ToString());
                    metroLabelCGPA.Text = (reader["UserID"].ToString());
                    metroLabelSec.Text = (reader["Password"].ToString());
                }
                reader.Close();

            }
            catch
            {
                MetroMessageBox.Show(this, "Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }
    }
}
