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
    public partial class frmFAQ : Form
    {
        public frmFAQ()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            int panelHeight = panel5.Visible ? panel5.Height : 0;
            panel5.Visible = !panel5.Visible;

            panel6.Top = panel5.Visible ? panel6.Top + panel5.Height : panel6.Top - panelHeight;
        }
    }
}
