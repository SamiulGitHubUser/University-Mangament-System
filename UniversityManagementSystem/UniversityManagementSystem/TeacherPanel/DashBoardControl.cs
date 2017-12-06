using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem.TeacherPanel
{
    public partial class DashBoardControl : UserControl
    {
        public DashBoardControl()
        {
            InitializeComponent();
        }

        private void DashBoardControl_Load(object sender, EventArgs e)
        {
            this.chartBar.Series["Result"].Points.AddXY("C++", 50);
            this.chartBar.Series["Result"].Points.AddXY("Data Structure", 70);
            this.chartBar.Series["Result"].Points.AddXY("Algorithm", 60);
            this.chartBar.Series["Result"].Points.AddXY("C", 95);
        }
    }
}
