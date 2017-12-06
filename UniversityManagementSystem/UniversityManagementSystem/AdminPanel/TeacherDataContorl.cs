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
using UniversityManagementSystem.AdminPanel;

namespace UniversityManagementSystem
{
    public partial class TeacherDataContorl : UserControl
    {
        TeacherInformation information = new TeacherInformation();
        TeacherOperation operation = new TeacherOperation();
        string deleteId;

        public TeacherDataContorl()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            TeacherAdd addTeacher = new TeacherAdd();
            addTeacher.ShowDialog();
        }

        private void TeacherDataContorl_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();

                table = operation.View_TeacherTable(information);
                metroGridTeacher.DataSource = table;

                metroGridTeacher.DataSource = table;
            }
            catch
            {
                MetroMessageBox.Show(this, "Error", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void metroGridTeacher_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    deleteId = metroGridTeacher.Rows[e.RowIndex].Cells["TeacherID"].Value.ToString();
                    this.metroContextMenuDelete.Show(this.metroGridTeacher, e.Location);
                    metroContextMenuDelete.Show(Cursor.Position);
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "You Can't deleting Form Here !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                information.TeacherID = deleteId;

                operation.Delete_Record(information);
            }
            catch
            {
                MetroMessageBox.Show(this, "Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            information.FirstName = metroTextBox1.Text;
            Console.WriteLine("" + information.FirstName);
            DataTable table = new DataTable();
            table = operation.SerchTeacher(information);

            metroGridTeacher.DataSource = table;
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            TeacherUpdate updateTeacher = new TeacherUpdate();
            updateTeacher.ShowDialog();
        }
    }
}
