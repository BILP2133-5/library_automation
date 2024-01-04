namespace kutuphane_otomasyonu_project
{
    partial class Register_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Form));
            this.loginRight_panel = new System.Windows.Forms.Panel();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_panel = new System.Windows.Forms.Panel();
            this.name_text = new System.Windows.Forms.TextBox();
            this.nameLogo_pic = new System.Windows.Forms.PictureBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.password_panel = new System.Windows.Forms.Panel();
            this.hide_pic = new System.Windows.Forms.PictureBox();
            this.show_pic = new System.Windows.Forms.PictureBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.passwordLogo_pic = new System.Windows.Forms.PictureBox();
            this.email_panel = new System.Windows.Forms.Panel();
            this.email_text = new System.Windows.Forms.TextBox();
            this.emailLogo_pic = new System.Windows.Forms.PictureBox();
            this.loginRight_panel.SuspendLayout();
            this.name_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameLogo_pic)).BeginInit();
            this.password_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLogo_pic)).BeginInit();
            this.email_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailLogo_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // loginRight_panel
            // 
            this.loginRight_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.loginRight_panel.Controls.Add(this.name_lbl);
            this.loginRight_panel.Controls.Add(this.name_panel);
            this.loginRight_panel.Controls.Add(this.password_lbl);
            this.loginRight_panel.Controls.Add(this.email_lbl);
            this.loginRight_panel.Controls.Add(this.label5);
            this.loginRight_panel.Controls.Add(this.register_btn);
            this.loginRight_panel.Controls.Add(this.label4);
            this.loginRight_panel.Controls.Add(this.password_panel);
            this.loginRight_panel.Controls.Add(this.email_panel);
            this.loginRight_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginRight_panel.Location = new System.Drawing.Point(0, 0);
            this.loginRight_panel.Margin = new System.Windows.Forms.Padding(2);
            this.loginRight_panel.Name = "loginRight_panel";
            this.loginRight_panel.Size = new System.Drawing.Size(447, 578);
            this.loginRight_panel.TabIndex = 2;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.name_lbl.Location = new System.Drawing.Point(6, 144);
            this.name_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(76, 23);
            this.name_lbl.TabIndex = 14;
            this.name_lbl.Text = "Name:";
            this.name_lbl.Click += new System.EventHandler(this.name_lbl_Click);
            // 
            // name_panel
            // 
            this.name_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.name_panel.Controls.Add(this.name_text);
            this.name_panel.Controls.Add(this.nameLogo_pic);
            this.name_panel.Location = new System.Drawing.Point(0, 182);
            this.name_panel.Margin = new System.Windows.Forms.Padding(2);
            this.name_panel.Name = "name_panel";
            this.name_panel.Size = new System.Drawing.Size(447, 37);
            this.name_panel.TabIndex = 13;
            this.name_panel.Click += new System.EventHandler(this.name_panel_Click);
            // 
            // name_text
            // 
            this.name_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.name_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_text.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_text.Location = new System.Drawing.Point(43, 8);
            this.name_text.Margin = new System.Windows.Forms.Padding(2);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(369, 29);
            this.name_text.TabIndex = 1;
            this.name_text.Click += new System.EventHandler(this.name_text_Click);
            // 
            // nameLogo_pic
            // 
            this.nameLogo_pic.Image = ((System.Drawing.Image)(resources.GetObject("nameLogo_pic.Image")));
            this.nameLogo_pic.Location = new System.Drawing.Point(10, 6);
            this.nameLogo_pic.Margin = new System.Windows.Forms.Padding(2);
            this.nameLogo_pic.Name = "nameLogo_pic";
            this.nameLogo_pic.Size = new System.Drawing.Size(24, 24);
            this.nameLogo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nameLogo_pic.TabIndex = 0;
            this.nameLogo_pic.TabStop = false;
            this.nameLogo_pic.Click += new System.EventHandler(this.nameLogo_pic_Click);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.password_lbl.Location = new System.Drawing.Point(4, 340);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(108, 23);
            this.password_lbl.TabIndex = 12;
            this.password_lbl.Text = "Password:";
            this.password_lbl.Click += new System.EventHandler(this.password_lbl_Click);
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.email_lbl.Location = new System.Drawing.Point(6, 245);
            this.email_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(67, 23);
            this.email_lbl.TabIndex = 11;
            this.email_lbl.Text = "Email:";
            this.email_lbl.Click += new System.EventHandler(this.email_lbl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(58, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "We are so happy to see you!";
            // 
            // register_btn
            // 
            this.register_btn.AutoSize = true;
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.register_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.register_btn.Location = new System.Drawing.Point(41, 442);
            this.register_btn.Margin = new System.Windows.Forms.Padding(2);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(369, 33);
            this.register_btn.TabIndex = 6;
            this.register_btn.Text = "REGISTER";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(174, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Register";
            // 
            // password_panel
            // 
            this.password_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.password_panel.Controls.Add(this.hide_pic);
            this.password_panel.Controls.Add(this.show_pic);
            this.password_panel.Controls.Add(this.password_text);
            this.password_panel.Controls.Add(this.passwordLogo_pic);
            this.password_panel.Location = new System.Drawing.Point(-2, 376);
            this.password_panel.Margin = new System.Windows.Forms.Padding(2);
            this.password_panel.Name = "password_panel";
            this.password_panel.Size = new System.Drawing.Size(447, 37);
            this.password_panel.TabIndex = 4;
            this.password_panel.Click += new System.EventHandler(this.password_panel_Click);
            // 
            // hide_pic
            // 
            this.hide_pic.Image = ((System.Drawing.Image)(resources.GetObject("hide_pic.Image")));
            this.hide_pic.Location = new System.Drawing.Point(416, 8);
            this.hide_pic.Margin = new System.Windows.Forms.Padding(2);
            this.hide_pic.Name = "hide_pic";
            this.hide_pic.Size = new System.Drawing.Size(20, 20);
            this.hide_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hide_pic.TabIndex = 3;
            this.hide_pic.TabStop = false;
            this.hide_pic.Visible = false;
            this.hide_pic.Click += new System.EventHandler(this.hide_pic_Click);
            // 
            // show_pic
            // 
            this.show_pic.Image = ((System.Drawing.Image)(resources.GetObject("show_pic.Image")));
            this.show_pic.Location = new System.Drawing.Point(416, 8);
            this.show_pic.Margin = new System.Windows.Forms.Padding(2);
            this.show_pic.Name = "show_pic";
            this.show_pic.Size = new System.Drawing.Size(20, 20);
            this.show_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.show_pic.TabIndex = 2;
            this.show_pic.TabStop = false;
            this.show_pic.Visible = false;
            this.show_pic.Click += new System.EventHandler(this.show_pic_Click);
            // 
            // password_text
            // 
            this.password_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.password_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_text.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_text.Location = new System.Drawing.Point(43, 8);
            this.password_text.Margin = new System.Windows.Forms.Padding(2);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(369, 29);
            this.password_text.TabIndex = 2;
            this.password_text.UseSystemPasswordChar = true;
            this.password_text.Click += new System.EventHandler(this.password_text_Click);
            // 
            // passwordLogo_pic
            // 
            this.passwordLogo_pic.Image = ((System.Drawing.Image)(resources.GetObject("passwordLogo_pic.Image")));
            this.passwordLogo_pic.Location = new System.Drawing.Point(10, 6);
            this.passwordLogo_pic.Margin = new System.Windows.Forms.Padding(2);
            this.passwordLogo_pic.Name = "passwordLogo_pic";
            this.passwordLogo_pic.Size = new System.Drawing.Size(24, 24);
            this.passwordLogo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordLogo_pic.TabIndex = 1;
            this.passwordLogo_pic.TabStop = false;
            this.passwordLogo_pic.Click += new System.EventHandler(this.passwordLogo_pic_Click);
            // 
            // email_panel
            // 
            this.email_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.email_panel.Controls.Add(this.email_text);
            this.email_panel.Controls.Add(this.emailLogo_pic);
            this.email_panel.Location = new System.Drawing.Point(0, 283);
            this.email_panel.Margin = new System.Windows.Forms.Padding(2);
            this.email_panel.Name = "email_panel";
            this.email_panel.Size = new System.Drawing.Size(447, 37);
            this.email_panel.TabIndex = 3;
            this.email_panel.Click += new System.EventHandler(this.email_panel_Click);
            // 
            // email_text
            // 
            this.email_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.email_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_text.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email_text.Location = new System.Drawing.Point(43, 8);
            this.email_text.Margin = new System.Windows.Forms.Padding(2);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(369, 29);
            this.email_text.TabIndex = 1;
            this.email_text.Click += new System.EventHandler(this.email_text_Click);
            // 
            // emailLogo_pic
            // 
            this.emailLogo_pic.Image = ((System.Drawing.Image)(resources.GetObject("emailLogo_pic.Image")));
            this.emailLogo_pic.Location = new System.Drawing.Point(10, 6);
            this.emailLogo_pic.Margin = new System.Windows.Forms.Padding(2);
            this.emailLogo_pic.Name = "emailLogo_pic";
            this.emailLogo_pic.Size = new System.Drawing.Size(24, 24);
            this.emailLogo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emailLogo_pic.TabIndex = 0;
            this.emailLogo_pic.TabStop = false;
            this.emailLogo_pic.Click += new System.EventHandler(this.emailLogo_pic_Click);
            // 
            // Register_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(447, 578);
            this.ControlBox = false;
            this.Controls.Add(this.loginRight_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register_Form";
            this.loginRight_panel.ResumeLayout(false);
            this.loginRight_panel.PerformLayout();
            this.name_panel.ResumeLayout(false);
            this.name_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameLogo_pic)).EndInit();
            this.password_panel.ResumeLayout(false);
            this.password_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLogo_pic)).EndInit();
            this.email_panel.ResumeLayout(false);
            this.email_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailLogo_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel password_panel;
        private System.Windows.Forms.PictureBox hide_pic;
        private System.Windows.Forms.PictureBox show_pic;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.PictureBox passwordLogo_pic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Panel name_panel;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.PictureBox nameLogo_pic;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Panel email_panel;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.PictureBox emailLogo_pic;
        public System.Windows.Forms.Panel loginRight_panel;
    }
}