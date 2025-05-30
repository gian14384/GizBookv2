namespace GizBookv2
{
    public partial class frmLogout : Form
    {
        #pragma warning disable CS8618
        public frmLogout()
        {
            InitializeComponent();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            // Close the HomePage
            _homePage.Hide();

            // Show the Login form
            frmLogin loginForm = new();
            loginForm.Show();

            // Close the logout confirmation dialog
            Close();
        }

        private readonly frmHomePage _homePage;

        public frmLogout(frmHomePage homePage)
        {
            InitializeComponent();
            _homePage = homePage;
        }
    }
}
