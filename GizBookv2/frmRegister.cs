namespace GizBookv2
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new();
            loginForm.Show();
            Close();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string confirmPassword = txtconfirmpass.Text;

            if (name == "" || username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill all the information needed");
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Passwords did not match");
            }
            else
            {
                var newUser = new UserRegistrationData
                {
                    name = txtname.Text,
                    username = txtusername.Text,
                    password = txtpassword.Text,
                    confirmPassword = txtconfirmpass.Text
                };

                var avatarForm = new frmRegisterAvatar(newUser);
                avatarForm.Show();
                Close();
            }
        }
    }
}
