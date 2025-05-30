using System.Windows.Forms;

namespace GizBookv2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtpassword.UseSystemPasswordChar = true;
            panel7.BackgroundImage = Properties.Resources.open; // Replace with your actual resource name
            panel7.BackgroundImageLayout = ImageLayout.Center;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            frmRegister fr = new frmRegister();
            fr.Show();
            this.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text; // Replace with your actual username textbox name
            string password = txtpassword.Text; // Replace with your actual password textbox name

            // Find user with matching username and password
            var user = UserRegistrationData.RegisteredUsers
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                MessageBox.Show("No user found. Try again.");
                return;
            }

            // If found, open HomePage and pass user data
            frmHomePage home = new frmHomePage(user);
            home.Show();
            this.Hide();
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
