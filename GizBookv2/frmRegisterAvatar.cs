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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        public frmRegisterAvatar(UserRegistrationData userData)
        {
            InitializeComponent();
            _userData = userData;
            lblname.Text = _userData.Name;
            lblusername.Text = _userData.Username;
            lblname.TextAlign = ContentAlignment.MiddleCenter;
            lblusername.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
