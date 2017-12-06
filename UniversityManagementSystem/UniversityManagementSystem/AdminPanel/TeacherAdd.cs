using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;
using MetroFramework;

namespace UniversityManagementSystem
{
    public partial class TeacherAdd : MetroFramework.Forms.MetroForm
    {

        TeacherInformation information = new TeacherInformation();
        TeacherOperation operation = new TeacherOperation();
        DateTime time = DateTime.Now;

        public TeacherAdd()
        {
            InitializeComponent();
        }

        private void TeacherEntryForm_Load(object sender, EventArgs e)
        {
            metroTextBoxTeacherId.Text = CalculateID();
            metroTextBox2.Text = metroTextBoxTeacherId.Text;
        }

        private void metroTextBox15_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel55_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string DOB = metroComboBoxDay.SelectedItem.ToString() + "-" + metroComboBoxMonth.SelectedItem.ToString() + "-" + metroComboBoxYear.SelectedItem.ToString();
                string join = metroComboBoxDay2.SelectedItem.ToString() + "-" + metroComboBoxMonth2.SelectedItem.ToString() + "-" + metroComboBoxYear2.SelectedItem.ToString();
                string email = metroTextBoxEmail.Text + metroComboBoxDestination.SelectedItem.ToString();

                information.TeacherID = CalculateID();
                information.FirstName = metroTextBoxFirstName.Text;
                information.LastName = metroTextBoxLastName.Text;
                information.DateOfBirth = DOB;
                information.Gender = metroComboBoxGander.SelectedItem.ToString();
                information.TeacherType = metroTextBoxType.Text;
                information.Age = Convert.ToInt16(metroTextBoxAge.Text);
                information.MaritalStatus = metroComboBoxStatus.SelectedItem.ToString();
                information.Email = email;
                information.PhoneNo = metroTextBoxPhone.Text;
                information.BloodGroup = metroComboBoxBloodGroup.SelectedItem.ToString();
                information.Salary = Convert.ToInt32(metroTextBoxSalary.Text);
                information.JoinDate = join;
                information.Department = metroComboBoxDepartment.SelectedItem.ToString();
                information.Address = metroTextBoxAddress.Text;

                information.Password = metroTextBoxPassword.Text;

            if (metroTextBoxPassword.Text != metroTextBoxConPassword.Text)
            {
                MetroMessageBox.Show(this, "Password did't match !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int row = operation.AddTeacher(information);
                this.Close();
            }
        }
        catch (Exception ex)
        {
            MetroMessageBox.Show(this, "" + ex, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        }


        public string CalculateID()
        {
            string month; month = Convert.ToString(time.Month);
            string day; day = Convert.ToString(time.Day);
            string hour; hour = Convert.ToString(time.Hour);
            string min; min = Convert.ToString(time.Minute);
            string sec; sec = Convert.ToString(time.Second);
            string year = Convert.ToString(time.Year - 2000);

            if (time.Month < 10) { month = "0" + month; }
            if (time.Day < 10) { day = "0" + day; }
            if (time.Hour < 10) { hour = "0" + hour; }
            if (time.Minute < 10) { min = "0" + min; }
            if (time.Second < 10) { sec = "0" + sec; }

            string userId = year + "-" + month + day + hour + "-" + min + sec;

            return userId;
        }

        private void genaralTab_Click(object sender, EventArgs e)
        {

        }
    }
}
