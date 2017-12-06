namespace UniversityManagementSystem.TeacherPanel
{
    partial class ScheduleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleControl));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.TimeDate4 = new MetroFramework.Controls.MetroLabel();
            this.TimeDate3 = new MetroFramework.Controls.MetroLabel();
            this.TimeDate2 = new MetroFramework.Controls.MetroLabel();
            this.TimeDate1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.deptTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.AllowDrop = true;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(31, 75);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1062, 535);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 67;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel14);
            this.metroTabPage1.Controls.Add(this.metroComboBox1);
            this.metroTabPage1.Controls.Add(this.metroLabel13);
            this.metroTabPage1.Controls.Add(this.monthCalendar1);
            this.metroTabPage1.Controls.Add(this.metroTabControl2);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1054, 493);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Schedule";
            this.metroTabPage1.UseStyleColors = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(10, 74);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(102, 19);
            this.metroLabel14.TabIndex = 144;
            this.metroLabel14.Text = "&Choice Session:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "2016-17 Spring",
            "2016-17 Fall",
            "2016-17 Summer"});
            this.metroComboBox1.Location = new System.Drawing.Point(10, 95);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(227, 29);
            this.metroComboBox1.TabIndex = 143;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(80, 288);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(55, 15);
            this.metroLabel13.TabIndex = 142;
            this.metroLabel13.Text = "Calander";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(10, 312);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 119;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage2);
            this.metroTabControl2.Location = new System.Drawing.Point(249, 36);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(793, 438);
            this.metroTabControl2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl2.TabIndex = 118;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.AutoScroll = true;
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.TimeDate4);
            this.metroTabPage2.Controls.Add(this.TimeDate3);
            this.metroTabPage2.Controls.Add(this.TimeDate2);
            this.metroTabPage2.Controls.Add(this.TimeDate1);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.HorizontalScrollbar = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(785, 396);
            this.metroTabPage2.TabIndex = 0;
            this.metroTabPage2.Text = "Description";
            this.metroTabPage2.VerticalScrollbar = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(73, 279);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(58, 15);
            this.metroLabel10.TabIndex = 156;
            this.metroLabel10.Text = "Course 4:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(73, 233);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 15);
            this.metroLabel6.TabIndex = 155;
            this.metroLabel6.Text = "Course 3:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(73, 183);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 15);
            this.metroLabel2.TabIndex = 154;
            this.metroLabel2.Text = "Course 2:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(73, 137);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 15);
            this.metroLabel9.TabIndex = 110;
            this.metroLabel9.Text = "Course 1:";
            // 
            // TimeDate4
            // 
            this.TimeDate4.AutoSize = true;
            this.TimeDate4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TimeDate4.Location = new System.Drawing.Point(437, 271);
            this.TimeDate4.Name = "TimeDate4";
            this.TimeDate4.Size = new System.Drawing.Size(103, 19);
            this.TimeDate4.TabIndex = 153;
            this.TimeDate4.Text = "[ Time && Days ]";
            // 
            // TimeDate3
            // 
            this.TimeDate3.AutoSize = true;
            this.TimeDate3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TimeDate3.Location = new System.Drawing.Point(437, 225);
            this.TimeDate3.Name = "TimeDate3";
            this.TimeDate3.Size = new System.Drawing.Size(103, 19);
            this.TimeDate3.TabIndex = 152;
            this.TimeDate3.Text = "[ Time && Days ]";
            // 
            // TimeDate2
            // 
            this.TimeDate2.AutoSize = true;
            this.TimeDate2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TimeDate2.Location = new System.Drawing.Point(437, 179);
            this.TimeDate2.Name = "TimeDate2";
            this.TimeDate2.Size = new System.Drawing.Size(103, 19);
            this.TimeDate2.TabIndex = 151;
            this.TimeDate2.Text = "[ Time && Days ]";
            // 
            // TimeDate1
            // 
            this.TimeDate1.AutoSize = true;
            this.TimeDate1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TimeDate1.Location = new System.Drawing.Point(437, 133);
            this.TimeDate1.Name = "TimeDate1";
            this.TimeDate1.Size = new System.Drawing.Size(103, 19);
            this.TimeDate1.TabIndex = 150;
            this.TimeDate1.Text = "[ Time && Days ]";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(437, 69);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(160, 25);
            this.metroLabel7.TabIndex = 147;
            this.metroLabel7.Text = "Time Day && Room :";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(73, 69);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(132, 25);
            this.metroLabel8.TabIndex = 137;
            this.metroLabel8.Text = "Courses Name :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(12, 19);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(131, 25);
            this.metroLabel5.TabIndex = 117;
            this.metroLabel5.Text = "Weakly Sehdule";
            // 
            // deptTitle
            // 
            this.deptTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deptTitle.AutoSize = true;
            this.deptTitle.ForeColor = System.Drawing.Color.Green;
            this.deptTitle.Location = new System.Drawing.Point(463, 57);
            this.deptTitle.Name = "deptTitle";
            this.deptTitle.Size = new System.Drawing.Size(141, 19);
            this.deptTitle.TabIndex = 66;
            this.deptTitle.Text = "Daily Schedule Control";
            this.deptTitle.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Green;
            this.metroLabel1.Location = new System.Drawing.Point(508, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 64;
            this.metroLabel1.Text = "Schedule";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Green;
            this.metroLabel4.Location = new System.Drawing.Point(882, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(113, 19);
            this.metroLabel4.TabIndex = 65;
            this.metroLabel4.Text = "Manage Schedule";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Green;
            this.metroLabel3.Location = new System.Drawing.Point(147, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(171, 19);
            this.metroLabel3.TabIndex = 63;
            this.metroLabel3.Text = "Running Session : 2016-2017";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.BackColor = System.Drawing.Color.Green;
            this.metroTextBox1.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseCompatibleTextRendering = true;
            this.metroTextBox1.CustomButton.UseCustomBackColor = true;
            this.metroTextBox1.CustomButton.UseCustomForeColor = true;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.UseStyleColors = true;
            this.metroTextBox1.CustomButton.UseVisualStyleBackColor = true;
            this.metroTextBox1.DisplayIcon = true;
            this.metroTextBox1.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox1.Icon")));
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(891, 82);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Search";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.ShowButton = true;
            this.metroTextBox1.ShowClearButton = true;
            this.metroTextBox1.Size = new System.Drawing.Size(190, 23);
            this.metroTextBox1.TabIndex = 71;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseCustomForeColor = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMark = "Search";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLink2
            // 
            this.metroLink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink2.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(179)))), ((int)(((byte)(158)))));
            this.metroLink2.Image = ((System.Drawing.Image)(resources.GetObject("metroLink2.Image")));
            this.metroLink2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink2.ImageSize = 20;
            this.metroLink2.Location = new System.Drawing.Point(806, 82);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(79, 23);
            this.metroLink2.TabIndex = 72;
            this.metroLink2.Text = "&Refrash";
            this.metroLink2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink2.UseCustomForeColor = true;
            this.metroLink2.UseSelectable = true;
            // 
            // ScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.deptTitle);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Name = "ScheduleControl";
            this.Size = new System.Drawing.Size(1126, 660);
            this.Load += new System.EventHandler(this.ScheduleControl_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        public MetroFramework.Controls.MetroLabel deptTitle;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel TimeDate4;
        private MetroFramework.Controls.MetroLabel TimeDate3;
        private MetroFramework.Controls.MetroLabel TimeDate2;
        private MetroFramework.Controls.MetroLabel TimeDate1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
