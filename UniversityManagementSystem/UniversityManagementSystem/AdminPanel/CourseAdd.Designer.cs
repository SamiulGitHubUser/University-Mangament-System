namespace UniversityManagementSystem
{
    partial class CourseAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseAdd));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.addmissionTab = new MetroFramework.Controls.MetroTabControl();
            this.ParentTab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.courseStatus = new MetroFramework.Controls.MetroComboBox();
            this.courseDept = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.courseCredits = new MetroFramework.Controls.MetroComboBox();
            this.courseFee = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.courseDesc = new MetroFramework.Controls.MetroTextBox();
            this.availableSection = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.pre_Reqsite = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.courseName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.courseProgrammeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.addmissionTab.SuspendLayout();
            this.ParentTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(6, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(156, 25);
            this.metroLabel1.TabIndex = 61;
            this.metroLabel1.Text = "Course Detalis Add";
            // 
            // addmissionTab
            // 
            this.addmissionTab.Controls.Add(this.ParentTab);
            this.addmissionTab.Location = new System.Drawing.Point(126, 43);
            this.addmissionTab.Name = "addmissionTab";
            this.addmissionTab.SelectedIndex = 0;
            this.addmissionTab.Size = new System.Drawing.Size(824, 423);
            this.addmissionTab.Style = MetroFramework.MetroColorStyle.Green;
            this.addmissionTab.TabIndex = 62;
            this.addmissionTab.UseSelectable = true;
            // 
            // ParentTab
            // 
            this.ParentTab.Controls.Add(this.courseProgrammeComboBox);
            this.ParentTab.Controls.Add(this.metroLabel5);
            this.ParentTab.Controls.Add(this.metroLabel4);
            this.ParentTab.Controls.Add(this.courseStatus);
            this.ParentTab.Controls.Add(this.courseDept);
            this.ParentTab.Controls.Add(this.metroLabel3);
            this.ParentTab.Controls.Add(this.label1);
            this.ParentTab.Controls.Add(this.courseCredits);
            this.ParentTab.Controls.Add(this.courseFee);
            this.ParentTab.Controls.Add(this.metroLabel2);
            this.ParentTab.Controls.Add(this.metroButton1);
            this.ParentTab.Controls.Add(this.metroLabel17);
            this.ParentTab.Controls.Add(this.courseDesc);
            this.ParentTab.Controls.Add(this.availableSection);
            this.ParentTab.Controls.Add(this.metroLabel22);
            this.ParentTab.Controls.Add(this.metroLabel15);
            this.ParentTab.Controls.Add(this.pre_Reqsite);
            this.ParentTab.Controls.Add(this.metroLabel18);
            this.ParentTab.Controls.Add(this.courseName);
            this.ParentTab.Controls.Add(this.metroLabel19);
            this.ParentTab.HorizontalScrollbarBarColor = true;
            this.ParentTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ParentTab.HorizontalScrollbarSize = 10;
            this.ParentTab.Location = new System.Drawing.Point(4, 38);
            this.ParentTab.Name = "ParentTab";
            this.ParentTab.Size = new System.Drawing.Size(816, 381);
            this.ParentTab.TabIndex = 1;
            this.ParentTab.Text = "&Genaral";
            this.ParentTab.VerticalScrollbarBarColor = true;
            this.ParentTab.VerticalScrollbarHighlightOnWheel = false;
            this.ParentTab.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(457, 309);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 15);
            this.metroLabel4.TabIndex = 71;
            this.metroLabel4.Text = "Course Status :";
            // 
            // courseStatus
            // 
            this.courseStatus.FormattingEnabled = true;
            this.courseStatus.ItemHeight = 23;
            this.courseStatus.Items.AddRange(new object[] {
            "open",
            "close",
            "upcoming"});
            this.courseStatus.Location = new System.Drawing.Point(457, 327);
            this.courseStatus.Name = "courseStatus";
            this.courseStatus.Size = new System.Drawing.Size(192, 29);
            this.courseStatus.TabIndex = 70;
            this.courseStatus.UseSelectable = true;
            // 
            // courseDept
            // 
            this.courseDept.FormattingEnabled = true;
            this.courseDept.ItemHeight = 23;
            this.courseDept.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "BBA",
            "LLB",
            "English",
            "Economics",
            "Architecture"});
            this.courseDept.Location = new System.Drawing.Point(457, 264);
            this.courseDept.Name = "courseDept";
            this.courseDept.Size = new System.Drawing.Size(310, 29);
            this.courseDept.TabIndex = 69;
            this.courseDept.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(457, 237);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(123, 15);
            this.metroLabel3.TabIndex = 68;
            this.metroLabel3.Text = "Course Department :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Course Details Information";
            // 
            // courseCredits
            // 
            this.courseCredits.FormattingEnabled = true;
            this.courseCredits.ItemHeight = 23;
            this.courseCredits.Items.AddRange(new object[] {
            "1",
            "3"});
            this.courseCredits.Location = new System.Drawing.Point(457, 84);
            this.courseCredits.Name = "courseCredits";
            this.courseCredits.Size = new System.Drawing.Size(310, 29);
            this.courseCredits.TabIndex = 66;
            this.courseCredits.UseSelectable = true;
            // 
            // courseFee
            // 
            // 
            // 
            // 
            this.courseFee.CustomButton.Image = null;
            this.courseFee.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.courseFee.CustomButton.Name = "";
            this.courseFee.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.courseFee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.courseFee.CustomButton.TabIndex = 1;
            this.courseFee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.courseFee.CustomButton.UseSelectable = true;
            this.courseFee.CustomButton.Visible = false;
            this.courseFee.Lines = new string[0];
            this.courseFee.Location = new System.Drawing.Point(457, 137);
            this.courseFee.MaxLength = 32767;
            this.courseFee.Name = "courseFee";
            this.courseFee.PasswordChar = '\0';
            this.courseFee.PromptText = "Course Fee";
            this.courseFee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.courseFee.SelectedText = "";
            this.courseFee.SelectionLength = 0;
            this.courseFee.SelectionStart = 0;
            this.courseFee.ShortcutsEnabled = true;
            this.courseFee.Size = new System.Drawing.Size(310, 29);
            this.courseFee.TabIndex = 65;
            this.courseFee.UseSelectable = true;
            this.courseFee.WaterMark = "Course Fee";
            this.courseFee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.courseFee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(457, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 15);
            this.metroLabel2.TabIndex = 64;
            this.metroLabel2.Text = "Course Fee :";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(668, 327);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(99, 25);
            this.metroButton1.TabIndex = 49;
            this.metroButton1.Text = "Add";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.Location = new System.Drawing.Point(32, 264);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(118, 15);
            this.metroLabel17.TabIndex = 35;
            this.metroLabel17.Text = "Course Description :";
            // 
            // courseDesc
            // 
            // 
            // 
            // 
            this.courseDesc.CustomButton.Image = null;
            this.courseDesc.CustomButton.Location = new System.Drawing.Point(238, 2);
            this.courseDesc.CustomButton.Name = "";
            this.courseDesc.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.courseDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.courseDesc.CustomButton.TabIndex = 1;
            this.courseDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.courseDesc.CustomButton.UseSelectable = true;
            this.courseDesc.CustomButton.Visible = false;
            this.courseDesc.Lines = new string[0];
            this.courseDesc.Location = new System.Drawing.Point(32, 282);
            this.courseDesc.MaxLength = 32767;
            this.courseDesc.Multiline = true;
            this.courseDesc.Name = "courseDesc";
            this.courseDesc.PasswordChar = '\0';
            this.courseDesc.PromptText = "Short Description";
            this.courseDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.courseDesc.SelectedText = "";
            this.courseDesc.SelectionLength = 0;
            this.courseDesc.SelectionStart = 0;
            this.courseDesc.ShortcutsEnabled = true;
            this.courseDesc.Size = new System.Drawing.Size(310, 74);
            this.courseDesc.TabIndex = 34;
            this.courseDesc.UseSelectable = true;
            this.courseDesc.WaterMark = "Short Description";
            this.courseDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.courseDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // availableSection
            // 
            // 
            // 
            // 
            this.availableSection.CustomButton.Image = null;
            this.availableSection.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.availableSection.CustomButton.Name = "";
            this.availableSection.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.availableSection.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.availableSection.CustomButton.TabIndex = 1;
            this.availableSection.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.availableSection.CustomButton.UseSelectable = true;
            this.availableSection.CustomButton.Visible = false;
            this.availableSection.Lines = new string[0];
            this.availableSection.Location = new System.Drawing.Point(457, 196);
            this.availableSection.MaxLength = 32767;
            this.availableSection.Name = "availableSection";
            this.availableSection.PasswordChar = '\0';
            this.availableSection.PromptText = "Available Section:";
            this.availableSection.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.availableSection.SelectedText = "";
            this.availableSection.SelectionLength = 0;
            this.availableSection.SelectionStart = 0;
            this.availableSection.ShortcutsEnabled = true;
            this.availableSection.Size = new System.Drawing.Size(310, 29);
            this.availableSection.TabIndex = 33;
            this.availableSection.UseSelectable = true;
            this.availableSection.WaterMark = "Available Section:";
            this.availableSection.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.availableSection.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel22.Location = new System.Drawing.Point(457, 178);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(108, 15);
            this.metroLabel22.TabIndex = 32;
            this.metroLabel22.Text = "Available Section :";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(457, 66);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(93, 15);
            this.metroLabel15.TabIndex = 29;
            this.metroLabel15.Text = "Course Credits :";
            // 
            // pre_Reqsite
            // 
            // 
            // 
            // 
            this.pre_Reqsite.CustomButton.Image = null;
            this.pre_Reqsite.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.pre_Reqsite.CustomButton.Name = "";
            this.pre_Reqsite.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.pre_Reqsite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pre_Reqsite.CustomButton.TabIndex = 1;
            this.pre_Reqsite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pre_Reqsite.CustomButton.UseSelectable = true;
            this.pre_Reqsite.CustomButton.Visible = false;
            this.pre_Reqsite.Lines = new string[0];
            this.pre_Reqsite.Location = new System.Drawing.Point(32, 228);
            this.pre_Reqsite.MaxLength = 32767;
            this.pre_Reqsite.Name = "pre_Reqsite";
            this.pre_Reqsite.PasswordChar = '\0';
            this.pre_Reqsite.PromptText = "Pre-Reqsite :";
            this.pre_Reqsite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pre_Reqsite.SelectedText = "";
            this.pre_Reqsite.SelectionLength = 0;
            this.pre_Reqsite.SelectionStart = 0;
            this.pre_Reqsite.ShortcutsEnabled = true;
            this.pre_Reqsite.Size = new System.Drawing.Size(310, 29);
            this.pre_Reqsite.TabIndex = 25;
            this.pre_Reqsite.UseSelectable = true;
            this.pre_Reqsite.WaterMark = "Pre-Reqsite :";
            this.pre_Reqsite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pre_Reqsite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel18.Location = new System.Drawing.Point(32, 210);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(79, 15);
            this.metroLabel18.TabIndex = 24;
            this.metroLabel18.Text = "Pre-Reqsite :";
            // 
            // courseName
            // 
            // 
            // 
            // 
            this.courseName.CustomButton.Image = null;
            this.courseName.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.courseName.CustomButton.Name = "";
            this.courseName.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.courseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.courseName.CustomButton.TabIndex = 1;
            this.courseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.courseName.CustomButton.UseSelectable = true;
            this.courseName.CustomButton.Visible = false;
            this.courseName.Lines = new string[0];
            this.courseName.Location = new System.Drawing.Point(32, 84);
            this.courseName.MaxLength = 32767;
            this.courseName.Multiline = true;
            this.courseName.Name = "courseName";
            this.courseName.PasswordChar = '\0';
            this.courseName.PromptText = "Course Name";
            this.courseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.courseName.SelectedText = "";
            this.courseName.SelectionLength = 0;
            this.courseName.SelectionStart = 0;
            this.courseName.ShortcutsEnabled = true;
            this.courseName.Size = new System.Drawing.Size(310, 61);
            this.courseName.TabIndex = 23;
            this.courseName.UseSelectable = true;
            this.courseName.WaterMark = "Course Name";
            this.courseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.courseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel19.Location = new System.Drawing.Point(32, 66);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(87, 15);
            this.metroLabel19.TabIndex = 22;
            this.metroLabel19.Text = "Course Name :";
            // 
            // metroLink1
            // 
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 25;
            this.metroLink1.Location = new System.Drawing.Point(108, 0);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(41, 31);
            this.metroLink1.TabIndex = 52;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLink1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(814, 6);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(149, 31);
            this.metroPanel1.TabIndex = 64;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(32, 151);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(120, 15);
            this.metroLabel5.TabIndex = 72;
            this.metroLabel5.Text = "Course Programme :";
            // 
            // courseProgrammeComboBox
            // 
            this.courseProgrammeComboBox.FormattingEnabled = true;
            this.courseProgrammeComboBox.ItemHeight = 23;
            this.courseProgrammeComboBox.Items.AddRange(new object[] {
            "Graduate",
            "Undergraduate"});
            this.courseProgrammeComboBox.Location = new System.Drawing.Point(32, 169);
            this.courseProgrammeComboBox.Name = "courseProgrammeComboBox";
            this.courseProgrammeComboBox.Size = new System.Drawing.Size(310, 29);
            this.courseProgrammeComboBox.TabIndex = 73;
            this.courseProgrammeComboBox.UseSelectable = true;
            // 
            // CourseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 473);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.addmissionTab);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CourseAdd";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.CourseAdd_Load);
            this.addmissionTab.ResumeLayout(false);
            this.ParentTab.ResumeLayout(false);
            this.ParentTab.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl addmissionTab;
        private MetroFramework.Controls.MetroTabPage ParentTab;
        private MetroFramework.Controls.MetroComboBox courseCredits;
        private MetroFramework.Controls.MetroTextBox courseFee;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox courseDesc;
        private MetroFramework.Controls.MetroTextBox availableSection;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox pre_Reqsite;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox courseName;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox courseDept;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox courseStatus;
        private MetroFramework.Controls.MetroComboBox courseProgrammeComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}