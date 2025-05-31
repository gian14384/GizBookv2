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

        private List<DeckInfo> _decks = new List<DeckInfo>();
        public frmDeckPage()
        {
            InitializeComponent();

        }
     
        private void panel10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmDeckPage_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var deck in _decks)
            {
                AddDeckToPanel(deck);
            }
        }

        private void AddDeckToPanel(DeckInfo deck)
        {
            DeckItemControl deckItem = new DeckItemControl();
            deckItem.SetDeck(deck.Name, deck.Color);
            deckItem.DeckClicked += DeckItem_DeckClicked;
            flowLayoutPanel1.Controls.Add(deckItem);
        }

        private void DeckItem_DeckClicked(object sender, EventArgs e)
        {
            frmCreateDeck createDeckForm = new frmCreateDeck();
            createDeckForm.Show();
        }



        private void frmDeckPage_Click(object sender, EventArgs e)
        {

        }
        

        private void panel4_Click(object sender, EventArgs e)
        {
            using (var addDeckForm = new frmAddDeck())
            {
                if (addDeckForm.ShowDialog() == DialogResult.OK)
                {
                    // Get the new deck info from frmAddDeck
                    var newDeck = addDeckForm.NewDeck;
                    if (newDeck != null)
                    {
                        _decks.Add(newDeck);
                        AddDeckToPanel(newDeck);
                    }
                }
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            frmLearn fl = new frmLearn();
            fl.Show();
        }
    }
}
