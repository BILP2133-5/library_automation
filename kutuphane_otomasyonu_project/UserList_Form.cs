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
            main_panel.AutoScroll = true;
            string apiUrl = "http://localhost:3000/users/";
            string protectedUrl = "http://localhost:3000/auth/protected";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Login_Form.userToken);
                var authUserResponse = await client.GetAsync(protectedUrl);

                if (authUserResponse.IsSuccessStatusCode)
                {
                    var authUserContent = await authUserResponse.Content.ReadAsStringAsync();
                    var authUserJsonData = JsonConvert.DeserializeObject<dynamic>(authUserContent);

                    using (HttpClient clientt = new HttpClient())
                    {
                        try
                        {
                            var response = await clientt.GetAsync(apiUrl);
                            response.EnsureSuccessStatusCode();
                            string json = await response.Content.ReadAsStringAsync();

                            List<UserData> userDataList = JsonConvert.DeserializeObject<List<UserData>>(json);

                            for (int i = 0; i < userDataList.Count; i++)
                            {
                                if (authUserJsonData.user.role == "superadmin")
                                {
                                    if (userDataList[i].role != "superadmin")
                                    {
                                        FlowLayoutPanel rowFlowPanel = new FlowLayoutPanel();
                                        rowFlowPanel.BorderStyle = BorderStyle.FixedSingle;
                                        rowFlowPanel.Size = new Size(main_panel.Width - 10, main_panel.Height / 15);
                                        rowFlowPanel.Location = new Point(0, 0);
                                        rowFlowPanel.FlowDirection = FlowDirection.LeftToRight;

                                        Label userNameLabel = new Label();
                                        userNameLabel.Text = userDataList[i].name;
                                        changeStyle(userNameLabel);
                                        userNameLabel.Height = rowFlowPanel.Height;
                                        userNameLabel.Width = rowFlowPanel.Width * 4 / 14;
                                        userNameLabel.TextAlign = ContentAlignment.MiddleLeft;

                                        Label userEmailLabel = new Label();
                                        userEmailLabel.Height = rowFlowPanel.Height;
                                        userEmailLabel.Width = rowFlowPanel.Width * 4 / 14;
                                        userEmailLabel.TextAlign = ContentAlignment.MiddleLeft;
                                        userEmailLabel.Text = userDataList[i].email;
                                        changeStyle(userEmailLabel);

                                        Label userRoleLabel = new Label();
                                        userRoleLabel.Height = rowFlowPanel.Height;
                                        userRoleLabel.Width = rowFlowPanel.Width * 3 / 14;
                                        userRoleLabel.TextAlign = ContentAlignment.MiddleLeft;
                                        userRoleLabel.Text = "role: " + userDataList[i].role;
                                        changeStyle(userRoleLabel);

                                        rowFlowPanel.Controls.Add(userNameLabel);
                                        rowFlowPanel.Controls.Add(userEmailLabel);
                                        rowFlowPanel.Controls.Add(userRoleLabel);

                                        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                                        flowLayoutPanel.BorderStyle = BorderStyle.None;
                                        flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;

                                        Button removeButton = new Button();
                                        removeButton.Text = "remove";
                                        removeButton.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                                        removeButton.FlatStyle = FlatStyle.Flat;
                                        removeButton.FlatAppearance.BorderSize = 0;
                                        removeButton.BackColor = Color.FromArgb(0, 173, 181);
                                        removeButton.ForeColor = Color.FromArgb(238, 238, 238);
                                        removeButton.AutoSize = false;
                                        removeButton.Size = new Size(76, 31);
                                        removeButton.TextAlign = ContentAlignment.MiddleCenter;
                                        removeButton.Tag = userDataList[i]._id;
                                        removeButton.Click += new EventHandler(remove_btn_Click);
                                        if (userDataList[i].role != "admin")
                                        {
                                            Button detailButton = new Button();
                                            detailButton.Text = "detail";
                                            detailButton.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                                            detailButton.FlatStyle = FlatStyle.Flat;
                                            detailButton.FlatAppearance.BorderSize = 0;
                                            detailButton.BackColor = Color.FromArgb(0, 173, 181);
                                            detailButton.ForeColor = Color.FromArgb(238, 238, 238);
                                            detailButton.AutoSize = false;
                                            detailButton.Size = new Size(76, 31);
                                            detailButton.TextAlign = ContentAlignment.MiddleCenter;
                                            detailButton.Tag = userDataList[i]._id;
                                            detailButton.Click += new EventHandler(remove_btn_Click);
                                            flowLayoutPanel.Controls.Add(detailButton);
                                            rowFlowPanel.Controls.Add(detailButton);
                                        }
                                        flowLayoutPanel.Controls.Add(removeButton);
                                        rowFlowPanel.Controls.Add(removeButton);
                                        rowFlowPanel.Controls.Add(flowLayoutPanel);

                                        main_panel.Controls.Add(rowFlowPanel);

                                    }
                                }

                                else
                                {
                                    if (userDataList[i].role != "superadmin" && userDataList[i].role != "admin")
                                    {
                                        FlowLayoutPanel rowFlowPanel = new FlowLayoutPanel();
                                        rowFlowPanel.BorderStyle = BorderStyle.FixedSingle;
                                        rowFlowPanel.Size = new Size(main_panel.Width - 10, main_panel.Height / 15);
                                        rowFlowPanel.Location = new Point(0, 0);
                                        rowFlowPanel.FlowDirection = FlowDirection.LeftToRight;

                                        Label userNameLabel = new Label();
                                        userNameLabel.Text = userDataList[i].name;
                                        changeStyle(userNameLabel);
                                        userNameLabel.Height = rowFlowPanel.Height;
                                        userNameLabel.Width = rowFlowPanel.Width * 4 / 14;
                                        userNameLabel.TextAlign = ContentAlignment.MiddleLeft;

                                        Label userEmailLabel = new Label();
                                        userEmailLabel.Height = rowFlowPanel.Height;
                                        userEmailLabel.Width = rowFlowPanel.Width * 4 / 14;
                                        userEmailLabel.TextAlign = ContentAlignment.MiddleLeft;
                                        userEmailLabel.Text = userDataList[i].email;
                                        changeStyle(userEmailLabel);

                                        Label userRoleLabel = new Label();
                                        userRoleLabel.Height = rowFlowPanel.Height;
                                        userRoleLabel.Width = rowFlowPanel.Width * 3 / 14;
                                        userRoleLabel.TextAlign = ContentAlignment.MiddleLeft;
                                        userRoleLabel.Text = "role: " + userDataList[i].role;
                                        changeStyle(userRoleLabel);

                                        rowFlowPanel.Controls.Add(userNameLabel);
                                        rowFlowPanel.Controls.Add(userEmailLabel);
                                        rowFlowPanel.Controls.Add(userRoleLabel);

                                        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                                        flowLayoutPanel.BorderStyle = BorderStyle.None;
                                        flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;

                                        Button detailButton = new Button();
                                        detailButton.Text = "detail";
                                        detailButton.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                                        detailButton.FlatStyle = FlatStyle.Flat;
                                        detailButton.FlatAppearance.BorderSize = 0;
                                        detailButton.BackColor = Color.FromArgb(0, 173, 181);
                                        detailButton.ForeColor = Color.FromArgb(238, 238, 238);
                                        detailButton.AutoSize = false;
                                        detailButton.Size = new Size(76, 31);
                                        detailButton.TextAlign = ContentAlignment.MiddleCenter;
                                        detailButton.Tag = userDataList[i]._id;
                                        detailButton.Click += new EventHandler(remove_btn_Click);
                                        flowLayoutPanel.Controls.Add(detailButton);
                                        rowFlowPanel.Controls.Add(detailButton);
                                        rowFlowPanel.Controls.Add(flowLayoutPanel);

                                        main_panel.Controls.Add(rowFlowPanel);

                                    }
                                }
                                //if (userDataList[i].role != "superadmin")
                                //{
                                //    FlowLayoutPanel rowFlowPanel = new FlowLayoutPanel();
                                //    rowFlowPanel.BorderStyle = BorderStyle.FixedSingle;
                                //    rowFlowPanel.Size = new Size(main_panel.Width - 10, main_panel.Height / 15);
                                //    rowFlowPanel.Location = new Point(0, 0);
                                //    rowFlowPanel.FlowDirection = FlowDirection.LeftToRight;

                                //    Label userNameLabel = new Label();
                                //    userNameLabel.Text = userDataList[i].name;
                                //    changeStyle(userNameLabel);
                                //    userNameLabel.Height = rowFlowPanel.Height;
                                //    userNameLabel.Width = rowFlowPanel.Width * 4 / 14;
                                //    userNameLabel.TextAlign = ContentAlignment.MiddleLeft;

                                //    Label userEmailLabel = new Label();
                                //    userEmailLabel.Height = rowFlowPanel.Height;
                                //    userEmailLabel.Width = rowFlowPanel.Width * 4 / 14;
                                //    userEmailLabel.TextAlign = ContentAlignment.MiddleLeft;
                                //    userEmailLabel.Text = userDataList[i].email;
                                //    changeStyle(userEmailLabel);

                                //    Label userRoleLabel = new Label();
                                //    userRoleLabel.Height = rowFlowPanel.Height;
                                //    userRoleLabel.Width = rowFlowPanel.Width * 3 / 14;
                                //    userRoleLabel.TextAlign = ContentAlignment.MiddleLeft;
                                //    userRoleLabel.Text = "role: " + userDataList[i].role;
                                //    changeStyle(userRoleLabel);

                                //    rowFlowPanel.Controls.Add(userNameLabel);
                                //    rowFlowPanel.Controls.Add(userEmailLabel);
                                //    rowFlowPanel.Controls.Add(userRoleLabel);

                                //    if (authUserJsonData.user.role == "superadmin")
                                //    {
                                //        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                                //        flowLayoutPanel.BorderStyle = BorderStyle.None;
                                //        flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;

                                //        Button removeButton = new Button();
                                //        removeButton.Text = "remove";
                                //        removeButton.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                                //        removeButton.FlatStyle = FlatStyle.Flat;
                                //        removeButton.FlatAppearance.BorderSize = 0;
                                //        removeButton.BackColor = Color.FromArgb(0, 173, 181);
                                //        removeButton.ForeColor = Color.FromArgb(238, 238, 238);
                                //        removeButton.AutoSize = false;
                                //        removeButton.Size = new Size(76, 31);
                                //        removeButton.TextAlign = ContentAlignment.MiddleCenter;
                                //        removeButton.Tag = userDataList[i]._id;
                                //        removeButton.Click += new EventHandler(remove_btn_Click);
                                //        if (userDataList[i].role != "admin")
                                //        {
                                //            Button detailButton = new Button();
                                //            detailButton.Text = "detail";
                                //            detailButton.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                                //            detailButton.FlatStyle = FlatStyle.Flat;
                                //            detailButton.FlatAppearance.BorderSize = 0;
                                //            detailButton.BackColor = Color.FromArgb(0, 173, 181);
                                //            detailButton.ForeColor = Color.FromArgb(238, 238, 238);
                                //            detailButton.AutoSize = false;
                                //            detailButton.Size = new Size(76, 31);
                                //            detailButton.TextAlign = ContentAlignment.MiddleCenter;
                                //            detailButton.Tag = userDataList[i]._id;
                                //            detailButton.Click += new EventHandler(remove_btn_Click);
                                //            flowLayoutPanel.Controls.Add(detailButton);
                                //            rowFlowPanel.Controls.Add(detailButton);
                                //        }
                                //        flowLayoutPanel.Controls.Add(removeButton);
                                //        rowFlowPanel.Controls.Add(removeButton);
                                //        rowFlowPanel.Controls.Add(flowLayoutPanel);
                                //    }

                                //    else if (authUserJsonData.user.role == "admin")
                                //    {
                                //        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                                //        flowLayoutPanel.BorderStyle = BorderStyle.None;
                                //        flowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;

                                //        Button detailButton = new Button();
                                //        detailButton.Text = "detail";
                                //        detailButton.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                                //        detailButton.FlatStyle = FlatStyle.Flat;
                                //        detailButton.FlatAppearance.BorderSize = 0;
                                //        detailButton.BackColor = Color.FromArgb(0, 173, 181);
                                //        detailButton.ForeColor = Color.FromArgb(238, 238, 238);
                                //        detailButton.AutoSize = false;
                                //        detailButton.Size = new Size(76, 31);
                                //        detailButton.TextAlign = ContentAlignment.MiddleCenter;
                                //        detailButton.Tag = userDataList[i]._id;
                                //        detailButton.Click += new EventHandler(remove_btn_Click);

                                //        flowLayoutPanel.Controls.Add(detailButton);
                                //        rowFlowPanel.Controls.Add(detailButton);
                                //        rowFlowPanel.Controls.Add(flowLayoutPanel);

                                //    }
                                //    main_panel.Controls.Add(rowFlowPanel);
                                //}
                            }

                            this.Controls.Add(main_panel);
                        }
                        catch (HttpRequestException ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                    isLoaded = true;
                    if (authUserJsonData.user.role == "superadmin")
                    {

                    }
                }
            }


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
            Button clickedButton = (Button)sender;
            string userId = (string)clickedButton.Tag;
            MessageBox.Show(userId);

            string removeUserUrl = $"http://localhost:3000/users/remove/{userId}";

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Login_Form.userToken);
                HttpResponseMessage response = await httpClient.DeleteAsync(removeUserUrl);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("İşlem Başarılı");
                    Application.OpenForms["Admin_Form"].Hide();
                    Admin_Form admin_Form = new Admin_Form();
                    admin_Form.Show();
                    //User_Form user_Form = new User_Form();
                    //getForm(user_Form);
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"API yanıtı başarısız: {response.StatusCode}\nDetay: {responseContent}");
                }
            }
        }
        //public void getForm(Form form)
        //{
        //    main_panel.Controls.Clear();
        //    form.MdiParent = this;
        //    form.FormBorderStyle = FormBorderStyle.None;
        //    main_panel.Controls.Add(form);
        //    form.Show();
        //}
    }
}
