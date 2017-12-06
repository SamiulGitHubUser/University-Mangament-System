using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UniversityManagementSystem.TeacherPanel
{
    public partial class SyllabusControl : UserControl
    {
        string fileNameSrt;

        public SyllabusControl()
        {
            InitializeComponent();
        }

        private void metroLink8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                midFileName.Text = openFileDialog1.FileName;
                File.ReadAllText(midFileName.Text);

            }
        }

        private void SyllabusControl_Load(object sender, EventArgs e)
        {
            midFileName.Text = "File Name : " + saveFileDialog1.FileName;
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                midFileName.Text = openFileDialog1.FileName;
                File.ReadAllText(midFileName.Text);

            }
        }
    }
}
