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
using static kutuphane_otomasyonu_project.BookList_Form;

namespace kutuphane_otomasyonu_project
{
    public partial class User_Profile_Form : Form
    {
        public User_Profile_Form()
        {
            InitializeComponent();
        }

        public class BookData
        {
            public string bookName { get; set; }
            public string borrowedAt { get; set; }
        }

        public class User
        {
            public string name { get; set; }
        }

        string userId = "";
        private async void User_Profile_Form_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Login_Form.userId);
            //MessageBox.Show(Register_Form.userId);
            if (Login_Form.userId != null)
            {
                userId = Login_Form.userId;
            }
            else if(Register_Form.userId != null)
            {
                userId = Register_Form.userId;
            }

            //MessageBox.Show(userId);
            string userUrl = "http://localhost:3000/users/" + userId;

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(userUrl);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                //MessageBox.Show(json);

                User user = JsonConvert.DeserializeObject<User>(json);
                //MessageBox.Show(Login_Form.userId);
                userName_lbl.Text = user.name;
            }

            main_panel.FlowDirection = FlowDirection.TopDown;
            main_panel.WrapContents = false;
            main_panel.AutoScroll = true;
            main_panel.BorderStyle = BorderStyle.None;

            string apiUrl = "http://localhost:3000/users/borrowedBook/" + Login_Form.userId;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();
                    //MessageBox.Show(json);
                    List<BookData> bookDataList = JsonConvert.DeserializeObject<List<BookData>>(json);

                    for (int i = 0; i < bookDataList.Count; i++)
                    {
                        FlowLayoutPanel cardPanel = new FlowLayoutPanel();
                        cardPanel.BorderStyle = BorderStyle.FixedSingle;
                        cardPanel.Size = new Size(main_panel.Width - 25, 65);
                        cardPanel.Margin = new Padding(10);
                        cardPanel.FlowDirection = FlowDirection.LeftToRight;

                        //PictureBox bookImage = new PictureBox();
                        //bookImage.ImageLocation = bookDataList[i].imageUrl;
                        //bookImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        //bookImage.Size = new Size(75, 100);
                        //bookImage.Location = new Point(cardPanel.Width / 2 - 37, 10);
                        //if (bookDataList[i].borrowedAt != null)
                        //{
                        //    MessageBox.Show(bookDataList[i].borrowedAt);
                        //}
                        Panel leftPanel = new Panel();
                        leftPanel.BorderStyle = BorderStyle.None;
                        leftPanel.Size = new Size(cardPanel.Width * 100 / 234, cardPanel.Height-10);
                        //leftPanel.Margin = new Padding(20);
                        leftPanel.Margin = new Padding(50, leftPanel.Margin.Top, leftPanel.Margin.Right, leftPanel.Margin.Bottom);

                        Label titleLabel = new Label();
                        titleLabel.Text = bookDataList[i].bookName;
                        changeStyle(titleLabel);
                        //titleLabel.Location = new Point(0, 120);
                        titleLabel.Width = leftPanel.Width;
                        titleLabel.Height = leftPanel.Height;
                        titleLabel.TextAlign = ContentAlignment.MiddleLeft;
                        

                        FlowLayoutPanel rigthPanel = new FlowLayoutPanel();
                        rigthPanel.BorderStyle = BorderStyle.None;
                        rigthPanel.Size = new Size(cardPanel.Width*100/234, cardPanel.Height-10);
                        rigthPanel.FlowDirection= FlowDirection.TopDown;
                        leftPanel.Margin = new Padding(leftPanel.Margin.Left, leftPanel.Margin.Top, leftPanel.Margin.Right, 50);
                        //rigthPanel.Margin = new Padding(20);

                        DateTime date = DateTime.Parse(bookDataList[i].borrowedAt);
                        Label borrowedDateLabel = new Label();
                        borrowedDateLabel.Text = "Barrowed At: " + date.ToString("dd/mm/yyyy");
                        changeStyle(borrowedDateLabel);
                        //titleLabel.Location = new Point(0, 120);
                        borrowedDateLabel.Width = rigthPanel.Width;
                        //borrowedDateLabel.Height = cardPanel.Height/2;
                        borrowedDateLabel.TextAlign = ContentAlignment.BottomRight;


                        DateTime targetDate = date.AddDays(15);
                        Label remainigDateLabel = new Label();
                        TimeSpan difference = targetDate - DateTime.Now;
                        remainigDateLabel.Text = "Remaining Days: " + ((int)(difference.TotalDays)).ToString();
                        changeStyle(remainigDateLabel);
                        //titleLabel.Location = new Point(0, 120);
                        remainigDateLabel.Width = rigthPanel.Width;
                        //remainigDateLabel.Height = cardPanel.Height/2;
                        remainigDateLabel.TextAlign = ContentAlignment.TopRight;

                        //Label authorLabel = new Label();
                        //authorLabel.Location = new Point(0, 145);
                        //authorLabel.Width = cardPanel.Width;
                        //authorLabel.TextAlign = ContentAlignment.MiddleCenter;
                        //authorLabel.Text = bookDataList[i].author;
                        //changeStyle(authorLabel);

                        //RichTextBox
                        //RichTextBox aboutBook = new RichTextBox();
                        //aboutBook.ReadOnly = true;
                        //aboutBook.ScrollBars = RichTextBoxScrollBars.Vertical;
                        //aboutBook.Text = bookDataList[i].aboutBook;
                        //aboutBook.Size = new Size(cardPanel.Width - 10, 220);
                        ////aboutBook.Width = cardPanel.Width - 10;
                        ////aboutBook.Height = 200;
                        //aboutBook.Location = new Point(5, 175);
                        //aboutBook.BackColor = Color.FromArgb(34, 40, 49);
                        //aboutBook.BorderStyle = BorderStyle.FixedSingle;
                        //changeStyle(aboutBook);

                        //FlowLayoutPanel fr Buttons
                        //FlowLayoutPanel buttonPanel = new FlowLayoutPanel();
                        //buttonPanel.Size = new Size(cardPanel.Width, 50);
                        //buttonPanel.FlowDirection = FlowDirection.LeftToRight;
                        //buttonPanel.Location = new Point(0, 405);



                        rigthPanel.Controls.Add(remainigDateLabel);
                        leftPanel.Controls.Add(titleLabel);
                        rigthPanel.Controls.Add(borrowedDateLabel);
                        cardPanel.Controls.Add(leftPanel);
                        cardPanel.Controls.Add(rigthPanel);
                        main_panel.Controls.Add(cardPanel);
                    }

                    this.Controls.Add(main_panel);
                }
                catch (HttpRequestException ex)
                {
                    //MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        void changeStyle(Control control)
        {
            control.Font = new Font("Century Gothic", 11, FontStyle.Regular);
            control.ForeColor = Color.FromArgb(238, 238, 238);
        }

    }
}
