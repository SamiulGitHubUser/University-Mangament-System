using BusinessLayer;
using EntityLayer;
using SmartUniversity.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem.TeacherPanel
{
    public partial class TeacherDashboardForm : MetroFramework.Forms.MetroForm
    {
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        TeacherInformation teacherInfo = new TeacherInformation();
        TeacherOperation teacherOperation = new TeacherOperation();

        ProfileControl profile;
        SettingControl setting;
        static int count = 0;

        private string teaID;

        public TeacherDashboardForm()
        {
            InitializeComponent();
        }

        public TeacherDashboardForm(string teaID)
        {
            this.teaID = teaID;
            InitializeComponent();
        }

        private void TeacherDashboardForm_Load(object sender, EventArgs e)
        {
            if(count==0)
            {
                //sSynth.Speak("Sir, it's Your Smart Dashboard.");
            }

            profile = new ProfileControl(this.teaID);
            setting = new SettingControl(this.teaID);

            DashBoardControl dashBoardControl = new DashBoardControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(dashBoardControl);

            teacherInfo.TeacherID = this.teaID;
            SqlDataReader reader;
            reader = teacherOperation.Load_TeacherProfile(teacherInfo);

            while (reader.Read())
            {
                FirstName.Text = (reader["FirstName"].ToString());/* +" "+ (reader["LastName"].ToString());*/
                label3.Text = (reader["LastName"].ToString());
                label2.Text = (reader["Email"].ToString());

            }

            reader.Close();

        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            StudentUnderTacher stdContorl = new StudentUnderTacher();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(stdContorl);
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            ScheduleControl scheduleContorl = new ScheduleControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(scheduleContorl);
        }

        private void metroLink6_Click(object sender, EventArgs e)
        {

            AttendanceControl attendanceControl = new AttendanceControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(attendanceControl);
        }

        private void metroLink7_Click(object sender, EventArgs e)
        {

            SyllabusControl syllabusControl = new SyllabusControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(syllabusControl);
        }

        private void metroLink8_Click(object sender, EventArgs e)
        {
            LibraryControl libraryControl = new LibraryControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(libraryControl);
        }

        private void metroLink9_Click(object sender, EventArgs e)
        {
            ExamResultControl resultControl = new ExamResultControl(this.teaID);
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(resultControl);
        }

        private void metroLink10_Click(object sender, EventArgs e)
        {

            MailControl mailControl = new MailControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(mailControl);
        }

        private void metroLink11_Click(object sender, EventArgs e)
        {
            UploadControl uploadControl = new UploadControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(uploadControl);
        }

        private void metroLink13_Click(object sender, EventArgs e)
        {

            NoticeControl noticeControl = new NoticeControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(noticeControl);
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            DashBoardControl dashBoardControl = new DashBoardControl();
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(dashBoardControl);
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            this.AdminPanel.Controls.Clear();
            this.AdminPanel.Controls.Add(profile);
        }

        private void metroLink12_Click(object sender, EventArgs e)
        {
            this.AdminPanel.Controls.Clear();
            this.AdminPanel.Controls.Add(setting);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrame login = new LoginFrame();
            login.Show();
        }
    }
}
