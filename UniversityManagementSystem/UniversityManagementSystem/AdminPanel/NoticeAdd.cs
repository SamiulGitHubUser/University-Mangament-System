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

namespace UniversityManagementSystem
{
    public partial class NoticeAdd : MetroFramework.Forms.MetroForm
    {
        Notice notice = new Notice();
        NoticeOperation noticeOperation = new NoticeOperation();

        public NoticeAdd()
        {
            InitializeComponent();
        }

        private void NoticeAdd_Load(object sender, EventArgs e)
        { 
            noticeDateComboBox.Items.Add(Convert.ToString(DateTime.Now));
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            notice.NoticeTitle = noticeTitle.Text;
            notice.DateOfNotice = Convert.ToDateTime( noticeDateComboBox.Text );
            notice.NoticeDescription = noticeDescription.Text;

            int row = noticeOperation.InsertNotice(notice);

            this.Close();

        }

    }
}
