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

namespace UniversityManagementSystem.TeacherPanel
{
    public partial class ScheduleControl : UserControl
    {
        Registration reg = new Registration();
        RegistrationOperation regOperation = new RegistrationOperation();

        public ScheduleControl()
        {
            InitializeComponent();
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void ScheduleControl_Load(object sender, EventArgs e)
        {
            SqlDataReader reader;
            //int temp = Convert.ToInt32(courseIDComboBox.SelectedItem);

            reader = regOperation.Load_AllRegistration(reg, "2016-17 Spring");

            while (reader.Read())
            {

                metroLabel9.Text = "Course 1: " + (reader["CourseName_1"].ToString());
                metroLabel2.Text = "Course 2: " + (reader["CourseName_2"].ToString());
                metroLabel6.Text = "Course 3: " + (reader["CourseName_3"].ToString());
                metroLabel10.Text = "Course 4: " + (reader["CourseName_4"].ToString());

                string sehdule = (reader["Sehdule"].ToString());
                string[] sehduleSplit = sehdule.Split(',');
                TimeDate1.Text = sehduleSplit[0];
                TimeDate2.Text = sehduleSplit[1];
                TimeDate3.Text = sehduleSplit[2];
                TimeDate4.Text = sehduleSplit[3];

            }

            reader.Close();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader;
            string temp = Convert.ToString(metroComboBox1.SelectedItem);

            reader = regOperation.Load_AllRegistration(reg, temp);

            while (reader.Read())
            {

                metroLabel9.Text= "Course 1 :"+(reader["CourseName_1"].ToString());
                metroLabel2.Text = "Course 2 :" + (reader["CourseName_2"].ToString());
                metroLabel6.Text = "Course 3 :" + (reader["CourseName_3"].ToString());
                metroLabel10.Text = "Course 4 :" + (reader["CourseName_4"].ToString());

                string sehdule = (reader["Sehdule"].ToString());
                string[] sehduleSplit= sehdule.Split(',');
                TimeDate1.Text = sehduleSplit[0];
                TimeDate2.Text = sehduleSplit[1];
                TimeDate3.Text = sehduleSplit[2];
                TimeDate4.Text = sehduleSplit[3];

            }

            reader.Close();
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
