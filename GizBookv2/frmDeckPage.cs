using GizBook;
using Newtonsoft.Json.Linq;

namespace GizBookv2
{
    public partial class frmDeckPage : Form
    {

        private readonly List<DeckInfo> _decks = [];
        private readonly dynamic Userdata;
        private readonly bool IsFromHomePage;
        public frmDeckPage(dynamic userdata, bool isFromHomePage)
        {
            InitializeComponent();
            Userdata = userdata;
            IsFromHomePage = isFromHomePage;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            if (IsFromHomePage)
            {
                Cursor.Current = Cursors.WaitCursor;
                frmHomePage homePage = new((string)Userdata.username);
                homePage.Show();
            }
            Close();
        }

        private void frmDeckPage_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            if ((int)Userdata.total_decks > 0)
            {
                foreach (dynamic deck in (JArray)Userdata.decks)
                {
                    DeckInfo deckInfo = new() { Name = deck.title, Color = deck.color, Deck = deck };
                    _decks.Add(deckInfo);
                    AddDeckToPanel(deckInfo);
                }
            }
        }

        private void AddDeckToPanel(DeckInfo deck)
        {
            DeckItemControl deckItem = new();
            deckItem.SetDeck(deck.Name, (int)deck.Deck.total_cards, deck.Color);
            deckItem.DeckClicked += (sender, e) => DeckItem_DeckClicked(deck.Deck);
            flowLayoutPanel1.Controls.Add(deckItem);
        }

        private void DeckItem_DeckClicked(dynamic deck)
        {
            frmCreateDeck createDeckForm = new(deck, (string)Userdata.username);
            createDeckForm.Show();
        }


        private void panel4_Click(object sender, EventArgs e)
        {
            using var addDeckForm = new frmAddDeck((string)Userdata.username, false);
            if (addDeckForm.ShowDialog() == DialogResult.OK)
            {
                var newDeck = addDeckForm.NewDeck;
                if (newDeck != null)
                {
                    _decks.Add(newDeck);
                    AddDeckToPanel(newDeck);
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            frmLearn fl = new();
            fl.Show();
        }
    }
}
