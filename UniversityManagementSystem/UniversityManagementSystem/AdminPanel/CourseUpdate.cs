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

namespace UniversityManagementSystem
{
    public partial class CourseUpdate : MetroFramework.Forms.MetroForm
    {
        Course course = new Course();
        CourseOperation courseOperation = new CourseOperation();


        public CourseUpdate()
        {
            InitializeComponent();
        }

        private void CourseUpdate_Load(object sender, EventArgs e)
        {
            SqlDataReader reader;
            reader = courseOperation.Load_CourseID(course);
            while (reader.Read())
            {
                courseIDComboBox.Items.Add(reader["CourseID"].ToString());
            }
            reader.Close();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void courseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader;
            int temp = Convert.ToInt32(courseIDComboBox.SelectedItem);

            reader = courseOperation.Load_AllCourses(course, temp);

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
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            course.CourseID = Convert.ToInt32 ( courseIDComboBox.SelectedItem );
            course.CourseName = courseName.Text;
            course.Department = courseDept.Text;
            course.AvailableSection = availableSection.Text;
            course.Pre_Reqsite = pre_Reqsite.Text;
            course.CourseCredits = Convert.ToInt32(courseCredits.Text);
            course.CourseFee = Convert.ToInt32(courseFee.Text);
            course.CourseDescription = courseDesc.Text;
            course.CourseStatus = courseStatus.Text;
            course.CourseProgramme = courseProgrammeComboBox.Text;

            courseOperation.UpdateCourseInfo(course);

            this.Dispose();
        }
    }
}
