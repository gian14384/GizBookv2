using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizBookv2
{
    public partial class frmLogout : Form
    {
        public frmLogout()
        {
            InitializeComponent();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            // Close the HomePage
            _homePage.Hide();

            // Show the Login form
            frmLogin loginForm = new frmLogin();
            loginForm.Show();

            // Close the logout confirmation dialog
            this.Hide();
        }

        private frmHomePage _homePage;

        public frmLogout(frmHomePage homePage)
        {
            InitializeComponent();
            _homePage = homePage;
        }
    }
}
