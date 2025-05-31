using System.Text;

namespace GizBookv2
{
    public partial class frmRegisterAvatar : Form
    {
    #pragma warning disable CS8618
        public frmRegisterAvatar()
        {
            InitializeComponent();
        }

        private string? _selectedAvatarResourceName = null;
        private void AvatarPictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && pictureBox.Tag is string resourceName)
            {
                _selectedAvatarResourceName = resourceName;
                // Optionally, highlight the selected PictureBox
            }
            else
            {
                _selectedAvatarResourceName = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = pictureBox1;
            _selectedAvatarResourceName = "gb1";
            pictureBox13.BackgroundImage = Properties.Resources.gb1;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private readonly UserRegistrationData _userData;
        // Add this field to the frmRegisterAvatar class
        private PictureBox _selectedPictureBox;

        public frmRegisterAvatar(UserRegistrationData userData)
        {
            InitializeComponent();
            _userData = userData;
            lblname.Text = _userData.name;
            lblusername.Text = _userData.username;
            lblname.TextAlign = ContentAlignment.MiddleCenter;
            lblusername.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new();
            registerForm.Show();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = pictureBox2;
            _selectedAvatarResourceName = "bb1";
            pictureBox13.BackgroundImage = Properties.Resources.bb1;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = pictureBox3;
            _selectedAvatarResourceName = "gb2";
            pictureBox13.BackgroundImage = Properties.Resources.gb2;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = pictureBox4;
            _selectedAvatarResourceName = "bb2";
            pictureBox13.BackgroundImage = Properties.Resources.bb2;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = pictureBox5;
            _selectedAvatarResourceName = "gb3";
            pictureBox13.BackgroundImage = Properties.Resources.gb3;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = pictureBox6;
            _selectedAvatarResourceName = "bb3";
            pictureBox13.BackgroundImage = Properties.Resources.bb3;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = pictureBox8;
            _selectedAvatarResourceName = "gb4";
            pictureBox13.BackgroundImage = Properties.Resources.gb4;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = pictureBox9;
            _selectedAvatarResourceName = "bb4";
            pictureBox13.BackgroundImage = Properties.Resources.bb4;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = pictureBox7;
            _selectedAvatarResourceName = "gb5";
            pictureBox13.BackgroundImage = Properties.Resources.gb5;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = pictureBox10;
            _selectedAvatarResourceName = "bb5";
            pictureBox13.BackgroundImage = Properties.Resources.bb5;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = pictureBox11;
            _selectedAvatarResourceName = "gb6";
            pictureBox13.BackgroundImage = Properties.Resources.gb6;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = pictureBox12;
            _selectedAvatarResourceName = "bb6";
            pictureBox13.BackgroundImage = Properties.Resources.bb6;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (_selectedPictureBox == null)
            {
                MessageBox.Show("Please select an avatar before continuing.");
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            // Save the avatar image
            _userData.avatar = _selectedAvatarResourceName;

            using HttpClient client = new();
            var endpoint = new Uri("https://gizbook.vercel.app/api/auth/register");

            if (string.IsNullOrWhiteSpace(_userData.name) ||
               string.IsNullOrWhiteSpace(_userData.username) ||
               string.IsNullOrWhiteSpace(_userData.password) ||
               string.IsNullOrWhiteSpace(_userData.avatar))
            {
                MessageBox.Show("All fields (name, username, password, avatar) must be filled before registration.");
                return;
            }

            var newUserJson = Newtonsoft.Json.JsonConvert.SerializeObject(new Dictionary<string, string?>
            {
               { "name", _userData.name },
               { "username", _userData.username },
               { "password", _userData.password },
               { "avatar", _userData.avatar }
            });
            var payload = new StringContent(newUserJson, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endpoint, payload).Result;

            if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                MessageBox.Show("Username already exists.");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("Registration successful!");
                frmLogin loginForm = new();
                loginForm.Show();
                Close();
            }
            else
            {
                var errorMessage = response.Content.ReadAsStringAsync().Result;
                MessageBox.Show($"Something went wrong. Please try again.\nError: {errorMessage}");
            }

            Cursor.Current = Cursors.Default;
        }
    }
}
