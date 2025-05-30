using GizBook;
using Newtonsoft.Json;

namespace GizBookv2
{
    public partial class frmHomePage : Form
    {
#pragma warning disable CS8618
        public frmHomePage()
        {
            InitializeComponent();

        }

        private void panel20_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private readonly UserRegistrationData _userData;

        public frmHomePage(UserRegistrationData userData)
        {
            InitializeComponent();
            _userData = userData;
            lblName.Text = userData.name;
            profile.Image = (Image)Properties.Resources.ResourceManager.GetObject(userData.avatar!)!;
            page.Image = (Image)Properties.Resources.ResourceManager.GetObject(userData.avatar!)!;
            page.SizeMode = PictureBoxSizeMode.StretchImage;
            profile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frmProfilePage profilePage = new(_userData.username);
            profilePage.Show();
        }

        private void page_Click(object sender, EventArgs e)
        {
            frmProfilePage profilePage = new(_userData.username);
            profilePage.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            // Provide default values for deckName and Color as required by frmDeckPage constructor
            string defaultDeckName = "How to Kiss a Girl";
            Color defaultColor = Color.Blue;
            frmDeckPage fd = new frmDeckPage(defaultDeckName, defaultColor);
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
            frmPrivacy privacyPage = new();
            privacyPage.Show();

            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
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

        private void btndropdown_Paint(object sender, PaintEventArgs e)
        {

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
            frmProfilePage profilePage = new(_userData.username);
            profilePage.Show();
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

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            // LEADERBOARDS
            using HttpClient client = new();
            var endpoint = new Uri("https://gizbook.vercel.app/api/users");
            var response = client.GetAsync(endpoint).Result;
            var result = JsonConvert.DeserializeObject<List<dynamic>>(response.Content.ReadAsStringAsync().Result)!
               .OrderByDescending(user => (int)user.score)
               .ToList();

            for (int i = 0; i < 10; i++)
            {
                var pic = Controls.Find($"pic{i + 1}", true).FirstOrDefault() as PictureBox;
                var picRank = Controls.Find($"picRank{i + 1}", true).FirstOrDefault() as PictureBox;
                var lblRank = Controls.Find($"lblRank{i + 1}", true).FirstOrDefault() as Label;
                var lblScore = Controls.Find($"lblScore{i + 1}", true).FirstOrDefault() as Label;
                var pnlRank = Controls.Find($"pnlRank{i + 1}", true).FirstOrDefault() as Panel;

                if (result.Count > i)
                {
                    if (pnlRank != null) pnlRank.Visible = true;
                    if (pic != null) pic.Visible = true;
                    if (picRank != null)
                    {
                        picRank.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)result[i].avatar)!;
                        picRank.Visible = true;
                    }
                    if (lblRank != null)
                    {
                        lblRank.Text = (string)result[i].name;
                        lblRank.Visible = true;
                    }
                    if (lblScore != null)
                    {
                        lblScore.Text = result[i].score.ToString();
                        lblScore.Visible = true;
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
        }
    }
}
