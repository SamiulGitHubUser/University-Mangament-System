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

namespace UniversityManagementSystem
{
    public partial class CourseControl : UserControl
    {
        int deleteId;
        Course course = new Course();
        CourseOperation courseOperation = new CourseOperation();

        public CourseControl()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CourseAdd addCourse = new CourseAdd();
            addCourse.ShowDialog();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            CourseUpdate updateCourse = new CourseUpdate();
            updateCourse.ShowDialog();
        }

        private void CourseControl_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = courseOperation.CourseViewTabel(course);

            courseGrid.DataSource = dt;
        }

        private void courseGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                if (e.Button == MouseButtons.Right)
                {
                    deleteId = Convert.ToInt32(courseGrid.Rows[e.RowIndex].Cells["CourseID"].Value.ToString());
                    this.DeleteContextMenu.Show(this.courseGrid, e.Location);
                    DeleteContextMenu.Show(Cursor.Position);
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "You Can't Click Here!!", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }

        }

        private void deleteCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            course.CourseID = deleteId;
            courseOperation.DeleteCourse_Record(course);

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            course.CourseName = searchBox.Text;

            DataTable table = new DataTable();
            table = courseOperation.SearchByCourseName(course);

            courseGrid.DataSource = table;
        }
    }
}
