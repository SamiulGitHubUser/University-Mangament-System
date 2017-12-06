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
using MetroFramework;

namespace SmartUniversity.Student
{
    public partial class OptionControl : UserControl
    {
        StudentInfromation teacherInfo = new StudentInfromation();
        StudentOperation teacherOperation = new StudentOperation();

        ChangePassword change;
        private string stuID;

        public OptionControl()
        {
            InitializeComponent();
        }

        public OptionControl(string p)
        {
            // TODO: Complete member initialization
            this.stuID = p;
            InitializeComponent();
        }

        private void metroButtonIssue_Click(object sender, EventArgs e)
        {
            change.Show();
        }

        private void OptionControl_Load(object sender, EventArgs e)
        {
            change = new ChangePassword(this.stuID); // To Send Student ID to Change Password Form being Option Control load
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            teacherInfo.Password = confirmPassword.Text;

            if (newPassword.Text != (" ") || confirmPassword.Text != (" ") && (newPassword.Text == confirmPassword.Text))
            {
                teacherOperation.UpdatePassword(teacherInfo);
                MetroMessageBox.Show(this, "Update Successful !!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this, "Password Didn't Match!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
