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
    public partial class NoticeBoardContorl : UserControl
    {
        int deleteId;
        Notice notice = new Notice();
        NoticeOperation noticeOperation = new NoticeOperation();

        public NoticeBoardContorl()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            NoticeAdd addNotice = new NoticeAdd();
            addNotice.ShowDialog();
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            NoticeUpdate updateNotice = new NoticeUpdate();
            updateNotice.ShowDialog();
        }

        private void NoticeBoardContorl_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = noticeOperation.NoticeViewTabel(notice);

            noticeBoardGrid.DataSource = dt;
        }

        private void noticeBoardGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                if (e.Button == MouseButtons.Right)
                {
                    deleteId = Convert.ToInt32(noticeBoardGrid.Rows[e.RowIndex].Cells["NoticeID"].Value.ToString());
                    this.DeleteContextMenu.Show(this.noticeBoardGrid, e.Location);
                    DeleteContextMenu.Show(Cursor.Position);
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "You Can't Click Here!!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }

        }

        private void deleteNoticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notice.NoticeID = deleteId;
            noticeOperation.DeleteNotice_Record(notice);

        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            notice.NoticeTitle = searchBox.Text;

            DataTable table = new DataTable();
            table = noticeOperation.SearchByTitle(notice);

            noticeBoardGrid.DataSource = table;
        }
    }
}
