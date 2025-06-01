namespace GizBookv2
{
#pragma warning disable CS8618

    public partial class DeckItemControl : UserControl
    {
        public DeckInfo Deck { get; private set; }

        public event EventHandler DeckClicked;
        public DeckItemControl()
        {
            InitializeComponent();
            Click += (sender, e) => DeckItemControl_Click();
            // Ensure child controls also trigger the click event
            foreach (Control c in this.Controls)
                c.Click += (sender, e) => DeckItemControl_Click();
        }

        private void DeckItemControl_Load(object sender, EventArgs e)
        {

        }
        public void SetDeck(string deckName, int totalCards, Color color)
        {
            lblDeckName.Text = deckName;
            lblTotalCards.Text = totalCards + " cards";
            panelColor.BackColor = color;
        }

        private void DeckItemControl_Click()
        {
            DeckClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
