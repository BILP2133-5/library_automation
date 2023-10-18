using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu_project
{
    public partial class addBookForm : Form
    {
        public addBookForm()
        {
            InitializeComponent();
        }

        private void publicationYear_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(publicationYear_txt.Text.Length < 4)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string postBookUrl = "http://localhost:3000/books/add";
            string postData = $"{{ \"bookName\": \"{bookName_txt.Text}\", \"publicationYear\": \"{Convert.ToInt16(publicationYear_txt.Text)}\", \"publisher\": \"{publisher_txt.Text}\", \"language\": \"{language_txt.Text}\", \"author\": \"{author_txt.Text}\", \"aboutBook\": \"{aboutBook_rchtxt.Text}\" }}";
            using (HttpClient httpClient = new HttpClient())
            {
                StringContent content = new StringContent(postData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(postBookUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    // Başarılı yanıt
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("işlem Başarılı");
                }
                else
                {
                    // Hata durumu
                    MessageBox.Show("API yanıtı başarısız: " + response.StatusCode);
                }
            }
        }

        private void addBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            admin_panel admin_Panel = new admin_panel();
            admin_Panel.Show();
            this.Hide();
        }
    }
}
