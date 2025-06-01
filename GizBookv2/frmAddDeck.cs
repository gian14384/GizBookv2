using GizBookv2;
using Newtonsoft.Json;
using System.Text;

namespace GizBook
{
#pragma warning disable CS8618
    public partial class frmAddDeck : Form
    {
        public DeckInfo NewDeck { get; private set; }
        private Color _selectedColor = ColorTranslator.FromHtml("#FF8A65");
        private string _selectedColorHex = "#FF8A65";
        private string _selectedPrivacy = "public";

        private readonly string Username;
        private readonly bool FromHomePage;
        public frmAddDeck(string username, bool fromHomePage)
        {
            InitializeComponent();
            Username = username;
            FromHomePage = fromHomePage;
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            if (FromHomePage)
            {
                Cursor.Current = Cursors.WaitCursor;
                frmHomePage homePage = new(Username);
                homePage.Show();
            }
            Close();
        }

        private void btnSaveDeck_Click(object sender, EventArgs e)
        {
            string deckName = txtDeckName.Text;
            Color deckColor = _selectedColor;

            if (!string.IsNullOrWhiteSpace(deckName))
            {
                Cursor.Current = Cursors.WaitCursor;
                using HttpClient client = new();
                var endpoint = new Uri("https://gizbook.vercel.app/api/decks/" + Username);

                var newDeckJson = JsonConvert.SerializeObject(new Dictionary<string, string>
                {
                    {"title", deckName},
                    {"color", _selectedColorHex},
                    {"privacy", _selectedPrivacy }
                });

                var payload = new StringContent(newDeckJson, Encoding.UTF8, "application/json");
                var response = client.PostAsync(endpoint, payload).Result;
                dynamic result = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result)!;

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    NewDeck = new DeckInfo { Name = deckName, Color = deckColor, Deck = result };
                    DialogResult = DialogResult.OK;

                    if (FromHomePage)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        frmHomePage homePage = new(Username);
                        homePage.Show();
                    }

                    Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a deck name.");
            }
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            _selectedColor = ColorTranslator.FromHtml("#FF8A65");
            _selectedColorHex = "#FF8A65";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            _selectedColor = ColorTranslator.FromHtml("#FFD54F");
            _selectedColorHex = "#FFD54F";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            _selectedColor = ColorTranslator.FromHtml("#4FC3F7");
            _selectedColorHex = "#4FC3F7";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            _selectedColor = ColorTranslator.FromHtml("#81C784");
            _selectedColorHex = "#81C784";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            _selectedColor = ColorTranslator.FromHtml("#BA68C8");
            _selectedColorHex = "#BA68C8";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            _selectedColor = ColorTranslator.FromHtml("#F06292");
            _selectedColorHex = "#F06292";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            _selectedColor = ColorTranslator.FromHtml("#A1887F");
            _selectedColorHex = "#A1887F";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            _selectedColor = ColorTranslator.FromHtml("#90A4AE");
            _selectedColorHex = "#90A4AE";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            _selectedColor = ColorTranslator.FromHtml("#7986CB");
            _selectedColorHex = "#7986CB";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            _selectedColor = ColorTranslator.FromHtml("#E57373");
            _selectedColorHex = "#E57373";
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            _selectedPrivacy = "public";
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            _selectedPrivacy = "private";
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            _selectedPrivacy = "friends";
        }
    }
}
