using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartUniversity.Student
{
    public partial class StudentDashboard : MetroFramework.Forms.MetroForm
    {
        public StudentDashboard()
        {
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
            this.metroPanelChanged.Controls.Add(new ResultControl());
        }

        private void metroLinkProfile_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(new ProfileControl());
        }

        private void metroLinkLibrary_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(new LibraryControl());
        }

        private void metroLinkClassRutine_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(new RoutineControl());
        }

        private void metroLinkLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Dispose();
        }

        private void metroLinkFinancial_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(new FinancialControl());
        }

        private void metroLinkMyCarriculam_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(new MyCarriculam());
        }

        private void metroLinkSemesterGrades_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(new SemesterGradesControl());
        }

        private void metroLinkStudyMaterial_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(new StudyMaterialControl());
        }

        private void metroLinkMailBox_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();
            this.metroPanelChanged.Controls.Add(new MailBoxControl());
        }

        private void metroLinkDashboard_Click(object sender, EventArgs e)
        {
            this.metroPanelChanged.Controls.Clear();

            DahboardContro dashboard = new DahboardContro();
            this.metroPanelChanged.Controls.Add(dashboard);
        }

        private void metroPanelChanged_Paint(object sender, PaintEventArgs e)
        {
            DahboardContro dashboard = new DahboardContro();
            this.metroPanelChanged.Controls.Add(dashboard);
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            DahboardContro dashboard = new DahboardContro();
            this.metroPanelChanged.Controls.Add(dashboard);
        }
    }
}
