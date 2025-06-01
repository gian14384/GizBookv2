using GizBookv2.Properties;

namespace GizBookv2
{
    public partial class frmDeckPage2 : Form
    {
        private readonly dynamic UserData;
        public dynamic? SelectedDeck { get; private set; }
        public frmDeckPage2(dynamic userData)
        {
            InitializeComponent();
            UserData = userData;
        }

        private void ButtonClick(Panel panel, dynamic deck)
        {
            if (panel.BackgroundImage!.GetHashCode() == Resources.decks_v21.GetHashCode())
            {
                panel.BackgroundImage = Resources.decks2;
                SelectedDeck = deck;
                lblSelectedDeck.Text = $"Selected Deck: {deck.title}";
            }
            else
            {
                panel.BackgroundImage = Resources.decks_v21;
                SelectedDeck = null;
                lblSelectedDeck.Text = "Selected Deck: None";
            }
        }

        private Label CloneLabelName(string text)
        {
            Label cloned = new()
            {
                Size = lblDeckTitle.Size,
                AutoSize = lblDeckTitle.AutoSize,
                BorderStyle = lblDeckTitle.BorderStyle,
                Location = new Point(lblDeckTitle.Location.X, lblDeckTitle.Location.Y),
                Text = text,
                Font = lblDeckTitle.Font,
                ForeColor = lblDeckTitle.ForeColor,
                Visible = true,
                BackColor = lblDeckTitle.BackColor
            };

            return cloned;
        }

        private Label CloneLabelCount(string text)
        {
            Label cloned = new()
            {
                Size = lblDeckNumber.Size,
                AutoSize = lblDeckNumber.AutoSize,
                BorderStyle = lblDeckNumber.BorderStyle,
                Location = new Point(lblDeckNumber.Location.X, lblDeckNumber.Location.Y),
                Text = text + " card/s",
                Font = lblDeckNumber.Font,
                ForeColor = lblDeckNumber.ForeColor,
                Visible = true,
                BackColor = lblDeckNumber.BackColor
            };

            return cloned;
        }

        private PictureBox ClonePictureBox(string hex)
        {
            PictureBox cloned = new()
            {
                Size = picDeckColor.Size,
                BorderStyle = picDeckColor.BorderStyle,
                Location = new Point(picDeckColor.Location.X, picDeckColor.Location.Y),
                SizeMode = picDeckColor.SizeMode,
                Visible = true,
                BackColor = ColorTranslator.FromHtml(hex)
            };

            return cloned;
        }

        private Panel ClonePanel(int yOffSet, dynamic deck)
        {
            Panel cloned = new()
            {
                Location = new Point(pnlDeck.Location.X, pnlDeck.Location.Y + (121 * yOffSet)),
                BackgroundImage = pnlDeck.BackgroundImage,
                BackgroundImageLayout = pnlDeck.BackgroundImageLayout,
                Cursor = pnlDeck.Cursor,
                Size = pnlDeck.Size,
                Visible = true,
                BackColor = pnlDeck.BackColor
            };

            cloned.Controls.Add(CloneLabelName((string)deck.title));
            cloned.Controls.Add(CloneLabelCount((string)deck.total_cards));
            cloned.Controls.Add(ClonePictureBox((string)deck.color));
            
            return cloned;
        }

        private void frmDeckPage2_Load(object sender, EventArgs e)
        {
            pnlDeck.Visible = false;
            lblDeckTitle.Visible = false;
            lblDeckNumber.Visible = false;
            picDeckColor.Visible = false;

            for (int i = 0; i < (int)UserData.total_decks; i++)
            {
                dynamic deck = UserData.decks[i];
                Panel cloned = ClonePanel(i, deck);
                cloned.Click += (sender, e) => ButtonClick(cloned, deck);
                pnlDecks.Controls.Add(cloned);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
