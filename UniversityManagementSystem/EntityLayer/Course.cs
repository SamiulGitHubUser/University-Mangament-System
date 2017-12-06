using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string Department { get; set; }
        public string AvailableSection { get; set; }
        public string Pre_Reqsite { get; set; }
        public int CourseCredits { get; set; }
        public int CourseFee { get; set; }
        public string CourseDescription { get; set; }
        public string CourseStatus { get; set; }
        public string CourseProgramme { get; set; }
        

    }
}