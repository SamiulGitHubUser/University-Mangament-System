using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagementSystem.AdminPanel;
using EntityLayer;
using BusinessLayer;


namespace UniversityManagementSystem
{
    public partial class StudentAdd : MetroFramework.Forms.MetroForm
    {
        public StudentInfromation information = new StudentInfromation();
        public Parents parentInfo = new Parents();
        public ParentOperation parentOperation = new ParentOperation();
        public StudentOperation stdOpertion = new StudentOperation();
        DateTime time = DateTime.Now;

        public StudentAdd()
        {
            InitializeComponent();
        }

        private void StudentAddmissionForm_Load(object sender, EventArgs e)
        {
            metroTextBoxStudentId.Text = CalculateID();
            metroTextBoxBatchNo.Text = CalculateBatch();
            UserIDText.Text = metroTextBoxStudentId.Text;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            /*
            stdInfo.FirstName = firstName.Text;
            stdInfo.LastName = lastName.Text;
            stdInfo.DateOfBirth = dateOfBirth.Text;
            stdInfo.Gender = gender.Text;
            stdInfo.BloodGroup = bloodGroup.Text;
            stdInfo.Age = Convert.ToInt32(age.Text);
            stdInfo.Email = email.Text;
            stdInfo.PhoneNo = phoneNo.Text;
            stdInfo.Address = address.Text;
            stdInfo.Department = department.Text;
            stdInfo.BatchNo = batchNo.Text;
            stdInfo.RegistrationNo = regNo.Text;
            stdInfo.RegistrationDate = regDate.Text;


            int row = stdOpertion.InsertStudentInfo(stdInfo);
*/

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            /*
            parentInfo.FatherName = fatherName.Text;
            parentInfo.MotherName = motherName.Text;
            parentInfo.FatherPhoneNo = fatherPhoneNo.Text;
            parentInfo.MotherPhoneNo = motherPhoneNo.Text;
            parentInfo.FatherOccupation = fatherOccupation.Text;
            parentInfo.MotherOccupation = motherOccupation.Text;
            parentInfo.FatherOccupationDetail = fatherOccupationDetail.Text;


            int row = parentOperation.InsertParentInfo(parentInfo);

            */
        }

        private void metroButtonNext_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string DOB = metroComboBoxDay.SelectedItem.ToString() + "-" + metroComboBoxMonth.SelectedItem.ToString() + "-" + metroComboBoxYear.SelectedItem.ToString();
            string registration = metroComboBoxDay2.SelectedItem.ToString() + "-" + metroComboBoxMonth2.SelectedItem.ToString() + "-" + metroComboBoxYear2.SelectedItem.ToString();
            string email = metroTextBoxEmail.Text + metroComboBoxDestination.SelectedItem.ToString();

            information.StudentID = CalculateID();
            information.FirstName = metroTextBoxFirstName.Text;
            information.LastName = metroTextBoxLastName.Text;
            information.DateOfBirth = DOB;
            information.Gender = metroComboBoxGander.SelectedItem.ToString();
            information.Age = Convert.ToInt16(metroTextBoxAge.Text);
            information.Email = email;
            information.PhoneNo = metroTextBoxPhone.Text;
            information.BloodGroup = metroComboBoxBloodGroup.SelectedItem.ToString();
            information.RegistrationDate = registration;
            information.Department = metroComboBoxDepartment.SelectedItem.ToString();
            information.CGPA = 0.0;
            information.Section = metroComboBoxSection.SelectedItem.ToString();
            information.Address = metroTextBoxAddress.Text;
            information.BatchNo = CalculateBatch();
            information.UserID = UserIDText.Text;
            information.Password = passwordText.Text;

            int row1 = stdOpertion.InsertStudentInfo(information);



            //Parent Information:

            parentInfo.StudentID = information.StudentID;
            parentInfo.FatherName = fatherName.Text;
            parentInfo.MotherName = motherName.Text;
            parentInfo.FatherPhoneNo = fatherPhoneNo.Text;
            parentInfo.MotherPhoneNo = motherPhoneNo.Text;
            parentInfo.FatherOccupation = fatherOccupation.Text;
            parentInfo.MotherOccupation = motherOccupation.Text;
            parentInfo.FatherOccupationDetail = fatherOccupationDetail.Text;


            int row = parentOperation.InsertParentInfo(parentInfo);

            this.Close();
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

        public string CalculateBatch()
        {
            string seasson;
            string year = Convert.ToString(time.Year);
            int month = time.Month;

            if (month <= 4)
            {
                seasson = "1";
            }
            else if (month > 4 && month <= 8)
            {
                seasson = "2";
            }
            else
            {
                seasson = "3";
            }
            string userBatch = year + "-" + seasson;

            return userBatch;
        }
    }
}
