using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EntityLayer;
using BusinessLayer;
using MetroFramework;

namespace UniversityManagementSystem.AdminPanel
{
    public partial class SettingsControl : UserControl
    {
        AdminInformation adminInfo = new AdminInformation();
        AdminOperation adminOperation = new AdminOperation();
        private string adminID;

        public SettingsControl()
        {
            InitializeComponent();
        }

        public SettingsControl(string Id)
        {
            this.adminID = Id;
            InitializeComponent();
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {

        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            adminInfo.Password = confirmPassword.Text;

            if (newPassword.Text == confirmPassword.Text)
            {
                adminOperation.UpdatePassword(adminInfo);
                MetroMessageBox.Show(this, "Update Successful !!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this, "Password Didn't Match!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
