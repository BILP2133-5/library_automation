using kutuphane_otomasyonu_project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static kutuphane_otomasyonu_project.User_Profile_Form;

namespace kutuphane_otomasyonu_project
{
    public partial class User_Form : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        BookList_Form bookList_Form = new BookList_Form();

        public User_Form()
        {
            InitializeComponent();

            
        }

        void imgResize20(Button button)
        {
            button.Image = (Image)(new Bitmap(button.Image, new Size(20, 20)));
        }

        void imgResize25(Button button)
        {
            button.Image = (Image)(new Bitmap(button.Image, new Size(20, 20)));
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            //List<Button> smallButtons = new List<Button> { addBook_btn, bookList_btn, removeBook_btn, updateBook_btn, authUser_btn, addUserOld_btn, removeUser_btn, updateUser_btn};
            List<Button> bigButtons = new List<Button> { book_btn, profile_btn };

            //foreach(Button button in smallButtons)
            //{
            //    imgResize20(button);
            //}

            foreach (Button button in bigButtons)
            {
                imgResize25(button);
            }

            bookList_Form = new BookList_Form();
            getForm(bookList_Form);

            panel1.MouseDown += new MouseEventHandler(DragPanel_MouseDown);
            panel1.MouseMove += new MouseEventHandler(DragPanel_MouseMove);
            panel1.MouseUp += new MouseEventHandler(DragPanel_MouseUp);
        }

        bool isSidebarExpanded = true;
        int paddingLeft = 0;

        private void menu_btn_Click(object sender, EventArgs e)
        {
            paddingLeft = book_btn.Padding.Left;
            sidebarTransition_timer.Start();
        }

        private void sidebarTransition_timer_Tick(object sender, EventArgs e)
        {
            if (!isSidebarExpanded)
            {
                sidebar_panel.Width += 8;
                //addBook_Form addBook_Form = new addBook_Form();
                //addBook_Form.Width -= 8;
                //background_panel.Width -= 1;
                //bookList_Form.Width = 962;
                //BookList_Form.bookList_datagrdview.Width -= 20;
                paddingLeft += 2;
                book_btn.Padding = new Padding(paddingLeft, 0, 0, 0);
                profile_btn.Padding = new Padding(paddingLeft, 0, 0, 0);
                //bookList_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                //addBook_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                //updateBook_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                //removeBook_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                if (sidebar_panel.Width == 238)
                {
                    sidebarTransition_timer.Stop();
                    isSidebarExpanded = true;
                    //bookList_Form.Width = 962;
                    book_btn.Enabled = true;
                    profile_btn.Enabled = true;
                    //background_panel.Width = 1283;
                }
            }

            else
            {
                sidebar_panel.Width -= 8;
                //addBook_Form addBook_Form = new addBook_Form();
                //addBook_Form.Width += 8;
                //background_panel.Width += 1;
                //bookList_Form.Width = 962;
                //BookList_Form.bookList_datagrdview.Width += 20;
                paddingLeft -= 2;
                book_btn.Padding = new Padding(paddingLeft, 0, 0, 0);
                profile_btn.Padding = new Padding(paddingLeft, 0, 0, 0);
                //bookList_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                //addBook_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                //updateBook_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                //removeBook_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                if (sidebar_panel.Width <= 48)
                {
                    sidebarTransition_timer.Stop();
                    isSidebarExpanded = false;
                    book_btn.Enabled = false;
                    profile_btn.Enabled = false;
                    //background_panel.Width = 1483;
                }
            }
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void book_btn_Click(object sender, EventArgs e)
        {
            bookList_Form = new BookList_Form();
            getForm(bookList_Form);
        }

        public void getForm(Form form)
        {
            main_panel.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            main_panel.Controls.Add(form);
            form.Show();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            string authedUserId = " ";
            if (Login_Form.AuthedUser != null)
            {
                authedUserId = Login_Form.AuthedUser.UserId;
            } else if (Register_Form.AuthedUser != null)
            {
                authedUserId = Register_Form.AuthedUser.UserId;
            }


            User_Profile_Form user_Profile_Form = new User_Profile_Form(authedUserId);
            getForm(user_Profile_Form);
        }


        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
