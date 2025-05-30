using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GizBook;

namespace GizBookv2
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();

        }

        private void panel20_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {

        }

        private UserRegistrationData _userData;

        public frmHomePage(UserRegistrationData userData)
        {
            InitializeComponent();
            _userData = userData;
            lblName.Text = _userData.Name; // Replace lblName with your actual label name
            profile.Image = _userData.Avatar; // Replace pictureBoxAvatar with your actual PictureBox name
            page.Image = userData.Avatar; // Replace page with your actual PictureBox name
            page.SizeMode = PictureBoxSizeMode.StretchImage; // Set the size mode for the page PictureBox
            profile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frmProfilePage fp = new frmProfilePage();
            fp.Show();
        }

        private void page_Click(object sender, EventArgs e)
        {
            frmProfilePage fp = new frmProfilePage();
            fp.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            // Provide default values for deckName and Color as required by frmDeckPage constructor
            string defaultDeckName = "How to Kiss a Girl";
            Color defaultColor = Color.Blue;
            frmDeckPage fd = new frmDeckPage(defaultDeckName, defaultColor);
            fd.Show();
        }

        private void panel33_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPrivacy fp = new frmPrivacy();
            fp.Show();

            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFAQ ff = new frmFAQ();
            ff.Show();

            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmContactUs fc = new frmContactUs();
            fc.Show();

            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogout logoutForm = new frmLogout(this);
            logoutForm.Show();

            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void btndropdown_Click(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void btndropdown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            panel8.Top = panelDropdown.Visible ? panel8.Top + panelDropdown.Height : panel8.Top - panelHeight;
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            frmProfilePage fp = new frmProfilePage();
            fp.Show();
        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelShare_Click(object sender, EventArgs e)
        {

        }

        private void panel33_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel33_Click_1(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void panel34_Click(object sender, EventArgs e)
        {
            frmAddDeck fa = new frmAddDeck();
            fa.Show();

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            frmAddDeck fa = new frmAddDeck();
            fa.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            frmLearn fl = new frmLearn();
            fl.Show();
        }
    }
}
