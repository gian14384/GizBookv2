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
    public partial class frmPrivacy : Form
    {
        public frmPrivacy()
        {
            InitializeComponent();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel4.Visible = false;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel6.Visible = false;
        }
    }
}
