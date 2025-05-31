using Newtonsoft.Json;

namespace GizBookv2
{
    public partial class frmProfilePage : Form
    {
        private readonly string username;

        public frmProfilePage(string _username)
        {
            InitializeComponent();
            username = _username;
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

        private void frmProfilePage_Load(object sender, EventArgs e)
        {
            var result = UserRegistrationData.FetchUserData(username);

            using HttpClient client2 = new();
            var endpoint2 = new Uri("https://gizbook.vercel.app/api/users");
            var response2 = client2.GetAsync(endpoint2).Result;
            var result2 = JsonConvert.DeserializeObject<List<dynamic>>(response2.Content.ReadAsStringAsync().Result)!
               .OrderByDescending(user => (int)user.score)
               .ToList();
            int rank = result2.FindIndex(user => (string)user.username == username) + 1;

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)result.avatar)!;
            label1.Text = (string)result.name;
            label2.Text = (string)result.username;
            label3.Text = (string)result.total_followers + " followers";
            label4.Text = (string)result.total_following + " following";
            label10.Text = "Your Total Score: " + (string)result.score;
            label11.Text = $"You're currently ranked {rank}{GetOrdinalSuffix(rank)} on the leaderboard! Keep Going!";
        }
    }
}
