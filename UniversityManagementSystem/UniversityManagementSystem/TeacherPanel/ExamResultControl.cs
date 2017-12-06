using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using EntityLayer;
using MetroFramework;
using System.Data.SqlClient;

namespace SmartUniversity.Teacher
{
    public partial class ExamResultControl : UserControl
    {
        CourseAssignOperation courseAssignOperation = new CourseAssignOperation();
        CourseAssign courseAssignInfo = new CourseAssign();

        StudentInfromation stdInfo = new StudentInfromation();
        StudentOperation stdOperation = new StudentOperation();

        Registration reg = new Registration();
        RegistrationOperation regOperation = new RegistrationOperation();

        ResultInformation information = new ResultInformation();
        ResultOperation operation = new ResultOperation();
        double grade;

        private string tID;


        public ExamResultControl()
        {
            InitializeComponent();
        }

        public ExamResultControl(string id)
        {
            this.tID = id;
            InitializeComponent();
        }

        private void ExamResultControl_Load(object sender, EventArgs e)
        {

            SqlDataReader reader1;
            reader1 = courseAssignOperation.SearchCourseByNameTID(courseAssignInfo, this.tID);
            while (reader1.Read())
            {
                metroComboBoxCourse.Items.Add(reader1["CourseName"].ToString());
            }
            reader1.Close();

            /*

            SqlDataReader reader;
            reader = regOperation.Load_StudentInformation(stdInfo);
            while (reader.Read())
            {
                batchNoComboBox.Items.Add(reader["BatchNo"].ToString());
                deptComboBox.Items.Add(reader["Department"].ToString());
                sectionComboBox.Items.Add(reader["Section"].ToString());
            }

            reader.Close();


            */

            try
            {
            SqlDataReader reader;

                // To load StudentId 
                reader = operation.Load_StudentID(information);

                while (reader.Read())
                {
                    information.StudentID = Convert.ToString(metroComboBoxStudentID.Items.Add(reader["StudentID"].ToString()));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "" + ex, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void metroLinkAdd_Click(object sender, EventArgs e)
        {
            string id = metroComboBoxStudentID.SelectedItem.ToString();
            string courseName = metroComboBoxCourse.SelectedItem.ToString();

            information.MidMark = CalculateMid();
            metroLabelMidMarks.Text = Convert.ToString(CalculateMid());

            operation.UpdateMidResult(information, id ,courseName);
        }
        private double CalculateMid()
        {
            double midFinal;
            double atten = Convert.ToDouble(metroTextBoxAttendence.Text);
            double perf = Convert.ToDouble(metroTextBoxPerformence.Text);
            double quiz1 = Convert.ToDouble(metroTextBoxQuiz1.Text);
            double quiz2 = Convert.ToDouble(metroTextBoxQuiz2.Text);
            double mid = Convert.ToDouble(metroTextBoxMid.Text);

            if ((atten >= 0 && atten <= 10) || (perf >= 0 && perf <= 10) && (quiz1 >= 0 && quiz1 <= 20) && (quiz1 >= 0 && quiz1 <= 20) && (mid >= 0 && mid <= 40))
            {
                midFinal = atten + perf + quiz1 + quiz2 + mid;
                midFinal = (midFinal * .4 );

                return midFinal;
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong input.\nMark Range : \n10 <= Attendence >= 0, 10 <= Performence >= 0 20 <= Quiz >= 0 , 40 <= Mid >= 0", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);

                return 0.0;
            }

        }

        private double CalculateFinal()
        {
            double midFinal;
            double atten = Convert.ToDouble(metroTextBoxAttendence2.Text);
            double perf = Convert.ToDouble(metroTextBoxPerformence2.Text);
            double quiz1 = Convert.ToDouble(metroTextBoxQuiz3.Text);
            double quiz2 = Convert.ToDouble(metroTextBoxQuiz4.Text);
            double mid = Convert.ToDouble(metroTextBoxWritten2.Text);

            if ((atten >= 0 && atten <= 10) || (perf >= 0 && perf <= 10) && (quiz1 >= 0 && quiz1 <= 20) && (quiz1 >= 0 && quiz1 <= 20) && (mid >= 0 && mid <= 40))
            {
                midFinal = atten + perf + quiz1 + quiz2 + mid;
                midFinal = (midFinal * .6);

                return midFinal;
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong input.\nMark Range : \n10 <= Attendence >= 0, 10 <= Performence >= 0 20 <= Quiz >= 0 , 40 <= Mid >= 0", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);

                return 0.0;
            }

        }

        private double CalculateCGPA()
        {
            double CGPA;
            if(information.TotalMark >= 90 && information.TotalMark <= 100)
            {
                CGPA = 4.00;
            }
            else if (information.TotalMark >= 80 && information.TotalMark <= 89)
            {
                CGPA = 3.50;
            }
            else if (information.TotalMark >= 70 && information.TotalMark <= 79)
            {
                CGPA = 3.00;
            }
            else if (information.TotalMark >= 60 && information.TotalMark <= 69)
            {
                CGPA = 2.50;
            }
            else if (information.TotalMark >= 50 && information.TotalMark <= 59)
            {
                CGPA = 2.00;
            }
            else if (information.TotalMark >= 40 && information.TotalMark <= 49)
            {
                CGPA = 1.50;
            }
            else if (information.TotalMark >= 30 && information.TotalMark <= 39)
            {
                CGPA = 1.00;
            }
            else if (information.TotalMark >= 20 && information.TotalMark <= 29)
            {
                CGPA = 1.00;
            }
            else
            {
                CGPA = 0.0;
            }

            return CGPA;
        }

        private void metroLinkFinalResult_Click(object sender, EventArgs e)
        {
            try
            {
                information.StudentID = metroComboBoxStudentID.SelectedItem.ToString();

                SqlDataReader reader;
                reader = operation.Load_GetMidResult(information);

                while (reader.Read())
                {
                     information.MidMark = Convert.ToDouble((reader["MidMark"].ToString()));
                }
                reader.Close();

                if (metroLabelMidMarks.Text != "null")
                {
                    information.FinalMark = CalculateFinal() ;
                    information.TotalMark = information.MidMark + information.FinalMark;
                    information.CGPA = CalculateCGPA();
                    operation.Update_FinalMark(information);

                    metroLabelFinalMarks.Text = Convert.ToString(information.FinalMark);
                    metroLabelCGPA.Text = Convert.ToString(information.CGPA);
                }
                else
                {
                    MetroMessageBox.Show(this, "Mid Result Upload first !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "" + ex, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void metroComboBoxStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            information.StudentID = metroComboBoxStudentID.SelectedItem.ToString();
            SqlDataReader reader;
            reader = operation.Load_GetMidResult(information);

            while (reader.Read())
            {
                metroLabelMidMarks.Text = (reader["MidMark"].ToString());
            }
            reader.Close();

            reader = operation.Load_GetFinalResult(information);

            while (reader.Read())
            {
                metroLabelFinal.Text = (reader["FinalMark"].ToString());
            }
            reader.Close();
            */
        }

        private void metroComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader;
            string temp = Convert.ToString(metroComboBoxCourse.SelectedItem);

            reader = courseAssignOperation.GetStudent(temp);

            while (reader.Read())
            {
                metroComboBoxStudentID.Items.Add(reader["StudentID"].ToString());
            }

            reader.Close();
            
        }
    }
}
