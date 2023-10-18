namespace kutuphane_otomasyonu_project
{
    partial class addBookForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.aboutBook_rchtxt = new System.Windows.Forms.RichTextBox();
            this.aboutBook_lbl = new System.Windows.Forms.Label();
            this.author_txt = new System.Windows.Forms.TextBox();
            this.author_lbl = new System.Windows.Forms.Label();
            this.language_txt = new System.Windows.Forms.TextBox();
            this.language_lbl = new System.Windows.Forms.Label();
            this.publisher_txt = new System.Windows.Forms.TextBox();
            this.publisher_lbl = new System.Windows.Forms.Label();
            this.publicationYear_txt = new System.Windows.Forms.TextBox();
            this.publicationYear_lbl = new System.Windows.Forms.Label();
            this.bookName_txt = new System.Windows.Forms.TextBox();
            this.bookName_lbl = new System.Windows.Forms.Label();
            this.addBook_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBook_pnl
            // 
            this.addBook_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addBook_pnl.Controls.Add(this.button1);
            this.addBook_pnl.Controls.Add(this.aboutBook_rchtxt);
            this.addBook_pnl.Controls.Add(this.aboutBook_lbl);
            this.addBook_pnl.Controls.Add(this.author_txt);
            this.addBook_pnl.Controls.Add(this.author_lbl);
            this.addBook_pnl.Controls.Add(this.language_txt);
            this.addBook_pnl.Controls.Add(this.language_lbl);
            this.addBook_pnl.Controls.Add(this.publisher_txt);
            this.addBook_pnl.Controls.Add(this.publisher_lbl);
            this.addBook_pnl.Controls.Add(this.publicationYear_txt);
            this.addBook_pnl.Controls.Add(this.publicationYear_lbl);
            this.addBook_pnl.Controls.Add(this.bookName_txt);
            this.addBook_pnl.Controls.Add(this.bookName_lbl);
            this.addBook_pnl.Location = new System.Drawing.Point(12, 12);
            this.addBook_pnl.Name = "addBook_pnl";
            this.addBook_pnl.Size = new System.Drawing.Size(820, 432);
            this.addBook_pnl.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(281, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboutBook_rchtxt
            // 
            this.aboutBook_rchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.aboutBook_rchtxt.Location = new System.Drawing.Point(500, 41);
            this.aboutBook_rchtxt.Name = "aboutBook_rchtxt";
            this.aboutBook_rchtxt.Size = new System.Drawing.Size(293, 294);
            this.aboutBook_rchtxt.TabIndex = 19;
            this.aboutBook_rchtxt.Text = "";
            // 
            // aboutBook_lbl
            // 
            this.aboutBook_lbl.AutoSize = true;
            this.aboutBook_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.aboutBook_lbl.Location = new System.Drawing.Point(496, 18);
            this.aboutBook_lbl.Name = "aboutBook_lbl";
            this.aboutBook_lbl.Size = new System.Drawing.Size(126, 20);
            this.aboutBook_lbl.TabIndex = 18;
            this.aboutBook_lbl.Text = "Kitap Hakkında:";
            // 
            // author_txt
            // 
            this.author_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.author_txt.Location = new System.Drawing.Point(132, 271);
            this.author_txt.Name = "author_txt";
            this.author_txt.Size = new System.Drawing.Size(278, 26);
            this.author_txt.TabIndex = 17;
            // 
            // author_lbl
            // 
            this.author_lbl.AutoSize = true;
            this.author_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.author_lbl.Location = new System.Drawing.Point(37, 274);
            this.author_lbl.Name = "author_lbl";
            this.author_lbl.Size = new System.Drawing.Size(61, 20);
            this.author_lbl.TabIndex = 16;
            this.author_lbl.Text = "Yazarı:";
            // 
            // language_txt
            // 
            this.language_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.language_txt.Location = new System.Drawing.Point(132, 222);
            this.language_txt.Name = "language_txt";
            this.language_txt.Size = new System.Drawing.Size(278, 26);
            this.language_txt.TabIndex = 15;
            // 
            // language_lbl
            // 
            this.language_lbl.AutoSize = true;
            this.language_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.language_lbl.Location = new System.Drawing.Point(37, 225);
            this.language_lbl.Name = "language_lbl";
            this.language_lbl.Size = new System.Drawing.Size(39, 20);
            this.language_lbl.TabIndex = 14;
            this.language_lbl.Text = "Dili:";
            // 
            // publisher_txt
            // 
            this.publisher_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.publisher_txt.Location = new System.Drawing.Point(132, 176);
            this.publisher_txt.Name = "publisher_txt";
            this.publisher_txt.Size = new System.Drawing.Size(278, 26);
            this.publisher_txt.TabIndex = 13;
            // 
            // publisher_lbl
            // 
            this.publisher_lbl.AutoSize = true;
            this.publisher_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.publisher_lbl.Location = new System.Drawing.Point(37, 179);
            this.publisher_lbl.Name = "publisher_lbl";
            this.publisher_lbl.Size = new System.Drawing.Size(75, 20);
            this.publisher_lbl.TabIndex = 12;
            this.publisher_lbl.Text = "Yayınevi:";
            // 
            // publicationYear_txt
            // 
            this.publicationYear_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.publicationYear_txt.Location = new System.Drawing.Point(132, 128);
            this.publicationYear_txt.Name = "publicationYear_txt";
            this.publicationYear_txt.Size = new System.Drawing.Size(278, 26);
            this.publicationYear_txt.TabIndex = 11;
            this.publicationYear_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.publicationYear_txt_KeyPress);
            // 
            // publicationYear_lbl
            // 
            this.publicationYear_lbl.AutoSize = true;
            this.publicationYear_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.publicationYear_lbl.Location = new System.Drawing.Point(37, 131);
            this.publicationYear_lbl.Name = "publicationYear_lbl";
            this.publicationYear_lbl.Size = new System.Drawing.Size(89, 20);
            this.publicationYear_lbl.TabIndex = 7;
            this.publicationYear_lbl.Text = "Basım Yılı:";
            // 
            // bookName_txt
            // 
            this.bookName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bookName_txt.Location = new System.Drawing.Point(132, 83);
            this.bookName_txt.Name = "bookName_txt";
            this.bookName_txt.Size = new System.Drawing.Size(278, 26);
            this.bookName_txt.TabIndex = 6;
            // 
            // bookName_lbl
            // 
            this.bookName_lbl.AutoSize = true;
            this.bookName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bookName_lbl.Location = new System.Drawing.Point(37, 86);
            this.bookName_lbl.Name = "bookName_lbl";
            this.bookName_lbl.Size = new System.Drawing.Size(81, 20);
            this.bookName_lbl.TabIndex = 5;
            this.bookName_lbl.Text = "Kitap Adı:";
            // 
            // addBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 456);
            this.Controls.Add(this.addBook_pnl);
            this.Name = "addBookForm";
            this.Text = "addBook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addBookForm_FormClosed);
            this.addBook_pnl.ResumeLayout(false);
            this.addBook_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addBook_pnl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox aboutBook_rchtxt;
        private System.Windows.Forms.Label aboutBook_lbl;
        private System.Windows.Forms.TextBox author_txt;
        private System.Windows.Forms.Label author_lbl;
        private System.Windows.Forms.TextBox language_txt;
        private System.Windows.Forms.Label language_lbl;
        private System.Windows.Forms.TextBox publisher_txt;
        private System.Windows.Forms.Label publisher_lbl;
        private System.Windows.Forms.TextBox publicationYear_txt;
        private System.Windows.Forms.Label publicationYear_lbl;
        private System.Windows.Forms.TextBox bookName_txt;
        private System.Windows.Forms.Label bookName_lbl;
    }
}