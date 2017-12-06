using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;
using System.Data.SqlClient;
using MetroFramework;

namespace SmartUniversity.Student
{
    public partial class FinancialControl : UserControl
    {
        EntityLayer.FianciaInformation information = new EntityLayer.FianciaInformation();
        FinancialOperation operation = new FinancialOperation();
        EntityLayer.StudentInfromation stuInfo = new EntityLayer.StudentInfromation();
        StudentOperation stuOper = new StudentOperation();
        DateTime time = DateTime.Now;

        private string stuID;

        public FinancialControl()
        {
            InitializeComponent();
        }

        public FinancialControl(string p)
        {
            // TODO: Complete member initialization
            this.stuID = p;
            InitializeComponent();
        }

        private void metroTabPageFinancial_Click(object sender, EventArgs e)
        {

        }

        private void FinancialControl_Load(object sender, EventArgs e)
        {
            string batchNo;
            stuInfo.StudentID = this.stuID;

            SqlDataReader reader;
            reader = stuOper.GetBachNo(stuInfo);

            while (reader.Read())
            {
                batchNo = (reader["BatchNo"].ToString());


                string[] batch = batchNo.Split('-');
                int oldYear = Convert.ToInt16(batch[0]);
                int oldSlot = Convert.ToInt16(batch[1]);

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
                int prevYear = Convert.ToInt32(batch[0]);
                int prevSemisterNo = Convert.ToInt32(batch[1]);


                //Calcuate SemisterNo
                if ((prevYear == currentYear) && (prevSemisterNo == currentSemisterNo))
                {
                    semisterNo = 1;
                }
                else
                {
                    semisterNo = (3 * (currentYear - prevYear) + (currentSemisterNo - prevSemisterNo)) + 1;

                }

                if (semisterNo == 1)
                {
                    metroComboBoxSemester.Items.Add("Semester 1");
                    //metroLabelAdmission.Text = ""
                }
                else if (semisterNo == 2)
                {
                    metroComboBoxSemester.Items.Add("Semester 1");
                    metroComboBoxSemester.Items.Add("Semester 2");
                }
                else if (semisterNo == 2)
                {
                    metroComboBoxSemester.Items.Add("Semester 1");
                    metroComboBoxSemester.Items.Add("Semester 2");
                    metroComboBoxSemester.Items.Add("Semester 2");
                }
                else
                {
                    metroComboBoxSemester.Items.Add("Semester 1");
                    metroComboBoxSemester.Items.Add("Semester 2");
                    metroComboBoxSemester.Items.Add("Semester 2");
                    metroComboBoxSemester.Items.Add("Semester 4");
                }
            }
            
            reader.Close();


            
        }

        private void metroLinkFinancialDetail_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch
            {
                
            }
            
        }

        private void metroComboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(metroComboBoxSemester.SelectedItem.ToString() == "Semester 1")
            {
                metroLabelAdmission.Text = "35000";
                metroLabelTution.Text = "60000";
                metroLabelComputerLab.Text = "2500";
                metroLabelUtility.Text = "3500";
                metroLabelLanguageLab.Text = "2000";
                metroLabelTotal.Text = "105000";
                metroLabelPaid.Text = "105000";
            }
            else
            {
                metroLabelAdmission.Text = "0.0";
                metroLabelTution.Text = "60000";
                metroLabelComputerLab.Text = "2500";
                metroLabelUtility.Text = "3500";
                metroLabelLanguageLab.Text = "2000";
                metroLabelTotal.Text = "70000";
                metroLabelPaid.Text = "70000";
            }

        }
        public int SendSemesterNo(int value)
        {
            int batch = value;

            return value;
        }
    }

}
