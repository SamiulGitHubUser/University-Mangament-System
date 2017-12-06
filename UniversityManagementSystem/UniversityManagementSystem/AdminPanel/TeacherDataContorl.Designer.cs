namespace UniversityManagementSystem
{
    partial class TeacherDataContorl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDataContorl));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroGridTeacher = new MetroFramework.Controls.MetroGrid();
            this.deptTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Search = new MetroFramework.Controls.MetroLink();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroContextMenuDelete = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridTeacher)).BeginInit();
            this.metroContextMenuDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.AllowDrop = true;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(20, 76);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1062, 532);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 55;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroGridTeacher);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1054, 490);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Teacher Information";
            this.metroTabPage1.UseStyleColors = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroGridTeacher
            // 
            this.metroGridTeacher.AllowUserToAddRows = false;
            this.metroGridTeacher.AllowUserToResizeRows = false;
            this.metroGridTeacher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridTeacher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridTeacher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridTeacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridTeacher.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridTeacher.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridTeacher.EnableHeadersVisualStyles = false;
            this.metroGridTeacher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridTeacher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridTeacher.Location = new System.Drawing.Point(15, 17);
            this.metroGridTeacher.Name = "metroGridTeacher";
            this.metroGridTeacher.ReadOnly = true;
            this.metroGridTeacher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridTeacher.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridTeacher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridTeacher.Size = new System.Drawing.Size(1025, 457);
            this.metroGridTeacher.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGridTeacher.TabIndex = 3;
            this.metroGridTeacher.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGridTeacher_CellMouseUp);
            // 
            // deptTitle
            // 
            this.deptTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deptTitle.AutoSize = true;
            this.deptTitle.ForeColor = System.Drawing.Color.Green;
            this.deptTitle.Location = new System.Drawing.Point(454, 57);
            this.deptTitle.Name = "deptTitle";
            this.deptTitle.Size = new System.Drawing.Size(154, 19);
            this.deptTitle.TabIndex = 54;
            this.deptTitle.Text = "School of Science Facalty";
            this.deptTitle.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Green;
            this.metroLabel1.Location = new System.Drawing.Point(514, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 52;
            this.metroLabel1.Text = "Teacher";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Green;
            this.metroLabel4.Location = new System.Drawing.Point(874, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 19);
            this.metroLabel4.TabIndex = 53;
            this.metroLabel4.Text = "Manage Teacher";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Green;
            this.metroLabel3.Location = new System.Drawing.Point(139, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(171, 19);
            this.metroLabel3.TabIndex = 51;
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
            this.metroButton1.Location = new System.Drawing.Point(980, 54);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(102, 25);
            this.metroButton1.TabIndex = 59;
            this.metroButton1.Text = "Add Teacher";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Search
            // 
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.Search.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(179)))), ((int)(((byte)(158)))));
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.ImageSize = 20;
            this.Search.Location = new System.Drawing.Point(732, 84);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(69, 23);
            this.Search.TabIndex = 61;
            this.Search.Text = "&Search";
            this.Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Search.UseCustomForeColor = true;
            this.Search.UseSelectable = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
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
            this.metroLink4.Location = new System.Drawing.Point(807, 84);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(79, 23);
            this.metroLink4.TabIndex = 62;
            this.metroLink4.Text = "&Update";
            this.metroLink4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink4.UseCustomForeColor = true;
            this.metroLink4.UseSelectable = true;
            this.metroLink4.Click += new System.EventHandler(this.metroLink4_Click);
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
            this.metroTextBox1.Location = new System.Drawing.Point(892, 84);
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
            this.metroTextBox1.TabIndex = 63;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseCustomForeColor = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMark = "Search";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroContextMenuDelete
            // 
            this.metroContextMenuDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRecordToolStripMenuItem});
            this.metroContextMenuDelete.Name = "metroContextMenuDelete";
            this.metroContextMenuDelete.Size = new System.Drawing.Size(159, 26);
            this.metroContextMenuDelete.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroContextMenuDelete.UseStyleColors = true;
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deleteRecordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteRecordToolStripMenuItem_Click);
            // 
            // TeacherDataContorl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLink4);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.deptTitle);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton1);
            this.Name = "TeacherDataContorl";
            this.Size = new System.Drawing.Size(1126, 660);
            this.Load += new System.EventHandler(this.TeacherDataContorl_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridTeacher)).EndInit();
            this.metroContextMenuDelete.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroLink Search;
        private MetroFramework.Controls.MetroLink metroLink4;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroGrid metroGridTeacher;
        private MetroFramework.Controls.MetroContextMenu metroContextMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
    }
}
