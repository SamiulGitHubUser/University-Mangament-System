using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;

namespace UniversityManagementSystem
{
    public partial class CourseAdd : MetroFramework.Forms.MetroForm
    {

        Course course = new Course();
        CourseOperation courseOperation = new CourseOperation();

        public CourseAdd()
        {
            InitializeComponent();
        }

        private void CourseAdd_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            course.CourseName = courseName.Text;
            course.Department = courseDept.Text;
            course.AvailableSection  = availableSection.Text;
            course.Pre_Reqsite = pre_Reqsite.Text;
            course.CourseCredits = Convert.ToInt32( courseCredits.Text);
            course.CourseFee = Convert.ToInt32(courseFee.Text);
            course.CourseDescription = courseDesc.Text;
            course.CourseStatus = courseStatus.Text;
            course.CourseProgramme = courseProgrammeComboBox.Text;

            int row = courseOperation.InsertCourseInfo(course);

            this.Close();
        }
    }
}
