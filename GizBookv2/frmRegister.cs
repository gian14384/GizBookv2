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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            this.Hide();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            string name = this.txtname.Text;
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
                var userData = new UserRegistrationData();
                userData.Name = txtname.Text;
                userData.Username = txtusername.Text;
                userData.Password = txtpassword.Text;


                var avatarForm = new frmRegisterAvatar(userData);
                avatarForm.Show();
                this.Hide();
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
