using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace GizBookv2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtpassword.UseSystemPasswordChar = true;
            panel7.BackgroundImage = Properties.Resources.open;
            panel7.BackgroundImageLayout = ImageLayout.Center;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new();
            registerForm.Show();
            Hide();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string username = txtusername.Text;
            string password = txtpassword.Text;

            using var client = new HttpClient();
            var endpoint = new Uri("https://gizbook.vercel.app/api/auth/login");
            var newUserJson = JsonConvert.SerializeObject(new { username, password });
            var payload = new StringContent(newUserJson, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endpoint, payload).Result;
            var resultContent = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<UserRegistrationData>(resultContent)!;
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                MessageBox.Show("Wrong username or password. Try again.");
            }
            else if (response.StatusCode == HttpStatusCode.OK)
            {
                frmHomePage home = new(result.username);
                home.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again later.");
            }

            Cursor.Current = Cursors.Default;
        }


        private bool showingFirstImage = true;
        private bool passwordShown = true;

        private void panel7_Click(object sender, EventArgs e)
        {
            if (showingFirstImage)
            {
                panel7.BackgroundImage = Properties.Resources.open;
                panel7.BackgroundImageLayout = ImageLayout.Center;
            }
            else
            {
                panel7.BackgroundImage = Properties.Resources.close;
                panel7.BackgroundImageLayout = ImageLayout.Center;
            }

            showingFirstImage = !showingFirstImage;
            passwordShown = !passwordShown;
            txtpassword.UseSystemPasswordChar = !passwordShown;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = !passwordShown;
            panel7.BackgroundImage = Properties.Resources.close;
            panel7.BackgroundImageLayout = ImageLayout.Center;
        }
    }
}
