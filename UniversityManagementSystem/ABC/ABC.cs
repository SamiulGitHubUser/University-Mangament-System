using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class CourseControl : UserControl
    {
        public CourseControl()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CourseAdd addCourse = new CourseAdd();
            addCourse.Show();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            CourseUpdate updateCourse = new CourseUpdate();
            updateCourse.Show();
        }
    }
}
