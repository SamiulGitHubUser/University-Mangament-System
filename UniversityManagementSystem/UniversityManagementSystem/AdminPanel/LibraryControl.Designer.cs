namespace UniversityManagementSystem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryControl));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.LibraryGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.deptTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.search = new MetroFramework.Controls.MetroLink();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.DeleteContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryGrid)).BeginInit();
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
            this.metroTabControl1.Size = new System.Drawing.Size(1062, 561);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 64;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.LibraryGrid);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1054, 519);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Library Information";
            this.metroTabPage1.UseStyleColors = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // LibraryGrid
            // 
            this.LibraryGrid.AllowUserToAddRows = false;
            this.LibraryGrid.AllowUserToResizeRows = false;
            this.LibraryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LibraryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LibraryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LibraryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LibraryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LibraryGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.LibraryGrid.EnableHeadersVisualStyles = false;
            this.LibraryGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LibraryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LibraryGrid.Location = new System.Drawing.Point(157, 17);
            this.LibraryGrid.Name = "LibraryGrid";
            this.LibraryGrid.ReadOnly = true;
            this.LibraryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LibraryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LibraryGrid.RowHeadersWidth = 25;
            this.LibraryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LibraryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LibraryGrid.Size = new System.Drawing.Size(860, 489);
            this.LibraryGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.LibraryGrid.TabIndex = 2;
            this.LibraryGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LibraryGrid_CellMouseUp);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(-4, 461);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(143, 25);
            this.metroLabel7.TabIndex = 69;
            this.metroLabel7.Text = "Book Information";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(-4, 436);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 25);
            this.metroLabel6.TabIndex = 68;
            this.metroLabel6.Text = "Unavailable";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(-4, 411);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(32, 25);
            this.metroLabel5.TabIndex = 67;
            this.metroLabel5.Text = "Or";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(-4, 386);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 25);
            this.metroLabel2.TabIndex = 66;
            this.metroLabel2.Text = "Available";
            // 
            // deptTitle
            // 
            this.deptTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deptTitle.AutoSize = true;
            this.deptTitle.ForeColor = System.Drawing.Color.Green;
            this.deptTitle.Location = new System.Drawing.Point(453, 57);
            this.deptTitle.Name = "deptTitle";
            this.deptTitle.Size = new System.Drawing.Size(165, 19);
            this.deptTitle.TabIndex = 63;
            this.deptTitle.Text = "Available All Type Of Book";
            this.deptTitle.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Green;
            this.metroLabel1.Location = new System.Drawing.Point(511, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 61;
            this.metroLabel1.Text = "Library";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Green;
            this.metroLabel4.Location = new System.Drawing.Point(894, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(102, 19);
            this.metroLabel4.TabIndex = 62;
            this.metroLabel4.Text = "Manage Library";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Green;
            this.metroLabel3.Location = new System.Drawing.Point(159, 0);
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
            this.metroButton1.Location = new System.Drawing.Point(991, 54);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(102, 25);
            this.metroButton1.TabIndex = 68;
            this.metroButton1.Text = "Add Book";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.search.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(179)))), ((int)(((byte)(158)))));
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.ImageSize = 20;
            this.search.Location = new System.Drawing.Point(743, 84);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(69, 23);
            this.search.TabIndex = 69;
            this.search.Text = "&Search";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search.UseCustomForeColor = true;
            this.search.UseSelectable = true;
            this.search.Click += new System.EventHandler(this.search_Click);
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
            this.metroLink4.Location = new System.Drawing.Point(818, 84);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(79, 23);
            this.metroLink4.TabIndex = 70;
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
            this.metroTextBox1.Location = new System.Drawing.Point(903, 84);
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
            // DeleteContextMenu
            // 
            this.DeleteContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteBookToolStripMenuItem});
            this.DeleteContextMenu.Name = "DeleteContextMenu";
            this.DeleteContextMenu.Size = new System.Drawing.Size(138, 26);
            this.DeleteContextMenu.Style = MetroFramework.MetroColorStyle.Orange;
            this.DeleteContextMenu.UseStyleColors = true;
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.deleteBookToolStripMenuItem.Text = "Delete Book";
            this.deleteBookToolStripMenuItem.Click += new System.EventHandler(this.deleteBookToolStripMenuItem_Click);
            // 
            // LibraryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLink4);
            this.Controls.Add(this.search);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.deptTitle);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton1);
            this.Name = "LibraryControl";
            this.Size = new System.Drawing.Size(1120, 640);
            this.Load += new System.EventHandler(this.LibraryControl_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryGrid)).EndInit();
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
        private MetroFramework.Controls.MetroLink search;
        private MetroFramework.Controls.MetroLink metroLink4;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroGrid LibraryGrid;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroContextMenu DeleteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
    }
}
