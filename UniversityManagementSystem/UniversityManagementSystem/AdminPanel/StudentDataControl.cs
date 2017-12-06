using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;
using MetroFramework;

namespace UniversityManagementSystem
{
    
    public partial class StudentDataControl : UserControl
    {
        string deleteId;
        StudentInfromation stdInfo = new StudentInfromation();
        Parents parentInfo = new Parents();
        StudentOperation operation = new StudentOperation();
        ParentOperation parentOperation = new ParentOperation();

        public StudentDataControl()
        {
            InitializeComponent();
        }

        private void DeptPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            stdInfo.FirstName = search.Text;

            DataTable table = new DataTable();
            table = operation.SerchStudent(stdInfo);

            studentInfoGrid.DataSource = table;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            StudentAdd addForm = new StudentAdd();
            addForm.ShowDialog();
        }

        private void metroLink1_Click_1(object sender, EventArgs e)
        {
            StudentUpdate update = new StudentUpdate();
            update.ShowDialog();
        }

        private void StudentDataControl_Load(object sender, EventArgs e)
        { 


                DataTable dt = new DataTable();
                dt = operation.StudentViewTabel(stdInfo);
                studentInfoGrid.DataSource = dt;
 
            
        }

        private void metroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentInfoGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    deleteId = studentInfoGrid.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
                    this.metroContextMenuDelete.Show(this.studentInfoGrid, e.Location);
                    metroContextMenuDelete.Show(Cursor.Position);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "You Can't Press Here For Deleting !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }


        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                stdInfo.StudentID = deleteId;
                parentInfo.StudentID = deleteId;

                operation.Delete_Record(stdInfo);
                parentOperation.DeleteParent_Record(parentInfo);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "" + ex, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

    }
}
