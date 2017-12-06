using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;
using MetroFramework;
using System.Data;
using System.Data.SqlClient;

namespace UniversityManagementSystem.TeacherPanel
{
    public partial class StudentUnderTacher : UserControl
    {
        StudentInfromation information = new StudentInfromation();
        StudentOperation operation = new StudentOperation();

        public StudentUnderTacher()
        {
            InitializeComponent();
        }

        private void StudentUnderTacher_Load(object sender, EventArgs e)
        {
            /*
            
            SqlDataReader reader;
            int = Convert.ToInt32(courseIDComboBox.SelectedItem);

            reader = operation.StudentFromRegistration(course, temp);

            while (reader.Read())
            {
                courseName.Text = (reader["CourseName"].ToString());
                courseDept.Text = (reader["Department"].ToString());
                availableSection.Text = (reader["AvailableSection"].ToString());
                pre_Reqsite.Text = (reader["Pre_Reqsite"].ToString());
                courseCredits.Text = (reader["CourseCredits"].ToString());
                courseFee.Text = (reader["CourseFee"].ToString());
                courseDesc.Text = (reader["CourseDescription"].ToString());
                courseStatus.Text = (reader["CourseStatus"].ToString());
                courseProgrammeComboBox.Text = (reader["CourseProgramme"].ToString());

            }

            reader.Close();
            */
                

            try
            {
                DataTable table = new DataTable();

                table = operation.StudentViewTabel_CES(information);
                metroGrid.DataSource = table;

                metroGrid.DataSource = table;
            }
            catch
            {
                MetroMessageBox.Show(this, "Error", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            information.FirstName = metroTextBox1.Text;

            DataTable table = new DataTable();
            table = operation.SerchStudent(information);

            metroGrid.DataSource = table;
        }
    }
}
