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
    public partial class UpdateBook_Form : Form
    {
        public string bookId;
        public UpdateBook_Form()
        {
            InitializeComponent();
        }

        private void publicationYear_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (publicationYear_txt.Text.Length < 4)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            else if (publicationYear_txt.Text.Length == 4)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            string updateBookUrl = "http://localhost:3000/books/update";
            string bookData = $"{{ \"bookName\": \"{bookName_txt.Text}\", \"publicationYear\": \"{Convert.ToInt16(publicationYear_txt.Text)}\", \"publisher\": \"{publisher_txt.Text}\", \"language\": \"{language_txt.Text}\", \"author\": \"{author_txt.Text}\", \"aboutBook\": \"{aboutBook_rchtxt.Text}\", \"imageUrl\": \"{imgUrl_text.Text}\" }}";

            using (HttpClient httpClient = new HttpClient())
            {
                var content = new StringContent(bookData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync($"{updateBookUrl}/{bookId}", content);


                if (response.IsSuccessStatusCode)
                {
                    // Başarılı yanıt
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
