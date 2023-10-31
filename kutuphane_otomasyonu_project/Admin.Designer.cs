namespace kutuphane_otomasyonu_project
{
    partial class admin_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_panel));
            this.adminNavbar_pnl = new System.Windows.Forms.Panel();
            this.admin_picbox = new System.Windows.Forms.PictureBox();
            this.admin_lbl = new System.Windows.Forms.Label();
            this.addBook_btn = new System.Windows.Forms.Button();
            this.aboutBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookList_datagrdvw = new System.Windows.Forms.DataGridView();
            this.adminNavbar_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookList_datagrdvw)).BeginInit();
            this.SuspendLayout();
            // 
            // adminNavbar_pnl
            // 
            this.adminNavbar_pnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminNavbar_pnl.Controls.Add(this.admin_picbox);
            this.adminNavbar_pnl.Controls.Add(this.admin_lbl);
            this.adminNavbar_pnl.Location = new System.Drawing.Point(9, 10);
            this.adminNavbar_pnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminNavbar_pnl.Name = "adminNavbar_pnl";
            this.adminNavbar_pnl.Size = new System.Drawing.Size(938, 81);
            this.adminNavbar_pnl.TabIndex = 0;
            // 
            // admin_picbox
            // 
            this.admin_picbox.Image = ((System.Drawing.Image)(resources.GetObject("admin_picbox.Image")));
            this.admin_picbox.Location = new System.Drawing.Point(293, 18);
            this.admin_picbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admin_picbox.Name = "admin_picbox";
            this.admin_picbox.Size = new System.Drawing.Size(75, 41);
            this.admin_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin_picbox.TabIndex = 1;
            this.admin_picbox.TabStop = false;
            // 
            // admin_lbl
            // 
            this.admin_lbl.AutoSize = true;
            this.admin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.admin_lbl.Location = new System.Drawing.Point(373, 30);
            this.admin_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.admin_lbl.Name = "admin_lbl";
            this.admin_lbl.Size = new System.Drawing.Size(290, 18);
            this.admin_lbl.TabIndex = 0;
            this.admin_lbl.Text = "Kütüphane Otomasyonu Admin Paneli";
            // 
            // addBook_btn
            // 
            this.addBook_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.addBook_btn.Location = new System.Drawing.Point(10, 114);
            this.addBook_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBook_btn.Name = "addBook_btn";
            this.addBook_btn.Size = new System.Drawing.Size(188, 28);
            this.addBook_btn.TabIndex = 4;
            this.addBook_btn.Text = "Kitap Ekle";
            this.addBook_btn.UseVisualStyleBackColor = true;
            this.addBook_btn.Click += new System.EventHandler(this.addBook_btn_Click);
            // 
            // aboutBook
            // 
            this.aboutBook.HeaderText = "Kitap Hakkında";
            this.aboutBook.MinimumWidth = 6;
            this.aboutBook.Name = "aboutBook";
            this.aboutBook.ReadOnly = true;
            // 
            // author
            // 
            this.author.HeaderText = "Yazarı";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // language
            // 
            this.language.HeaderText = "Dili";
            this.language.MinimumWidth = 6;
            this.language.Name = "language";
            this.language.ReadOnly = true;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "Yayınevi";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            // 
            // publicationYear
            // 
            this.publicationYear.HeaderText = "Basım Yılı";
            this.publicationYear.MinimumWidth = 6;
            this.publicationYear.Name = "publicationYear";
            this.publicationYear.ReadOnly = true;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Kitap Adı";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            // 
            // bookList_datagrdvw
            // 
            this.bookList_datagrdvw.AllowUserToAddRows = false;
            this.bookList_datagrdvw.AllowUserToDeleteRows = false;
            this.bookList_datagrdvw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookList_datagrdvw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookList_datagrdvw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookName,
            this.publicationYear,
            this.publisher,
            this.language,
            this.author,
            this.aboutBook});
            this.bookList_datagrdvw.Location = new System.Drawing.Point(10, 171);
            this.bookList_datagrdvw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookList_datagrdvw.Name = "bookList_datagrdvw";
            this.bookList_datagrdvw.ReadOnly = true;
            this.bookList_datagrdvw.RowHeadersWidth = 51;
            this.bookList_datagrdvw.RowTemplate.Height = 24;
            this.bookList_datagrdvw.Size = new System.Drawing.Size(937, 349);
            this.bookList_datagrdvw.TabIndex = 8;
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 530);
            this.Controls.Add(this.bookList_datagrdvw);
            this.Controls.Add(this.addBook_btn);
            this.Controls.Add(this.adminNavbar_pnl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "admin_panel";
            this.Text = "Admin Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.admin_panel_FormClosed);
            this.Load += new System.EventHandler(this.admin_panel_Load);
            this.adminNavbar_pnl.ResumeLayout(false);
            this.adminNavbar_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookList_datagrdvw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminNavbar_pnl;
        private System.Windows.Forms.Label admin_lbl;
        private System.Windows.Forms.PictureBox admin_picbox;
        private System.Windows.Forms.Button addBook_btn;
        private System.Windows.Forms.DataGridView bookList_datagrdvw;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboutBook;
    }
}