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

namespace SmartUniversity.Teacher
{
    public partial class SettingControl : UserControl
    {

        TeacherInformation teacherInfo = new TeacherInformation();
        TeacherOperation teacherOperation = new TeacherOperation();

        ChangePassword change;

        private string teaID;

        public SettingControl()
        {
            InitializeComponent();
        }

        public SettingControl(string p)
        {
            // TODO: Complete member initialization
            this.teaID = p;
            InitializeComponent();
        }

        private void metroButtonIssue_Click(object sender, EventArgs e)
        {
            change.Show();
        }

        private void SettingControl_Load(object sender, EventArgs e)
        {
            change = new ChangePassword(this.teaID); // To send Teacher Id to Change Password Form being load Setting control
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            teacherInfo.Password = confirmPassword.Text;

            if (newPassword.Text != (" ") || confirmPassword.Text!= (" ") && (newPassword.Text == confirmPassword.Text))
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
