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
    public partial class DepartmentControl : UserControl
    {
        public string checkDepartment="";
        DeptCourseControl courseControl = new DeptCourseControl();


        public DepartmentControl()
        {
            InitializeComponent();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(courseControl);
            courseControl.deptTitle.Text = "BBA in Accounting and Finance";
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {

        }

        private void CourseButtonControl_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            checkDepartment = "CSE";
            Console.WriteLine(checkDepartment);
            this.Controls.Clear();
            this.Controls.Add(courseControl);
            courseControl.deptTitle.Text = "BSc in Computer Science & Engineering";
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(courseControl);
            courseControl.deptTitle.Text = "Bachelor of Science in Economics";
            
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(courseControl);
            courseControl.deptTitle.Text = "Electrical and Electronic Engineering";
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(courseControl);
            courseControl.deptTitle.Text = "Bachelor of Science in Laws(LLB)";
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(courseControl);
            courseControl.deptTitle.Text = "Bachelor Degree in English(BA)";
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(courseControl);
            courseControl.deptTitle.Text = "M.Sc in Electrical & Electronic Engineering";
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(courseControl);
            courseControl.deptTitle.Text = "M.Sc in Computer Science Engineering";
        }
    }
}
