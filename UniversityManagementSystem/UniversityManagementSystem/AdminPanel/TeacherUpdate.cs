using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem.AdminPanel
{
    public partial class TeacherUpdate : MetroFramework.Forms.MetroForm
    {
        TeacherInformation teacherInfo = new TeacherInformation();
        TeacherOperation teacherOperation = new TeacherOperation();

        public TeacherUpdate()
        {
            InitializeComponent();
        }

        

        private void TeacherUpdate_Load(object sender, EventArgs e)
        {
            SqlDataReader reader;
            reader = teacherOperation.Load_TeacherID(teacherInfo);

            while (reader.Read())
            {
                metroComboBoxID.Items.Add(reader["TeacherID"].ToString());
            }
            reader.Close();
        }

        private void metroComboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader;
            string id = metroComboBoxID.SelectedItem.ToString();

            reader = teacherOperation.Load_AllItem(teacherInfo, id);

            while (reader.Read())
            {
                string[] date = (reader["DateOfBirth"].ToString()).Split('-');
                string[] email = (reader["Email"].ToString()).Split('@');
                string[] join = (reader["JoinDate"].ToString()).Split('-');

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

            }
            reader.Close();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genaralTab_Click(object sender, EventArgs e)
        {
            teacherInfo.TeacherID = metroComboBoxID.SelectedItem.ToString();
            teacherInfo.FirstName = metroTextBoxFirstName.Text;
            teacherInfo.LastName = metroTextBoxLastName.Text;
            teacherInfo.DateOfBirth = metroComboBoxDay.SelectedItem.ToString() + "-" + metroComboBoxMonth.SelectedItem.ToString() + "-" + metroComboBoxYear.SelectedItem.ToString();
            teacherInfo.Gender = metroComboBoxGander.SelectedItem.ToString();
            teacherInfo.Age = Convert.ToInt16(metroTextBoxAge.Text);
            teacherInfo.Email = metroTextBoxEmail.Text + metroComboBoxDestination.SelectedItem.ToString();
            teacherInfo.PhoneNo = metroTextBoxPhone.Text;
            teacherInfo.BloodGroup = metroComboBoxBloodGroup.SelectedItem.ToString();
            teacherInfo.JoinDate = metroComboBoxDay2.SelectedItem.ToString() + "-" + metroComboBoxMonth2.SelectedItem.ToString() + "-" + metroComboBoxYear2.SelectedItem.ToString();
            teacherInfo.Department = metroComboBoxDepartment.SelectedItem.ToString();
            teacherInfo.Address = metroTextBoxAddress.Text;

            teacherOperation.UpdateTeacher(teacherInfo);

            this.Dispose();
        }
    }
}
