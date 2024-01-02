namespace kutuphane_otomasyonu_project
{
    partial class AddAdmin_Form
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
            this.addBook_pnl = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.publisher_lbl = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.bookName_lbl = new System.Windows.Forms.Label();
            this.addBook_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBook_pnl
            // 
            this.addBook_pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addBook_pnl.Controls.Add(this.add_btn);
            this.addBook_pnl.Controls.Add(this.password_txt);
            this.addBook_pnl.Controls.Add(this.publisher_lbl);
            this.addBook_pnl.Controls.Add(this.email_txt);
            this.addBook_pnl.Controls.Add(this.email_lbl);
            this.addBook_pnl.Controls.Add(this.name_txt);
            this.addBook_pnl.Controls.Add(this.bookName_lbl);
            this.addBook_pnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.addBook_pnl.Location = new System.Drawing.Point(155, 191);
            this.addBook_pnl.Name = "addBook_pnl";
            this.addBook_pnl.Size = new System.Drawing.Size(916, 284);
            this.addBook_pnl.TabIndex = 8;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.add_btn.Location = new System.Drawing.Point(405, 207);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(278, 34);
            this.add_btn.TabIndex = 20;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.password_txt.Location = new System.Drawing.Point(405, 135);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(278, 30);
            this.password_txt.TabIndex = 13;
            // 
            // publisher_lbl
            // 
            this.publisher_lbl.AutoSize = true;
            this.publisher_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.publisher_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.publisher_lbl.Location = new System.Drawing.Point(268, 144);
            this.publisher_lbl.Name = "publisher_lbl";
            this.publisher_lbl.Size = new System.Drawing.Size(90, 21);
            this.publisher_lbl.TabIndex = 12;
            this.publisher_lbl.Text = "Password";
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.email_txt.Location = new System.Drawing.Point(405, 87);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(278, 30);
            this.email_txt.TabIndex = 11;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.email_lbl.Location = new System.Drawing.Point(268, 96);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(55, 21);
            this.email_lbl.TabIndex = 7;
            this.email_lbl.Text = "Email";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.name_txt.Location = new System.Drawing.Point(405, 42);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(278, 30);
            this.name_txt.TabIndex = 6;
            // 
            // bookName_lbl
            // 
            this.bookName_lbl.AutoSize = true;
            this.bookName_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookName_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bookName_lbl.Location = new System.Drawing.Point(268, 51);
            this.bookName_lbl.Name = "bookName_lbl";
            this.bookName_lbl.Size = new System.Drawing.Size(64, 21);
            this.bookName_lbl.TabIndex = 5;
            this.bookName_lbl.Text = "Name";
            // 
            // AddAdmin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1224, 727);
            this.ControlBox = false;
            this.Controls.Add(this.addBook_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAdmin_Form";
            this.Text = "AddAdmin_Form";
            this.addBook_pnl.ResumeLayout(false);
            this.addBook_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addBook_pnl;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label publisher_lbl;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label bookName_lbl;
    }
}