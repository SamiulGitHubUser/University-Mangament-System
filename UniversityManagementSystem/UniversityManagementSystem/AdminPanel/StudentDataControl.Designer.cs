namespace UniversityManagementSystem
{
    partial class StudentDataControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDataControl));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.deptTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.studentInfoGrid = new MetroFramework.Controls.MetroGrid();
            this.search = new MetroFramework.Controls.MetroTextBox();
            this.serch1 = new MetroFramework.Controls.MetroLink();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroContextMenuDelete = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoGrid)).BeginInit();
            this.metroContextMenuDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Green;
            this.metroLabel3.Location = new System.Drawing.Point(136, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(171, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Running Session : 2016-2017";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Green;
            this.metroLabel4.Location = new System.Drawing.Point(871, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Manage Student";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // deptTitle
            // 
            this.deptTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deptTitle.AutoSize = true;
            this.deptTitle.ForeColor = System.Drawing.Color.Green;
            this.deptTitle.Location = new System.Drawing.Point(430, 57);
            this.deptTitle.Name = "deptTitle";
            this.deptTitle.Size = new System.Drawing.Size(193, 19);
            this.deptTitle.TabIndex = 15;
            this.deptTitle.Text = "Computer Science & Engineering";
            this.deptTitle.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Green;
            this.metroLabel1.Location = new System.Drawing.Point(488, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Department";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.AllowDrop = true;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(20, 76);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1062, 528);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 16;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.studentInfoGrid);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1054, 486);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Student Information";
            this.metroTabPage1.UseStyleColors = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // studentInfoGrid
            // 
            this.studentInfoGrid.AllowUserToAddRows = false;
            this.studentInfoGrid.AllowUserToResizeRows = false;
            this.studentInfoGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentInfoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentInfoGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studentInfoGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentInfoGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentInfoGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentInfoGrid.EnableHeadersVisualStyles = false;
            this.studentInfoGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.studentInfoGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentInfoGrid.Location = new System.Drawing.Point(16, 21);
            this.studentInfoGrid.Name = "studentInfoGrid";
            this.studentInfoGrid.ReadOnly = true;
            this.studentInfoGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentInfoGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.studentInfoGrid.RowHeadersWidth = 25;
            this.studentInfoGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.studentInfoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentInfoGrid.Size = new System.Drawing.Size(1016, 426);
            this.studentInfoGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.studentInfoGrid.TabIndex = 3;
            this.studentInfoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellContentClick);
            this.studentInfoGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentInfoGrid_CellMouseUp);
            // 
            // search
            // 
            // 
            // 
            // 
            this.search.CustomButton.BackColor = System.Drawing.Color.Green;
            this.search.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.search.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.search.CustomButton.Name = "";
            this.search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.search.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.search.CustomButton.TabIndex = 1;
            this.search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.search.CustomButton.UseCompatibleTextRendering = true;
            this.search.CustomButton.UseCustomBackColor = true;
            this.search.CustomButton.UseCustomForeColor = true;
            this.search.CustomButton.UseSelectable = true;
            this.search.CustomButton.UseStyleColors = true;
            this.search.CustomButton.UseVisualStyleBackColor = true;
            this.search.DisplayIcon = true;
            this.search.Icon = ((System.Drawing.Image)(resources.GetObject("search.Icon")));
            this.search.Lines = new string[0];
            this.search.Location = new System.Drawing.Point(880, 84);
            this.search.MaxLength = 32767;
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PromptText = "Search";
            this.search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search.SelectedText = "";
            this.search.SelectionLength = 0;
            this.search.SelectionStart = 0;
            this.search.ShortcutsEnabled = true;
            this.search.ShowButton = true;
            this.search.ShowClearButton = true;
            this.search.Size = new System.Drawing.Size(190, 23);
            this.search.TabIndex = 17;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search.UseCustomForeColor = true;
            this.search.UseSelectable = true;
            this.search.UseStyleColors = true;
            this.search.WaterMark = "Search";
            this.search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // serch1
            // 
            this.serch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serch1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.serch1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.serch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(179)))), ((int)(((byte)(158)))));
            this.serch1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serch1.ImageSize = 20;
            this.serch1.Location = new System.Drawing.Point(720, 84);
            this.serch1.Name = "serch1";
            this.serch1.Size = new System.Drawing.Size(69, 23);
            this.serch1.TabIndex = 19;
            this.serch1.Text = "&Search";
            this.serch1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.serch1.UseCustomForeColor = true;
            this.serch1.UseSelectable = true;
            this.serch1.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(968, 54);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(102, 25);
            this.metroButton1.TabIndex = 50;
            this.metroButton1.Text = "Add Student";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(179)))), ((int)(((byte)(158)))));
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.ImageSize = 20;
            this.metroLink1.Location = new System.Drawing.Point(795, 84);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(79, 23);
            this.metroLink1.TabIndex = 20;
            this.metroLink1.Text = "&Update";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click_1);
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
            // StudentDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.serch1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.deptTitle);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Name = "StudentDataControl";
            this.Size = new System.Drawing.Size(1126, 660);
            this.Load += new System.EventHandler(this.StudentDataControl_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoGrid)).EndInit();
            this.metroContextMenuDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox search;
        private MetroFramework.Controls.MetroLink serch1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLink metroLink1;
        public MetroFramework.Controls.MetroLabel deptTitle;
        public MetroFramework.Controls.MetroGrid studentInfoGrid;
        private MetroFramework.Controls.MetroContextMenu metroContextMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
    }
}
