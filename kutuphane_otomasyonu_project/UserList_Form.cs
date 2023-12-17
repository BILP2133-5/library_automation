using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static kutuphane_otomasyonu_project.BookList_Form;

namespace kutuphane_otomasyonu_project
{
    public partial class UserList_Form : Form
    {
        public UserList_Form()
        {
            InitializeComponent();
        }

        public class UserData
        {
            public string _id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string role { get; set; }
        }

        void changeStyle(Control control)
        {
            control.Font = new Font("Century Gothic", 11, FontStyle.Regular);
            control.ForeColor = Color.FromArgb(238, 238, 238);
        }

        bool isLoaded = false;
        //List<Button> updateButtons = new List<Button>();
        public class RadioButtonData
        {
            public string Role { get; set; }
            public string Id { get; set; }
        }
        RadioButtonData userRadioButtonData, adminRadioButtonData;
        private async void UserList_Form_Load(object sender, EventArgs e)
        {
            //FlowLayoutPanel mainFlowLayoutPanel = new FlowLayoutPanel();
            //mainFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            ////mainFlowLayoutPanel.Size = new Size(-500, -500);
            //mainFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            main_panel.AutoScroll = true;
            //main_panel.Controls.Add(mainFlowLayoutPanel);

            string apiUrl = "http://localhost:3000/users/";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();

                    List<UserData> userDataList = JsonConvert.DeserializeObject<List<UserData>>(json);

                    for (int i = 0; i < userDataList.Count; i++)
                    {
                        FlowLayoutPanel rowFlowPanel = new FlowLayoutPanel();
                        rowFlowPanel.BorderStyle = BorderStyle.FixedSingle;
                        //rowFlowPanel.AutoSize = true;
                        rowFlowPanel.Size = new Size(main_panel.Width-50, main_panel.Height/15);
                        rowFlowPanel.Location = new Point(0, 0);
                        //rowFlowPanel.Margin = new Padding(0);


                        //PictureBox bookImage = new PictureBox();
                        //bookImage.ImageLocation = userDataList[i].imageUrl;
                        //bookImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        //bookImage.Size = new Size(75, 100);
                        //bookImage.Location = new Point(cardPanel.Width / 2 - 37, 10);

                        Label userNameLabel = new Label();
                        userNameLabel.Text = userDataList[i].name;
                        changeStyle(userNameLabel);
                        //userNameLabel.Location = new Point(0, -rowFlowPanel.Location.Y);
                        userNameLabel.Height = rowFlowPanel.Height;
                        userNameLabel.Width = rowFlowPanel.Width / 6;
                        //userNameLabel.Size = new Size(rowFlowPanel.Width/6, rowFlowPanel.Height);
                        userNameLabel.TextAlign = ContentAlignment.MiddleCenter;

                        Label userEmailLabel = new Label();
                        //userEmailLabel.Location = new Point(0, -rowFlowPanel.Location.Y);
                        userEmailLabel.Height = rowFlowPanel.Height;
                        userEmailLabel.Width = rowFlowPanel.Width / 4;
                        //userEmailLabel.Size = new Size(rowFlowPanel.Width / 4, rowFlowPanel.Height);
                        userEmailLabel.TextAlign = ContentAlignment.MiddleCenter;
                        userEmailLabel.Text = userDataList[i].email;
                        changeStyle(userEmailLabel);

                        //role radio buttons
                        RadioButton userRadioButton = new RadioButton();
                        userRadioButton.Text = "user";
                        changeStyle(userRadioButton);
                        //userRadioButton.Location = new Point(0, 0);
                        userRadioButton.Height = rowFlowPanel.Height;
                        //userRadioButton.ImageAlign = ContentAlignment.MiddleLeft;
                        //userRadioButton.TextAlign = ContentAlignment.MiddleLeft;
                        userRadioButton.Click += new EventHandler(adminRadioButton_Click);
                        userRadioButtonData = new RadioButtonData();
                        userRadioButtonData.Id = userDataList[i]._id;
                        userRadioButtonData.Role = "user";
                        userRadioButton.Tag = userRadioButtonData;

                        RadioButton adminRadioButton = new RadioButton();
                        adminRadioButton.Text = "admin";
                        changeStyle(adminRadioButton);
                        adminRadioButton.Height = rowFlowPanel.Height;
                        //adminRadioButton.ImageAlign = ContentAlignment.MiddleLeft;
                        //adminRadioButton.Location = new Point(0, rowFlowPanel.Height/2);
                        //adminRadioButton.Width = rowFlowPanel.Width / 8;
                        //adminRadioButton.TextAlign = ContentAlignment.MiddleLeft;
                        adminRadioButton.Click += new EventHandler(adminRadioButton_Click);
                        adminRadioButtonData = new RadioButtonData();
                        adminRadioButtonData.Id = userDataList[i]._id;
                        adminRadioButtonData.Role = "admin";
                        adminRadioButton.Tag = adminRadioButtonData;

                        if (userDataList[i].role == "user")
                        {
                            userRadioButton.Checked = true;
                        }

                        else
                        {
                            adminRadioButton.Checked = true;
                        }


                            ////RichTextBox
                            //RichTextBox aboutBook = new RichTextBox();
                            //aboutBook.ScrollBars = RichTextBoxScrollBars.Vertical;
                            //aboutBook.Text = userDataList[i].aboutBook;
                            //aboutBook.Size = new Size(cardPanel.Width - 10, 220);
                            ////aboutBook.Width = cardPanel.Width - 10;
                            ////aboutBook.Height = 200;
                            //aboutBook.Location = new Point(5, 175);
                            //aboutBook.BackColor = Color.FromArgb(34, 40, 49);
                            //aboutBook.BorderStyle = BorderStyle.FixedSingle;
                            //changeStyle(aboutBook);



                            //Buttons
                        //    Button updateButton = new Button();
                        //updateButton.Text = "update";
                        //updateButton.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                        //updateButton.FlatStyle = FlatStyle.Flat;
                        //updateButton.FlatAppearance.BorderSize = 0;
                        //updateButton.BackColor = Color.FromArgb(0, 173, 181);
                        //updateButton.ForeColor = Color.FromArgb(238, 238, 238);
                        //updateButton.Click += new EventHandler(update_btn_Click);
                        ////updateButton.Size = new Size(20, 20);
                        //updateButton.AutoSize = true;
                        ////updateButton.Margin = new Padding(15, updateButton.Margin.Top, 15, updateButton.Margin.Bottom);
                        //updateButton.Tag = userDataList[i]._id;
                        //updateButton.Enabled = false;
                        ////updateButton.Location = new Point(0, rowFlowPanel.Height/2);

                        Button removeButton = new Button();
                        removeButton.Text = "remove";
                        removeButton.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                        removeButton.FlatStyle = FlatStyle.Flat;
                        removeButton.FlatAppearance.BorderSize = 0;
                        removeButton.BackColor = Color.FromArgb(0, 173, 181);
                        removeButton.ForeColor = Color.FromArgb(238, 238, 238);
                        removeButton.AutoSize = true;
                        removeButton.Tag = userDataList[i]._id;
                        removeButton.Click += new EventHandler(remove_btn_Click);
                        //removeButton.AutoSize = true;
                        //removeButton.Location = new Point(0, -20);

                        //FlowLayoutPanel fr Buttons
                        //FlowLayoutPanel buttonPanel = new FlowLayoutPanel();
                        ////buttonPanel.AutoSize = true;
                        //buttonPanel.FlowDirection = FlowDirection.LeftToRight;
                        //buttonPanel.Location = new Point(0, 405);
                        //buttonPanel.Controls.Add(updateButton);
                        //buttonPanel.Controls.Add(removeButton);

                        rowFlowPanel.Controls.Add(userNameLabel);
                        rowFlowPanel.Controls.Add(userEmailLabel);
                        rowFlowPanel.Controls.Add(userRadioButton);
                        rowFlowPanel.Controls.Add(adminRadioButton);
                        //rowFlowPanel.Controls.Add(updateButton);
                        rowFlowPanel.Controls.Add(removeButton);
                        main_panel.Controls.Add(rowFlowPanel);
                    }

                    this.Controls.Add(main_panel);
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            isLoaded = true;
        }
        //Button updateButton = null;
        //private async void userRadioButton_CheckedChanged(object sender, EventArgs e)
        //{
        //    if(isLoaded)
        //    {
        //        DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if(result == DialogResult.Yes)
        //        {
        //            RadioButton userRadioButton = (RadioButton)sender;

        //            if (userRadioButton.Checked)
        //            {
        //                string updateUserUrl = "http://localhost:3000/user/updaterole";
        //                string userData = $"{{ \"adminUserId\": \"{Login_Form.userId}\", \"userIdToPromote\": \"{userRadioButton.Tag}\", \"role\": \"user\" }}";

        //                using (HttpClient httpClient = new HttpClient())
        //                {
        //                    var content = new StringContent(userData, Encoding.UTF8, "application/json");
        //                    HttpResponseMessage response = await httpClient.PutAsync(updateUserUrl, content);


        //                    if (response.IsSuccessStatusCode)
        //                    {
        //                        // Başarılı yanıt
        //                        MessageBox.Show("işlem Başarılı");
        //                    }
        //                    else
        //                    {
        //                        // Hata durumu
        //                        MessageBox.Show("API yanıtı başarısız: " + response.StatusCode);
        //                    }
        //                }

        //            }
        //        }
                
        //    }
        //}

        private async void adminRadioButton_Click(object sender, EventArgs e)
        {
            if(isLoaded)
            {
                RadioButton radioButton = sender as RadioButton;
                RadioButtonData storedData = radioButton.Tag as RadioButtonData;
                DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    radioButton.Checked = true;
                    string protectedUrl = "http://localhost:3000/auth/protected";
                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Login_Form.userToken);
                        var authUserResponse = await client.GetAsync(protectedUrl);
                        if (authUserResponse.IsSuccessStatusCode)
                        {
                            var authUserContent = await authUserResponse.Content.ReadAsStringAsync();
                            var authUserJsonData = JsonConvert.DeserializeObject<dynamic>(authUserContent);
                            string role = authUserJsonData.user.role;
                            //userId = authUserJsonData.user._id;
                            if (role == "admin")
                            {
                                //RadioButton adminRadioButton = (RadioButton)sender;
                                string updateUserUrl = "http://localhost:3000/users/updaterole";
                                //string userData = $"{{ \"adminUserId\": \"{Login_Form.userId}\", \"userIdToPromote\": \"{radioButton.Tag}\", \"role\": \"admin\" }}";
                                string userData = $"{{ \"userIdToPromote\": \"{storedData.Id}\", \"role\": \"{storedData.Role}\" }}";
                                MessageBox.Show(storedData.Id, storedData.Role);
                                MessageBox.Show(userData);
                                MessageBox.Show(Login_Form.userToken);

                                using (HttpClient httpClient = new HttpClient())
                                {
                                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Login_Form.userToken);
                                    var content = new StringContent(userData, Encoding.UTF8, "application/json");
                                    HttpResponseMessage response = await httpClient.PutAsync(updateUserUrl, content);


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
                            else
                            {
                                MessageBox.Show("Yetkisiz İşlem!");
                            }
                        }
                    }               
                    //if (adminRadioButton.Checked)
                    //{
                    

                    //else
                    //{
                    //    string userData = $"{{ \"adminUserId\": \"{Login_Form.userId}\", \"userIdToPromote\": \"{adminRadioButton.Tag}\", \"role\": \"user\" }}";

                    //    using (HttpClient httpClient = new HttpClient())
                    //    {
                    //        var content = new StringContent(userData, Encoding.UTF8, "application/json");
                    //        HttpResponseMessage response = await httpClient.PutAsync(updateUserUrl, content);


                    //        if (response.IsSuccessStatusCode)
                    //        {
                    //            // Başarılı yanıt
                    //            MessageBox.Show("işlem Başarılı");
                    //        }
                    //        else
                    //        {
                    //            // Hata durumu
                    //            MessageBox.Show("API yanıtı başarısız: " + response.StatusCode);
                    //        }
                    //    }
                    //}
                }
                else
                {
                    radioButton.Checked = false;
                }
            }
            
        }
        private async void userRadioButton_Click(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                RadioButton radioButton = sender as RadioButton;
                RadioButtonData storedData = radioButton.Tag as RadioButtonData;
                DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    radioButton.Checked = true;
                    string protectedUrl = "http://localhost:3000/auth/protected";
                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Login_Form.userToken);
                        var authUserResponse = await client.GetAsync(protectedUrl);
                        if (authUserResponse.IsSuccessStatusCode)
                        {
                            var authUserContent = await authUserResponse.Content.ReadAsStringAsync();
                            var authUserJsonData = JsonConvert.DeserializeObject<dynamic>(authUserContent);
                            string role = authUserJsonData.user.role;
                            //userId = authUserJsonData.user._id;
                            if (role == "admin")
                            {
                                //RadioButton adminRadioButton = (RadioButton)sender;
                                string updateUserUrl = "http://localhost:3000/users/updaterole";
                                //string userData = $"{{ \"adminUserId\": \"{Login_Form.userId}\", \"userIdToPromote\": \"{radioButton.Tag}\", \"role\": \"admin\" }}";
                                string userData = $"{{ \"userIdToPromote\": \"{storedData.Id}\", \"role\": \"{storedData.Role}\" }}";
                                MessageBox.Show(storedData.Id, storedData.Role);
                                MessageBox.Show(userData);
                                MessageBox.Show(Login_Form.userToken);

                                using (HttpClient httpClient = new HttpClient())
                                {
                                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Login_Form.userToken);
                                    var content = new StringContent(userData, Encoding.UTF8, "application/json");
                                    HttpResponseMessage response = await httpClient.PutAsync(updateUserUrl, content);


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
                            else
                            {
                                MessageBox.Show("Yetkisiz İşlem!");
                            }
                        }
                    }
                    //if (adminRadioButton.Checked)
                    //{


                    //else
                    //{
                    //    string userData = $"{{ \"adminUserId\": \"{Login_Form.userId}\", \"userIdToPromote\": \"{adminRadioButton.Tag}\", \"role\": \"user\" }}";

                    //    using (HttpClient httpClient = new HttpClient())
                    //    {
                    //        var content = new StringContent(userData, Encoding.UTF8, "application/json");
                    //        HttpResponseMessage response = await httpClient.PutAsync(updateUserUrl, content);


                    //        if (response.IsSuccessStatusCode)
                    //        {
                    //            // Başarılı yanıt
                    //            MessageBox.Show("işlem Başarılı");
                    //        }
                    //        else
                    //        {
                    //            // Hata durumu
                    //            MessageBox.Show("API yanıtı başarısız: " + response.StatusCode);
                    //        }
                    //    }
                    //}
                }
                else
                {
                    radioButton.Checked = false;
                }
            }

        }


        public string userId;

        private async void update_btn_Click(object sender, EventArgs e)
        {
            //Button clickedButton = sender as Button;
            //userId = clickedButton.Tag as string;
            ////MessageBox.Show(bookId);
            //UpdateBook_Form updateForm = new UpdateBook_Form();
            //updateForm.userId = userId;

            //string apiUrl = "http://localhost:3000/books";

            //using (HttpClient httpClient = new HttpClient())
            //{
            //    HttpResponseMessage response = await httpClient.GetAsync($"{apiUrl}/{userId}");

            //    if (response.IsSuccessStatusCode)
            //    {
            //        // Yanıtı JSON veri olarak okuyun
            //        string bookData = await response.Content.ReadAsStringAsync();
            //        var bookInfo = JsonConvert.DeserializeObject<BookData>(bookData);

            //        updateForm.bookName_txt.Text = bookInfo.bookName;
            //        updateForm.publicationYear_txt.Text = bookInfo.publicationYear.ToString();
            //        updateForm.publisher_txt.Text = bookInfo.publisher;
            //        updateForm.language_txt.Text = bookInfo.language;
            //        updateForm.author_txt.Text = bookInfo.author;
            //        updateForm.imgUrl_text.Text = bookInfo.imageUrl;
            //        updateForm.aboutBook_rchtxt.Text = bookInfo.aboutBook;

            //        Application.OpenForms["Admin_Form"].Hide();

            //        Admin_Form admin_Form = new Admin_Form();
            //        admin_Form.main_panel.Controls.Clear();
            //        updateForm.MdiParent = admin_Form;
            //        updateForm.FormBorderStyle = FormBorderStyle.None;
            //        admin_Form.main_panel.Controls.Add(updateForm);
            //        updateForm.Show();
            //        admin_Form.Show();
            //    }
            //    else
            //    {
            //        Console.WriteLine("API'den veri alınamadı. HTTP durumu: " + response.StatusCode);
            //    }
            //}
        }

        private async void remove_btn_Click(object sender, EventArgs e)
        {
            //Button clickedButton = (Button)sender;
            //userId = (string)clickedButton.Tag;

            //string removeBookUrl = "http://localhost:3000/books/remove";

            //using (HttpClient httpClient = new HttpClient())
            //{
            //    HttpResponseMessage response = await httpClient.DeleteAsync($"{removeBookUrl}/{userId}");


            //    if (response.IsSuccessStatusCode)
            //    {
            //        // Başarılı yanıt
            //        MessageBox.Show("işlem Başarılı");
            //        Application.OpenForms["Admin_Form"].Hide();

            //        Admin_Form admin_Form = new Admin_Form();
            //        admin_Form.Show();

            //    }
            //    else
            //    {
            //        // Hata durumu
            //        MessageBox.Show("API yanıtı başarısız: " + response.StatusCode);
            //    }
            //}
        }
    }
}
