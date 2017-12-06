namespace SmartUniversity.Student
{
    partial class StudentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            this.metroPanelHeadline = new MetroFramework.Controls.MetroPanel();
            this.metroLabelUniversityName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMinimized = new MetroFramework.Controls.MetroLabel();
            this.metroLabelClose = new MetroFramework.Controls.MetroLabel();
            this.metroPanelChanged = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLinkDashboard = new MetroFramework.Controls.MetroLink();
            this.metroLinkResult = new MetroFramework.Controls.MetroLink();
            this.metroLinkClassRutine = new MetroFramework.Controls.MetroLink();
            this.metroLinkMyCarriculam = new MetroFramework.Controls.MetroLink();
            this.metroLinkSemesterGrades = new MetroFramework.Controls.MetroLink();
            this.metroLinkFinancial = new MetroFramework.Controls.MetroLink();
            this.metroLinkLibrary = new MetroFramework.Controls.MetroLink();
            this.metroLinkMailBox = new MetroFramework.Controls.MetroLink();
            this.metroLinkProfile = new MetroFramework.Controls.MetroLink();
            this.metroLinkLogout = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLinkOption = new MetroFramework.Controls.MetroLink();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroOptionPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanelHeadline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroOptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelHeadline
            // 
            this.metroPanelHeadline.Controls.Add(this.metroLabelUniversityName);
            this.metroPanelHeadline.Controls.Add(this.metroLabelMinimized);
            this.metroPanelHeadline.Controls.Add(this.metroLabelClose);
            this.metroPanelHeadline.HorizontalScrollbarBarColor = true;
            this.metroPanelHeadline.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelHeadline.HorizontalScrollbarSize = 10;
            this.metroPanelHeadline.Location = new System.Drawing.Point(261, 7);
            this.metroPanelHeadline.Name = "metroPanelHeadline";
            this.metroPanelHeadline.Size = new System.Drawing.Size(1012, 87);
            this.metroPanelHeadline.TabIndex = 5;
            this.metroPanelHeadline.VerticalScrollbarBarColor = true;
            this.metroPanelHeadline.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelHeadline.VerticalScrollbarSize = 10;
            // 
            // metroLabelUniversityName
            // 
            this.metroLabelUniversityName.AutoSize = true;
            this.metroLabelUniversityName.BackColor = System.Drawing.Color.White;
            this.metroLabelUniversityName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelUniversityName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelUniversityName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))));
            this.metroLabelUniversityName.Location = new System.Drawing.Point(412, 29);
            this.metroLabelUniversityName.Name = "metroLabelUniversityName";
            this.metroLabelUniversityName.Size = new System.Drawing.Size(338, 25);
            this.metroLabelUniversityName.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabelUniversityName.TabIndex = 7;
            this.metroLabelUniversityName.Text = "Smart University Management System";
            this.metroLabelUniversityName.UseStyleColors = true;
            // 
            // metroLabelMinimized
            // 
            this.metroLabelMinimized.AutoSize = true;
            this.metroLabelMinimized.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelMinimized.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelMinimized.Location = new System.Drawing.Point(1084, 2);
            this.metroLabelMinimized.Name = "metroLabelMinimized";
            this.metroLabelMinimized.Size = new System.Drawing.Size(24, 25);
            this.metroLabelMinimized.TabIndex = 6;
            this.metroLabelMinimized.Text = " -";
            this.metroLabelMinimized.Click += new System.EventHandler(this.metroLabelMinimized_Click);
            // 
            // metroLabelClose
            // 
            this.metroLabelClose.AutoSize = true;
            this.metroLabelClose.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelClose.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelClose.Location = new System.Drawing.Point(1116, 2);
            this.metroLabelClose.Name = "metroLabelClose";
            this.metroLabelClose.Size = new System.Drawing.Size(32, 25);
            this.metroLabelClose.TabIndex = 5;
            this.metroLabelClose.Text = " x ";
            this.metroLabelClose.Click += new System.EventHandler(this.metroLabelClose_Click);
            // 
            // metroPanelChanged
            // 
            this.metroPanelChanged.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanelChanged.HorizontalScrollbarBarColor = true;
            this.metroPanelChanged.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelChanged.HorizontalScrollbarSize = 10;
            this.metroPanelChanged.Location = new System.Drawing.Point(240, 100);
            this.metroPanelChanged.Name = "metroPanelChanged";
            this.metroPanelChanged.Size = new System.Drawing.Size(1126, 668);
            this.metroPanelChanged.TabIndex = 6;
            this.metroPanelChanged.VerticalScrollbarBarColor = true;
            this.metroPanelChanged.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelChanged.VerticalScrollbarSize = 10;
            this.metroPanelChanged.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanelChanged_Paint);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1241, 7);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(125, 38);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLinkDashboard
            // 
            this.metroLinkDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(137)))));
            this.metroLinkDashboard.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkDashboard.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkDashboard.Image")));
            this.metroLinkDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkDashboard.ImageSize = 20;
            this.metroLinkDashboard.Location = new System.Drawing.Point(0, 292);
            this.metroLinkDashboard.Name = "metroLinkDashboard";
            this.metroLinkDashboard.Size = new System.Drawing.Size(214, 36);
            this.metroLinkDashboard.Style = MetroFramework.MetroColorStyle.White;
            this.metroLinkDashboard.TabIndex = 2;
            this.metroLinkDashboard.Text = "Dashboard";
            this.metroLinkDashboard.UseCustomBackColor = true;
            this.metroLinkDashboard.UseSelectable = true;
            this.metroLinkDashboard.UseStyleColors = true;
            this.metroLinkDashboard.Click += new System.EventHandler(this.metroLinkDashboard_Click);
            // 
            // metroLinkResult
            // 
            this.metroLinkResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(137)))));
            this.metroLinkResult.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkResult.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkResult.Image")));
            this.metroLinkResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkResult.ImageSize = 20;
            this.metroLinkResult.Location = new System.Drawing.Point(0, 328);
            this.metroLinkResult.Name = "metroLinkResult";
            this.metroLinkResult.Size = new System.Drawing.Size(214, 36);
            this.metroLinkResult.Style = MetroFramework.MetroColorStyle.White;
            this.metroLinkResult.TabIndex = 3;
            this.metroLinkResult.Text = "Result";
            this.metroLinkResult.UseCustomBackColor = true;
            this.metroLinkResult.UseSelectable = true;
            this.metroLinkResult.UseStyleColors = true;
            this.metroLinkResult.Click += new System.EventHandler(this.metroLinkResult_Click);
            // 
            // metroLinkClassRutine
            // 
            this.metroLinkClassRutine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(137)))));
            this.metroLinkClassRutine.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkClassRutine.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkClassRutine.Image")));
            this.metroLinkClassRutine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkClassRutine.ImageSize = 20;
            this.metroLinkClassRutine.Location = new System.Drawing.Point(0, 364);
            this.metroLinkClassRutine.Name = "metroLinkClassRutine";
            this.metroLinkClassRutine.Size = new System.Drawing.Size(214, 36);
            this.metroLinkClassRutine.Style = MetroFramework.MetroColorStyle.White;
            this.metroLinkClassRutine.TabIndex = 4;
            this.metroLinkClassRutine.Text = "Class Rutine";
            this.metroLinkClassRutine.UseCustomBackColor = true;
            this.metroLinkClassRutine.UseSelectable = true;
            this.metroLinkClassRutine.UseStyleColors = true;
            this.metroLinkClassRutine.Click += new System.EventHandler(this.metroLinkClassRutine_Click);
            // 
            // metroLinkMyCarriculam
            // 
            this.metroLinkMyCarriculam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(137)))));
            this.metroLinkMyCarriculam.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkMyCarriculam.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkMyCarriculam.Image")));
            this.metroLinkMyCarriculam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkMyCarriculam.ImageSize = 20;
            this.metroLinkMyCarriculam.Location = new System.Drawing.Point(0, 400);
            this.metroLinkMyCarriculam.Name = "metroLinkMyCarriculam";
            this.metroLinkMyCarriculam.Size = new System.Drawing.Size(214, 36);
            this.metroLinkMyCarriculam.Style = MetroFramework.MetroColorStyle.White;
            this.metroLinkMyCarriculam.TabIndex = 5;
            this.metroLinkMyCarriculam.Text = "Carriculam";
            this.metroLinkMyCarriculam.UseCustomBackColor = true;
            this.metroLinkMyCarriculam.UseSelectable = true;
            this.metroLinkMyCarriculam.UseStyleColors = true;
            this.metroLinkMyCarriculam.Click += new System.EventHandler(this.metroLinkMyCarriculam_Click);
            // 
            // metroLinkSemesterGrades
            // 
            this.metroLinkSemesterGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(137)))));
            this.metroLinkSemesterGrades.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkSemesterGrades.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkSemesterGrades.Image")));
            this.metroLinkSemesterGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkSemesterGrades.ImageSize = 20;
            this.metroLinkSemesterGrades.Location = new System.Drawing.Point(0, 436);
            this.metroLinkSemesterGrades.Name = "metroLinkSemesterGrades";
            this.metroLinkSemesterGrades.Size = new System.Drawing.Size(214, 36);
            this.metroLinkSemesterGrades.Style = MetroFramework.MetroColorStyle.White;
            this.metroLinkSemesterGrades.TabIndex = 6;
            this.metroLinkSemesterGrades.Text = "Semester Grades";
            this.metroLinkSemesterGrades.UseCustomBackColor = true;
            this.metroLinkSemesterGrades.UseSelectable = true;
            this.metroLinkSemesterGrades.UseStyleColors = true;
            this.metroLinkSemesterGrades.Click += new System.EventHandler(this.metroLinkSemesterGrades_Click);
            // 
            // metroLinkFinancial
            // 
            this.metroLinkFinancial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(137)))));
            this.metroLinkFinancial.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkFinancial.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkFinancial.Image")));
            this.metroLinkFinancial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkFinancial.ImageSize = 20;
            this.metroLinkFinancial.Location = new System.Drawing.Point(0, 469);
            this.metroLinkFinancial.Name = "metroLinkFinancial";
            this.metroLinkFinancial.Size = new System.Drawing.Size(214, 36);
            this.metroLinkFinancial.Style = MetroFramework.MetroColorStyle.White;
            this.metroLinkFinancial.TabIndex = 9;
            this.metroLinkFinancial.Text = "Financial";
            this.metroLinkFinancial.UseCustomBackColor = true;
            this.metroLinkFinancial.UseSelectable = true;
            this.metroLinkFinancial.UseStyleColors = true;
            this.metroLinkFinancial.Click += new System.EventHandler(this.metroLinkFinancial_Click);
            // 
            // metroLinkLibrary
            // 
            this.metroLinkLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(137)))));
            this.metroLinkLibrary.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkLibrary.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkLibrary.Image")));
            this.metroLinkLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkLibrary.ImageSize = 20;
            this.metroLinkLibrary.Location = new System.Drawing.Point(0, 505);
            this.metroLinkLibrary.Name = "metroLinkLibrary";
            this.metroLinkLibrary.Size = new System.Drawing.Size(214, 36);
            this.metroLinkLibrary.Style = MetroFramework.MetroColorStyle.White;
            this.metroLinkLibrary.TabIndex = 10;
            this.metroLinkLibrary.Text = "Library";
            this.metroLinkLibrary.UseCustomBackColor = true;
            this.metroLinkLibrary.UseSelectable = true;
            this.metroLinkLibrary.UseStyleColors = true;
            this.metroLinkLibrary.Click += new System.EventHandler(this.metroLinkLibrary_Click);
            // 
            // metroLinkMailBox
            // 
            this.metroLinkMailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(137)))));
            this.metroLinkMailBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkMailBox.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkMailBox.Image")));
            this.metroLinkMailBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkMailBox.ImageSize = 20;
            this.metroLinkMailBox.Location = new System.Drawing.Point(0, 541);
            this.metroLinkMailBox.Name = "metroLinkMailBox";
            this.metroLinkMailBox.Size = new System.Drawing.Size(214, 36);
            this.metroLinkMailBox.Style = MetroFramework.MetroColorStyle.White;
            this.metroLinkMailBox.TabIndex = 11;
            this.metroLinkMailBox.Text = "Send Message";
            this.metroLinkMailBox.UseCustomBackColor = true;
            this.metroLinkMailBox.UseSelectable = true;
            this.metroLinkMailBox.UseStyleColors = true;
            this.metroLinkMailBox.Click += new System.EventHandler(this.metroLinkMailBox_Click);
            // 
            // metroLinkProfile
            // 
            this.metroLinkProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(137)))));
            this.metroLinkProfile.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkProfile.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkProfile.Image")));
            this.metroLinkProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkProfile.ImageSize = 20;
            this.metroLinkProfile.Location = new System.Drawing.Point(0, 613);
            this.metroLinkProfile.Name = "metroLinkProfile";
            this.metroLinkProfile.Size = new System.Drawing.Size(214, 36);
            this.metroLinkProfile.Style = MetroFramework.MetroColorStyle.White;
            this.metroLinkProfile.TabIndex = 12;
            this.metroLinkProfile.Text = "Profile";
            this.metroLinkProfile.UseCustomBackColor = true;
            this.metroLinkProfile.UseSelectable = true;
            this.metroLinkProfile.UseStyleColors = true;
            this.metroLinkProfile.Click += new System.EventHandler(this.metroLinkProfile_Click);
            // 
            // metroLinkLogout
            // 
            this.metroLinkLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(137)))));
            this.metroLinkLogout.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkLogout.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkLogout.Image")));
            this.metroLinkLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkLogout.ImageSize = 20;
            this.metroLinkLogout.Location = new System.Drawing.Point(0, 649);
            this.metroLinkLogout.Name = "metroLinkLogout";
            this.metroLinkLogout.Size = new System.Drawing.Size(214, 36);
            this.metroLinkLogout.Style = MetroFramework.MetroColorStyle.White;
            this.metroLinkLogout.TabIndex = 13;
            this.metroLinkLogout.Text = "Logout";
            this.metroLinkLogout.UseCustomBackColor = true;
            this.metroLinkLogout.UseSelectable = true;
            this.metroLinkLogout.UseStyleColors = true;
            this.metroLinkLogout.Click += new System.EventHandler(this.metroLinkLogout_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(137)))));
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.ImageSize = 20;
            this.metroLink1.Location = new System.Drawing.Point(673, 342);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(214, 36);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLink1.TabIndex = 30;
            this.metroLink1.Text = "Library";
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.UseStyleColors = true;
            // 
            // metroLinkOption
            // 
            this.metroLinkOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(137)))));
            this.metroLinkOption.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkOption.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkOption.Image")));
            this.metroLinkOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkOption.ImageSize = 20;
            this.metroLinkOption.Location = new System.Drawing.Point(0, 577);
            this.metroLinkOption.Name = "metroLinkOption";
            this.metroLinkOption.Size = new System.Drawing.Size(214, 36);
            this.metroLinkOption.Style = MetroFramework.MetroColorStyle.White;
            this.metroLinkOption.TabIndex = 31;
            this.metroLinkOption.Text = "Settings";
            this.metroLinkOption.UseCustomBackColor = true;
            this.metroLinkOption.UseSelectable = true;
            this.metroLinkOption.UseStyleColors = true;
            this.metroLinkOption.Click += new System.EventHandler(this.metroLinkOption_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Adam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "adamSmithMail@";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Smith";
            // 
            // metroOptionPanel
            // 
            this.metroOptionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroOptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.metroOptionPanel.Controls.Add(this.label3);
            this.metroOptionPanel.Controls.Add(this.label2);
            this.metroOptionPanel.Controls.Add(this.label1);
            this.metroOptionPanel.Controls.Add(this.pictureBox2);
            this.metroOptionPanel.Controls.Add(this.metroLinkOption);
            this.metroOptionPanel.Controls.Add(this.metroLink1);
            this.metroOptionPanel.Controls.Add(this.metroLinkLogout);
            this.metroOptionPanel.Controls.Add(this.metroLinkProfile);
            this.metroOptionPanel.Controls.Add(this.metroLinkMailBox);
            this.metroOptionPanel.Controls.Add(this.metroLinkLibrary);
            this.metroOptionPanel.Controls.Add(this.metroLinkFinancial);
            this.metroOptionPanel.Controls.Add(this.metroLinkSemesterGrades);
            this.metroOptionPanel.Controls.Add(this.metroLinkMyCarriculam);
            this.metroOptionPanel.Controls.Add(this.metroLinkClassRutine);
            this.metroOptionPanel.Controls.Add(this.metroLinkResult);
            this.metroOptionPanel.Controls.Add(this.metroLinkDashboard);
            this.metroOptionPanel.HorizontalScrollbarBarColor = true;
            this.metroOptionPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroOptionPanel.HorizontalScrollbarSize = 10;
            this.metroOptionPanel.Location = new System.Drawing.Point(0, 5);
            this.metroOptionPanel.Name = "metroOptionPanel";
            this.metroOptionPanel.Size = new System.Drawing.Size(214, 761);
            this.metroOptionPanel.TabIndex = 4;
            this.metroOptionPanel.UseCustomBackColor = true;
            this.metroOptionPanel.VerticalScrollbarBarColor = true;
            this.metroOptionPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroOptionPanel.VerticalScrollbarSize = 10;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanelChanged);
            this.Controls.Add(this.metroPanelHeadline);
            this.Controls.Add(this.metroOptionPanel);
            this.Name = "StudentDashboard";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.metroPanelHeadline.ResumeLayout(false);
            this.metroPanelHeadline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroOptionPanel.ResumeLayout(false);
            this.metroOptionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanelHeadline;
        private MetroFramework.Controls.MetroLabel metroLabelMinimized;
        private MetroFramework.Controls.MetroLabel metroLabelClose;
        private MetroFramework.Controls.MetroLabel metroLabelUniversityName;
        private MetroFramework.Controls.MetroPanel metroPanelChanged;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink metroLinkDashboard;
        private MetroFramework.Controls.MetroLink metroLinkResult;
        private MetroFramework.Controls.MetroLink metroLinkClassRutine;
        private MetroFramework.Controls.MetroLink metroLinkMyCarriculam;
        private MetroFramework.Controls.MetroLink metroLinkSemesterGrades;
        private MetroFramework.Controls.MetroLink metroLinkFinancial;
        private MetroFramework.Controls.MetroLink metroLinkLibrary;
        private MetroFramework.Controls.MetroLink metroLinkMailBox;
        private MetroFramework.Controls.MetroLink metroLinkProfile;
        private MetroFramework.Controls.MetroLink metroLinkLogout;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLinkOption;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroPanel metroOptionPanel;
    }
}