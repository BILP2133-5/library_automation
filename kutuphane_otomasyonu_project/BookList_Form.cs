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
    public partial class BookList_Form : Form
    {
        public static DataGridView bookList_datagrdview;
        public BookList_Form()
        {
            InitializeComponent();
            //bookList_datagrdview = bookList_datagrdvw;
        }

        //private async void BookList_Form_Load(object sender, EventArgs e)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        try
        //        {
        //            string getBooksUrl = "http://localhost:3000/books";
        //            HttpResponseMessage response = await client.GetAsync(getBooksUrl);

        //            if (response.IsSuccessStatusCode)
        //            {
        //                string content = await response.Content.ReadAsStringAsync();
        //                List<Book> data = new List<Book>();
        //                data = JsonConvert.DeserializeObject<List<Book>>(content);
        //                List<Book> book = data;

        //                // DataGridView'i temizle
        //                bookList_datagrdvw.Rows.Clear();
        //                bookList_datagrdvw.Columns.Clear();

        //                // DataGridView için sütunları oluşturun
        //                bookList_datagrdvw.Columns.Add("bookName", "Kitap Adı");
        //                bookList_datagrdvw.Columns.Add("publicationYear", "Basım Tarihi");
        //                bookList_datagrdvw.Columns.Add("publisher", "Yayınevi");
        //                bookList_datagrdvw.Columns.Add("language", "Dili");
        //                bookList_datagrdvw.Columns.Add("author", "Yazarı");
        //                bookList_datagrdvw.Columns.Add("aboutBook", "Kitap Hakkında");
        //                bookList_datagrdvw.Columns.Add("isAvailable", "Uygunluk");
        //                bookList_datagrdvw.Columns.Add("loaner", "Ödünç Alan");
        //                bookList_datagrdvw.Columns.Add("borrowedAt", "Ödünç Alınma Tarihi");



        //                // Diğer sütunları burada ekleyebilirsiniz

        //                // API verilerini DataGridView'e ekleyin
        //                foreach (Book item in book)
        //                {
        //                    // DataGridView'e bir satır ekleyin ve verileri sütunlara yerleştirin
        //                    int rowIndex = bookList_datagrdvw.Rows.Add();
        //                    bookList_datagrdvw["bookName", rowIndex].Value = item.bookName;
        //                    bookList_datagrdvw["publicationYear", rowIndex].Value = item.publicationYear;
        //                    bookList_datagrdvw["publisher", rowIndex].Value = item.publisher;
        //                    bookList_datagrdvw["language", rowIndex].Value = item.language;
        //                    bookList_datagrdvw["author", rowIndex].Value = item.author;
        //                    bookList_datagrdvw["aboutBook", rowIndex].Value = item.aboutBook;
        //                    bookList_datagrdvw["isAvailable", rowIndex].Value = item.isAvailable;
        //                    bookList_datagrdvw["loaner", rowIndex].Value = item.loaner;
        //                    bookList_datagrdvw["borrowedAt", rowIndex].Value = item.borrowedAt;
        //                }

        //                //MessageBox.Show("başarılı");
        //            }

        //            else
        //            {
        //                //MessageBox.Show("API yanıtı başarısız: " + response.StatusCode);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            //MessageBox.Show("hata");
        //        }
        //    }

        //}

        private void minimize_btn_Click(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {

        }

        public class BookData
        {
            public string bookName { get; set; }
            public string author { get; set; }
            public string publisher { get; set; }
            public string language { get; set; }
            public string imageUrl { get; set; }
            public int publicationYear { get; set; }
            public string aboutBook { get; set; }
            public string _id { get; set; }
            public string borrowedAt { get; set; }
        }

        void changeStyle (Control control)
        {
            control.Font = new Font("Century Gothic", 11, FontStyle.Regular);
            control.ForeColor = Color.FromArgb(238, 238, 238);
        }

        private async void BookList_Form_Load(object sender, EventArgs e)
        {
            bool isUser = false;
            User_Form user_Form = Application.OpenForms["User_Form"] as User_Form;
            if (user_Form != null)
            {
                isUser = true;
            }
            //addBook_btn.Image = (Image)(new Bitmap(addBook_btn.Image, new Size(20, 20)));
            main_panel.FlowDirection = FlowDirection.LeftToRight;
            main_panel.WrapContents = true;
            main_panel.AutoScroll = true;

            string apiUrl = "http://localhost:3000/books/";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();

                    List<BookData> bookDataList = JsonConvert.DeserializeObject<List<BookData>>(json);

                    for (int i = 0; i < bookDataList.Count; i++)
                    {
                        Panel cardPanel = new Panel();
                        cardPanel.BorderStyle = BorderStyle.FixedSingle;
                        cardPanel.Size = new Size(200, 450);
                        cardPanel.Margin = new Padding(20);

                        PictureBox bookImage = new PictureBox();
                        bookImage.ImageLocation = bookDataList[i].imageUrl;
                        bookImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        bookImage.Size = new Size(75, 100);
                        bookImage.Location = new Point(cardPanel.Width / 2 - 37, 10);
                        if (bookDataList[i].borrowedAt != null)
                        {
                            MessageBox.Show(bookDataList[i].borrowedAt);
                        }
                        

                        Label titleLabel = new Label();
                        titleLabel.Text = bookDataList[i].bookName + " (" + Convert.ToInt32(bookDataList[i].publicationYear) + ")";
                        changeStyle(titleLabel);
                        titleLabel.Location = new Point(0, 120);
                        titleLabel.Width = cardPanel.Width;
                        titleLabel.TextAlign = ContentAlignment.MiddleCenter;

                        Label authorLabel = new Label();
                        authorLabel.Location = new Point(0, 145);
                        authorLabel.Width = cardPanel.Width;
                        authorLabel.TextAlign = ContentAlignment.MiddleCenter;
                        authorLabel.Text = bookDataList[i].author;
                        changeStyle(authorLabel);

                        //RichTextBox
                        RichTextBox aboutBook = new RichTextBox();
                        aboutBook.ReadOnly = true;
                        aboutBook.ScrollBars = RichTextBoxScrollBars.Vertical;
                        aboutBook.Text = bookDataList[i].aboutBook;
                        aboutBook.Size = new Size(cardPanel.Width - 10, 220);
                        //aboutBook.Width = cardPanel.Width - 10;
                        //aboutBook.Height = 200;
                        aboutBook.Location = new Point(5, 175);
                        aboutBook.BackColor = Color.FromArgb(34, 40, 49);
                        aboutBook.BorderStyle = BorderStyle.FixedSingle;
                        changeStyle(aboutBook);

                        //FlowLayoutPanel fr Buttons
                        FlowLayoutPanel buttonPanel = new FlowLayoutPanel();
                        buttonPanel.Size = new Size(cardPanel.Width, 50);
                        buttonPanel.FlowDirection = FlowDirection.LeftToRight;
                        buttonPanel.Location = new Point(0, 405);

                        if (isUser)
                        {
                            //Buttons
                            Button borrowButton = new Button();
                            borrowButton.Text = "borrow";
                            borrowButton.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                            borrowButton.FlatStyle = FlatStyle.Flat;
                            borrowButton.FlatAppearance.BorderSize = 0;
                            borrowButton.BackColor = Color.FromArgb(0, 173, 181);
                            borrowButton.ForeColor = Color.FromArgb(238, 238, 238);
                            borrowButton.Click += new EventHandler(update_btn_Click);
                            //updateButton.Size = new Size(20, 20);
                            borrowButton.AutoSize = true;
                            borrowButton.Margin = new Padding(15, borrowButton.Margin.Top, 15, borrowButton.Margin.Bottom);
                            borrowButton.Tag = bookDataList[i]._id;
                            if (bookDataList[i].borrowedAt != null )
                            {
                                borrowButton.Enabled = false;
                            }
                            //updateButton.Location = new Point(20, 405);

                            buttonPanel.Controls.Add(borrowButton);
                        }

                        else
                        {
                            //Buttons
                            Button updateButton = new Button();
                            updateButton.Text = "update";
                            updateButton.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                            updateButton.FlatStyle = FlatStyle.Flat;
                            updateButton.FlatAppearance.BorderSize = 0;
                            updateButton.BackColor = Color.FromArgb(0, 173, 181);
                            updateButton.ForeColor = Color.FromArgb(238, 238, 238);
                            updateButton.Click += new EventHandler(update_btn_Click);
                            //updateButton.Size = new Size(20, 20);
                            updateButton.AutoSize = true;
                            updateButton.Margin = new Padding(15, updateButton.Margin.Top, 15, updateButton.Margin.Bottom);
                            updateButton.Tag = bookDataList[i]._id;
                            //updateButton.Location = new Point(20, 405);

                            Button removeButton = new Button();
                            removeButton.Text = "remove";
                            removeButton.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                            removeButton.FlatStyle = FlatStyle.Flat;
                            removeButton.FlatAppearance.BorderSize = 0;
                            removeButton.BackColor = Color.FromArgb(0, 173, 181);
                            removeButton.ForeColor = Color.FromArgb(238, 238, 238);
                            removeButton.AutoSize = true;
                            removeButton.Tag = bookDataList[i]._id;
                            removeButton.Click += new EventHandler(remove_btn_Click);
                            //removeButton.Location = new Point(80, 405);

                            buttonPanel.Controls.Add(updateButton);
                            buttonPanel.Controls.Add(removeButton);
                        }                        

                        cardPanel.Controls.Add(bookImage);
                        cardPanel.Controls.Add(titleLabel);
                        cardPanel.Controls.Add(authorLabel);
                        cardPanel.Controls.Add(aboutBook);
                        cardPanel.Controls.Add(buttonPanel);
                        main_panel.Controls.Add(cardPanel);
                    }

                    this.Controls.Add(main_panel);
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }
        public string bookId;
        private async void update_btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            bookId = clickedButton.Tag as string;
            //MessageBox.Show(bookId);
            UpdateBook_Form updateForm = new UpdateBook_Form();
            updateForm.bookId = bookId;
            string apiUrl = "http://localhost:3000/books/";
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{apiUrl}/{bookId}");
                if (response.IsSuccessStatusCode)
                {
                    // Yanıtı JSON veri olarak okuyun
                    string bookData = await response.Content.ReadAsStringAsync();
                    var bookInfo = JsonConvert.DeserializeObject<BookData>(bookData);
                    
                    updateForm.bookName_txt.Text = bookInfo.bookName;
                    updateForm.publicationYear_txt.Text = bookInfo.publicationYear.ToString();
                    updateForm.publisher_txt.Text = bookInfo.publisher;
                    updateForm.language_txt.Text = bookInfo.language;
                    updateForm.author_txt.Text = bookInfo.author;
                    updateForm.imgUrl_text.Text = bookInfo.imageUrl;
                    updateForm.aboutBook_rchtxt.Text = bookInfo.aboutBook;

                    Application.OpenForms["Admin_Form"].Hide();

                    Admin_Form admin_Form = new Admin_Form();
                    admin_Form.main_panel.Controls.Clear();
                    updateForm.MdiParent = admin_Form;
                    updateForm.FormBorderStyle = FormBorderStyle.None;
                    admin_Form.main_panel.Controls.Add(updateForm);
                    updateForm.Show();
                    admin_Form.Show();
                }
                else
                {
                    Console.WriteLine("API'den veri alınamadı. HTTP durumu: " + response.StatusCode);
                }
            }
        }

        private async void remove_btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            bookId = (string)clickedButton.Tag;

            string removeBookUrl = "http://localhost:3000/books/remove";

            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.DeleteAsync($"{removeBookUrl}/{bookId}");


                if (response.IsSuccessStatusCode)
                {
                    // Başarılı yanıt
                    MessageBox.Show("işlem Başarılı");
                    Application.OpenForms["Admin_Form"].Hide();

                    Admin_Form admin_Form = new Admin_Form();
                    admin_Form.Show();

                }
                else
                {
                    // Hata durumu
                    MessageBox.Show("API yanıtı başarısız: " + response.StatusCode);
                }
            }
        }

        private async Task<List<Book>> GetBooksFromApiAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string getBooksUrl = "http://localhost:3000/books";
                HttpResponseMessage response = await client.GetAsync(getBooksUrl);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    List<Book> books = JsonConvert.DeserializeObject<List<Book>>(content);
                    return books;
                }
                else
                {
                    throw new Exception("API'den veri alınamadı.");
                }
            }
        }

        
    }
}
