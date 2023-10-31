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
    public partial class login_form : Form
    {
        private Timer timer;
        public login_form()
        {
            InitializeComponent();
        }

        private void forgotPass_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passwordReminder_pnl.Visible = true;
            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += reminder_timer_Tick;
            timer.Start();
        }

        private void reminder_timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            passwordReminder_pnl.Visible = false;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            admin_panel admin_Panel = new admin_panel();
            admin_Panel.Show();
            this.Hide();
        }
    }
}
