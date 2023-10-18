using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
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
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

        private void addBook_btn_Click(object sender, EventArgs e)
        {
            addBookForm addBookForm = new addBookForm();
            addBookForm.Show();
            this.Hide();
        }

        private async void admin_panel_Load(object sender, EventArgs e)
        {
            using(HttpClient client = new HttpClient())
            {
                try
                {
                    string getBooksUrl = "http://localhost:3000/books";
                    HttpResponseMessage response = await client.GetAsync(getBooksUrl);

                    if(response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        List<Book> data = new List<Book>();
                        data = JsonConvert.DeserializeObject<List<Book>>(content);
                        List<Book> book = data;

                        // DataGridView'i temizle
                        bookList_datagrdvw.Rows.Clear();
                        bookList_datagrdvw.Columns.Clear();

                        // DataGridView için sütunları oluşturun
                        bookList_datagrdvw.Columns.Add("bookName", "Kitap Adı");
                        bookList_datagrdvw.Columns.Add("publicationYear", "Basım Tarihi");
                        bookList_datagrdvw.Columns.Add("publisher", "Yayınevi");
                        bookList_datagrdvw.Columns.Add("language", "Dili");
                        bookList_datagrdvw.Columns.Add("author", "Yazarı");
                        bookList_datagrdvw.Columns.Add("aboutBook", "Kitap Hakkında");
                        bookList_datagrdvw.Columns.Add("isAvailable", "Uygunluk");
                        bookList_datagrdvw.Columns.Add("loaner", "Ödünç Alan");
                        bookList_datagrdvw.Columns.Add("borrowedAt", "Ödünç Alınma Tarihi");



                        // Diğer sütunları burada ekleyebilirsiniz

                        // API verilerini DataGridView'e ekleyin
                        foreach (Book item in book)
                        {
                            // DataGridView'e bir satır ekleyin ve verileri sütunlara yerleştirin
                            int rowIndex = bookList_datagrdvw.Rows.Add();
                            bookList_datagrdvw["bookName", rowIndex].Value = item.bookName;
                            bookList_datagrdvw["publicationYear", rowIndex].Value = item.publicationYear;
                            bookList_datagrdvw["publisher", rowIndex].Value = item.publisher;
                            bookList_datagrdvw["language", rowIndex].Value = item.language;
                            bookList_datagrdvw["author", rowIndex].Value = item.author;
                            bookList_datagrdvw["aboutBook", rowIndex].Value = item.aboutBook;
                            bookList_datagrdvw["isAvailable", rowIndex].Value = item.isAvailable;
                            bookList_datagrdvw["loaner", rowIndex].Value = item.loaner;
                            bookList_datagrdvw["borrowedAt", rowIndex].Value = item.borrowedAt;
                        }

                        //MessageBox.Show("başarılı");
                    }

                    else
                    {
                        //MessageBox.Show("API yanıtı başarısız: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("hata");
                }
            }
        }

        private void admin_panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    public class Book
    {
        public string bookName { get; set; }
        public int publicationYear { get; set; }
        public string publisher { get; set; }
        public string language { get; set; }
        public string author { get; set; }
        public string aboutBook { get; set; }
        public bool isAvailable { get; set; }
        public object loaner { get; set; }
        public string borrowedAt { get; set; }
    }
}
