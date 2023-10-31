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
        }

        void getForm(Form form)
        {
            loginRegisterPanel.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            loginRegisterPanel.Controls.Add(form);
            form.Show();
        }
    }
}
