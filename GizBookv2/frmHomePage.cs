using GizBook;
using Newtonsoft.Json;

namespace GizBookv2
{
    public partial class frmHomePage : Form
    {
        private void panel20_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private readonly dynamic _userData;

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
            OpenProfile((string)_userData.username);
        }

        private void page_Click(object sender, EventArgs e)
        {
            OpenProfile((string)_userData.username);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            // Provide default values for deckName and Color as required by frmDeckPage constructor
            string defaultDeckName = "How to Kiss a Girl";
            Color defaultColor = Color.Blue;
            frmDeckPage fd = new(defaultDeckName, defaultColor);
            fd.Show();
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

            frmPrivacy privacyPage = new((string)_userData.username);
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
            OpenProfile((string)_userData.username);
        }

        private void panel33_Click_1(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void panel34_Click(object sender, EventArgs e)
        {
            frmAddDeck addDeckForm = new();
            addDeckForm.Show();

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            frmAddDeck addDeckForm = new();
            addDeckForm.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            frmLearn learnForm = new();
            learnForm.Show();
        }

        private void OpenProfile(string username)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmProfilePage profilePage = new(username, (string)_userData.username);
            profilePage.Show();
            Close();
        }

        private PictureBox ClonePictureBox(string avatar)
        {
            PictureBox cloned = new()
            {
                Size = picPost.Size,
                BorderStyle = picPost.BorderStyle,
                Image = (Image)Properties.Resources.ResourceManager.GetObject(avatar)!,
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

        private Panel ClonePanelLike(string bg)
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

            return cloned;
        }

        private Panel ClonePanelShare(string bg)
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

        private Panel ClonePanelPost(int yOffset, dynamic post)
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
            cloned.Controls.Add(ClonePictureBox((string)uploader.avatar));
            cloned.Controls.Add(CloneLabelName((string)uploader.name, (string)uploader.username));
            cloned.Controls.Add(CloneLabelUsername((string)uploader.username));
            cloned.Controls.Add(ClonePanelButton());
            cloned.Controls.Add(CloneLabelCaption((string)post.caption));
            cloned.Controls.Add(ClonePanelStatic((string)deck.owner, (string)deck.title));
            cloned.Controls.Add(ClonePanelTry());
            cloned.Controls.Add(ClonePanelLike("heart"));
            cloned.Controls.Add(ClonePanelShare("share"));

            return cloned;
        }



        private void frmHomePage_Load(object sender, EventArgs e)
        {
            // LEADERBOARDS
            using HttpClient client = new();
            var endpoint = new Uri("https://gizbook.vercel.app/api/users");
            var response = client.GetAsync(endpoint).Result;
            var result = JsonConvert.DeserializeObject<List<dynamic>>(response.Content.ReadAsStringAsync().Result)!
               .OrderByDescending(user => (int)user.score)
               .ThenBy(user => (string)user.name)
               .ToList();

            for (int i = 0; i < 10; i++)
            {
                var pic = Controls.Find($"pic{i + 1}", true).FirstOrDefault() as PictureBox;
                var picRank = Controls.Find($"picRank{i + 1}", true).FirstOrDefault() as PictureBox;
                var lblRank = Controls.Find($"lblRank{i + 1}", true).FirstOrDefault() as Label;
                var lblScore = Controls.Find($"lblScore{i + 1}", true).FirstOrDefault() as Label;
                var pnlRank = Controls.Find($"pnlRank{i + 1}", true).FirstOrDefault() as Panel;

                if (i < result.Count)
                {
                    string username = (string)result[i].username;
                    if (pic != null) pic.Visible = true;
                    if (picRank != null)
                    {
                        picRank.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)result[i].avatar)!;
                        picRank.Visible = true;
                        picRank.Click += (sender, e) => OpenProfile(username);
                    }
                    if (lblRank != null)
                    {
                        lblRank.Text = (string)result[i].leaderboard_privacy == "public" ? (string)result[i].name : "Anonymous User";
                        lblRank.Visible = true;
                        lblRank.Click += (sender, e) => OpenProfile(username);
                    }
                    if (lblScore != null)
                    {
                        lblScore.Text = result[i].score.ToString();
                        lblScore.Visible = true;
                        lblScore.Click += (sender, e) => OpenProfile(username);
                    }
                    if (pnlRank != null)
                    {
                        pnlRank.Visible = true;
                        pnlRank.Click += (sender, e) => OpenProfile(username);
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

            if (postResult.Count > 0)
            {
                for (int i = 0; i < postResult.Count; i++)
                {
                    dynamic post = postResult[i];
                    Panel clonePost = ClonePanelPost(i, post);
                    pnlPosts.Controls.Add(clonePost);
                }
            }

            Cursor.Current = Cursors.Default;
        }
    }
}
