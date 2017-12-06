using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;

namespace UniversityManagementSystem
{
    public partial class DeptCourseControl : UserControl
    {
        Course course = new Course();
        CourseOperation courseOperation = new CourseOperation();

        public DeptCourseControl()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CourseAdd addCourse = new CourseAdd();
            addCourse.Show();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            CourseUpdate updateCourse = new CourseUpdate();
            updateCourse.Show();
        }

        private void DeptCourseControl_Load(object sender, EventArgs e)
        {

            switch ("CSE")
            {
                case "CSE":
                    DataTable dt = new DataTable();
                    dt = courseOperation.CourseViewTabel(course);

                    deptCourseGrid.DataSource = dt;
                break;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            course.CourseName = searchBox.Text;

            DataTable table = new DataTable();
            table = courseOperation.SearchByCourseName(course);

            deptCourseGrid.DataSource = table;
        }
    }
}
