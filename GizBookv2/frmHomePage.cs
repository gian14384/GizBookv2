using GizBook;
using GizBookv2.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace GizBookv2
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }
        private void panel20_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private readonly dynamic _userData;
        private static List<dynamic> AllUsers = [];


        public frmHomePage(string username)
        {
            InitializeComponent();
            _userData = UserRegistrationData.FetchUserData(username);
            lblName.Text = (string)_userData.name;
            profile.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)_userData.avatar!)!;
            page.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)_userData.avatar!)!;
            page.SizeMode = PictureBoxSizeMode.StretchImage;
            profile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            OpenProfile(_userData);
        }

        private void page_Click(object sender, EventArgs e)
        {
            OpenProfile(_userData);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            frmDeckPage fd = new(_userData, true);
            fd.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            frmPrivacy privacyPage = new(_userData);
            privacyPage.Show();

            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;

            Cursor.Current = Cursors.Default;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFAQ faqPage = new();
            faqPage.Show();

            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmContactUs contactPage = new();
            contactPage.Show();

            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogout logoutForm = new(this);
            logoutForm.Show();

            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void btndropdown_Click(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            OpenProfile(_userData);
        }

        private void panel33_Click_1(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void panel34_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmAddDeck addDeckForm = new((string)_userData.username, true);
            addDeckForm.Show();
            Close();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmAddDeck addDeckForm = new((string)_userData.username, true);
            addDeckForm.Show();
            Close();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            frmDeckPage2 deckPage2 = new(_userData);
            deckPage2.Show();
        }

        private void OpenProfile(dynamic user)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmProfilePage profilePage = new(user, _userData, AllUsers);
            profilePage.Show();
            Close();
        }

        private PictureBox ClonePictureBox(string avatar)
        {
            PictureBox cloned = new()
            {
                Size = picPost.Size,
                BorderStyle = picPost.BorderStyle,
                Image = (Image)Resources.ResourceManager.GetObject(avatar)!,
                Location = new Point(picPost.Location.X, picPost.Location.Y),
                SizeMode = picPost.SizeMode,
                Visible = true,
                BackColor = picPost.BackColor
            };

            return cloned;
        }

        private Label CloneLabelName(string text, string username)
        {
            Label cloned = new()
            {
                Size = lblPostName.Size,
                AutoSize = lblPostName.AutoSize,
                BorderStyle = lblPostName.BorderStyle,
                Location = new Point(lblPostName.Location.X, lblPostName.Location.Y),
                Text = text + ((string)_userData.name == username ? " (You)" : ""),
                Font = lblPostName.Font,
                ForeColor = lblPostName.ForeColor,
                Visible = true,
                BackColor = lblPostName.BackColor
            };

            return cloned;
        }

        private Label CloneLabelUsername(string text)
        {
            Label cloned = new()
            {
                Size = lblPostUsername.Size,
                AutoSize = lblPostUsername.AutoSize,
                BorderStyle = lblPostUsername.BorderStyle,
                Location = new Point(lblPostUsername.Location.X, lblPostUsername.Location.Y),
                Text = text,
                Font = lblPostUsername.Font,
                ForeColor = lblPostUsername.ForeColor,
                Visible = true,
                BackColor = lblPostUsername.BackColor
            };

            return cloned;
        }

        private Label CloneLabelUsername2(string text)
        {
            Label cloned = new()
            {
                Size = lblPostUsername2.Size,
                AutoSize = lblPostUsername2.AutoSize,
                BorderStyle = lblPostUsername2.BorderStyle,
                Location = new Point(lblPostUsername2.Location.X, lblPostUsername2.Location.Y),
                Text = $"[ {text} ] just crushed a deck!",
                Font = lblPostUsername2.Font,
                ForeColor = lblPostUsername2.ForeColor,
                Visible = true,
                BackColor = lblPostUsername2.BackColor
            };

            return cloned;
        }

        private Label CloneLabelCaption(string text)
        {
            Label cloned = new()
            {
                Size = lblCaption.Size,
                AutoSize = lblCaption.AutoSize,
                BorderStyle = lblCaption.BorderStyle,
                Location = new Point(lblCaption.Location.X, lblCaption.Location.Y),
                Text = text,
                Font = lblCaption.Font,
                ForeColor = lblCaption.ForeColor,
                Visible = true,
                BackColor = lblCaption.BackColor
            };

            return cloned;
        }

        private Label CloneLabelDeckName(string text)
        {
            Label cloned = new()
            {
                Size = lblPostDeckName.Size,
                AutoSize = lblPostDeckName.AutoSize,
                BorderStyle = lblPostDeckName.BorderStyle,
                Location = new Point(lblPostDeckName.Location.X, lblPostDeckName.Location.Y),
                Text = text,
                Font = lblPostDeckName.Font,
                ForeColor = lblPostDeckName.ForeColor,
                Visible = true,
                BackColor = lblPostDeckName.BackColor,
                AutoEllipsis = lblPostDeckName.AutoEllipsis
            };

            return cloned;
        }

        private void LikePost(int postId, string type)
        {
            Cursor.Current = Cursors.WaitCursor;
            using HttpClient client = new();
            var endpoint = new Uri($"https://gizbook.vercel.app/api/posts/{(string)_userData.username}/{postId}?type={(type == "heart" ? "like" : "unlike")}");
            var response = client.GetAsync(endpoint).Result;
            var result = JsonConvert.DeserializeObject<List<dynamic>>(response.Content.ReadAsStringAsync().Result)!
               .ToList();

            LoadPosts(result);
        }

        private Panel ClonePanelLike(string bg, int postId)
        {
            Panel cloned = new()
            {
                Location = new Point(pnlPostLike.Location.X, pnlPostLike.Location.Y),
                BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(bg)!,
                BackgroundImageLayout = pnlPostLike.BackgroundImageLayout,
                Cursor = pnlPostLike.Cursor,
                Size = pnlPostLike.Size,
                Visible = true,
                BackColor = pnlPostLike.BackColor
            };

            cloned.Click += (sender, e) => LikePost(postId, bg);

            return cloned;
        }

        private void SharePost(string postId)
        {
            Cursor.Current = Cursors.WaitCursor;
            using HttpClient client = new();
            var endpoint = new Uri("https://gizbook.vercel.app/api/posts/" + (string)_userData.username);

            var newPostJson = JsonConvert.SerializeObject(new Dictionary<string, string>
            {
               { "deck_id", postId },
               { "caption", "Check out this deck!" }
            });

            var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endpoint, payload).Result;
            var result = JsonConvert.DeserializeObject<List<dynamic>>(response.Content.ReadAsStringAsync().Result)!
               .ToList();

            LoadPosts(result);
        }

        private Panel ClonePanelShare(string bg, string postId)
        {
            Panel cloned = new()
            {
                Location = new Point(pnlShare.Location.X, pnlShare.Location.Y),
                BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(bg)!,
                BackgroundImageLayout = pnlShare.BackgroundImageLayout,
                Cursor = pnlShare.Cursor,
                Size = pnlShare.Size,
                Visible = true,
                BackColor = pnlShare.BackColor
            };

            if (bg == "share") cloned.Click += (sender, e) => SharePost(postId);
            else cloned.Cursor = Cursors.No;

            return cloned;
        }

        private Panel ClonePanelButton()
        {
            Panel cloned = new()
            {
                Location = new Point(pnlPostButton.Location.X, pnlPostButton.Location.Y),
                BackgroundImage = pnlPostButton.BackgroundImage,
                BackgroundImageLayout = pnlPostButton.BackgroundImageLayout,
                Cursor = pnlPostButton.Cursor,
                Size = pnlPostButton.Size,
                Visible = true,
                BackColor = pnlPostButton.BackColor
            };

            return cloned;
        }

        private Panel ClonePanelTry()
        {
            Panel cloned = new()
            {
                Location = new Point(pnlPostTry.Location.X, pnlPostTry.Location.Y),
                BackgroundImage = pnlPostTry.BackgroundImage,
                BackgroundImageLayout = pnlPostTry.BackgroundImageLayout,
                Cursor = pnlPostTry.Cursor,
                Size = pnlPostTry.Size,
                Visible = true,
                BackColor = pnlPostTry.BackColor
            };

            return cloned;
        }

        private Label CloneLabelStatic()
        {
            Label cloned = new()
            {
                Size = lblStatic.Size,
                AutoSize = lblStatic.AutoSize,
                BorderStyle = lblStatic.BorderStyle,
                Location = new Point(lblStatic.Location.X, lblStatic.Location.Y),
                Text = lblStatic.Text,
                Font = lblStatic.Font,
                ForeColor = lblStatic.ForeColor,
                Visible = true,
                BackColor = lblStatic.BackColor
            };

            return cloned;
        }

        private Panel ClonePanelStatic2()
        {
            Panel cloned = new()
            {
                Location = new Point(pnlStatic2.Location.X, pnlStatic2.Location.Y),
                BackgroundImage = pnlStatic2.BackgroundImage,
                BackgroundImageLayout = pnlStatic2.BackgroundImageLayout,
                Cursor = pnlStatic2.Cursor,
                Size = pnlStatic2.Size,
                Visible = true,
                BackColor = pnlStatic2.BackColor
            };

            return cloned;
        }

        private PictureBox ClonePictureEdit()
        {
            PictureBox cloned = new()
            {
                Size = picEdit.Size,
                BorderStyle = picEdit.BorderStyle,
                Image = picEdit.Image,
                Location = new Point(picEdit.Location.X, picEdit.Location.Y),
                SizeMode = picEdit.SizeMode,
                Visible = true,
                BackColor = picEdit.BackColor,
                Cursor = picEdit.Cursor
            };

            return cloned;
        }

        private PictureBox ClonePicturePrivacy()
        {
            PictureBox cloned = new()
            {
                Size = picPrivacy.Size,
                BorderStyle = picPrivacy.BorderStyle,
                Image = picPrivacy.Image,
                Location = new Point(picPrivacy.Location.X, picPrivacy.Location.Y),
                SizeMode = picPrivacy.SizeMode,
                Visible = true,
                BackColor = picPrivacy.BackColor,
                Cursor = picPrivacy.Cursor
            };

            return cloned;
        }

        private void DeletePost(string postId)
        {
            Cursor.Current = Cursors.WaitCursor;
            using HttpClient client = new();
            var endpoint = new Uri($"https://gizbook.vercel.app/api/posts/delete/{(string)_userData.username}/{postId}");
            var response = client.PostAsync(endpoint, null).Result;
            var result = JsonConvert.DeserializeObject<List<dynamic>>(response.Content.ReadAsStringAsync().Result)!
               .ToList();

            LoadPosts(result);
        }

        private PictureBox ClonePictureDelete(string postId)
        {
            PictureBox cloned = new()
            {
                Size = picDelete.Size,
                BorderStyle = picDelete.BorderStyle,
                Image = picDelete.Image,
                Location = new Point(picDelete.Location.X, picDelete.Location.Y),
                SizeMode = picDelete.SizeMode,
                Visible = true,
                BackColor = picDelete.BackColor,
                Cursor = picDelete.Cursor
            };

            cloned.Click += (sender, e) => DeletePost(postId);

            return cloned;
        }

        private Panel ClonePanelOptions(string postId)
        {
            Panel cloned = new()
            {
                Location = new Point(pnlOptions.Location.X, pnlOptions.Location.Y),
                BackgroundImage = pnlOptions.BackgroundImage,
                BackgroundImageLayout = pnlOptions.BackgroundImageLayout,
                Cursor = pnlOptions.Cursor,
                Size = pnlOptions.Size,
                Visible = false,
                BackColor = pnlOptions.BackColor
            };

            cloned.Controls.Add(ClonePictureEdit());
            cloned.Controls.Add(ClonePicturePrivacy());
            cloned.Controls.Add(ClonePictureDelete(postId));

            return cloned;
        }

        private Panel ClonePanelStatic(string username, string deckName)
        {
            Panel cloned = new()
            {
                Location = new Point(pnlStatic.Location.X, pnlStatic.Location.Y),
                BackgroundImage = pnlStatic.BackgroundImage,
                BackgroundImageLayout = pnlStatic.BackgroundImageLayout,
                Cursor = pnlStatic.Cursor,
                Size = pnlStatic.Size,
                Visible = true,
                BackColor = pnlStatic.BackColor
            };

            cloned.Controls.Add(ClonePanelStatic2());
            cloned.Controls.Add(CloneLabelUsername2(username));
            cloned.Controls.Add(CloneLabelDeckName(deckName));
            cloned.Controls.Add(CloneLabelStatic());

            return cloned;
        }

        private Panel ClonePanelPost(int yOffset, dynamic post, bool shared)
        {
            Panel cloned = new()
            {
                Location = new Point(pnlPost.Location.X, pnlPost.Location.Y + (479 * yOffset)),
                BackgroundImage = pnlPost.BackgroundImage,
                BackgroundImageLayout = pnlPost.BackgroundImageLayout,
                Cursor = pnlPost.Cursor,
                Size = pnlPost.Size,
                Visible = true,
                BackColor = pnlPost.BackColor
            };

            dynamic uploader = post.uploader;
            dynamic deck = post.deck;
            string like = "heart";
            if ((int)post.total_likes > 0) like = ((JArray)post.likes).Select(username => username.ToString()).ToArray().Contains((string)_userData.username) ? "fullheart" : "heart";

            cloned.Controls.Add(ClonePictureBox((string)uploader.avatar));
            cloned.Controls.Add(CloneLabelName((string)uploader.name, (string)uploader.username));
            cloned.Controls.Add(CloneLabelUsername((string)uploader.username));
            cloned.Controls.Add(CloneLabelCaption((string)post.caption));
            cloned.Controls.Add(ClonePanelStatic((string)deck.owner, (string)deck.title));
            cloned.Controls.Add(ClonePanelTry());
            cloned.Controls.Add(ClonePanelLike(like, (int)post.id));
            cloned.Controls.Add(ClonePanelShare(shared ? "shared" : "share", (string)deck.id));

            if ((string)uploader.username == (string)_userData.username)
            {
                Panel button = ClonePanelButton();
                Panel options = ClonePanelOptions((string)post.id);
                button.Click += (sender, e) => options.Visible = !options.Visible;
                cloned.Controls.Add(button);
                cloned.Controls.Add(options);
            }

            return cloned;
        }

        private void LoadPosts(List<dynamic> posts)
        {
            foreach (Control control in pnlPosts.Controls.Cast<Control>().ToList())
            {
                if (control == pnlPost || control == picPost || control == lblPostName || control == lblPostUsername ||
                    control == pnlPostButton || control == lblCaption || control == pnlStatic || control == pnlStatic2 ||
                    control == lblPostUsername2 || control == lblPostDeckName || control == lblStatic || control == pnlPostTry ||
                    control == pnlPostLike || control == pnlShare)
                {
                    if (control == pnlPostButton || control == pnlPostTry || control == pnlPostLike || control == pnlShare)
                    {
                        control.Click -= null;
                    }
                    continue;
                }

                pnlPosts.Controls.Remove(control);
                control.Dispose();
            }

            pnlPost.Visible = false;
            picPost.Visible = false;
            lblPostName.Visible = false;
            lblPostUsername.Visible = false;
            pnlPostButton.Visible = false;
            lblCaption.Visible = false;
            pnlStatic.Visible = false;
            pnlStatic2.Visible = false;
            lblPostUsername2.Visible = false;
            lblPostDeckName.Visible = false;
            lblStatic.Visible = false;
            pnlPostTry.Visible = false;
            pnlPostLike.Visible = false;
            pnlShare.Visible = false;
            pnlOptions.Visible = false;

            if (posts.Count > 0)
            {
                for (int i = 0; i < posts.Count; i++)
                {
                    dynamic post = posts[i];
                    bool shared = false;
                    if (posts.Select(post_ => post_.uploader.username.ToString()).ToArray().Contains((string)_userData.username))
                    {
                        List<dynamic> __posts = posts.Where(post_ => post_.uploader.username.ToString() == (string)_userData.username).ToList();

                        foreach (dynamic __post in __posts)
                        {
                            if (__post.deck.id == post.deck.id) shared = true;
                        }
                    }
                    Panel clonePost = ClonePanelPost(i, post, shared);
                    pnlPosts.Controls.Add(clonePost);
                }
            }

            Cursor.Current = Cursors.Default;
        }



        private void frmHomePage_Load(object sender, EventArgs e)
        {
            // LEADERBOARDS
            if (AllUsers.Count <= 0)
            {
                using HttpClient client = new();
                var endpoint = new Uri("https://gizbook.vercel.app/api/users");
                var response = client.GetAsync(endpoint).Result;
                var result = JsonConvert.DeserializeObject<List<dynamic>>(response.Content.ReadAsStringAsync().Result)!
                   .ToList();

                List<dynamic> allUsers = [];
                foreach (dynamic user in result)
                {
                    dynamic userData = UserRegistrationData.FetchUserData((string)user.username);
                    allUsers.Add(userData);
                }

                AllUsers = allUsers;
            }

            for (int i = 0; i < 10; i++)
            {
                var pic = Controls.Find($"pic{i + 1}", true).FirstOrDefault() as PictureBox;
                var picRank = Controls.Find($"picRank{i + 1}", true).FirstOrDefault() as PictureBox;
                var lblRank = Controls.Find($"lblRank{i + 1}", true).FirstOrDefault() as Label;
                var lblScore = Controls.Find($"lblScore{i + 1}", true).FirstOrDefault() as Label;
                var pnlRank = Controls.Find($"pnlRank{i + 1}", true).FirstOrDefault() as Panel;

                if (i < AllUsers.Count)
                {
                    dynamic user = AllUsers[i];
                    bool isAnonymous = (string)user.leaderboard_privacy == "private";
                    if (pic != null) pic.Visible = true;
                    if (picRank != null)
                    {
                        picRank.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)user.avatar)!;
                        picRank.Visible = true;
                        if (!isAnonymous)
                        {
                            picRank.Click += (sender, e) => OpenProfile(user);
                        }
                        else
                        {
                            picRank.Cursor = Cursors.Default;
                        }
                    }
                    if (lblRank != null)
                    {
                        lblRank.Text = isAnonymous ? "Anonymous User" : (string)user.name;
                        lblRank.Visible = true;
                        if (!isAnonymous)
                        {
                            lblRank.Click += (sender, e) => OpenProfile(user);
                        }
                        else
                        {
                            lblRank.Cursor = Cursors.Default;
                        }
                    }
                    if (lblScore != null)
                    {
                        lblScore.Text = user.score.ToString();
                        lblScore.Visible = true;
                        if (!isAnonymous)
                        {
                            lblScore.Click += (sender, e) => OpenProfile(user);
                        }
                        else
                        {
                            lblScore.Cursor = Cursors.Default;
                        }
                    }
                    if (pnlRank != null)
                    {
                        pnlRank.Visible = true;
                        if (!isAnonymous)
                        {
                            pnlRank.Click += (sender, e) => OpenProfile(user);
                        }
                        else
                        {
                            pnlRank.Cursor = Cursors.Default;
                        }
                    }
                }
                else
                {
                    if (pic != null) pic.Visible = false;
                    if (picRank != null) picRank.Visible = false;
                    if (lblRank != null) lblRank.Visible = false;
                    if (lblScore != null) lblScore.Visible = false;
                    if (pnlRank != null) pnlRank.Visible = false;
                }
            }


            // POSTS
            pnlPost.Visible = false;
            picPost.Visible = false;
            lblPostName.Visible = false;
            lblPostUsername.Visible = false;
            pnlPostButton.Visible = false;
            lblCaption.Visible = false;
            pnlStatic.Visible = false;
            pnlStatic2.Visible = false;
            lblPostUsername2.Visible = false;
            lblPostDeckName.Visible = false;
            lblStatic.Visible = false;
            pnlPostTry.Visible = false;
            pnlPostLike.Visible = false;
            pnlShare.Visible = false;

            using HttpClient postClient = new();
            var postEndpoint = new Uri("https://gizbook.vercel.app/api/posts/" + (string)_userData.username);
            var postResponse = postClient.GetAsync(postEndpoint).Result;
            var postResult = JsonConvert.DeserializeObject<List<dynamic>>(postResponse.Content.ReadAsStringAsync().Result)!
               .ToList();

            LoadPosts(postResult);
        }

        private void pnlPosts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
