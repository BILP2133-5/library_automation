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
    public partial class addBook_Form : Form
    {
        public static addBook_Form instance;
        public addBook_Form()
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

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if(bookName_txt.Text == "" || publicationYear_txt.Text == "" || publisher_txt.Text == "" || language_txt.Text == "" || author_txt.Text == "" || imgUrl_text.Text == "" || aboutBook_rchtxt.Text == "")
            {
                MessageBox.Show("Please fill all inputs.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                string postBookUrl = "http://localhost:3000/books/add";
                string postData = $"{{ \"bookName\": \"{bookName_txt.Text}\", \"publicationYear\": \"{Convert.ToInt16(publicationYear_txt.Text)}\", \"publisher\": \"{publisher_txt.Text}\", \"language\": \"{language_txt.Text}\", \"author\": \"{author_txt.Text}\", \"aboutBook\": \"{aboutBook_rchtxt.Text}\", \"imageUrl\": \"{imgUrl_text.Text}\" }}";
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

                bookName_txt.Text = string.Empty;
                publicationYear_txt.Text = string.Empty;
                publisher_txt.Text = string.Empty;
                language_txt.Text = string.Empty;
                author_txt.Text = string.Empty;
                aboutBook_rchtxt.Text = string.Empty;
                imgUrl_text.Text = string.Empty;
            }
        }


        //private void addBookForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    admin_panel admin_Panel = new admin_panel();
        //    admin_Panel.Show();
        //    this.Hide();
        //}
    }
}
