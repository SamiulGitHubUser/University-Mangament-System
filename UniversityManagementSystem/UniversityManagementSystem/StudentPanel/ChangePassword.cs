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
using MetroFramework;
using UniversityManagementSystem.AdminPanel;

namespace SmartUniversity.Student
{
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        EntityLayer.StudentInfromation information = new EntityLayer.StudentInfromation();
        StudentOperation operation = new StudentOperation();
        private string stuID;

        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(string p)
        {
            // TODO: Complete member initialization
            this.stuID = p;
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            metroTextBoxUserID.Text = this.stuID;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(metroTextBoxCurPassword.Text) || string.IsNullOrEmpty(metroTextBoxNewPassword.Text) || string.IsNullOrEmpty(metroTextBoxConPassword.Text))
                {
                    MetroMessageBox.Show(this, "You have to fill up all !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    information.StudentID = this.stuID;
                    information.Password = metroTextBoxCurPassword.Text;
                    DataTable table = new DataTable();

                    table = operation.GetCurrentPassword(information);

                    if (table.Rows.Count == 1)
                    {
                        if (metroTextBoxNewPassword.Text == metroTextBoxConPassword.Text)
                        {
                            if(metroTextBoxCurPassword.Text == metroTextBoxNewPassword.Text)
                            {
                                MetroMessageBox.Show(this, "Current Password and new Password is same !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                            else
                            {
                                information.Password = metroTextBoxNewPassword.Text;
                                operation.Change_StudentPassword(information);
                                this.Dispose();
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Password didn't match !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Current Password don't exist !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "" + ex, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void metroLinkClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
