using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagementSystem.AdminPanel;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace UniversityManagementSystem
{
    
    public partial class AdminDashboard : MetroFramework.Forms.MetroForm
    {
        SpeechSynthesizer sSynth = new SpeechSynthesizer();

        AdminInformation adminInfo = new AdminInformation();
        AdminOperation adminOperation = new AdminOperation();

        private string adminID;
        static int count = 0;

        public AdminDashboard()
        {
            InitializeComponent();
            //sSynth.Speak("Wellcome To, Smart Admin Dashboard.");
        }

        public AdminDashboard(string id)
        {
            this.adminID = id;
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            if(count==0)
            {
                //sSynth.Speak("Sir, it's Your Smart Dashboard.");
                count++;
            }
            //sSynth.Speak("Sir, This is The Login Frame");
            //sSynth.Speak("Please Enter Your User Name and Password ");


            DashBoardControl dashBoardControl = new DashBoardControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(dashBoardControl);

            adminInfo.AdminID = this.adminID;
            SqlDataReader reader;
            reader = adminOperation.Load_AdminProfile(adminInfo);
            


            while (reader.Read())
            {
                UserName.Text = (reader["FirstName"].ToString());/* +" "+ (reader["LastName"].ToString());*/
                LastName.Text = (reader["LastName"].ToString());
                UserEmail.Text = (reader["Email"].ToString());

            }

            reader.Close();;
        }

        private void AdminDashboard_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            StudentControl stdContorl = new StudentControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(stdContorl);
        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            TeacherContorl tecBtnContorl = new TeacherContorl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(tecBtnContorl);
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            DepartmentControl courseButton = new DepartmentControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(courseButton);
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            LibraryControl libraryControl = new LibraryControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(libraryControl);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DashBoardControl dashBoardControl = new DashBoardControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(dashBoardControl);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ParentsControl parentButton = new ParentsControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(parentButton);
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            AccountContorl accountContorl = new AccountContorl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(accountContorl);
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {

            MailBoxControl messageContorl = new MailBoxControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(messageContorl);
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            NoticeBoardContorl noticeContorl = new NoticeBoardContorl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(noticeContorl);
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            CourseControl courseControl = new CourseControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(courseControl);
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            DashBoardControl dashBoardControl = new DashBoardControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(dashBoardControl);
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            StudentControl stdContorl = new StudentControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(stdContorl);
        }

        private void metroLink6_Click(object sender, EventArgs e)
        {
            ParentsControl parentButton = new ParentsControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(parentButton);
        }

        private void metroLink7_Click(object sender, EventArgs e)
        {
            DepartmentControl courseButton = new DepartmentControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(courseButton);
        }

        private void metroLink8_Click(object sender, EventArgs e)
        {
            LibraryControl libraryControl = new LibraryControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(libraryControl);
        }

        private void metroLink9_Click(object sender, EventArgs e)
        {
            AccountContorl accountContorl = new AccountContorl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(accountContorl);
        }

        private void metroLink10_Click(object sender, EventArgs e)
        {
            MailBoxControl messageContorl = new MailBoxControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(messageContorl);
        }

        private void metroLink11_Click(object sender, EventArgs e)
        {
            CourseControl courseControl = new CourseControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(courseControl);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroLink13_Click(object sender, EventArgs e)
        {
            NoticeBoardContorl noticeContorl = new NoticeBoardContorl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(noticeContorl);
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            TeacherContorl tecBtnContorl = new TeacherContorl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(tecBtnContorl);
        }

        private void metroPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrame login = new LoginFrame();
            login.Show();

        }

        private void metroLink14_Click(object sender, EventArgs e)
        {
            RegistrationControl registrationControl = new RegistrationControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(registrationControl);
        }

        //Profile
        private void metroLink2_Click(object sender, EventArgs e)
        {
            ProfileControler profile= new ProfileControler(adminID);
            this.AdminPanel.Controls.Clear();
            this.AdminPanel.Controls.Add(profile);
        }

        private void metroLink12_Click(object sender, EventArgs e)
        {
            SettingsControl settingControl = new SettingsControl(adminID);
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(settingControl);
        }
    }
}
