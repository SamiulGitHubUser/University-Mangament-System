namespace SmartUniversity.Student
{
    partial class StudyMaterialControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyMaterialControl));
            this.metroComboBoxSemester = new MetroFramework.Controls.MetroComboBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageStudyMaterial = new MetroFramework.Controls.MetroTabPage();
            this.metroLabelSemester = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPagePerSemester = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelStudyMAterial = new MetroFramework.Controls.MetroLabel();
            this.metroLabelRunningSeassion = new MetroFramework.Controls.MetroLabel();
            this.metroLinkShowStudyMaterial = new MetroFramework.Controls.MetroLink();
            this.metroLinkCarriculamDetails = new MetroFramework.Controls.MetroLink();
            this.metroComboBoxCourse = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelCourse = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPageStudyMaterial.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroComboBoxSemester
            // 
            this.metroComboBoxSemester.DisplayMember = "Gender";
            this.metroComboBoxSemester.FormattingEnabled = true;
            this.metroComboBoxSemester.ItemHeight = 23;
            this.metroComboBoxSemester.Location = new System.Drawing.Point(14, 78);
            this.metroComboBoxSemester.Name = "metroComboBoxSemester";
            this.metroComboBoxSemester.Size = new System.Drawing.Size(231, 29);
            this.metroComboBoxSemester.TabIndex = 106;
            this.metroComboBoxSemester.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.AllowDrop = true;
            this.metroTabControl1.Controls.Add(this.metroTabPageStudyMaterial);
            this.metroTabControl1.Location = new System.Drawing.Point(30, 75);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1062, 535);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 108;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPageStudyMaterial
            // 
            this.metroTabPageStudyMaterial.Controls.Add(this.metroComboBoxCourse);
            this.metroTabPageStudyMaterial.Controls.Add(this.metroLabelCourse);
            this.metroTabPageStudyMaterial.Controls.Add(this.metroLinkShowStudyMaterial);
            this.metroTabPageStudyMaterial.Controls.Add(this.metroComboBoxSemester);
            this.metroTabPageStudyMaterial.Controls.Add(this.metroLabelSemester);
            this.metroTabPageStudyMaterial.Controls.Add(this.metroTabControl2);
            this.metroTabPageStudyMaterial.Controls.Add(this.metroLabel5);
            this.metroTabPageStudyMaterial.HorizontalScrollbarBarColor = true;
            this.metroTabPageStudyMaterial.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageStudyMaterial.HorizontalScrollbarSize = 10;
            this.metroTabPageStudyMaterial.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageStudyMaterial.Name = "metroTabPageStudyMaterial";
            this.metroTabPageStudyMaterial.Size = new System.Drawing.Size(1054, 493);
            this.metroTabPageStudyMaterial.TabIndex = 0;
            this.metroTabPageStudyMaterial.Text = "Study Materials Information";
            this.metroTabPageStudyMaterial.UseStyleColors = true;
            this.metroTabPageStudyMaterial.VerticalScrollbarBarColor = true;
            this.metroTabPageStudyMaterial.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageStudyMaterial.VerticalScrollbarSize = 10;
            // 
            // metroLabelSemester
            // 
            this.metroLabelSemester.AutoSize = true;
            this.metroLabelSemester.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelSemester.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelSemester.Location = new System.Drawing.Point(14, 57);
            this.metroLabelSemester.Name = "metroLabelSemester";
            this.metroLabelSemester.Size = new System.Drawing.Size(57, 15);
            this.metroLabelSemester.TabIndex = 105;
            this.metroLabelSemester.Text = "Semister";
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPagePerSemester);
            this.metroTabControl2.Location = new System.Drawing.Point(269, 28);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(775, 438);
            this.metroTabControl2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl2.TabIndex = 104;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPagePerSemester
            // 
            this.metroTabPagePerSemester.AutoScroll = true;
            this.metroTabPagePerSemester.HorizontalScrollbar = true;
            this.metroTabPagePerSemester.HorizontalScrollbarBarColor = true;
            this.metroTabPagePerSemester.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPagePerSemester.HorizontalScrollbarSize = 10;
            this.metroTabPagePerSemester.Location = new System.Drawing.Point(4, 38);
            this.metroTabPagePerSemester.Name = "metroTabPagePerSemester";
            this.metroTabPagePerSemester.Size = new System.Drawing.Size(767, 396);
            this.metroTabPagePerSemester.TabIndex = 0;
            this.metroTabPagePerSemester.Text = "Study Materials";
            this.metroTabPagePerSemester.VerticalScrollbar = true;
            this.metroTabPagePerSemester.VerticalScrollbarBarColor = true;
            this.metroTabPagePerSemester.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPagePerSemester.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(14, 11);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(185, 25);
            this.metroLabel5.TabIndex = 103;
            this.metroLabel5.Text = "Study Materials System";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Green;
            this.metroLabel2.Location = new System.Drawing.Point(460, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(191, 19);
            this.metroLabel2.TabIndex = 107;
            this.metroLabel2.Text = "Students Study Material System";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Green;
            this.metroLabel1.Location = new System.Drawing.Point(509, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 105;
            this.metroLabel1.Text = "Study Materials";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabelStudyMAterial
            // 
            this.metroLabelStudyMAterial.AutoSize = true;
            this.metroLabelStudyMAterial.ForeColor = System.Drawing.Color.Green;
            this.metroLabelStudyMAterial.Location = new System.Drawing.Point(892, 0);
            this.metroLabelStudyMAterial.Name = "metroLabelStudyMAterial";
            this.metroLabelStudyMAterial.Size = new System.Drawing.Size(128, 19);
            this.metroLabelStudyMAterial.TabIndex = 106;
            this.metroLabelStudyMAterial.Text = "Show Study Material";
            this.metroLabelStudyMAterial.UseCustomForeColor = true;
            // 
            // metroLabelRunningSeassion
            // 
            this.metroLabelRunningSeassion.AutoSize = true;
            this.metroLabelRunningSeassion.ForeColor = System.Drawing.Color.Green;
            this.metroLabelRunningSeassion.Location = new System.Drawing.Point(157, 0);
            this.metroLabelRunningSeassion.Name = "metroLabelRunningSeassion";
            this.metroLabelRunningSeassion.Size = new System.Drawing.Size(171, 19);
            this.metroLabelRunningSeassion.TabIndex = 104;
            this.metroLabelRunningSeassion.Text = "Running Session : 2016-2017";
            this.metroLabelRunningSeassion.UseCustomForeColor = true;
            // 
            // metroLinkShowStudyMaterial
            // 
            this.metroLinkShowStudyMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.metroLinkShowStudyMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkShowStudyMaterial.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkShowStudyMaterial.ForeColor = System.Drawing.Color.White;
            this.metroLinkShowStudyMaterial.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkShowStudyMaterial.Image")));
            this.metroLinkShowStudyMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLinkShowStudyMaterial.Location = new System.Drawing.Point(14, 205);
            this.metroLinkShowStudyMaterial.Name = "metroLinkShowStudyMaterial";
            this.metroLinkShowStudyMaterial.Size = new System.Drawing.Size(123, 23);
            this.metroLinkShowStudyMaterial.TabIndex = 102;
            this.metroLinkShowStudyMaterial.Text = "Study Material";
            this.metroLinkShowStudyMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkShowStudyMaterial.UseCustomBackColor = true;
            this.metroLinkShowStudyMaterial.UseCustomForeColor = true;
            this.metroLinkShowStudyMaterial.UseSelectable = true;
            // 
            // metroLinkCarriculamDetails
            // 
            this.metroLinkCarriculamDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.metroLinkCarriculamDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkCarriculamDetails.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkCarriculamDetails.ForeColor = System.Drawing.Color.White;
            this.metroLinkCarriculamDetails.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkCarriculamDetails.Image")));
            this.metroLinkCarriculamDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLinkCarriculamDetails.Location = new System.Drawing.Point(953, 85);
            this.metroLinkCarriculamDetails.Name = "metroLinkCarriculamDetails";
            this.metroLinkCarriculamDetails.Size = new System.Drawing.Size(139, 23);
            this.metroLinkCarriculamDetails.TabIndex = 109;
            this.metroLinkCarriculamDetails.Text = "Carriculam Details";
            this.metroLinkCarriculamDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkCarriculamDetails.UseCustomBackColor = true;
            this.metroLinkCarriculamDetails.UseCustomForeColor = true;
            this.metroLinkCarriculamDetails.UseSelectable = true;
            // 
            // metroComboBoxCourse
            // 
            this.metroComboBoxCourse.DisplayMember = "Gender";
            this.metroComboBoxCourse.FormattingEnabled = true;
            this.metroComboBoxCourse.ItemHeight = 23;
            this.metroComboBoxCourse.Location = new System.Drawing.Point(14, 146);
            this.metroComboBoxCourse.Name = "metroComboBoxCourse";
            this.metroComboBoxCourse.Size = new System.Drawing.Size(231, 29);
            this.metroComboBoxCourse.TabIndex = 110;
            this.metroComboBoxCourse.UseSelectable = true;
            // 
            // metroLabelCourse
            // 
            this.metroLabelCourse.AutoSize = true;
            this.metroLabelCourse.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelCourse.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelCourse.Location = new System.Drawing.Point(14, 125);
            this.metroLabelCourse.Name = "metroLabelCourse";
            this.metroLabelCourse.Size = new System.Drawing.Size(45, 15);
            this.metroLabelCourse.TabIndex = 109;
            this.metroLabelCourse.Text = "Course";
            // 
            // StudyMaterialControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLinkCarriculamDetails);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelStudyMAterial);
            this.Controls.Add(this.metroLabelRunningSeassion);
            this.Name = "StudyMaterialControl";
            this.Size = new System.Drawing.Size(1152, 657);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPageStudyMaterial.ResumeLayout(false);
            this.metroTabPageStudyMaterial.PerformLayout();
            this.metroTabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBoxSemester;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPageStudyMaterial;
        private MetroFramework.Controls.MetroLink metroLinkShowStudyMaterial;
        private MetroFramework.Controls.MetroLabel metroLabelSemester;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPagePerSemester;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLink metroLinkCarriculamDetails;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelStudyMAterial;
        private MetroFramework.Controls.MetroLabel metroLabelRunningSeassion;
        private MetroFramework.Controls.MetroComboBox metroComboBoxCourse;
        private MetroFramework.Controls.MetroLabel metroLabelCourse;
    }
}
