using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using EntityLayer;
using BusinessLayer;
using MetroFramework;

namespace SmartUniversity.Student
{
    public partial class ProfileControl : UserControl
    {

        EntityLayer.StudentInfromation information = new EntityLayer.StudentInfromation();
        StudentOperation operation = new StudentOperation();
        Parents parentInfo = new Parents();
        ParentOperation parentOper = new ParentOperation();

        private string stuID;

        public ProfileControl()
        {
            InitializeComponent();
        }

        public ProfileControl(string stuId)
        {
            // TODO: Complete member initialization
            this.stuID = stuId;
            InitializeComponent();
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {

            try
            {
                information.StudentID = this.stuID;
                SqlDataReader reader;
                reader = operation.Load_StudentProfile(information);

                while (reader.Read())
                {
                    string[] address = (reader["Address"].ToString()).Split(',');

                    metroLabelStudentID.Text = (reader["StudentID"].ToString());
                    //metroLabelRegNo.Text = (reader["RegistrationNo"].ToString());
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
                    metroLabelBatchNo.Text = (reader["BatchNo"].ToString());
                    metroLabelRegDate.Text = (reader["RegistrationDate"].ToString());
                    metroLabelCGPA.Text = (reader["CGPA"].ToString());
                    metroLabelSec.Text = (reader["Section"].ToString());
                }
                reader.Close();


                parentInfo.StudentID = this.stuID;
                reader = parentOper.Load_ParentInfo(parentInfo);

                while (reader.Read())
                {
                    metroLabelFaName.Text = (reader["FatherName"].ToString());
                    metroLabelFaOccupation.Text = (reader["FatherOccupation"].ToString());
                    metroLabelFaPhone.Text = (reader["FatherPhoneNo"].ToString());
                    MotherNameMoName.Text = (reader["MotherName"].ToString());
                    metroLabelMoPhone.Text = (reader["MotherPhoneNo"].ToString());
                    metroLabelMoOccupation.Text = (reader["MotherOccupation"].ToString());
                    metroLabelFaOccDetail.Text = (reader["FatherOccupationDetail"].ToString());
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



