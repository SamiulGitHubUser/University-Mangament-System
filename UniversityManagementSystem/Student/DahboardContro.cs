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
        public DahboardContro()
        {
            InitializeComponent();
        }

        private void DahboardControl_Load(object sender, EventArgs e)
        {
            this.chartBar.Series["Convocation"].Points.AddXY("2009", 350);
            this.chartBar.Series["Convocation"].Points.AddXY("2010", 700);
            this.chartBar.Series["Convocation"].Points.AddXY("2011", 1200);
            this.chartBar.Series["Convocation"].Points.AddXY("2012", 2000);
            this.chartBar.Series["Convocation"].Points.AddXY("2013", 2200);
            this.chartBar.Series["Convocation"].Points.AddXY("2014", 2500);
            this.chartBar.Series["Convocation"].Points.AddXY("2015", 3150);
            this.chartBar.Series["Convocation"].Points.AddXY("2016", 3350);
        }
    }
}
