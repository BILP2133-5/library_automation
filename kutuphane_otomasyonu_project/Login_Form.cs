using kutuphane_otomasyonu_project.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static kutuphane_otomasyonu_project.Login_Form;

namespace kutuphane_otomasyonu_project
{
    public partial class Login_Form : Form
    {
        Panel loginRegisterPanel;
        public Login_Form()
        {
            InitializeComponent();
            loginRegisterPanel = Login_Register_Form.loginRegisterPanel;
        }

        

        #region EmailClickRegion
        void emailClicked()
        {
            email_text.BackColor = Color.FromArgb(238, 238, 238);
            email_panel.BackColor = Color.FromArgb(238, 238, 238);
            password_text.BackColor = Color.FromArgb(57, 62, 70);
            password_panel.BackColor = Color.FromArgb(57, 62, 70);
            email_text.Focus();
            hide_pic.Visible = false;
            show_pic.Visible = false;
            password_text.UseSystemPasswordChar = true;
        }

        private void email_label_Click(object sender, EventArgs e)
        {
            emailClicked();
        }

        private void emailLogo_pic_Click(object sender, EventArgs e)
        {
            emailClicked();
        }

        private void email_panel_Click(object sender, EventArgs e)
        {
            emailClicked();
        }

        private void email_text_Click(object sender, EventArgs e)
        {
            emailClicked();
        }
        #endregion

        #region PasswordClickRegion
        void passwordClicked()
        {
            password_text.BackColor = Color.FromArgb(238, 238, 238);
            password_panel.BackColor = Color.FromArgb(238, 238, 238);
            email_text.BackColor = Color.FromArgb(57, 62, 70);
            email_panel.BackColor = Color.FromArgb(57, 62, 70);
            hide_pic.Visible = false;
            show_pic.Visible = true;
            password_text.Focus();
        }

        private void password_lbl_Click(object sender, EventArgs e)
        {
            passwordClicked();
        }

        private void password_text_Click(object sender, EventArgs e)
        {
            passwordClicked();
        }

        private void passwordLogo_pic_Click(object sender, EventArgs e)
        {
            passwordClicked();
        }

        private void password_panel_Click(object sender, EventArgs e)
        {
            passwordClicked();
        }
        #endregion

        #region Show/Hide
        private void show_pic_Click(object sender, EventArgs e)
        {
            password_text.UseSystemPasswordChar = false;
            hide_pic.Visible = true;
            show_pic.Visible = false;
        }

        private void hide_pic_Click(object sender, EventArgs e)
        {
            password_text.UseSystemPasswordChar = true;
            hide_pic.Visible = false;
            show_pic.Visible = true;
        }
        #endregion

        private void register_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_Form register_Form = new Register_Form();
            Login_Register_Form loginRegisterForm = new Login_Register_Form();

            loginRegisterPanel.Controls.Clear();
            register_Form.MdiParent = loginRegisterForm;
            register_Form.FormBorderStyle = FormBorderStyle.None;
            loginRegisterPanel.Controls.Add(register_Form);
            register_Form.Show();
        }

        public static string userId, userToken;
        public static AuthedUser AuthedUser { get; private set; }
        private async void login_btn_Click(object sender, EventArgs e)
        {
            string loginUrl = "http://localhost:3000/auth/login";
            string postData = $"{{ \"email\": \"{email_text.Text}\", \"password\": \"{password_text.Text}\"}}";
            using (HttpClient httpClient = new HttpClient())
            {
                StringContent loginContent = new StringContent(postData, Encoding.UTF8, "application/json");
                HttpResponseMessage loginResponse = await httpClient.PostAsync(loginUrl, loginContent);

                if (loginResponse.IsSuccessStatusCode)
                {
                    string loginJsonResponse = await loginResponse.Content.ReadAsStringAsync();
                    //Token userResponse = JsonConvert.DeserializeObject<Token>(jsonResponse);
                    var loginJsonData = JsonConvert.DeserializeObject<dynamic>(loginJsonResponse);
                    userToken = loginJsonData.token;
                    //MessageBox.Show(token);
                    //userToken = token;

                   

                    string protectedUrl = "http://localhost:3000/auth/protected";
                    using(HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userToken);
                        var authUserResponse = await client.GetAsync(protectedUrl);


                        //StringContent content1 = new StringContent(userToken, Encoding.UTF8, "application/json");
                        //HttpResponseMessage response1 = await httpClient.PostAsync(protectedUrl, content);
                        if(authUserResponse.IsSuccessStatusCode)
                        {
                            // baristaner section
                            var authUserContent = await authUserResponse.Content.ReadAsStringAsync();
                            var authUserJsonData = JsonConvert.DeserializeObject<dynamic>(authUserContent);

                            AuthedUser = new AuthedUser
                            {
                                UserId = authUserJsonData.user._id,
                                UserToken = userToken, // Use userToken instead of AuthedUser.UserToken
                                UserRole = authUserJsonData.user.role
                            };

                            MessageBox.Show(Login_Form.AuthedUser.UserId);

                            //MessageBox.Show(role);

                            //var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(content1); // JSON verisini bir sözlük olarak işliyoruz
                            //MessageBox.Show(data["role"]);


                            if (authUserJsonData.user.role == "admin" || authUserJsonData.user.role ==  "superadmin")
                            {
                                //userId = userResponse.token;

                                // Başarılı yanıt
                                Admin_Form admin_Form = new Admin_Form();
                                admin_Form.Show();
                                //User_Form user_Form = new User_Form();
                              
                            }

                            else
                            {
                                User_Form user_Form = new User_Form();
                                user_Form.Show();
                                
                            }
                        }
                    }
                    //MessageBox.Show(userResponse.role);




                    Application.OpenForms["Login_Register_Form"].Hide();
                }
                else
                {
                    // Hata durumu
                    MessageBox.Show("Wrong email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
