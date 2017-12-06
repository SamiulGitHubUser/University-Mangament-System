using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class TeacherContorl : UserControl
    {
        TeacherDataContorl t_DataContorl = new TeacherDataContorl();

        public TeacherContorl()
        {
            InitializeComponent();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(t_DataContorl);
            t_DataContorl.deptTitle.Text = "School of Engineering";
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(t_DataContorl);
            t_DataContorl.deptTitle.Text = "School of Arts Facalty";
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(t_DataContorl);
            t_DataContorl.deptTitle.Text = "School of Mathematics";
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(t_DataContorl);
            t_DataContorl.deptTitle.Text = "School of Science Facalty";
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(t_DataContorl);
            t_DataContorl.deptTitle.Text = "School of Architecture Facalty";
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(t_DataContorl);
            t_DataContorl.deptTitle.Text = "School of Business Administration";
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(t_DataContorl);
            t_DataContorl.deptTitle.Text = "School of Natural Science";
        }
    }
}
