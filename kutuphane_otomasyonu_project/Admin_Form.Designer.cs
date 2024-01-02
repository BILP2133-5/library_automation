namespace kutuphane_otomasyonu_project
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.userOps_panel = new System.Windows.Forms.Panel();
            this.removeUser_btn = new System.Windows.Forms.Button();
            this.updateUser_btn = new System.Windows.Forms.Button();
            this.addUserOld_btn = new System.Windows.Forms.Button();
            this.authUser_btn = new System.Windows.Forms.Button();
            this.userOps_btn = new System.Windows.Forms.Button();
            this.menu_btn = new System.Windows.Forms.PictureBox();
            this.bookOps_panel = new System.Windows.Forms.Panel();
            this.removeBook_btn = new System.Windows.Forms.Button();
            this.updateBook_btn = new System.Windows.Forms.Button();
            this.addBookOld_btn = new System.Windows.Forms.Button();
            this.bookList_btn = new System.Windows.Forms.Button();
            this.bookOps_btn = new System.Windows.Forms.Button();
            this.appLogo_picbox = new System.Windows.Forms.PictureBox();
            this.sidebarTransition_timer = new System.Windows.Forms.Timer(this.components);
            this.userOps_timer = new System.Windows.Forms.Timer(this.components);
            this.bookOps_timer = new System.Windows.Forms.Timer(this.components);
            this.close_btn = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.background_panel = new System.Windows.Forms.Panel();
            this.addAdmin_btn = new System.Windows.Forms.Button();
            this.addBook_btn = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.sidebar_panel.SuspendLayout();
            this.userOps_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).BeginInit();
            this.bookOps_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo_picbox)).BeginInit();
            this.panel1.SuspendLayout();
            this.background_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.sidebar_panel.Controls.Add(this.userOps_panel);
            this.sidebar_panel.Controls.Add(this.menu_btn);
            this.sidebar_panel.Controls.Add(this.bookOps_panel);
            this.sidebar_panel.Controls.Add(this.appLogo_picbox);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(317, 855);
            this.sidebar_panel.TabIndex = 2;
            // 
            // userOps_panel
            // 
            this.userOps_panel.Controls.Add(this.removeUser_btn);
            this.userOps_panel.Controls.Add(this.updateUser_btn);
            this.userOps_panel.Controls.Add(this.addUserOld_btn);
            this.userOps_panel.Controls.Add(this.authUser_btn);
            this.userOps_panel.Controls.Add(this.userOps_btn);
            this.userOps_panel.Location = new System.Drawing.Point(0, 321);
            this.userOps_panel.Margin = new System.Windows.Forms.Padding(4);
            this.userOps_panel.Name = "userOps_panel";
            this.userOps_panel.Size = new System.Drawing.Size(319, 45);
            this.userOps_panel.TabIndex = 16;
            // 
            // removeUser_btn
            // 
            this.removeUser_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.removeUser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeUser_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeUser_btn.FlatAppearance.BorderSize = 0;
            this.removeUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeUser_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.removeUser_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.removeUser_btn.Image = ((System.Drawing.Image)(resources.GetObject("removeUser_btn.Image")));
            this.removeUser_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeUser_btn.Location = new System.Drawing.Point(67, 181);
            this.removeUser_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeUser_btn.Name = "removeUser_btn";
            this.removeUser_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.removeUser_btn.Size = new System.Drawing.Size(252, 30);
            this.removeUser_btn.TabIndex = 15;
            this.removeUser_btn.Text = "      Remove User";
            this.removeUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeUser_btn.UseVisualStyleBackColor = false;
            // 
            // updateUser_btn
            // 
            this.updateUser_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.updateUser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateUser_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateUser_btn.FlatAppearance.BorderSize = 0;
            this.updateUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateUser_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateUser_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.updateUser_btn.Image = ((System.Drawing.Image)(resources.GetObject("updateUser_btn.Image")));
            this.updateUser_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateUser_btn.Location = new System.Drawing.Point(67, 139);
            this.updateUser_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateUser_btn.Name = "updateUser_btn";
            this.updateUser_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.updateUser_btn.Size = new System.Drawing.Size(252, 30);
            this.updateUser_btn.TabIndex = 14;
            this.updateUser_btn.Text = "      Update User";
            this.updateUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateUser_btn.UseVisualStyleBackColor = false;
            // 
            // addUserOld_btn
            // 
            this.addUserOld_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.addUserOld_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addUserOld_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserOld_btn.FlatAppearance.BorderSize = 0;
            this.addUserOld_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserOld_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addUserOld_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.addUserOld_btn.Image = ((System.Drawing.Image)(resources.GetObject("addUserOld_btn.Image")));
            this.addUserOld_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserOld_btn.Location = new System.Drawing.Point(67, 94);
            this.addUserOld_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addUserOld_btn.Name = "addUserOld_btn";
            this.addUserOld_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.addUserOld_btn.Size = new System.Drawing.Size(252, 30);
            this.addUserOld_btn.TabIndex = 13;
            this.addUserOld_btn.Text = "      Add User";
            this.addUserOld_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserOld_btn.UseVisualStyleBackColor = false;
            // 
            // authUser_btn
            // 
            this.authUser_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.authUser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.authUser_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authUser_btn.FlatAppearance.BorderSize = 0;
            this.authUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authUser_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authUser_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.authUser_btn.Image = ((System.Drawing.Image)(resources.GetObject("authUser_btn.Image")));
            this.authUser_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authUser_btn.Location = new System.Drawing.Point(67, 52);
            this.authUser_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authUser_btn.Name = "authUser_btn";
            this.authUser_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.authUser_btn.Size = new System.Drawing.Size(252, 30);
            this.authUser_btn.TabIndex = 12;
            this.authUser_btn.Text = "      Auth User";
            this.authUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authUser_btn.UseVisualStyleBackColor = false;
            // 
            // userOps_btn
            // 
            this.userOps_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.userOps_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userOps_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userOps_btn.FlatAppearance.BorderSize = 0;
            this.userOps_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userOps_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userOps_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.userOps_btn.Image = ((System.Drawing.Image)(resources.GetObject("userOps_btn.Image")));
            this.userOps_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userOps_btn.Location = new System.Drawing.Point(0, 0);
            this.userOps_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userOps_btn.Name = "userOps_btn";
            this.userOps_btn.Padding = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.userOps_btn.Size = new System.Drawing.Size(319, 41);
            this.userOps_btn.TabIndex = 11;
            this.userOps_btn.Text = "         User Operations";
            this.userOps_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userOps_btn.UseVisualStyleBackColor = false;
            this.userOps_btn.Click += new System.EventHandler(this.userOps_btn_Click);
            // 
            // menu_btn
            // 
            this.menu_btn.Image = ((System.Drawing.Image)(resources.GetObject("menu_btn.Image")));
            this.menu_btn.Location = new System.Drawing.Point(16, 15);
            this.menu_btn.Margin = new System.Windows.Forms.Padding(4);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(40, 25);
            this.menu_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu_btn.TabIndex = 1;
            this.menu_btn.TabStop = false;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // bookOps_panel
            // 
            this.bookOps_panel.Controls.Add(this.removeBook_btn);
            this.bookOps_panel.Controls.Add(this.updateBook_btn);
            this.bookOps_panel.Controls.Add(this.addBookOld_btn);
            this.bookOps_panel.Controls.Add(this.bookList_btn);
            this.bookOps_panel.Controls.Add(this.bookOps_btn);
            this.bookOps_panel.Location = new System.Drawing.Point(0, 249);
            this.bookOps_panel.Margin = new System.Windows.Forms.Padding(4);
            this.bookOps_panel.Name = "bookOps_panel";
            this.bookOps_panel.Size = new System.Drawing.Size(317, 42);
            this.bookOps_panel.TabIndex = 12;
            // 
            // removeBook_btn
            // 
            this.removeBook_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.removeBook_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeBook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBook_btn.FlatAppearance.BorderSize = 0;
            this.removeBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBook_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.removeBook_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.removeBook_btn.Image = ((System.Drawing.Image)(resources.GetObject("removeBook_btn.Image")));
            this.removeBook_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeBook_btn.Location = new System.Drawing.Point(67, 181);
            this.removeBook_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeBook_btn.Name = "removeBook_btn";
            this.removeBook_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.removeBook_btn.Size = new System.Drawing.Size(252, 30);
            this.removeBook_btn.TabIndex = 15;
            this.removeBook_btn.Text = "      Remove Book";
            this.removeBook_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeBook_btn.UseVisualStyleBackColor = false;
            // 
            // updateBook_btn
            // 
            this.updateBook_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.updateBook_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateBook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBook_btn.FlatAppearance.BorderSize = 0;
            this.updateBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBook_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateBook_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.updateBook_btn.Image = ((System.Drawing.Image)(resources.GetObject("updateBook_btn.Image")));
            this.updateBook_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBook_btn.Location = new System.Drawing.Point(67, 139);
            this.updateBook_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBook_btn.Name = "updateBook_btn";
            this.updateBook_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.updateBook_btn.Size = new System.Drawing.Size(252, 30);
            this.updateBook_btn.TabIndex = 14;
            this.updateBook_btn.Text = "      Update Book";
            this.updateBook_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBook_btn.UseVisualStyleBackColor = false;
            // 
            // addBookOld_btn
            // 
            this.addBookOld_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.addBookOld_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addBookOld_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookOld_btn.FlatAppearance.BorderSize = 0;
            this.addBookOld_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookOld_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBookOld_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.addBookOld_btn.Image = ((System.Drawing.Image)(resources.GetObject("addBookOld_btn.Image")));
            this.addBookOld_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBookOld_btn.Location = new System.Drawing.Point(67, 94);
            this.addBookOld_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBookOld_btn.Name = "addBookOld_btn";
            this.addBookOld_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.addBookOld_btn.Size = new System.Drawing.Size(252, 30);
            this.addBookOld_btn.TabIndex = 13;
            this.addBookOld_btn.Text = "      Add Book";
            this.addBookOld_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBookOld_btn.UseVisualStyleBackColor = false;
            this.addBookOld_btn.Click += new System.EventHandler(this.addBook_btn_Click);
            // 
            // bookList_btn
            // 
            this.bookList_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bookList_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookList_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookList_btn.FlatAppearance.BorderSize = 0;
            this.bookList_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookList_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookList_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.bookList_btn.Image = ((System.Drawing.Image)(resources.GetObject("bookList_btn.Image")));
            this.bookList_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookList_btn.Location = new System.Drawing.Point(67, 52);
            this.bookList_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookList_btn.Name = "bookList_btn";
            this.bookList_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.bookList_btn.Size = new System.Drawing.Size(252, 30);
            this.bookList_btn.TabIndex = 12;
            this.bookList_btn.Text = "      Book List";
            this.bookList_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookList_btn.UseVisualStyleBackColor = false;
            // 
            // bookOps_btn
            // 
            this.bookOps_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bookOps_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookOps_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookOps_btn.FlatAppearance.BorderSize = 0;
            this.bookOps_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookOps_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookOps_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.bookOps_btn.Image = ((System.Drawing.Image)(resources.GetObject("bookOps_btn.Image")));
            this.bookOps_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookOps_btn.Location = new System.Drawing.Point(0, 0);
            this.bookOps_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookOps_btn.Name = "bookOps_btn";
            this.bookOps_btn.Padding = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.bookOps_btn.Size = new System.Drawing.Size(319, 41);
            this.bookOps_btn.TabIndex = 11;
            this.bookOps_btn.Text = "         Book Operations";
            this.bookOps_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookOps_btn.UseVisualStyleBackColor = false;
            this.bookOps_btn.Click += new System.EventHandler(this.bookOps_btn_Click);
            // 
            // appLogo_picbox
            // 
            this.appLogo_picbox.Image = ((System.Drawing.Image)(resources.GetObject("appLogo_picbox.Image")));
            this.appLogo_picbox.Location = new System.Drawing.Point(81, 57);
            this.appLogo_picbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appLogo_picbox.Name = "appLogo_picbox";
            this.appLogo_picbox.Size = new System.Drawing.Size(141, 130);
            this.appLogo_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appLogo_picbox.TabIndex = 0;
            this.appLogo_picbox.TabStop = false;
            // 
            // sidebarTransition_timer
            // 
            this.sidebarTransition_timer.Interval = 10;
            this.sidebarTransition_timer.Tick += new System.EventHandler(this.sidebarTransition_timer_Tick);
            // 
            // userOps_timer
            // 
            this.userOps_timer.Interval = 10;
            this.userOps_timer.Tick += new System.EventHandler(this.userOps_timer_Tick);
            // 
            // bookOps_timer
            // 
            this.bookOps_timer.Interval = 10;
            this.bookOps_timer.Tick += new System.EventHandler(this.bookOps_timer_Tick);
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.AutoSize = true;
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.close_btn.Location = new System.Drawing.Point(1241, 0);
            this.close_btn.Margin = new System.Windows.Forms.Padding(0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(41, 36);
            this.close_btn.TabIndex = 10;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.minimize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minimize_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.minimize_btn.Location = new System.Drawing.Point(1200, 0);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(41, 36);
            this.minimize_btn.TabIndex = 11;
            this.minimize_btn.Text = "─";
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.minimize_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(317, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 50);
            this.panel1.TabIndex = 13;
            // 
            // background_panel
            // 
            this.background_panel.Controls.Add(this.addAdmin_btn);
            this.background_panel.Controls.Add(this.addBook_btn);
            this.background_panel.Controls.Add(this.main_panel);
            this.background_panel.Location = new System.Drawing.Point(0, 50);
            this.background_panel.Margin = new System.Windows.Forms.Padding(4);
            this.background_panel.Name = "background_panel";
            this.background_panel.Size = new System.Drawing.Size(1600, 805);
            this.background_panel.TabIndex = 3;
            // 
            // addAdmin_btn
            // 
            this.addAdmin_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addAdmin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.addAdmin_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addAdmin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAdmin_btn.FlatAppearance.BorderSize = 0;
            this.addAdmin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAdmin_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addAdmin_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.addAdmin_btn.Image = ((System.Drawing.Image)(resources.GetObject("addAdmin_btn.Image")));
            this.addAdmin_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAdmin_btn.Location = new System.Drawing.Point(1411, 25);
            this.addAdmin_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAdmin_btn.Name = "addAdmin_btn";
            this.addAdmin_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.addAdmin_btn.Size = new System.Drawing.Size(101, 38);
            this.addAdmin_btn.TabIndex = 24;
            this.addAdmin_btn.Text = "      add";
            this.addAdmin_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAdmin_btn.UseVisualStyleBackColor = false;
            this.addAdmin_btn.Visible = false;
            this.addAdmin_btn.Click += new System.EventHandler(this.addAdmin_btn_Click);
            // 
            // addBook_btn
            // 
            this.addBook_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBook_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.addBook_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addBook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBook_btn.FlatAppearance.BorderSize = 0;
            this.addBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBook_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.addBook_btn.Image = ((System.Drawing.Image)(resources.GetObject("addBook_btn.Image")));
            this.addBook_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBook_btn.Location = new System.Drawing.Point(1411, 25);
            this.addBook_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBook_btn.Name = "addBook_btn";
            this.addBook_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.addBook_btn.Size = new System.Drawing.Size(101, 38);
            this.addBook_btn.TabIndex = 23;
            this.addBook_btn.Text = "      add";
            this.addBook_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBook_btn.UseVisualStyleBackColor = false;
            this.addBook_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // main_panel
            // 
            this.main_panel.Location = new System.Drawing.Point(324, 78);
            this.main_panel.Margin = new System.Windows.Forms.Padding(4);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1272, 714);
            this.main_panel.TabIndex = 4;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1600, 855);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar_panel);
            this.Controls.Add(this.background_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.sidebar_panel.ResumeLayout(false);
            this.userOps_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).EndInit();
            this.bookOps_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appLogo_picbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.background_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.PictureBox appLogo_picbox;
        private System.Windows.Forms.PictureBox menu_btn;
        private System.Windows.Forms.Timer sidebarTransition_timer;
        private System.Windows.Forms.Timer userOps_timer;
        private System.Windows.Forms.Timer bookOps_timer;
        private System.Windows.Forms.Panel userOps_panel;
        private System.Windows.Forms.Button removeUser_btn;
        private System.Windows.Forms.Button updateUser_btn;
        private System.Windows.Forms.Button addUserOld_btn;
        private System.Windows.Forms.Button authUser_btn;
        private System.Windows.Forms.Button userOps_btn;
        private System.Windows.Forms.Panel bookOps_panel;
        private System.Windows.Forms.Button removeBook_btn;
        private System.Windows.Forms.Button updateBook_btn;
        private System.Windows.Forms.Button addBookOld_btn;
        private System.Windows.Forms.Button bookList_btn;
        private System.Windows.Forms.Button bookOps_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel background_panel;
        public System.Windows.Forms.Panel main_panel;
        public System.Windows.Forms.Button addBook_btn;
        public System.Windows.Forms.Button addAdmin_btn;
    }
}