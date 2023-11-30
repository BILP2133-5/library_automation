using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu_project
{
    public partial class User_Form : Form
    {
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
        }

        bool isSidebarExpanded = true;
        int paddingLeft = 0;
        BookList_Form bookList_Form = new BookList_Form();

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
    }
}
