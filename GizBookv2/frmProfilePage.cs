using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace GizBookv2
{
#pragma warning disable CS8618
    public partial class frmProfilePage : Form
    {
        private readonly string Username;
        private readonly string OriginalUsername;
        private List<dynamic> AllUsers;
        private dynamic User;

        public frmProfilePage(string username, string originalUsername)
        {
            InitializeComponent();
            Username = username;
            OriginalUsername = originalUsername;
        }

        private void btnAllPost_MouseClick(object sender, MouseEventArgs e)
        {
            panelAllPost.Visible = true;
            mark1.Visible = true;
            panelDecks.Visible = false;
            panelFriends.Visible = false;
            panelStats.Visible = false;
            mark2.Visible = false;
            mark3.Visible = false;
            mark4.Visible = false;
        }

        private void btnDecks_MouseClick(object sender, MouseEventArgs e)
        {
            panelDecks.Visible = true;
            mark2.Visible = true;
            panelFriends.Visible = false;
            panelAllPost.Visible = false;
            panelStats.Visible = false;
            mark1.Visible = false;
            mark3.Visible = false;
            mark4.Visible = false;
        }

        private void btnStats_MouseClick(object sender, MouseEventArgs e)
        {
            panelStats.Visible = true;
            mark3.Visible = true;
            panelAllPost.Visible = false;
            panelDecks.Visible = false;
            panelFriends.Visible = false;
            mark1.Visible = false;
            mark2.Visible = false;
            mark4.Visible = false;
        }

        private void btnFriends_MouseClick(object sender, MouseEventArgs e)
        {
            panelFriends.Visible = true;
            mark4.Visible = true;
            panelAllPost.Visible = false;
            panelDecks.Visible = false;
            panelStats.Visible = false;
            mark1.Visible = false;
            mark2.Visible = false;
            mark3.Visible = false;

            SetFriendPanel((int)User.total_friends, (JArray)User.friends, "Button2");
        }
        private void panel19_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmHomePage homePage = new(OriginalUsername);
            homePage.Show();
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
                SizeMode = picFriend1.SizeMode,
                Visible = true
            };

            return cloned;
        }

        private Label CloneLabelName(int yOffset, string text, string username)
        {
            Label cloned = new()
            {
                Size = lblFriend1.Size,
                AutoSize = lblFriend1.AutoSize,
                BorderStyle = lblFriend1.BorderStyle,
                Location = new Point(lblFriend1.Location.X, lblFriend1.Location.Y + (80 * yOffset)),
                Text = text + (OriginalUsername == username ? " (You)" : ""),
                Font = lblFriend1.Font,
                ForeColor = lblFriend1.ForeColor,
                Visible = true
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
                ForeColor = lblFriendUsername1.ForeColor,
                Visible = true
            };

            return cloned;
        }

        private void ClickEventVisit(string username)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmProfilePage profilePage = new(username, OriginalUsername);
            profilePage.Show();
            Close();
        }

        private void ClickEventUnfollow(string username)
        {
            Cursor.Current = Cursors.WaitCursor;
            using HttpClient client = new();
            var endpoint = new Uri("https://gizbook.vercel.app/api/friends/delete/" + OriginalUsername);

            var newUserJson = JsonConvert.SerializeObject(new Dictionary<string, string>
            {
               { "unfollow", username }
            });
            var payload = new StringContent(newUserJson, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endpoint, payload).Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                frmProfilePage profilePage = new(Username, OriginalUsername);
                profilePage.Show();
                Close();
            }
            else
            {
                var errorMessage = response.Content.ReadAsStringAsync().Result;
                MessageBox.Show($"Something went wrong. Please try again.\nError: {errorMessage}");
                Cursor.Current = Cursors.Default;
            }
        }
        
        private void ClickEventFollow(string username)
        {
            Cursor.Current = Cursors.WaitCursor;
            using HttpClient client = new();
            var endpoint = new Uri("https://gizbook.vercel.app/api/friends/create/" + OriginalUsername);

            var newUserJson = JsonConvert.SerializeObject(new Dictionary<string, string>
            {
               { "follow", username }
            });
            var payload = new StringContent(newUserJson, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endpoint, payload).Result;

            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                frmProfilePage profilePage = new(Username, OriginalUsername);
                profilePage.Show();
                Close();
            }
            else
            {
                var errorMessage = response.Content.ReadAsStringAsync().Result;
                MessageBox.Show($"Something went wrong. Please try again.\nError: {errorMessage}");
                Cursor.Current = Cursors.Default;
            }
        }

        private Panel ClonePanel(int yOffset, string username, string bg)
        {
            Panel cloned = new()
            {
                Location = new Point(pnlFriend1.Location.X, pnlFriend1.Location.Y + (80 * yOffset)),
                BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(bg)!,
                BackgroundImageLayout = pnlFriend1.BackgroundImageLayout,
                Cursor = pnlFriend1.Cursor,
                Size = pnlFriend1.Size,
                Visible = true
            };

            if (bg == "unfollow")
            {
                if (OriginalUsername == username || OriginalUsername != Username)
                {
                    cloned.Visible = false;
                }
                else
                {
                    cloned.Click += (sender, e) => ClickEventUnfollow(username);
                }
            }
            else if (bg == "follow")
            {
                if ((int)User.total_following > 0)
                {
                    if (((JArray)User.following).Select(username => username.ToString()).ToArray().Contains(username))
                    {
                        cloned.Visible = false;
                    }
                }
                
                if (OriginalUsername == username || OriginalUsername != Username)
                {
                    cloned.Visible = false;
                }
                else
                {
                    cloned.Click += (sender, e) => ClickEventFollow(username);
                }
            }
            else
            {
                cloned.Click += (sender, e) => ClickEventVisit(username);
            }

            return cloned;
        }

        private dynamic GetUser(string username)
        {
            return AllUsers[AllUsers.FindIndex(user => (string)user.username == username)];
        }

        private void SetFriendPanel(int totalFriends, JArray friendsArray, string bg)
        {
            foreach (Control control in panel15.Controls.Cast<Control>().ToList())
            {
                if (control == picFriend1 || control == lblFriend1 || control == lblFriendUsername1 || control == pnlFriend1)
                {
                    if (control == pnlFriend1)
                    {
                        pnlFriend1.Click -= null;
                    }
                    continue;
                }
                panel15.Controls.Remove(control);
                control.Dispose();
            }

            picFriend1.Visible = false;
            lblFriend1.Visible = false;
            lblFriendUsername1.Visible = false;
            pnlFriend1.Visible = false;
            if (totalFriends > 0)
            {
                string[] friends = friendsArray.Select(username => username.ToString()).ToArray();

                for (int i = 0; i < friends.Length; i++)
                {
                    dynamic friend = GetUser(friends[i]);
                    PictureBox friendPic = ClonePictureBox(i, (string)friend.avatar);
                    Label friendName = CloneLabelName(i, (string)friend.name, (string)friend.username);
                    Label friendUsername = CloneLabelUsername(i, (string)friend.username);
                    Panel friendPanel = ClonePanel(i, (string)friend.username, bg);

                    panel15.Controls.Add(friendPic);
                    panel15.Controls.Add(friendName);
                    panel15.Controls.Add(friendUsername);
                    panel15.Controls.Add(friendPanel);
                }
            }
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

            User = user;
            AllUsers = result2;

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)user.avatar)!;
            label1.Text = (string)user.name;
            label2.Text = (string)user.username;
            label3.Text = (string)user.total_followers + " followers";
            label4.Text = (string)user.total_following + " following";
            label10.Text = "Your Total Score: " + (string)user.score;
            label11.Text = $"{(OriginalUsername == Username ? "You're" : "They are")} currently ranked {rank}{GetOrdinalSuffix(rank)} on the leaderboard! {(OriginalUsername == Username ? "Keep Going!" : "")}";

            // FRIENDS
            SetFriendPanel((int)user.total_friends, (JArray)user.friends, "Button2");

            Cursor.Current = Cursors.Default;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panelFriends.Visible = true;
            panelAllPost.Visible = false;
            panelDecks.Visible = false;
            panelStats.Visible = false;
            mark1.Visible = false;
            mark2.Visible = false;
            mark3.Visible = false;
            mark4.Visible = false;

            SetFriendPanel((int)User.total_following, (JArray)User.following, "unfollow");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panelFriends.Visible = true;
            panelAllPost.Visible = false;
            panelDecks.Visible = false;
            panelStats.Visible = false;
            mark1.Visible = false;
            mark2.Visible = false;
            mark3.Visible = false;
            mark4.Visible = false;

            SetFriendPanel((int)User.total_followers, (JArray)User.followers, "follow");
        }
    }
}
