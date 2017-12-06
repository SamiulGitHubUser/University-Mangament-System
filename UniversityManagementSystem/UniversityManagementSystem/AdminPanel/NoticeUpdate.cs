using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace UniversityManagementSystem
{
    public partial class NoticeUpdate : MetroFramework.Forms.MetroForm
    {
        Notice notice = new Notice();
        NoticeOperation noticeOperation = new NoticeOperation();

        public NoticeUpdate()
        {
            InitializeComponent();
        }

        private void NoticeUpdate_Load(object sender, EventArgs e)
        {
            SqlDataReader reader;
            reader = noticeOperation.Load_CourseID(notice);
            while (reader.Read())
            {
                noticeIDComboBox.Items.Add(reader["NoticeID"].ToString());
            }
            reader.Close();

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader;
            int temp = Convert.ToInt32(noticeIDComboBox.SelectedItem);

            reader = noticeOperation.Load_AllCourses(notice, temp);

            while (reader.Read())
            {
                noticeTitle.Text = (reader["NoticeTitle"].ToString());
                noticeDateComboBox.Items.Add(Convert.ToString(DateTime.Now));
                noticeDescription.Text = (reader["NoticeDescription"].ToString());

            }

            reader.Close();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            notice.NoticeID = Convert.ToInt16( noticeIDComboBox.Text );
            notice.NoticeTitle = noticeTitle.Text;
            notice.DateOfNotice = Convert.ToDateTime(noticeDateComboBox.Text);
            notice.NoticeDescription = noticeDescription.Text;

            noticeOperation.UpdateNotice(notice);

            this.Close();
        }

    }
}
