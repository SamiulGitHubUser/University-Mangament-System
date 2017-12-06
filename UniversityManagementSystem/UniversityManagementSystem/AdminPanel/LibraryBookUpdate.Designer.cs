namespace UniversityManagementSystem
{
    partial class LibraryBookUpdate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryBookUpdate));
            this.label1 = new System.Windows.Forms.Label();
            this.bookPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BookIDComboBox = new MetroFramework.Controls.MetroComboBox();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.bookDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.authorName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.ParentTab = new MetroFramework.Controls.MetroTabPage();
            this.bookName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.addmissionTab = new MetroFramework.Controls.MetroTabControl();
            this.bookQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            this.ParentTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.addmissionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Book Details Information";
            // 
            // bookPrice
            // 
            // 
            // 
            // 
            this.bookPrice.CustomButton.Image = null;
            this.bookPrice.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.bookPrice.CustomButton.Name = "";
            this.bookPrice.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.bookPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookPrice.CustomButton.TabIndex = 1;
            this.bookPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bookPrice.CustomButton.UseSelectable = true;
            this.bookPrice.CustomButton.Visible = false;
            this.bookPrice.Lines = new string[0];
            this.bookPrice.Location = new System.Drawing.Point(381, 137);
            this.bookPrice.MaxLength = 32767;
            this.bookPrice.Name = "bookPrice";
            this.bookPrice.PasswordChar = '\0';
            this.bookPrice.PromptText = "Book Price";
            this.bookPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bookPrice.SelectedText = "";
            this.bookPrice.SelectionLength = 0;
            this.bookPrice.SelectionStart = 0;
            this.bookPrice.ShortcutsEnabled = true;
            this.bookPrice.Size = new System.Drawing.Size(310, 29);
            this.bookPrice.TabIndex = 65;
            this.bookPrice.UseSelectable = true;
            this.bookPrice.WaterMark = "Book Price";
            this.bookPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bookPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(381, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 15);
            this.metroLabel2.TabIndex = 64;
            this.metroLabel2.Text = "Book Price :";
            // 
            // BookIDComboBox
            // 
            this.BookIDComboBox.FormattingEnabled = true;
            this.BookIDComboBox.ItemHeight = 23;
            this.BookIDComboBox.Location = new System.Drawing.Point(32, 84);
            this.BookIDComboBox.Name = "BookIDComboBox";
            this.BookIDComboBox.Size = new System.Drawing.Size(310, 29);
            this.BookIDComboBox.TabIndex = 63;
            this.BookIDComboBox.UseSelectable = true;
            this.BookIDComboBox.SelectedIndexChanged += new System.EventHandler(this.BookIDComboBox_SelectedIndexChanged);
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "Library";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(592, 347);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(99, 25);
            this.metroButton1.TabIndex = 49;
            this.metroButton1.Text = "Update";
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
            this.metroLabel17.Location = new System.Drawing.Point(381, 186);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(109, 15);
            this.metroLabel17.TabIndex = 35;
            this.metroLabel17.Text = "Book Description :";
            // 
            // bookDesc
            // 
            // 
            // 
            // 
            this.bookDesc.CustomButton.Image = null;
            this.bookDesc.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.bookDesc.CustomButton.Name = "";
            this.bookDesc.CustomButton.Size = new System.Drawing.Size(99, 99);
            this.bookDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookDesc.CustomButton.TabIndex = 1;
            this.bookDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bookDesc.CustomButton.UseSelectable = true;
            this.bookDesc.CustomButton.Visible = false;
            this.bookDesc.Lines = new string[0];
            this.bookDesc.Location = new System.Drawing.Point(381, 204);
            this.bookDesc.MaxLength = 32767;
            this.bookDesc.Multiline = true;
            this.bookDesc.Name = "bookDesc";
            this.bookDesc.PasswordChar = '\0';
            this.bookDesc.PromptText = "Short Description";
            this.bookDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bookDesc.SelectedText = "";
            this.bookDesc.SelectionLength = 0;
            this.bookDesc.SelectionStart = 0;
            this.bookDesc.ShortcutsEnabled = true;
            this.bookDesc.Size = new System.Drawing.Size(310, 101);
            this.bookDesc.TabIndex = 34;
            this.bookDesc.UseSelectable = true;
            this.bookDesc.WaterMark = "Short Description";
            this.bookDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bookDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(6, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(187, 25);
            this.metroLabel1.TabIndex = 68;
            this.metroLabel1.Text = "Update Book to Library";
            // 
            // authorName
            // 
            // 
            // 
            // 
            this.authorName.CustomButton.Image = null;
            this.authorName.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.authorName.CustomButton.Name = "";
            this.authorName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.authorName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.authorName.CustomButton.TabIndex = 1;
            this.authorName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.authorName.CustomButton.UseSelectable = true;
            this.authorName.CustomButton.Visible = false;
            this.authorName.Lines = new string[0];
            this.authorName.Location = new System.Drawing.Point(32, 214);
            this.authorName.MaxLength = 32767;
            this.authorName.Name = "authorName";
            this.authorName.PasswordChar = '\0';
            this.authorName.PromptText = "Author Name";
            this.authorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.authorName.SelectedText = "";
            this.authorName.SelectionLength = 0;
            this.authorName.SelectionStart = 0;
            this.authorName.ShortcutsEnabled = true;
            this.authorName.Size = new System.Drawing.Size(310, 29);
            this.authorName.TabIndex = 25;
            this.authorName.UseSelectable = true;
            this.authorName.WaterMark = "Author Name";
            this.authorName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.authorName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel18.Location = new System.Drawing.Point(32, 196);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(52, 15);
            this.metroLabel18.TabIndex = 24;
            this.metroLabel18.Text = "Author :";
            // 
            // ParentTab
            // 
            this.ParentTab.Controls.Add(this.bookQuantity);
            this.ParentTab.Controls.Add(this.metroLabel15);
            this.ParentTab.Controls.Add(this.label1);
            this.ParentTab.Controls.Add(this.bookPrice);
            this.ParentTab.Controls.Add(this.metroLabel2);
            this.ParentTab.Controls.Add(this.BookIDComboBox);
            this.ParentTab.Controls.Add(this.metroButton1);
            this.ParentTab.Controls.Add(this.metroLabel17);
            this.ParentTab.Controls.Add(this.bookDesc);
            this.ParentTab.Controls.Add(this.authorName);
            this.ParentTab.Controls.Add(this.metroLabel18);
            this.ParentTab.Controls.Add(this.bookName);
            this.ParentTab.Controls.Add(this.metroLabel19);
            this.ParentTab.Controls.Add(this.metroLabel20);
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
            // bookName
            // 
            // 
            // 
            // 
            this.bookName.CustomButton.Image = null;
            this.bookName.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.bookName.CustomButton.Name = "";
            this.bookName.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.bookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookName.CustomButton.TabIndex = 1;
            this.bookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bookName.CustomButton.UseSelectable = true;
            this.bookName.CustomButton.Visible = false;
            this.bookName.Lines = new string[0];
            this.bookName.Location = new System.Drawing.Point(32, 137);
            this.bookName.MaxLength = 32767;
            this.bookName.Multiline = true;
            this.bookName.Name = "bookName";
            this.bookName.PasswordChar = '\0';
            this.bookName.PromptText = "Book Name";
            this.bookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bookName.SelectedText = "";
            this.bookName.SelectionLength = 0;
            this.bookName.SelectionStart = 0;
            this.bookName.ShortcutsEnabled = true;
            this.bookName.Size = new System.Drawing.Size(310, 56);
            this.bookName.TabIndex = 23;
            this.bookName.UseSelectable = true;
            this.bookName.WaterMark = "Book Name";
            this.bookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bookName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel19.Location = new System.Drawing.Point(32, 119);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(78, 15);
            this.metroLabel19.TabIndex = 22;
            this.metroLabel19.Text = "Book Name :";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel20.Location = new System.Drawing.Point(32, 66);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(58, 15);
            this.metroLabel20.TabIndex = 20;
            this.metroLabel20.Text = "Book ID :";
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
            this.metroPanel1.TabIndex = 70;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // addmissionTab
            // 
            this.addmissionTab.Controls.Add(this.ParentTab);
            this.addmissionTab.Location = new System.Drawing.Point(221, 30);
            this.addmissionTab.Name = "addmissionTab";
            this.addmissionTab.SelectedIndex = 0;
            this.addmissionTab.Size = new System.Drawing.Size(729, 436);
            this.addmissionTab.Style = MetroFramework.MetroColorStyle.Green;
            this.addmissionTab.TabIndex = 69;
            this.addmissionTab.UseSelectable = true;
            // 
            // bookQuantity
            // 
            // 
            // 
            // 
            this.bookQuantity.CustomButton.Image = null;
            this.bookQuantity.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.bookQuantity.CustomButton.Name = "";
            this.bookQuantity.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.bookQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookQuantity.CustomButton.TabIndex = 1;
            this.bookQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bookQuantity.CustomButton.UseSelectable = true;
            this.bookQuantity.CustomButton.Visible = false;
            this.bookQuantity.Lines = new string[0];
            this.bookQuantity.Location = new System.Drawing.Point(32, 276);
            this.bookQuantity.MaxLength = 32767;
            this.bookQuantity.Name = "bookQuantity";
            this.bookQuantity.PasswordChar = '\0';
            this.bookQuantity.PromptText = "Book Quantity";
            this.bookQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bookQuantity.SelectedText = "";
            this.bookQuantity.SelectionLength = 0;
            this.bookQuantity.SelectionStart = 0;
            this.bookQuantity.ShortcutsEnabled = true;
            this.bookQuantity.Size = new System.Drawing.Size(310, 29);
            this.bookQuantity.TabIndex = 70;
            this.bookQuantity.UseSelectable = true;
            this.bookQuantity.WaterMark = "Book Quantity";
            this.bookQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bookQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(32, 258);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(93, 15);
            this.metroLabel15.TabIndex = 69;
            this.metroLabel15.Text = "Book Quantity :";
            // 
            // LibraryBookUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 473);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.addmissionTab);
            this.Name = "LibraryBookUpdate";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.BookUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            this.ParentTab.ResumeLayout(false);
            this.ParentTab.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.addmissionTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox bookPrice;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox BookIDComboBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox bookDesc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox authorName;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTabPage ParentTab;
        private MetroFramework.Controls.MetroTextBox bookName;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl addmissionTab;
        //private UniversityDataBaseDataSet1 universityDataBaseDataSet1;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private MetroFramework.Controls.MetroTextBox bookQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        //private UniversityDataBaseDataSet1TableAdapters.LibraryTableAdapter libraryTableAdapter;
    }
}