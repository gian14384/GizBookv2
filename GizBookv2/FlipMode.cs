using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace GizBookv2
{
    public partial class FlipMode : Form
    {
        private List<dynamic> cards;
        private int currentIndex;
        private Random rng = new();
        private bool isShowingFront = true;
        private dynamic currentCard;

        public FlipMode(dynamic selectedDeck, string deckName, string deckColor)
        {
            InitializeComponent();

            // Set deck name and color
            label1.Text = deckName;
            panel2.BackColor = ColorTranslator.FromHtml(deckColor);

            // Extract and randomize cards
            cards = ((JArray)selectedDeck.cards).ToObject<List<dynamic>>();
            ShuffleCards();
            currentIndex = 0;
            ShowCurrentCard();
        }

        private void ShuffleCards()
        {
            // Fisher-Yates shuffle
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        private void ShowCurrentCard()
        {
            if (cards.Count == 0) return;

            currentCard = cards[currentIndex];
            string type = (string)currentCard.type;

            if (type == "two-sided")
            {
                isShowingFront = true;
                label3.Text = (string)currentCard.question;
                button4.Visible = true;
            }
            else // "one-sided"
            {
                label3.Text = (string)currentCard.question;
                button4.Visible = false;
            }
        }
        private void ShowRandomCard()
        {
            if (cards.Count == 0) return;
            int newIndex;
            do
            {
                newIndex = rng.Next(cards.Count);
            } while (cards.Count > 1 && newIndex == currentIndex);

            currentIndex = newIndex;
            ShowCurrentCard();
        }
        public FlipMode()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentCard == null) return;

            if (isShowingFront)
            {
                label3.Text = (string)currentCard.answer;
                isShowingFront = false;
            }
            else
            {
                label3.Text = (string)currentCard.question;
                isShowingFront = true;
            }
        }

        private void FlipMode_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowRandomCard();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowRandomCard();
        }
    }
}
