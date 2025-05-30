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
    public partial class frmLearn : Form
    {
        public frmLearn()
        {
            InitializeComponent();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (!isPanel4Toggled)
            {
                panel2.BackgroundImage = Properties.Resources.p2;
                panel2.BackgroundImageLayout = ImageLayout.Center;
                isPanel4Toggled = true;
            }
            else
            {
                panel2.BackgroundImage = null;
                isPanel4Toggled = false;
            }
        }

        private bool isPanel4Toggled = false;

        private void panel4_Click(object sender, EventArgs e)
        {
            if (!isPanel4Toggled)
            {
                panel4.BackgroundImage = Properties.Resources.p1;
                panel4.BackgroundImageLayout = ImageLayout.Center;
                isPanel4Toggled = true;
            }
            else
            {
                panel4.BackgroundImage = null;
                isPanel4Toggled = false;
            }
        }
    }
}
