using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagementSystem;

namespace SmartUniversity.Student
{
    public delegate void SendStudentID(string s);
    public partial class StudentDashboard : MetroFramework.Forms.MetroForm
    {
        SpeechSynthesizer sSynth = new SpeechSynthesizer();

        ProfileControl profile;
        ResultControl result;
        LibraryControl library;
        RoutineControl routine;
        FinancialControl financial;
        MyCarriculam myCarriculam;
        SemesterGradesControl grade;
        StudyMaterialControl study;
        MailBoxControl mail;
        OptionControl option;
        DahboardContro dashboard1;

        private string stuID;
        static int count = 0;

        public StudentDashboard()
        {
            InitializeComponent();
        }

        public StudentDashboard(string stuID)
        {
            // TODO: Complete member initialization
            this.stuID = stuID;
            InitializeComponent();
        }

        private void metroLabelClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void metroLabelMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void metroLinkResult_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(result);
        }

        //Profile
        private void metroLinkProfile_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(profile); 
        }

        private void metroLinkLibrary_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(library);
        }

        private void metroLinkClassRutine_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(routine);
        }

        private void metroLinkLogout_Click(object sender, EventArgs e)
        {
           new LoginFrame().Show();
            this.Dispose();
        }

        private void metroLinkFinancial_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(financial);
        }

        private void metroLinkMyCarriculam_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(myCarriculam);
        }

        private void metroLinkSemesterGrades_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(grade);
        }

        private void metroLinkStudyMaterial_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(study);
        }

        private void metroLinkMailBox_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(mail);
        }

        private void metroLinkDashboard_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(dashboard1);
        }

        private void metroPanelChanged_Paint(object sender, PaintEventArgs e)
        {
            DahboardContro dashboard = new DahboardContro();
            this.metroPanelChanged.Controls.Add(dashboard);
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            if (count == 0)
            {
                //sSynth.Speak("Sir, it's Your Smart Dashboard.");
                count++;
            }

            profile = new ProfileControl(this.stuID); // Send student ID to Profile Control being load Student dashboard
            option = new OptionControl(this.stuID); // Send student ID to Option Control being load Student dashboard
            mail = new MailBoxControl(this.stuID); // Send student ID to MailBox Control being load Student dashboard
            study = new StudyMaterialControl(this.stuID); // Send student ID to Study Matarial Control being load Student dashboard
            grade = new SemesterGradesControl(this.stuID); // Send student ID to Semester Grade Control being load Student dashboard
            myCarriculam = new MyCarriculam(this.stuID); // Send student ID to MyCariculam Control being load Student dashboard
            financial = new FinancialControl(this.stuID); // Send student ID to Financial Control being load Student dashboard
            routine = new RoutineControl(this.stuID); // Send student ID to Routine Control being load Student dashboard
            library = new LibraryControl(this.stuID); // Send student ID to Library Control being load Student dashboard
            result = new ResultControl(this.stuID); // Send student ID to Result Control being load Student dashboard
            dashboard1 = new DahboardContro(this.stuID);  // Send student ID to Dashboard Control being load Student dashboard

            DahboardContro dashboard = new DahboardContro();
            this.metroPanelChanged.Controls.Add(dashboard);
        }

        private void metroLinkOption_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(option);  
        }
    }
}
