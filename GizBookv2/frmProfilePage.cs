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
    public partial class frmProfilePage : Form
    {
        public frmProfilePage()
        {
            InitializeComponent();
        }

        private void frmProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {

        }

        private void mark4_Click(object sender, EventArgs e)
        {

        }

        private void btnAllPost_MouseClick(object sender, MouseEventArgs e)
        {
            panelAllPost.Visible = !panelAllPost.Visible;
            mark1.Visible = !mark1.Visible;
            panelDecks.Visible = false;
            panelFriends.Visible = false;
            panelStats.Visible = false;
            mark2.Visible = false;
            mark3.Visible = false;
            mark4.Visible = false;
        }

        private void mark2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnDecks_MouseClick(object sender, MouseEventArgs e)
        {
            panelDecks.Visible = !panelDecks.Visible;
            mark2.Visible = !mark2.Visible;
            panelFriends.Visible = false;
            panelAllPost.Visible = false;
            panelStats.Visible = false;
            mark1.Visible = false;
            mark3.Visible = false;
            mark4.Visible = false;
        }

        private void btnStats_MouseClick(object sender, MouseEventArgs e)
        {
            panelStats.Visible = !panelStats.Visible;
            mark3.Visible = !mark3.Visible;
            panelAllPost.Visible = false;
            panelDecks.Visible = false;
            panelFriends.Visible = false;
            mark1.Visible = false;
            mark2.Visible = false;
            mark4.Visible = false;
        }

        private void btnFriends_MouseClick(object sender, MouseEventArgs e)
        {
            panelFriends.Visible = !panelFriends.Visible;
            mark4.Visible = !mark4.Visible;
            panelAllPost.Visible = false;
            panelDecks.Visible = false;
            panelStats.Visible = false;
            mark1.Visible = false;
            mark2.Visible = false;
            mark3.Visible = false;
        }

        private void btnStats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mark1_Click(object sender, EventArgs e)
        {

        }
    }
}
