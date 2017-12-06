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
    public partial class StudentControl : UserControl
    {
        public static string checkDept;
        StudentDataControl deptContorl = new StudentDataControl();

        public StudentControl()
        {
            InitializeComponent();
        }

        private void StudentBtnControl_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CSEProgButton_Click(object sender, EventArgs e)
        {
            checkDept = "CSE";
            this.Controls.Clear();
            this.Controls.Add(deptContorl);
            
        }

        private void BBAProgButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(deptContorl);
            deptContorl.deptTitle.Text= "Bachelor of Business Administration";
        }

        private void ArchiProgButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(deptContorl);
            deptContorl.deptTitle.Text = "Bachelor of Science in Economics";
        }

        private void EEEProgButton_Click(object sender, EventArgs e)
        {
            checkDept = "EEE";
            this.Controls.Clear();
            this.Controls.Add(deptContorl);
            deptContorl.deptTitle.Text = "Electrical and Electronic Engineering";
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(deptContorl);
            deptContorl.deptTitle.Text = "Bachelor of Laws (LLB Hons)";
        }

        private void LLBProgButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(deptContorl);
            deptContorl.deptTitle.Text = "Bachelor of Science in Architectures";
        }
    }
}
