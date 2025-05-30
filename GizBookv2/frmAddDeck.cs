using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GizBook
{
    public partial class frmAddDeck : Form
    {
        public frmAddDeck()
        {
            InitializeComponent();

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveDeck_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveDeck_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private Dictionary<string, Color> buttonColors = new Dictionary<string, Color>
{
         { "btn1", Color.FromArgb(255, 0, 0) },
         { "btn2", Color.FromArgb(0, 0, 255) },
         { "btn3", Color.FromArgb(0, 255, 0) },
         { "btn4", Color.FromArgb(255, 0, 0) },
         { "btn5", Color.FromArgb(0, 0, 255) },
         { "btn6", Color.FromArgb(0, 255, 0) },
         { "btn7", Color.FromArgb(255, 0, 0) },
         { "btn8", Color.FromArgb(0, 0, 255) },
         { "btn9", Color.FromArgb(0, 255, 0) },
         { "btn10", Color.FromArgb(0, 255, 0) }
    // Add more buttons as needed
};

        private void frmAddDeck_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
