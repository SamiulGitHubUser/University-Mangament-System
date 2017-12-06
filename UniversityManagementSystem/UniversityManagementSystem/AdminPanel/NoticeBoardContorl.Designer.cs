namespace UniversityManagementSystem
{
    partial class NoticeBoardContorl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeBoardContorl));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.noticeBoardGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.deptTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.searchBox = new MetroFramework.Controls.MetroTextBox();
            this.DeleteContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteNoticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noticeBoardGrid)).BeginInit();
            this.DeleteContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.AllowDrop = true;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(29, 76);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1062, 535);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 64;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.noticeBoardGrid);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1054, 493);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "ALL Notice";
            this.metroTabPage1.UseStyleColors = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // noticeBoardGrid
            // 
            this.noticeBoardGrid.AllowUserToAddRows = false;
            this.noticeBoardGrid.AllowUserToDeleteRows = false;
            this.noticeBoardGrid.AllowUserToResizeRows = false;
            this.noticeBoardGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.noticeBoardGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noticeBoardGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.noticeBoardGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.noticeBoardGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.noticeBoardGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.noticeBoardGrid.EnableHeadersVisualStyles = false;
            this.noticeBoardGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.noticeBoardGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.noticeBoardGrid.Location = new System.Drawing.Point(306, 90);
            this.noticeBoardGrid.Name = "noticeBoardGrid";
            this.noticeBoardGrid.ReadOnly = true;
            this.noticeBoardGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.noticeBoardGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.noticeBoardGrid.RowHeadersWidth = 23;
            this.noticeBoardGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.noticeBoardGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.noticeBoardGrid.Size = new System.Drawing.Size(697, 348);
            this.noticeBoardGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.noticeBoardGrid.TabIndex = 77;
            this.noticeBoardGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.noticeBoardGrid_CellMouseUp);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(19, 68);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(180, 25);
            this.metroLabel5.TabIndex = 76;
            this.metroLabel5.Text = "Students and Teachers";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(19, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 25);
            this.metroLabel2.TabIndex = 75;
            this.metroLabel2.Text = "Notice Board";
            // 
            // deptTitle
            // 
            this.deptTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deptTitle.AutoSize = true;
            this.deptTitle.ForeColor = System.Drawing.Color.Green;
            this.deptTitle.Location = new System.Drawing.Point(468, 57);
            this.deptTitle.Name = "deptTitle";
            this.deptTitle.Size = new System.Drawing.Size(166, 19);
            this.deptTitle.TabIndex = 63;
            this.deptTitle.Text = "Update Notice Information";
            this.deptTitle.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Green;
            this.metroLabel1.Location = new System.Drawing.Point(511, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 61;
            this.metroLabel1.Text = "NoticeBoard";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Green;
            this.metroLabel4.Location = new System.Drawing.Point(858, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(135, 19);
            this.metroLabel4.TabIndex = 62;
            this.metroLabel4.Text = "Manage NoticeBoard";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Green;
            this.metroLabel3.Location = new System.Drawing.Point(123, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(171, 19);
            this.metroLabel3.TabIndex = 60;
            this.metroLabel3.Text = "Running Session : 2016-2017";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(983, 53);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(102, 25);
            this.metroButton1.TabIndex = 68;
            this.metroButton1.Text = "Add Notice";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLink3
            // 
            this.metroLink3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink3.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink3.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(179)))), ((int)(((byte)(158)))));
            this.metroLink3.Image = ((System.Drawing.Image)(resources.GetObject("metroLink3.Image")));
            this.metroLink3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink3.ImageSize = 20;
            this.metroLink3.Location = new System.Drawing.Point(735, 84);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(69, 23);
            this.metroLink3.TabIndex = 69;
            this.metroLink3.Text = "&Search";
            this.metroLink3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink3.UseCustomForeColor = true;
            this.metroLink3.UseSelectable = true;
            this.metroLink3.Click += new System.EventHandler(this.metroLink3_Click);
            // 
            // metroLink4
            // 
            this.metroLink4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink4.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink4.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(179)))), ((int)(((byte)(158)))));
            this.metroLink4.Image = ((System.Drawing.Image)(resources.GetObject("metroLink4.Image")));
            this.metroLink4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink4.ImageSize = 20;
            this.metroLink4.Location = new System.Drawing.Point(810, 84);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(79, 23);
            this.metroLink4.TabIndex = 68;
            this.metroLink4.Text = "&Update";
            this.metroLink4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink4.UseCustomForeColor = true;
            this.metroLink4.UseSelectable = true;
            this.metroLink4.Click += new System.EventHandler(this.metroLink4_Click);
            // 
            // searchBox
            // 
            // 
            // 
            // 
            this.searchBox.CustomButton.BackColor = System.Drawing.Color.Green;
            this.searchBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.searchBox.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.searchBox.CustomButton.Name = "";
            this.searchBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.searchBox.CustomButton.TabIndex = 1;
            this.searchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchBox.CustomButton.UseCompatibleTextRendering = true;
            this.searchBox.CustomButton.UseCustomBackColor = true;
            this.searchBox.CustomButton.UseCustomForeColor = true;
            this.searchBox.CustomButton.UseSelectable = true;
            this.searchBox.CustomButton.UseStyleColors = true;
            this.searchBox.CustomButton.UseVisualStyleBackColor = true;
            this.searchBox.DisplayIcon = true;
            this.searchBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchBox.Icon")));
            this.searchBox.Lines = new string[0];
            this.searchBox.Location = new System.Drawing.Point(895, 84);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PromptText = "SearchByTitle";
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.ShowButton = true;
            this.searchBox.ShowClearButton = true;
            this.searchBox.Size = new System.Drawing.Size(190, 23);
            this.searchBox.TabIndex = 69;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.UseCustomForeColor = true;
            this.searchBox.UseSelectable = true;
            this.searchBox.UseStyleColors = true;
            this.searchBox.WaterMark = "SearchByTitle";
            this.searchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DeleteContextMenu
            // 
            this.DeleteContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteNoticeToolStripMenuItem});
            this.DeleteContextMenu.Name = "deleteContextMenu";
            this.DeleteContextMenu.Size = new System.Drawing.Size(146, 26);
            // 
            // deleteNoticeToolStripMenuItem
            // 
            this.deleteNoticeToolStripMenuItem.Name = "deleteNoticeToolStripMenuItem";
            this.deleteNoticeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteNoticeToolStripMenuItem.Text = "Delete Notice";
            this.deleteNoticeToolStripMenuItem.Click += new System.EventHandler(this.deleteNoticeToolStripMenuItem_Click);
            // 
            // NoticeBoardContorl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLink4);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.metroLink3);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.deptTitle);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton1);
            this.Name = "NoticeBoardContorl";
            this.Size = new System.Drawing.Size(1120, 640);
            this.Load += new System.EventHandler(this.NoticeBoardContorl_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noticeBoardGrid)).EndInit();
            this.DeleteContextMenu.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLink metroLink4;
        private MetroFramework.Controls.MetroTextBox searchBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroGrid noticeBoardGrid;
        private MetroFramework.Controls.MetroContextMenu DeleteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteNoticeToolStripMenuItem;
    }
}
