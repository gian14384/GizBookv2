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
    public partial class DeckItemControl : UserControl
    {
        public DeckInfo Deck { get; private set; }

        public event EventHandler DeckClicked;
        public DeckItemControl()
        {
            InitializeComponent();
            this.Click += DeckItemControl_Click;
            // Ensure child controls also trigger the click event
            foreach (Control c in this.Controls)
                c.Click += DeckItemControl_Click;
        }

        private void DeckItemControl_Load(object sender, EventArgs e)
        {

        }
        public void SetDeck(string deckName, Color color)
        {
            lblDeckName.Text = deckName;
            panelColor.BackColor = color;
        }

        private void DeckItemControl_Click(object sender, EventArgs e)
        {
            DeckClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
