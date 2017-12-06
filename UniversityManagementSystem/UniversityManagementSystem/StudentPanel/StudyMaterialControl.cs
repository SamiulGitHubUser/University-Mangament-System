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
    public partial class StudyMaterialControl : UserControl
    {
        private string stuID;

        public StudyMaterialControl()
        {
            InitializeComponent();
        }

        public StudyMaterialControl(string p)
        {
            // TODO: Complete member initialization
            this.stuID = p;
            InitializeComponent();
        }
    }
}
