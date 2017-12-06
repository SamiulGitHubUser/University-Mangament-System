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
using BusinessLayer;
using EntityLayer;
using MetroFramework;

namespace UniversityManagementSystem
{
    public partial class StudentUpdate : MetroFramework.Forms.MetroForm
    {
        StudentInfromation information = new StudentInfromation();
        StudentOperation operation = new StudentOperation();


        public StudentUpdate()
        {
            InitializeComponent();
        }

        private void StudentUpdateForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader reader;
                reader = operation.Load_StudentID(information);

                while (reader.Read())
                {
                    metroComboBoxStudentID.Items.Add(reader["StudentID"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "" + ex, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroButtonNext_Click(object sender, EventArgs e)
        {
            information.StudentID = metroComboBoxStudentID.SelectedItem.ToString();
            information.FirstName = metroTextBoxFirstName.Text;
            information.LastName = metroTextBoxLastName.Text;
            information.DateOfBirth = metroComboBoxDay.SelectedItem.ToString() + "-" + metroComboBoxMonth.SelectedItem.ToString() + "-" + metroComboBoxYear.SelectedItem.ToString();
            information.Gender = metroComboBoxGander.SelectedItem.ToString();
            information.Age = Convert.ToInt16(metroTextBoxAge.Text);
            information.Email = metroTextBoxEmail.Text + metroComboBoxDestination.SelectedItem.ToString();
            information.PhoneNo = metroTextBoxPhone.Text;
            information.BloodGroup = metroComboBoxBloodGroup.SelectedItem.ToString();
            information.RegistrationDate = metroComboBoxDay2.SelectedItem.ToString() + "-" + metroComboBoxMonth2.SelectedItem.ToString() + "-" + metroComboBoxYear2.SelectedItem.ToString();
            information.Department = metroComboBoxDepartment.SelectedItem.ToString();
            information.BatchNo = metroTextBoxBatchNo.Text;
            information.Address = metroTextBoxAddress.Text;
            information.Section = metroComboBoxBloodGroup.SelectedItem.ToString();

            operation.UpdateStudent(information);

            this.Dispose();
        }

        private void metroComboBoxStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader;
            string id = metroComboBoxStudentID.SelectedItem.ToString();

            reader = operation.Load_AllItem(information, id);

            while (reader.Read())
            {
                string[] date = (reader["DateOfBirth"].ToString()).Split('-');
                string[] email = (reader["Email"].ToString()).Split('@');
                string[] join = (reader["RegistrationDate"].ToString()).Split('-');

                metroTextBoxFirstName.Text = (reader["FirstName"].ToString());
                metroTextBoxLastName.Text = (reader["LastName"].ToString());
                metroComboBoxDay.Text = date[0];
                metroComboBoxMonth.Text = date[1];
                metroComboBoxYear.Text = date[2];
                metroComboBoxGander.SelectedItem = (reader["Gender"].ToString());
                metroTextBoxAge.Text = (reader["Age"].ToString());
                metroTextBoxEmail.Text = email[0];
                metroComboBoxDestination.Text = "@" + email[1];
                metroTextBoxPhone.Text = (reader["PhoneNo"].ToString());
                metroComboBoxBloodGroup.SelectedItem = (reader["BloodGroup"].ToString());
                metroComboBoxDay2.Text = join[0];
                metroComboBoxMonth2.Text = join[1];
                metroComboBoxYear2.Text = join[2];
                metroComboBoxDepartment.SelectedItem = (reader["Department"].ToString());
                metroTextBoxAddress.Text = (reader["Address"].ToString());
                metroTextBoxBatchNo.Text = (reader["BatchNo"].ToString());
                metroComboBoxBloodGroup.SelectedItem = (reader["Section"].ToString());
                
            }
            reader.Close();
        }
    }
}
