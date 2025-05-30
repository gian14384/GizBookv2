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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GizBookv2
{
    public partial class frmDeckPage : Form
    {
        public frmDeckPage(string deckName, Color deckColor)
        {
            InitializeComponent();
         
            DisplayDecks();


            if (!string.IsNullOrWhiteSpace(deckName))
            {
                DeckItemControl deckItem = new DeckItemControl();
                deckItem.SetDeck(deckName, deckColor);
                flowLayoutPanel1.Controls.Add(deckItem);
            }

            UpdateDeckVisibility();
        }

        public void DisplayDecks()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var deck in Decks)
            {
                DeckItemControl deckItem = new DeckItemControl();
                deckItem.SetDeck(deck.Name, deck.Color);
                flowLayoutPanel1.Controls.Add(deckItem);
            }
        }

        private void UpdateDeckVisibility()
        {
            // Count only DeckItemControl instances
            bool hasDecks = flowLayoutPanel1.Controls.OfType<DeckItemControl>().Any();
            lblNoDecks.Visible = !hasDecks;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmDeckPage_Load(object sender, EventArgs e)
        {

        }

      
        

        private void frmDeckPage_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            frmAddDeck fa = new frmAddDeck();
            fa.Show();
        }

        private Label lblNoDecks = new Label
        {
            Text = "No decks added.",
            AutoSize = true,
            Font = new Font("Segoe UI", 14, FontStyle.Italic),
            ForeColor = Color.Gray,
            Visible = false
        };
        // Add this field to the frmDeckPage class
        private List<(string Name, Color Color)> Decks = new List<(string Name, Color Color)>();

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
