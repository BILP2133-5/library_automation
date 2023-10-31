namespace kutuphane_otomasyonu_project
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.loginNavbar_panel = new System.Windows.Forms.Panel();
            this.login_picbox = new System.Windows.Forms.PictureBox();
            this.login_lbl = new System.Windows.Forms.Label();
            this.loginArea_pnl = new System.Windows.Forms.Panel();
            this.passwordReminder_pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.forgotPass_linklbl = new System.Windows.Forms.LinkLabel();
            this.login_btn = new System.Windows.Forms.Button();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.reminder_timer = new System.Windows.Forms.Timer(this.components);
            this.loginNavbar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_picbox)).BeginInit();
            this.loginArea_pnl.SuspendLayout();
            this.passwordReminder_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginNavbar_panel
            // 
            this.loginNavbar_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginNavbar_panel.Controls.Add(this.login_picbox);
            this.loginNavbar_panel.Controls.Add(this.login_lbl);
            this.loginNavbar_panel.Location = new System.Drawing.Point(12, 12);
            this.loginNavbar_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginNavbar_panel.Name = "loginNavbar_panel";
            this.loginNavbar_panel.Size = new System.Drawing.Size(376, 100);
            this.loginNavbar_panel.TabIndex = 0;
            // 
            // login_picbox
            // 
            this.login_picbox.Image = ((System.Drawing.Image)(resources.GetObject("login_picbox.Image")));
            this.login_picbox.Location = new System.Drawing.Point(5, 21);
            this.login_picbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_picbox.Name = "login_picbox";
            this.login_picbox.Size = new System.Drawing.Size(100, 50);
            this.login_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.login_picbox.TabIndex = 1;
            this.login_picbox.TabStop = false;
            // 
            // login_lbl
            // 
            this.login_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_lbl.Location = new System.Drawing.Point(111, 21);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(260, 50);
            this.login_lbl.TabIndex = 0;
            this.login_lbl.Text = "Kütüphane Otomasyonu Giriş Ekranı";
            // 
            // loginArea_pnl
            // 
            this.loginArea_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginArea_pnl.Controls.Add(this.passwordReminder_pnl);
            this.loginArea_pnl.Controls.Add(this.forgotPass_linklbl);
            this.loginArea_pnl.Controls.Add(this.login_btn);
            this.loginArea_pnl.Controls.Add(this.password_txt);
            this.loginArea_pnl.Controls.Add(this.email_txt);
            this.loginArea_pnl.Controls.Add(this.password_lbl);
            this.loginArea_pnl.Controls.Add(this.email_lbl);
            this.loginArea_pnl.Location = new System.Drawing.Point(12, 129);
            this.loginArea_pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginArea_pnl.Name = "loginArea_pnl";
            this.loginArea_pnl.Size = new System.Drawing.Size(375, 252);
            this.loginArea_pnl.TabIndex = 1;
            // 
            // passwordReminder_pnl
            // 
            this.passwordReminder_pnl.BackColor = System.Drawing.SystemColors.Info;
            this.passwordReminder_pnl.Controls.Add(this.label1);
            this.passwordReminder_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordReminder_pnl.Location = new System.Drawing.Point(0, 0);
            this.passwordReminder_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.passwordReminder_pnl.Name = "passwordReminder_pnl";
            this.passwordReminder_pnl.Size = new System.Drawing.Size(373, 250);
            this.passwordReminder_pnl.TabIndex = 2;
            this.passwordReminder_pnl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifreniz T.C. Kimlik Numaranızdır.";
            // 
            // forgotPass_linklbl
            // 
            this.forgotPass_linklbl.AutoSize = true;
            this.forgotPass_linklbl.Location = new System.Drawing.Point(227, 142);
            this.forgotPass_linklbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotPass_linklbl.Name = "forgotPass_linklbl";
            this.forgotPass_linklbl.Size = new System.Drawing.Size(99, 16);
            this.forgotPass_linklbl.TabIndex = 5;
            this.forgotPass_linklbl.TabStop = true;
            this.forgotPass_linklbl.Text = "Şifremi Unuttum";
            this.forgotPass_linklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPass_linklbl_LinkClicked);
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_btn.Location = new System.Drawing.Point(84, 183);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(251, 34);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Giriş";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_txt.Location = new System.Drawing.Point(83, 98);
            this.password_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(249, 26);
            this.password_txt.TabIndex = 3;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email_txt.Location = new System.Drawing.Point(83, 46);
            this.email_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(249, 26);
            this.email_txt.TabIndex = 2;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_lbl.Location = new System.Drawing.Point(19, 102);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(49, 20);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Şifre:";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email_lbl.Location = new System.Drawing.Point(19, 49);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(56, 20);
            this.email_lbl.TabIndex = 0;
            this.email_lbl.Text = "Email:";
            // 
            // reminder_timer
            // 
            this.reminder_timer.Tick += new System.EventHandler(this.reminder_timer_Tick);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 394);
            this.Controls.Add(this.loginArea_pnl);
            this.Controls.Add(this.loginNavbar_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "login_form";
            this.Text = "Giriş Yap";
            this.loginNavbar_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.login_picbox)).EndInit();
            this.loginArea_pnl.ResumeLayout(false);
            this.loginArea_pnl.PerformLayout();
            this.passwordReminder_pnl.ResumeLayout(false);
            this.passwordReminder_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginNavbar_panel;
        private System.Windows.Forms.PictureBox login_picbox;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Panel loginArea_pnl;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.LinkLabel forgotPass_linklbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel passwordReminder_pnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer reminder_timer;
    }
}

