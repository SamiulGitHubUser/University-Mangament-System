using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Notice
    {
        public int NoticeID { get; set; }
        public string NoticeTitle { get; set; }
        public DateTime DateOfNotice { get; set; }
        public string NoticeDescription { get; set; }
    }
}
