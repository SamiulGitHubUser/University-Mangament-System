using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartUniversity.Student
{
    public partial class DahboardContro : UserControl
    {
        private string stuID;

        public DahboardContro()
        {
            InitializeComponent();
        }

        public DahboardContro(string p)
        {
            // TODO: Complete member initialization
            this.stuID = p;
            InitializeComponent();
        }

        private void DahboardControl_Load(object sender, EventArgs e)
        {
            this.chartBar.Series["CGPA"].Points.AddXY("Semister-1", 3.50);
            this.chartBar.Series["CGPA"].Points.AddXY("Semister-2", 3.00);
            this.chartBar.Series["CGPA"].Points.AddXY("Semister-3", 4.00);
        }

        private void chartBar_Click(object sender, EventArgs e)
        {

        }
    }
}
