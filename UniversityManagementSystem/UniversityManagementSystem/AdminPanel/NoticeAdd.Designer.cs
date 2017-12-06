namespace UniversityManagementSystem
{
    partial class NoticeAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeAdd));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.label1 = new System.Windows.Forms.Label();
            this.noticeDateComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.noticeDescription = new MetroFramework.Controls.MetroTextBox();
            this.ParentTab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.noticeTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.addmissionTab = new MetroFramework.Controls.MetroTabControl();
            this.metroPanel1.SuspendLayout();
            this.ParentTab.SuspendLayout();
            this.addmissionTab.SuspendLayout();
            this.SuspendLayout();
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
            this.metroPanel1.TabIndex = 73;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Notice Details Information";
            // 
            // noticeDateComboBox
            // 
            this.noticeDateComboBox.FormattingEnabled = true;
            this.noticeDateComboBox.ItemHeight = 23;
            this.noticeDateComboBox.Location = new System.Drawing.Point(32, 168);
            this.noticeDateComboBox.Name = "noticeDateComboBox";
            this.noticeDateComboBox.Size = new System.Drawing.Size(310, 29);
            this.noticeDateComboBox.TabIndex = 66;
            this.noticeDateComboBox.UseSelectable = true;
            
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(589, 335);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(99, 25);
            this.metroButton1.TabIndex = 49;
            this.metroButton1.Text = "Add Notice";
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
            this.metroLabel17.Location = new System.Drawing.Point(32, 209);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(106, 15);
            this.metroLabel17.TabIndex = 35;
            this.metroLabel17.Text = "Give Description :";
            // 
            // noticeDescription
            // 
            // 
            // 
            // 
            this.noticeDescription.CustomButton.Image = null;
            this.noticeDescription.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.noticeDescription.CustomButton.Name = "";
            this.noticeDescription.CustomButton.Size = new System.Drawing.Size(99, 99);
            this.noticeDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.noticeDescription.CustomButton.TabIndex = 1;
            this.noticeDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.noticeDescription.CustomButton.UseSelectable = true;
            this.noticeDescription.CustomButton.Visible = false;
            this.noticeDescription.Lines = new string[0];
            this.noticeDescription.Location = new System.Drawing.Point(32, 227);
            this.noticeDescription.MaxLength = 32767;
            this.noticeDescription.Multiline = true;
            this.noticeDescription.Name = "noticeDescription";
            this.noticeDescription.PasswordChar = '\0';
            this.noticeDescription.PromptText = "Short Description";
            this.noticeDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.noticeDescription.SelectedText = "";
            this.noticeDescription.SelectionLength = 0;
            this.noticeDescription.SelectionStart = 0;
            this.noticeDescription.ShortcutsEnabled = true;
            this.noticeDescription.Size = new System.Drawing.Size(310, 101);
            this.noticeDescription.TabIndex = 34;
            this.noticeDescription.UseSelectable = true;
            this.noticeDescription.WaterMark = "Short Description";
            this.noticeDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.noticeDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ParentTab
            // 
            this.ParentTab.Controls.Add(this.metroLabel15);
            this.ParentTab.Controls.Add(this.metroLabel4);
            this.ParentTab.Controls.Add(this.Calendar);
            this.ParentTab.Controls.Add(this.label1);
            this.ParentTab.Controls.Add(this.noticeDateComboBox);
            this.ParentTab.Controls.Add(this.metroButton1);
            this.ParentTab.Controls.Add(this.metroLabel17);
            this.ParentTab.Controls.Add(this.noticeDescription);
            this.ParentTab.Controls.Add(this.noticeTitle);
            this.ParentTab.Controls.Add(this.metroLabel19);
            this.ParentTab.HorizontalScrollbarBarColor = true;
            this.ParentTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ParentTab.HorizontalScrollbarSize = 10;
            this.ParentTab.Location = new System.Drawing.Point(4, 38);
            this.ParentTab.Name = "ParentTab";
            this.ParentTab.Size = new System.Drawing.Size(721, 394);
            this.ParentTab.TabIndex = 1;
            this.ParentTab.Text = "&Genaral";
            this.ParentTab.VerticalScrollbarBarColor = true;
            this.ParentTab.VerticalScrollbarHighlightOnWheel = false;
            this.ParentTab.VerticalScrollbarSize = 10;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(32, 146);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(97, 15);
            this.metroLabel15.TabIndex = 74;
            this.metroLabel15.Text = "Date Of Notice :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(508, 77);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 15);
            this.metroLabel4.TabIndex = 73;
            this.metroLabel4.Text = "Calander";
            // 
            // Calendar
            // 
            this.Calendar.Enabled = false;
            this.Calendar.Location = new System.Drawing.Point(427, 105);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 72;
            // 
            // noticeTitle
            // 
            // 
            // 
            // 
            this.noticeTitle.CustomButton.Image = null;
            this.noticeTitle.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.noticeTitle.CustomButton.Name = "";
            this.noticeTitle.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.noticeTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.noticeTitle.CustomButton.TabIndex = 1;
            this.noticeTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.noticeTitle.CustomButton.UseSelectable = true;
            this.noticeTitle.CustomButton.Visible = false;
            this.noticeTitle.Lines = new string[0];
            this.noticeTitle.Location = new System.Drawing.Point(32, 105);
            this.noticeTitle.MaxLength = 32767;
            this.noticeTitle.Multiline = true;
            this.noticeTitle.Name = "noticeTitle";
            this.noticeTitle.PasswordChar = '\0';
            this.noticeTitle.PromptText = "Notice Title";
            this.noticeTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.noticeTitle.SelectedText = "";
            this.noticeTitle.SelectionLength = 0;
            this.noticeTitle.SelectionStart = 0;
            this.noticeTitle.ShortcutsEnabled = true;
            this.noticeTitle.Size = new System.Drawing.Size(310, 29);
            this.noticeTitle.TabIndex = 23;
            this.noticeTitle.UseSelectable = true;
            this.noticeTitle.WaterMark = "Notice Title";
            this.noticeTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.noticeTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel19.Location = new System.Drawing.Point(32, 77);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(78, 15);
            this.metroLabel19.TabIndex = 22;
            this.metroLabel19.Text = "Notice Title :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(6, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(216, 25);
            this.metroLabel1.TabIndex = 71;
            this.metroLabel1.Text = "Add Notice to NoticeBoard";
            // 
            // addmissionTab
            // 
            this.addmissionTab.Controls.Add(this.ParentTab);
            this.addmissionTab.Location = new System.Drawing.Point(221, 30);
            this.addmissionTab.Name = "addmissionTab";
            this.addmissionTab.SelectedIndex = 0;
            this.addmissionTab.Size = new System.Drawing.Size(729, 436);
            this.addmissionTab.Style = MetroFramework.MetroColorStyle.Green;
            this.addmissionTab.TabIndex = 72;
            this.addmissionTab.UseSelectable = true;
            // 
            // NoticeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 473);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.addmissionTab);
            this.Name = "NoticeAdd";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.NoticeAdd_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ParentTab.ResumeLayout(false);
            this.ParentTab.PerformLayout();
            this.addmissionTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox noticeDateComboBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox noticeDescription;
        private MetroFramework.Controls.MetroTabPage ParentTab;
        private MetroFramework.Controls.MetroTextBox noticeTitle;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl addmissionTab;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.MonthCalendar Calendar;
        private MetroFramework.Controls.MetroLabel metroLabel15;
    }
}