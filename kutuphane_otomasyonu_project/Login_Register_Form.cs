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
    public partial class Login_Register_Form : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public static Panel loginRegisterPanel;

        public Login_Register_Form()
        {
            InitializeComponent();
            loginRegisterPanel = main_panel;
        }

        private void Login_Register_From_Load(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            getForm(login_Form);

            panel1.MouseDown += new MouseEventHandler(DragPanel_MouseDown);
            panel1.MouseMove += new MouseEventHandler(DragPanel_MouseMove);
            panel1.MouseUp += new MouseEventHandler(DragPanel_MouseUp);
        }

        void getForm(Form form)
        {
            loginRegisterPanel.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            loginRegisterPanel.Controls.Add(form);
            form.Show();
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

        #region CloseMinimize
        private void minimize_btn_Click_1(object sender, EventArgs e)
        {
            Login_Register_Form loginRegisterForm = Application.OpenForms["Login_Register_Form"] as Login_Register_Form;
            if (loginRegisterForm != null)
            {
                loginRegisterForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void close_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}
