using System;
using System.Windows.Forms;
using UniversityManagementSystem.TeacherPanel;
using BusinessLayer;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;
using SmartUniversity.Student;
using UniversityManagementSystem.AdminPanel;
using MetroFramework;
using System.Speech.Synthesis;
//using UniversityManagementSystem.LoginPanel;

namespace UniversityManagementSystem
{
    public partial class LoginFrame : MetroFramework.Forms.MetroForm
    {
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        StudentInfromation stuInformation = new StudentInfromation();
        StudentOperation stuOperation = new StudentOperation();
        TeacherInformation teaInformation = new TeacherInformation();
        TeacherOperation teaOperation = new TeacherOperation();
        AdminInformation adminInformation = new AdminInformation();
        AdminOperation adminOperation = new AdminOperation();


        string stuID;
        string teaID;
        string adminID;
        static int count = 0;

        public LoginFrame()
        {
            InitializeComponent();
            
        }

        private void btnLoggin_Click_1(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();

            stuID = stuInformation.StudentID = userName.Text;
            stuInformation.Password = password.Text;
            teaID = teaInformation.TeacherID = userName.Text;
            teaInformation.Password = password.Text;

            adminID = adminInformation.AdminID = userName.Text;
            adminInformation.Password = password.Text;

            table1 = teaOperation.Check_TeacherTable(teaInformation);
            table2 = stuOperation.Check_StudentTable(stuInformation);
            table3 = adminOperation.Check_AdminTable(adminInformation);

            if (table1.Rows.Count == 1)
            {
                
                TeacherDashboardForm dashboard = new TeacherDashboardForm(teaID); // To sent TeaId to Teacher Dashboard
                dashboard.Show();
                this.Hide();
            }
            else if (table2.Rows.Count == 1)
            {
                StudentDashboard dashboard = new StudentDashboard(stuID); // To send StuId in Student Dashboard
                dashboard.Show();
                this.Hide();
            }
            else if (table3.Rows.Count == 1)
            {
                AdminDashboard dashboard = new AdminDashboard(adminID); // To send StuId in Student Dashboard
                dashboard.Show();
                this.Hide();
            }
            else if (userName.Text == "admin" && password.Text == "admin")
            {
                AdminDashboard dashboard = new AdminDashboard();
                dashboard.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "User Name and Password don't match", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            //HomeForm form = new HomeForm();
            //form.Show();
            this.Close(); 
        }

        private void LoginFrame_Load(object sender, EventArgs e)
        {
            if(count==0)
            {
                //sSynth.Speak("Wellcome To, Smart University System.");
                count++;
            }

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
