namespace SmartUniversity.Student
{
    partial class LibraryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryControl));
            this.metroLabelBookInformation = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageProfile = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLibrary = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroLabelRunningSeassion = new MetroFramework.Controls.MetroLabel();
            this.metroLabelShowBook = new MetroFramework.Controls.MetroLabel();
            this.metroButtonIssue = new MetroFramework.Controls.MetroButton();
            this.metroLinkDelete = new MetroFramework.Controls.MetroLink();
            this.MetroTextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPageProfile.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabelBookInformation
            // 
            this.metroLabelBookInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabelBookInformation.AutoSize = true;
            this.metroLabelBookInformation.ForeColor = System.Drawing.Color.Green;
            this.metroLabelBookInformation.Location = new System.Drawing.Point(461, 57);
            this.metroLabelBookInformation.Name = "metroLabelBookInformation";
            this.metroLabelBookInformation.Size = new System.Drawing.Size(135, 19);
            this.metroLabelBookInformation.TabIndex = 110;
            this.metroLabelBookInformation.Text = "All Books Information";
            this.metroLabelBookInformation.UseCustomForeColor = true;
            // 
            // metroTabPageProfile
            // 
            this.metroTabPageProfile.Controls.Add(this.metroLabel5);
            this.metroTabPageProfile.HorizontalScrollbarBarColor = true;
            this.metroTabPageProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageProfile.HorizontalScrollbarSize = 10;
            this.metroTabPageProfile.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageProfile.Name = "metroTabPageProfile";
            this.metroTabPageProfile.Size = new System.Drawing.Size(1054, 493);
            this.metroTabPageProfile.TabIndex = 0;
            this.metroTabPageProfile.Text = "Book Information";
            this.metroTabPageProfile.UseStyleColors = true;
            this.metroTabPageProfile.VerticalScrollbarBarColor = true;
            this.metroTabPageProfile.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageProfile.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(-28, -54);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(162, 25);
            this.metroLabel5.TabIndex = 103;
            this.metroLabel5.Text = "Examination Results";
            // 
            // metroLabelLibrary
            // 
            this.metroLabelLibrary.AutoSize = true;
            this.metroLabelLibrary.ForeColor = System.Drawing.Color.Green;
            this.metroLabelLibrary.Location = new System.Drawing.Point(510, 38);
            this.metroLabelLibrary.Name = "metroLabelLibrary";
            this.metroLabelLibrary.Size = new System.Drawing.Size(50, 19);
            this.metroLabelLibrary.TabIndex = 108;
            this.metroLabelLibrary.Text = "Library";
            this.metroLabelLibrary.UseCustomForeColor = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.AllowDrop = true;
            this.metroTabControl1.Controls.Add(this.metroTabPageProfile);
            this.metroTabControl1.Location = new System.Drawing.Point(31, 75);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1062, 535);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 111;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroLabelRunningSeassion
            // 
            this.metroLabelRunningSeassion.AutoSize = true;
            this.metroLabelRunningSeassion.ForeColor = System.Drawing.Color.Green;
            this.metroLabelRunningSeassion.Location = new System.Drawing.Point(158, 0);
            this.metroLabelRunningSeassion.Name = "metroLabelRunningSeassion";
            this.metroLabelRunningSeassion.Size = new System.Drawing.Size(171, 19);
            this.metroLabelRunningSeassion.TabIndex = 107;
            this.metroLabelRunningSeassion.Text = "Running Session : 2016-2017";
            this.metroLabelRunningSeassion.UseCustomForeColor = true;
            // 
            // metroLabelShowBook
            // 
            this.metroLabelShowBook.AutoSize = true;
            this.metroLabelShowBook.ForeColor = System.Drawing.Color.Green;
            this.metroLabelShowBook.Location = new System.Drawing.Point(893, 0);
            this.metroLabelShowBook.Name = "metroLabelShowBook";
            this.metroLabelShowBook.Size = new System.Drawing.Size(74, 19);
            this.metroLabelShowBook.TabIndex = 109;
            this.metroLabelShowBook.Text = "Show Book";
            this.metroLabelShowBook.UseCustomForeColor = true;
            // 
            // metroButtonIssue
            // 
            this.metroButtonIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.metroButtonIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonIssue.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonIssue.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButtonIssue.ForeColor = System.Drawing.Color.White;
            this.metroButtonIssue.Location = new System.Drawing.Point(991, 53);
            this.metroButtonIssue.Name = "metroButtonIssue";
            this.metroButtonIssue.Size = new System.Drawing.Size(102, 25);
            this.metroButtonIssue.TabIndex = 130;
            this.metroButtonIssue.Text = "Issu Book";
            this.metroButtonIssue.UseCustomBackColor = true;
            this.metroButtonIssue.UseCustomForeColor = true;
            this.metroButtonIssue.UseSelectable = true;
            this.metroButtonIssue.UseStyleColors = true;
            // 
            // metroLinkDelete
            // 
            this.metroLinkDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkDelete.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLinkDelete.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLinkDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(179)))), ((int)(((byte)(158)))));
            this.metroLinkDelete.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkDelete.Image")));
            this.metroLinkDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkDelete.ImageSize = 20;
            this.metroLinkDelete.Location = new System.Drawing.Point(727, 80);
            this.metroLinkDelete.Name = "metroLinkDelete";
            this.metroLinkDelete.Size = new System.Drawing.Size(69, 23);
            this.metroLinkDelete.TabIndex = 129;
            this.metroLinkDelete.Text = "&Delete";
            this.metroLinkDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLinkDelete.UseCustomForeColor = true;
            this.metroLinkDelete.UseSelectable = true;
            // 
            // MetroTextBoxSearch
            // 
            // 
            // 
            // 
            this.MetroTextBoxSearch.CustomButton.BackColor = System.Drawing.Color.Green;
            this.MetroTextBoxSearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.MetroTextBoxSearch.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.MetroTextBoxSearch.CustomButton.Name = "";
            this.MetroTextBoxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MetroTextBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.MetroTextBoxSearch.CustomButton.TabIndex = 1;
            this.MetroTextBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MetroTextBoxSearch.CustomButton.UseCompatibleTextRendering = true;
            this.MetroTextBoxSearch.CustomButton.UseCustomBackColor = true;
            this.MetroTextBoxSearch.CustomButton.UseCustomForeColor = true;
            this.MetroTextBoxSearch.CustomButton.UseSelectable = true;
            this.MetroTextBoxSearch.CustomButton.UseStyleColors = true;
            this.MetroTextBoxSearch.CustomButton.UseVisualStyleBackColor = true;
            this.MetroTextBoxSearch.DisplayIcon = true;
            this.MetroTextBoxSearch.Icon = ((System.Drawing.Image)(resources.GetObject("MetroTextBoxSearch.Icon")));
            this.MetroTextBoxSearch.Lines = new string[0];
            this.MetroTextBoxSearch.Location = new System.Drawing.Point(824, 80);
            this.MetroTextBoxSearch.MaxLength = 32767;
            this.MetroTextBoxSearch.Name = "MetroTextBoxSearch";
            this.MetroTextBoxSearch.PasswordChar = '\0';
            this.MetroTextBoxSearch.PromptText = "Search";
            this.MetroTextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetroTextBoxSearch.SelectedText = "";
            this.MetroTextBoxSearch.SelectionLength = 0;
            this.MetroTextBoxSearch.SelectionStart = 0;
            this.MetroTextBoxSearch.ShortcutsEnabled = true;
            this.MetroTextBoxSearch.ShowButton = true;
            this.MetroTextBoxSearch.ShowClearButton = true;
            this.MetroTextBoxSearch.Size = new System.Drawing.Size(268, 23);
            this.MetroTextBoxSearch.TabIndex = 128;
            this.MetroTextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MetroTextBoxSearch.UseCustomForeColor = true;
            this.MetroTextBoxSearch.UseSelectable = true;
            this.MetroTextBoxSearch.UseStyleColors = true;
            this.MetroTextBoxSearch.WaterMark = "Search";
            this.MetroTextBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MetroTextBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LibraryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroButtonIssue);
            this.Controls.Add(this.metroLinkDelete);
            this.Controls.Add(this.MetroTextBoxSearch);
            this.Controls.Add(this.metroLabelBookInformation);
            this.Controls.Add(this.metroLabelLibrary);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabelRunningSeassion);
            this.Controls.Add(this.metroLabelShowBook);
            this.Name = "LibraryControl";
            this.Size = new System.Drawing.Size(1152, 657);
            this.metroTabPageProfile.ResumeLayout(false);
            this.metroTabPageProfile.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel metroLabelBookInformation;
        private MetroFramework.Controls.MetroTabPage metroTabPageProfile;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabelLibrary;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroLabel metroLabelRunningSeassion;
        private MetroFramework.Controls.MetroLabel metroLabelShowBook;
        private MetroFramework.Controls.MetroTextBox MetroTextBoxSearch;
        private MetroFramework.Controls.MetroLink metroLinkDelete;
        private MetroFramework.Controls.MetroButton metroButtonIssue;
    }
}
