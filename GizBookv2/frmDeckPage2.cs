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

            pnlDeck.BackgroundImage = Resources.decks_v21;
            pnlDeck.Tag = "v21";
            pnlDeck.Click += (sender, e) => ButtonClick(pnlDeck, null);
        }
        public frmDeckPage2()
        {
            InitializeComponent();
     
        }

        private void DeselectAllDeckPanels()
        {
            // Deselect the template panel
            pnlDeck.BackgroundImage = Resources.decks_v21;
            pnlDeck.Tag = "v21";

            // Deselect all dynamically created panels
            foreach (Control ctrl in pnlDecks.Controls)
            {
                if (ctrl is Panel panel)
                {
                    panel.BackgroundImage = Resources.decks_v21;
                    panel.Tag = "v21";
                }
            }
        }




        private void ButtonClick(Panel panel, dynamic deck)
        {
            if (panel.Tag == null || panel.Tag.ToString() == "v21")
            {
                DeselectAllDeckPanels(); // Deselect all first

                panel.BackgroundImage = Resources.decks2;
                panel.Tag = "decks2";
                SelectedDeck = deck;
                lblSelectedDeck.Text = deck != null ? $"Selected Deck: {deck.title}" : "Selected Deck: None";
            }
            else
            {
                panel.BackgroundImage = Resources.decks_v21;
                panel.Tag = "v21";
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

        private void pnlDeck_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDeckTitle_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SelectedDeck != null)
            {
                string deckName = (string)SelectedDeck.title;
                string deckColor = (string)SelectedDeck.color;
                frmLearn learnForm = new frmLearn(SelectedDeck, deckName, deckColor, UserData);
                learnForm.ShowDialog();
            }
        }

        private void pnlDecks_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
