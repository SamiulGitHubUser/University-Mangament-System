using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ResultInformation
    {
        public int ID { get; set; }
        public string StudentID { get; set; } 
        public string CourseName { get; set; }
        public string Semester { get; set; }
        public double MidMark { get; set; }
        public double FinalMark { get; set; }
        public string MidGrade { get; set; }
        public string FinalGrade { get; set; }

        public double TotalMark { get; set; }
        public string Grade { get; set; }
        public double CGPA { get; set; }
    }
}
