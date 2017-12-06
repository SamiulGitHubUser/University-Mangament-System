using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;
using MetroFramework;

namespace UniversityManagementSystem.TeacherPanel
{
    public partial class NoticeControl : UserControl
    {
        Notice notice = new Notice();
        NoticeOperation noticeOperation = new NoticeOperation();

        public NoticeControl()
        {
            InitializeComponent();
        }

        private void NoticeControl_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = noticeOperation.NoticeViewTabel(notice);

            metroGrid.DataSource = dt;

            /*
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable table = new DataTable();
                //table = 
                List <DataTable>  list = new List<DataTable>();
                table = noticeOperation.NoticeViewTabel(notice);
                metroGrid.DataSource = table;
                sda.Fill(table);
                metroGrid.Rows.Clear();
                foreach (DataTable item in list)
                {
                    int n = metroGrid.Rows.Add();
                    Console.WriteLine(n);
                    metroGrid.Rows[n].Cells[0].Value = item.ToString();
                    metroGrid.Rows[n].Cells[1].Value = item.ToString();
                    metroGrid.Rows[n].Cells[2].Value = item.ToString();
                    metroGrid.Rows[n].Cells[3].Value = item.ToString();
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Error", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            */
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            notice.NoticeTitle = search.Text;

            DataTable table = new DataTable();
            table = noticeOperation.SearchByTitle(notice);

            metroGrid.DataSource = table;
        }
    }
}
