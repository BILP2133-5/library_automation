using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace kutuphane_otomasyonu_project
{
    public partial class Admin_Form : Form
    {
        //public static Admin_Form instance;
        public Admin_Form()
        {
            InitializeComponent();

            BookList_Form bookListForm = new BookList_Form();
            getForm(bookListForm);
            //if(instance != null)
            //{
            //    i
            //}
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            List<Button> smallButtons = new List<Button> { addBook_btn, bookList_btn, removeBook_btn, updateBook_btn, authUser_btn, addUserOld_btn, removeUser_btn, updateUser_btn};
            List<Button> bigButtons = new List<Button> { bookOps_btn, userOps_btn };

            foreach(Button button in smallButtons)
            {
                imgResize20(button);
            }

            foreach (Button button in bigButtons)
            {
                imgResize25(button);
            }
        }

        void imgResize20(Button button)
        {
            button.Image = (Image)(new Bitmap(button.Image, new Size(20, 20)));
        }

        void imgResize25(Button button)
        {
            button.Image = (Image)(new Bitmap(button.Image, new Size(20, 20)));
        }

        bool isSidebarExpanded = true;
        int paddingLeft = 0;
        BookList_Form bookList_Form = new BookList_Form();

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
                bookOps_btn.Padding = new Padding(paddingLeft, 0, 0, 0);
                userOps_btn.Padding = new Padding(paddingLeft, 0, 0, 0);
                //bookList_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                //addBook_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                //updateBook_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                //removeBook_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                if (sidebar_panel.Width == 238)
                {
                    sidebarTransition_timer.Stop();
                    isSidebarExpanded = true;
                    bookList_Form.Width = 962;
                    bookOps_btn.Enabled = true;
                    userOps_btn.Enabled = true;
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
                bookOps_btn.Padding = new Padding(paddingLeft, 0, 0, 0);
                userOps_btn.Padding = new Padding(paddingLeft, 0, 0, 0);
                //bookList_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                //addBook_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                //updateBook_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                //removeBook_btno.Padding = new Padding(paddingLeft, 0, 0, 0);
                if (sidebar_panel.Width <= 48)
                {
                    sidebarTransition_timer.Stop();
                    isSidebarExpanded = false;
                    bookOps_btn.Enabled = false;
                    userOps_btn.Enabled = false;
                    //background_panel.Width = 1483;
                }
            }
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            //if(!isSidebarExpanded)
            //{
            //    //bookList_Form.Width = 962;
            //}

            //else
            //{
            //    bookList_Form.Width = 1150;
            //}
            paddingLeft = bookOps_btn.Padding.Left;
            sidebarTransition_timer.Start();
        }

        private void bookList_btn_Click(object sender, EventArgs e)
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

        bool bookSubmenuExpanded = false;
        bool userSubmenuExpanded = false;
        private void bookOps_btn_Click(object sender, EventArgs e)
        {
            addBook_btn.Visible = true;
            bookList_Form = new BookList_Form();
            getForm(bookList_Form);
        }

        private void bookOps_timer_Tick(object sender, EventArgs e)
        {
            if (!bookSubmenuExpanded)
            {
                bookOps_panel.Height += 16;
                Point newLocation = new Point(0, userOps_panel.Top + 11);
                userOps_panel.Location = newLocation;
                if (bookOps_panel.Height >= 216)
                {
                    bookOps_timer.Stop();
                    bookSubmenuExpanded = true;
                }
            }

            else
            {
                bookOps_panel.Height -= 16;
                Point newLocation = new Point(0, userOps_panel.Top - 11);
                userOps_panel.Location = newLocation;
                if (bookOps_panel.Height <= 46)
                {
                    bookOps_timer.Stop();
                    bookSubmenuExpanded = false;

                }
            }
        }

        private void userOps_btn_Click(object sender, EventArgs e)
        {
            addBook_btn.Visible = false;
            UserList_Form userList_Form = new UserList_Form();
            getForm(userList_Form);
            //userOps_timer.Start();
        }

        private void userOps_timer_Tick(object sender, EventArgs e)
        {
            if (!userSubmenuExpanded)
            {
                userOps_panel.Height += 16;
                if (userOps_panel.Height >= 216)
                {
                    userOps_timer.Stop();
                    userSubmenuExpanded = true;
                }
            }

            else
            {
                userOps_panel.Height -= 16;
                if (userOps_panel.Height <= 46)
                {
                    userOps_timer.Stop();
                    userSubmenuExpanded = false;

                }
            }
        }

        private void addBook_btn_Click(object sender, EventArgs e)
        {
            addBook_Form addBook_Form = new addBook_Form();
            getForm(addBook_Form);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            addBook_btn.Visible=false;
            addBook_Form addBook_Form = new addBook_Form();
            getForm(addBook_Form);
        }
    }
}
