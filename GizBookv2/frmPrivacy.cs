using Newtonsoft.Json;

namespace GizBookv2
{
    public partial class frmPrivacy : Form
    {
        private readonly dynamic UserData;
        public frmPrivacy(dynamic userData)
        {
            InitializeComponent();
            UserData = userData;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel4.Visible = false;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmHomePage homePage = new((string)UserData.username);
            homePage.Show();
            Close();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel6.Visible = false;
        }

        private void SetDatas(dynamic data)
        {
            if (data.leaderboard_privacy == "public")
            {
                picLeaderboard.Image = Properties.Resources.buttonOff;
            }
            else
            {
                picLeaderboard.Image = Properties.Resources.buttonOn;
            }

            if (data.posts_privacy == "public")
            {
                picPostDefault.Image = Properties.Resources.Public1;
            }
            else if (data.posts_privacy == "friends")
            {
                picPostDefault.Image = Properties.Resources.Friends;
            }
            else
            {
                picPostDefault.Image = Properties.Resources.Only_Me;
            }

            Cursor.Current = Cursors.Default;
        }

        private void frmPrivacy_Load(object sender, EventArgs e)
        {
            SetDatas(UserData);
        }

        private void SetPostPrivacy(string privacy)
        {
            Cursor.Current = Cursors.WaitCursor;

            using HttpClient client = new();
            var endpoint = new Uri($"https://gizbook.vercel.app/api/settings/{(string)UserData.username}?type=posts&privacy={privacy}");
            var response = client.GetAsync(endpoint).Result;
            var result = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result)!;

            SetDatas(result);
        }

        private void picLeaderboard_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            using HttpClient client = new();
            var endpoint = new Uri($"https://gizbook.vercel.app/api/settings/{(string)UserData.username}?type=leaderboards");
            var response = client.GetAsync(endpoint).Result;
            var result = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result)!;

            SetDatas(result);
        }

        private void picPostOnlyMe_Click(object sender, EventArgs e)
        {
            SetPostPrivacy("private");

            panel4.Visible = true;
            panel6.Visible = false;
        }

        private void picPostPublic_Click(object sender, EventArgs e)
        {
            SetPostPrivacy("public");

            panel4.Visible = true;
            panel6.Visible = false;
        }

        private void picPostFriends_Click(object sender, EventArgs e)
        {
            SetPostPrivacy("friends");

            panel4.Visible = true;
            panel6.Visible = false;
        }
    }
}
