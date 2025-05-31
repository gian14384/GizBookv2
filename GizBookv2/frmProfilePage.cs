using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GizBookv2
{
    public partial class frmProfilePage : Form
    {
        private readonly string Username;
        private readonly string OriginalUsername;

        public frmProfilePage(string username, string originalUsername)
        {
            InitializeComponent();
            Username = username;
            OriginalUsername = originalUsername;
        }

        private void btnAllPost_MouseClick(object sender, MouseEventArgs e)
        {
            panelAllPost.Visible = !panelAllPost.Visible;
            mark1.Visible = !mark1.Visible;
            panelDecks.Visible = false;
            panelFriends.Visible = false;
            panelStats.Visible = false;
            mark2.Visible = false;
            mark3.Visible = false;
            mark4.Visible = false;
        }

        private void btnDecks_MouseClick(object sender, MouseEventArgs e)
        {
            panelDecks.Visible = !panelDecks.Visible;
            mark2.Visible = !mark2.Visible;
            panelFriends.Visible = false;
            panelAllPost.Visible = false;
            panelStats.Visible = false;
            mark1.Visible = false;
            mark3.Visible = false;
            mark4.Visible = false;
        }

        private void btnStats_MouseClick(object sender, MouseEventArgs e)
        {
            panelStats.Visible = !panelStats.Visible;
            mark3.Visible = !mark3.Visible;
            panelAllPost.Visible = false;
            panelDecks.Visible = false;
            panelFriends.Visible = false;
            mark1.Visible = false;
            mark2.Visible = false;
            mark4.Visible = false;
        }

        private void btnFriends_MouseClick(object sender, MouseEventArgs e)
        {
            panelFriends.Visible = !panelFriends.Visible;
            mark4.Visible = !mark4.Visible;
            panelAllPost.Visible = false;
            panelDecks.Visible = false;
            panelStats.Visible = false;
            mark1.Visible = false;
            mark2.Visible = false;
            mark3.Visible = false;
        }
        private void panel19_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static string GetOrdinalSuffix(int number)
        {
            if (number % 100 >= 11 && number % 100 <= 13)
                return "th";
            return (number % 10) switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th",
            };
        }

        private PictureBox ClonePictureBox(int yOffset, string avatar)
        {
            PictureBox cloned = new()
            {
                Size = picFriend1.Size,
                BorderStyle = picFriend1.BorderStyle,
                Image = (Image)Properties.Resources.ResourceManager.GetObject(avatar)!,
                Location = new Point(picFriend1.Location.X, picFriend1.Location.Y + (80 * yOffset)),
                SizeMode = picFriend1.SizeMode
            };

            return cloned;
        }

        private Label CloneLabelName(int yOffset, string text)
        {
            Label cloned = new()
            {
                Size = lblFriend1.Size,
                AutoSize = lblFriend1.AutoSize,
                BorderStyle = lblFriend1.BorderStyle,
                Location = new Point(lblFriend1.Location.X, lblFriend1.Location.Y + (80 * yOffset)),
                Text = text,
                Font = lblFriend1.Font,
                ForeColor = lblFriend1.ForeColor
            };

            return cloned;
        }
        private Label CloneLabelUsername(int yOffset, string text)
        {
            Label cloned = new()
            {
                Size = lblFriendUsername1.Size,
                AutoSize = lblFriendUsername1.AutoSize,
                BorderStyle = lblFriendUsername1.BorderStyle,
                Location = new Point(lblFriendUsername1.Location.X, lblFriendUsername1.Location.Y + (80 * yOffset)),
                Text = text,
                Font = lblFriendUsername1.Font,
                ForeColor = lblFriendUsername1.ForeColor
            };

            return cloned;
        }

        private void ClickEvent(string username)
        {
            frmProfilePage profilePage = new(username, OriginalUsername);
            profilePage.Show();
            Hide();
        }

        private Panel ClonePanel(int yOffset, string username)
        {
            Panel cloned = new()
            {
                Location = new Point(pnlFriend1.Location.X, pnlFriend1.Location.Y + (80 * yOffset)),
                BackgroundImage = pnlFriend1.BackgroundImage,
                BackgroundImageLayout = pnlFriend1.BackgroundImageLayout,
                Cursor = pnlFriend1.Cursor,
                Size = pnlFriend1.Size
            };
            cloned.Click += (sender, e) => ClickEvent(username);

            return cloned;
        }

        private void frmProfilePage_Load(object sender, EventArgs e)
        {
            var user = UserRegistrationData.FetchUserData(Username);

            using HttpClient client2 = new();
            var endpoint2 = new Uri("https://gizbook.vercel.app/api/users");
            var response2 = client2.GetAsync(endpoint2).Result;
            var result2 = JsonConvert.DeserializeObject<List<dynamic>>(response2.Content.ReadAsStringAsync().Result)!
               .OrderByDescending(user => (int)user.score)
               .ToList();
            int rank = result2.FindIndex(user => (string)user.username == Username) + 1;

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)user.avatar)!;
            label1.Text = (string)user.name;
            label2.Text = (string)user.username;
            label3.Text = (string)user.total_followers + " followers";
            label4.Text = (string)user.total_following + " following";
            label10.Text = "Your Total Score: " + (string)user.score;
            label11.Text = $"{(OriginalUsername == Username ? "You're" : "They are")} currently ranked {rank}{GetOrdinalSuffix(rank)} on the leaderboard! {(OriginalUsername == Username ? "Keep Going!" : "")}";

            // FRIENDS
            string[] friends = ((JArray)user.friends).Select(username => username.ToString()).ToArray();
            dynamic friend1 = result2[result2.FindIndex(user => (string)user.username == friends[0])];
            picFriend1.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)friend1.avatar)!;
            lblFriend1.Text = (string)friend1.name;
            lblFriendUsername1.Text = (string)friend1.username;
            pnlFriend1.Click += (sender, e) => ClickEvent((string)friend1.username);

            for (int i = 1; i < friends.Length; i++)
            {
                dynamic friend = result2[result2.FindIndex(user => (string)user.username == friends[i])];
                PictureBox friendPic = ClonePictureBox(i, (string)friend.avatar);
                Label friendName = CloneLabelName(i, (string)friend.name);
                Label friendUsername = CloneLabelUsername(i, (string)friend.username);
                Panel friendPanel = ClonePanel(i, (string)friend.username);

                panel15.Controls.Add(friendPic);
                panel15.Controls.Add(friendName);
                panel15.Controls.Add(friendUsername);
                panel15.Controls.Add(friendPanel);
            }
        }
    }
}
