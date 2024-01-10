using kutuphane_otomasyonu_project.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kutuphane_otomasyonu_project
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        // Control email
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(email, emailPattern);
        }

        public static string userId, userToken;
        public static AuthedUser AuthedUser { get; private set; }
        private async void register_btn_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(email_text.Text))
            {
                MessageBox.Show("Please enter a valid email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email_text.Focus();
            }

            else
            {
                string registerUrl = "http://localhost:3000/auth/register";
                string postData = $"{{ \"email\": \"{email_text.Text}\", \"password\": \"{password_text.Text}\", \"name\": \"{name_text.Text}\" }}";
                MessageBox.Show(postData);
                using (HttpClient httpClient = new HttpClient())
                {
                    StringContent registerContent = new StringContent(postData, Encoding.UTF8, "application/json");
                    HttpResponseMessage registerResponse = await httpClient.PostAsync(registerUrl, registerContent);

                    if (registerResponse.IsSuccessStatusCode)
                    {
                        // Başarılı yanıt
                        string registerJsonResponse = await registerResponse.Content.ReadAsStringAsync();
                        //Token userResponse = JsonConvert.DeserializeObject<Token>(jsonResponse);
                        var loginJsonData = JsonConvert.DeserializeObject<dynamic>(registerJsonResponse);
                        userToken = loginJsonData.token;
                        
                        MessageBox.Show("Kayıt olundu.");

                        string protectedUrl = "http://localhost:3000/auth/protected";
                        using (HttpClient client = new HttpClient())
                        {
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userToken);
                            var authUserResponse = await client.GetAsync(protectedUrl);


                            if (authUserResponse.IsSuccessStatusCode)
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

                                MessageBox.Show(Register_Form.AuthedUser.UserId);

                                User_Form user_Form = new User_Form();
                                user_Form.Show();

                                //MessageBox.Show(role);

                                //var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(content1); // JSON verisini bir sözlük olarak işliyoruz
                                //MessageBox.Show(data["role"]);



                            }
                        }
                        Application.OpenForms["Login_Register_Form"].Hide();
                    }
                    else
                    {
                        // Hata durumu
                        MessageBox.Show("API yanıtı başarısız: " + registerResponse.StatusCode);
                    }
                }
            }
        }

        #region EmailClickRegion
        void emailClicked()
        {
            email_text.BackColor = Color.FromArgb(238, 238, 238);
            email_panel.BackColor = Color.FromArgb(238, 238, 238);
            password_text.BackColor = Color.FromArgb(57, 62, 70);
            password_panel.BackColor = Color.FromArgb(57, 62, 70);
            name_text.BackColor = Color.FromArgb(57, 62, 70);
            name_panel.BackColor = Color.FromArgb(57, 62, 70);
            email_text.Focus();
            hide_pic.Visible = false;
            show_pic.Visible = false;
            password_text.UseSystemPasswordChar = true;
        }

        private void email_lbl_Click(object sender, EventArgs e)
        {
            emailClicked();
        }

        private void email_text_Click(object sender, EventArgs e)
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
        #endregion

        #region PasswordClickRegion
        void passwordClicked()
        {
            password_text.BackColor = Color.FromArgb(238, 238, 238);
            password_panel.BackColor = Color.FromArgb(238, 238, 238);
            email_text.BackColor = Color.FromArgb(57, 62, 70);
            email_panel.BackColor = Color.FromArgb(57, 62, 70);
            name_text.BackColor = Color.FromArgb(57, 62, 70);
            name_panel.BackColor = Color.FromArgb(57, 62, 70);
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

        private void password_panel_Click(object sender, EventArgs e)
        {
            passwordClicked();
        }

        private void passwordLogo_pic_Click(object sender, EventArgs e)
        {
            passwordClicked();
        }
        #endregion

        #region NameClickRegion
        void nameClicked()
        {
            name_text.BackColor = Color.FromArgb(238, 238, 238);
            name_panel.BackColor = Color.FromArgb(238, 238, 238);
            email_text.BackColor = Color.FromArgb(57, 62, 70);
            email_panel.BackColor = Color.FromArgb(57, 62, 70);
            password_text.BackColor = Color.FromArgb(57, 62, 70);
            password_panel.BackColor = Color.FromArgb(57, 62, 70);
            hide_pic.Visible = false;
            show_pic.Visible = false;
            password_text.UseSystemPasswordChar = true;
            name_text.Focus();
        }
        private void name_lbl_Click(object sender, EventArgs e)
        {
            nameClicked();
        }

        private void name_text_Click(object sender, EventArgs e)
        {
            nameClicked();
        }

        private void name_panel_Click(object sender, EventArgs e)
        {
            nameClicked();
        }

        private void nameLogo_pic_Click(object sender, EventArgs e)
        {
            nameClicked();
        }

        #endregion

        #region Show/Hide
        private void hide_pic_Click(object sender, EventArgs e)
        {
            password_text.UseSystemPasswordChar = true;
            hide_pic.Visible = false;
            show_pic.Visible = true;
        }

        private void show_pic_Click(object sender, EventArgs e)
        {
            password_text.UseSystemPasswordChar = false;
            hide_pic.Visible = true;
            show_pic.Visible = false;
        }
        #endregion

        

        
    }
}
