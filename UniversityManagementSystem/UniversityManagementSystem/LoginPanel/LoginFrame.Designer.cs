namespace UniversityManagementSystem
{
    partial class LoginFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrame));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userName = new MetroFramework.Controls.MetroTextBox();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.btnLoggin = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.metroPanel1.Controls.Add(this.label6);
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(879, 760);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vonique64", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(294, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vonique64", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(277, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vonique64", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(159, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Smart University";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vonique64", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(159, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wellcome";
            // 
            // userName
            // 
            // 
            // 
            // 
            this.userName.CustomButton.Image = null;
            this.userName.CustomButton.Location = new System.Drawing.Point(248, 2);
            this.userName.CustomButton.Name = "";
            this.userName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userName.CustomButton.TabIndex = 1;
            this.userName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userName.CustomButton.UseSelectable = true;
            this.userName.CustomButton.Visible = false;
            this.userName.DisplayIcon = true;
            this.userName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Icon = ((System.Drawing.Image)(resources.GetObject("userName.Icon")));
            this.userName.Lines = new string[0];
            this.userName.Location = new System.Drawing.Point(149, 397);
            this.userName.MaxLength = 32767;
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.PromptText = "User Name";
            this.userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userName.SelectedText = "";
            this.userName.SelectionLength = 0;
            this.userName.SelectionStart = 0;
            this.userName.ShortcutsEnabled = true;
            this.userName.Size = new System.Drawing.Size(272, 26);
            this.userName.Style = MetroFramework.MetroColorStyle.White;
            this.userName.TabIndex = 2;
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userName.UseCustomBackColor = true;
            this.userName.UseCustomForeColor = true;
            this.userName.UseSelectable = true;
            this.userName.UseStyleColors = true;
            this.userName.WaterMark = "User Name";
            this.userName.WaterMarkColor = System.Drawing.Color.White;
            this.userName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(248, 2);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.DisplayIcon = true;
            this.password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Icon = ((System.Drawing.Image)(resources.GetObject("password.Icon")));
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(149, 440);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PromptText = "Password";
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(272, 26);
            this.password.Style = MetroFramework.MetroColorStyle.White;
            this.password.TabIndex = 4;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.UseCustomBackColor = true;
            this.password.UseCustomForeColor = true;
            this.password.UseSelectable = true;
            this.password.UseStyleColors = true;
            this.password.WaterMark = "Password";
            this.password.WaterMarkColor = System.Drawing.Color.White;
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLoggin
            // 
            this.btnLoggin.BackColor = System.Drawing.Color.White;
            this.btnLoggin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(118)))));
            this.btnLoggin.Location = new System.Drawing.Point(292, 502);
            this.btnLoggin.Name = "btnLoggin";
            this.btnLoggin.Size = new System.Drawing.Size(129, 26);
            this.btnLoggin.TabIndex = 0;
            this.btnLoggin.Text = "Login";
            this.btnLoggin.UseCustomBackColor = true;
            this.btnLoggin.UseCustomForeColor = true;
            this.btnLoggin.UseSelectable = true;
            this.btnLoggin.Click += new System.EventHandler(this.btnLoggin_Click_1);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(118)))));
            this.metroPanel2.Controls.Add(this.metroPanel3);
            this.metroPanel2.Controls.Add(this.label2);
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Controls.Add(this.userName);
            this.metroPanel2.Controls.Add(this.password);
            this.metroPanel2.Controls.Add(this.btnLoggin);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(875, 5);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(505, 760);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroLink2);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(362, 5);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(125, 38);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLink2
            // 
            this.metroLink2.Image = ((System.Drawing.Image)(resources.GetObject("metroLink2.Image")));
            this.metroLink2.ImageSize = 28;
            this.metroLink2.Location = new System.Drawing.Point(89, -2);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(33, 40);
            this.metroLink2.TabIndex = 7;
            this.metroLink2.UseCustomBackColor = true;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vonique64", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "To Your Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vonique64", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // LoginFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "LoginFrame";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginFrame_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox userName;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroButton btnLoggin;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLink metroLink2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}