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

namespace UniversityManagementSystem.AdminPanel
{
    public partial class RegistrationControl : UserControl
    {


        TeacherOperation teacherOperation = new TeacherOperation();
        TeacherInformation teacherInfo = new TeacherInformation();

        StudentInfromation stdInfo = new StudentInfromation();
        StudentOperation studentOperation = new StudentOperation();

        Curriculum curriculum = new Curriculum();
        CurriculumOperation curriculumOperation = new CurriculumOperation();

        Registration reg = new Registration();
        RegistrationOperation regOperation = new RegistrationOperation();

        public RegistrationControl()
        {
            InitializeComponent();
        }

        private void RegistrationControl_Load(object sender, EventArgs e)
        {

            SqlDataReader reader;
            reader = studentOperation.Load_StudentInformation(stdInfo);
            while (reader.Read())
            {
                batchNoComboBox.Items.Add(reader["BatchNo"].ToString());
                deptComboBox.Items.Add(reader["Department"].ToString());
                sectionComboBox.Items.Add(reader["Section"].ToString());
            }

            reader.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
        
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            int semisterNo =calculateSemisterNo();

            SqlDataReader reader;
            reader = curriculumOperation.Load_AllCurriculum(curriculum, semisterNo);

            while (reader.Read())
            {
                semisterNoLabel.Text ="Semister:    "+(reader["SemisterNo"].ToString());
                courseLabel_1.Text = "1.    "+(reader["CourseName_1"].ToString());
                courseLabel_2.Text = "2.    "+(reader["CourseName_2"].ToString());
                courseLabel_3.Text = "3.    "+(reader["CourseName_3"].ToString());
                courseLabel_4.Text = "4.    "+(reader["CourseName_4"].ToString());
            }

            reader.Close();


            //Teacher Name Selection
            reader = teacherOperation.Load_TeacherName(teacherInfo, deptComboBox.Text);
            while (reader.Read())
            {
                TeacherComboBox1.Items.Add(reader["FirstName"].ToString() + " " + reader["LastName"].ToString());
                TeacherComboBox2.Items.Add(reader["FirstName"].ToString() + " " + reader["LastName"].ToString());
                TeacherComboBox3.Items.Add(reader["FirstName"].ToString() + " " + reader["LastName"].ToString());
                TeacherComboBox4.Items.Add(reader["FirstName"].ToString() + " " + reader["LastName"].ToString());

            }

            reader.Close();
        }


        //SemisterNo Calculation:
        private int calculateSemisterNo()
        {
            int semisterNo;

            //Current Semister & Year
            int currentSemisterNo = 0;
            int currentYear = DateTime.Now.Year;
            if (DateTime.Now.Month == 1 || DateTime.Now.Month == 2 || DateTime.Now.Month == 3 || DateTime.Now.Month == 4)
            {
                currentSemisterNo = 1;
            }
            else if (DateTime.Now.Month == 5 || DateTime.Now.Month == 6 || DateTime.Now.Month == 7 || DateTime.Now.Month == 8)
            {
                currentSemisterNo = 2;
            }
            else if (DateTime.Now.Month == 9 || DateTime.Now.Month == 10 || DateTime.Now.Month == 11 || DateTime.Now.Month == 12)
            {
                currentSemisterNo = 3;
            }

            //Previous Semister & Year
            string[] value = batchNoComboBox.Text.Split('-');
            int prevYear = Convert.ToInt32(value[0]);
            int prevSemisterNo = Convert.ToInt32(value[1]);


            //Calcuate SemisterNo
            if ((prevYear == currentYear) && (prevSemisterNo == currentSemisterNo))
            {
                semisterNo = 1;
            }
            else
            {
                semisterNo = (3 * (currentYear - prevYear) + (currentSemisterNo - prevSemisterNo)) + 1;

            }

            return semisterNo;
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            reg.BatchNo = batchNoComboBox.Text;
            reg.Section = sectionComboBox.Text;
            reg.Department = deptComboBox.Text;
            reg.CourseName_1 = courseLabel_1.Text;
            reg.CourseName_2 = courseLabel_2.Text;
            reg.CourseName_3 = courseLabel_3.Text;
            reg.CourseName_4 = courseLabel_4.Text;
            reg.Sehdule = (courseSehdule1.Text +","+ courseSehdule2.Text +","+ courseSehdule3.Text +","+ courseSehdule4.Text);
            reg.TeacherName = (TeacherComboBox1.Text +","+ TeacherComboBox2 +","+ TeacherComboBox3 +","+ TeacherComboBox4);

            int row = regOperation.InsertRegistrationInfo(reg);


        }
    }
}
