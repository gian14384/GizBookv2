using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GizBookv2;
using static System.Windows.Forms.DataFormats;

namespace GizBook
{
    public partial class frmAddDeck : Form
    {
        public DeckInfo NewDeck { get; private set; }
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
            string deckName = txtDeckName.Text;
            Color deckColor = _selectedColor;

            if (!string.IsNullOrWhiteSpace(deckName))
            {
                NewDeck = new DeckInfo { Name = deckName, Color = deckColor };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a deck name.");
            }
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

        private Color _selectedColor = Color.White;

        private void btn1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            _selectedColor = Color.FromArgb(255, 138, 101);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.FromArgb(255, 213, 79);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.FromArgb(79, 195, 247);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.FromArgb(129, 199, 132);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.FromArgb(186, 104, 200);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.FromArgb(240, 98, 146);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.FromArgb(161, 136, 127);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.FromArgb(144, 164, 174);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.FromArgb(121, 134, 203);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.FromArgb(229, 155, 155);
        }
    }
}
