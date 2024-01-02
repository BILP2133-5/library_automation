using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu_project
{
    public partial class AddAdmin_Form : Form
    {
        public AddAdmin_Form()
        {
            InitializeComponent();
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if (name_txt.Text == "" || email_txt.Text == "" || password_txt.Text == "")
            {
                MessageBox.Show("Please fill all inputs.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                string protectedUrl = "http://localhost:3000/auth/protected";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Login_Form.userToken);
                    var authUserResponse = await client.GetAsync(protectedUrl);
                    //MessageBox.Show(authUserResponse.ToString());

                    if (authUserResponse.IsSuccessStatusCode)
                    {
                        string postBookUrl = "http://localhost:3000/auth/createUser";
                        string postData = $"{{ \"name\": \"{name_txt.Text}\", \"email\": \"{email_txt.Text}\", \"password\": \"{password_txt.Text}\" }}";

                        using (HttpClient httpClient = new HttpClient())
                        {
                            StringContent content = new StringContent(postData, Encoding.UTF8, "application/json");
                            HttpResponseMessage response = await httpClient.PostAsync(postBookUrl, content);

                            if (response.IsSuccessStatusCode)
                            {
                                // Başarılı yanıt
                                string responseContent = await response.Content.ReadAsStringAsync();
                                name_txt.Text = string.Empty;
                                email_txt.Text = string.Empty;
                                password_txt.Text = string.Empty;
                                MessageBox.Show("işlem Başarılı");
                            }
                            else
                            {
                                // Hata durumu
                                MessageBox.Show("API yanıtı başarısız: " + response.StatusCode);
                            }
                        }

                    }
                }
            }
        }
    }
}
