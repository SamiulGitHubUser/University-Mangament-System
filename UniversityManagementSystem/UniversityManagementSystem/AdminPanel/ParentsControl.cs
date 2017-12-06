using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;
using MetroFramework;

namespace UniversityManagementSystem
{
    public partial class ParentsControl : UserControl
    {

        int deleteId;
        public Parents parent = new Parents();
        public ParentOperation parentOperation = new ParentOperation();


        public ParentsControl()
        {
            InitializeComponent();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ParentUpdate parent = new ParentUpdate();
            parent.ShowDialog();
        }

        private void ParentsControl_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = parentOperation.ParentsViewTabel(parent);

            ParentInformationGrid.DataSource = dt;
        }

        private void ParentInformationGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                if (e.Button == MouseButtons.Right)
                {
                    deleteId = Convert.ToInt32(ParentInformationGrid.Rows[e.RowIndex].Cells["ParentID"].Value.ToString());
                    this.DeleteContextMenu.Show(this.ParentInformationGrid, e.Location);
                    DeleteContextMenu.Show(Cursor.Position);
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "You Can't Click Here For Deleting!!", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.ParentID = deleteId;
            parentOperation.DeleteParent_Record(parent);
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            parent.StudentID = searchBox.Text;

            DataTable table = new DataTable();
            table = parentOperation.SearchByStudentID(parent);

            ParentInformationGrid.DataSource = table;
        }
    }
}
