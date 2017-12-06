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
    public partial class DashBoardControl : UserControl
    {
        public DashBoardControl()
        {
            InitializeComponent();
        }

        private void DashBoardControl_Load(object sender, EventArgs e)
        {

            chartBar.Series["Department"].Points.AddXY("CSE",20);
            chartBar.Series["Department"].Points.AddXY("EEE", 10);
            chartBar.Series["Department"].Points.AddXY("BBA", 50);
            chartBar.Series["Department"].Points.AddXY("LLB", 5);
            chartBar.Series["Department"].Points.AddXY("Eco", 8);
            
            
        }
    }
}
