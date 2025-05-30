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
        public DeckItemControl()
        {
            InitializeComponent();
        }

        private void DeckItemControl_Load(object sender, EventArgs e)
        {

        }
        public void SetDeck(string deckName, Color color)
        {
            this.deckName.Text = deckName;
            deckColor.BackColor = color;
        }

        private void deckColor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
