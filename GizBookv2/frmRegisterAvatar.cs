using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GizBookv2
{
    public partial class frmRegisterAvatar : Form
    {
        public frmRegisterAvatar()
        {
            InitializeComponent();
        }
     private string _selectedAvatarResourceName = null;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private UserRegistrationData _userData;
        // Add this field to the frmRegisterAvatar class
        private PictureBox _selectedPictureBox;

        public frmRegisterAvatar(UserRegistrationData userData)
        {
            InitializeComponent();
            _userData = userData;
            lblname.Text = _userData.Name;
            lblusername.Text = _userData.Username;
            lblname.TextAlign = ContentAlignment.MiddleCenter;
            lblusername.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            frmRegister fr = new frmRegister();
            fr.Show();
            this.Hide();
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

            // Save the avatar image
            _userData.Avatar = pictureBox13.BackgroundImage;

            // Add the user to the static list
            UserRegistrationData.RegisteredUsers.Add(_userData);

            MessageBox.Show("Registration complete!");

            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}
