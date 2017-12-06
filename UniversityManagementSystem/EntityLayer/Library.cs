using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EntityLayer
{
    public class Library
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string BookDescription { get; set; }
        public double BookPrice { get; set; }
        public int BookQuantity { get; set; }
        public string Status { get; set; }
    }
}
