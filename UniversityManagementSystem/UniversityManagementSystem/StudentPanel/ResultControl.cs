using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;
using System.Data.SqlClient;

namespace SmartUniversity.Student
{
    public partial class ResultControl : UserControl
    {
        Registration reg = new Registration();
        RegistrationOperation regOperation = new RegistrationOperation();
        private string stuID;

        public ResultControl()
        {
            InitializeComponent();
        }

        public ResultControl(string p)
        {
            // TODO: Complete member initialization
            this.stuID = p;
            InitializeComponent();
        }

        private void metroComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            SqlDataReader reader;
            //int temp = Convert.ToInt32(courseIDComboBox.SelectedItem);

            reader = regOperation.Load_AllRegistration(reg, "2016-17 Spring");
            string temp;

            while (reader.Read())
            {
               
                temp = reader["CourseName_1"].ToString() + reader["CourseName_2"].ToString() + reader["CourseName_3"].ToString() + reader["CourseName_4"].ToString();
                metroComboBoxCourse.Items.Add(temp);

            }
            reader.Close();
            */
        }

        private void metroComboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader;
            //int temp = Convert.ToInt32(courseIDComboBox.SelectedItem);

            reader = regOperation.Load_AllRegistration(reg, "2016-17 Spring");
            string temp;

            while (reader.Read())
            {

                //temp = reader["CourseName_1"].ToString() + reader["CourseName_2"].ToString() + reader["CourseName_3"].ToString() + reader["CourseName_4"].ToString();
                metroComboBoxCourse.Items.Add(reader["CourseName_1"].ToString());
                metroComboBoxCourse.Items.Add(reader["CourseName_2"].ToString());
                metroComboBoxCourse.Items.Add(reader["CourseName_3"].ToString());
                metroComboBoxCourse.Items.Add(reader["CourseName_4"].ToString());

            }
            reader.Close();
        }
    }
}
