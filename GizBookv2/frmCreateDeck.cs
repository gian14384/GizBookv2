using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace GizBookv2
{
    public partial class frmCreateDeck : Form
    {
        private readonly dynamic DeckInfo;
        private readonly dynamic UserData;
        private readonly string Username;
        private static int TotalCards;
        public frmCreateDeck(dynamic userData, dynamic deckInfo, string username)
        {
            InitializeComponent();
            DeckInfo = deckInfo;
            UserData = userData;
            Username = username;
            TotalCards = (int)DeckInfo.total_cards;
        }

        private void frmCreateDeck_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = ColorTranslator.FromHtml((string)DeckInfo.color);
            label1.Text = (string)DeckInfo.title;
            label2.Text = $"Recently Added Cards ({TotalCards})";
            SetQuizMode(true);

            if (TotalCards > 0)
            {
                foreach (dynamic card in (JArray)DeckInfo.cards)
                {
                    if ((string)card.type == "one-sided")
                    {
                        var quizCard = new QuizCardControl();
                        quizCard.SetQuiz((string)card.question);
                        flowLayoutPanel1.Controls.Add(quizCard);
                    }
                    else if ((string)card.type == "two-sided")
                    {
                        var fbCard = new FrontBackCardControl();
                        fbCard.SetFrontBack((string)card.question, (string)card.answer);
                        flowLayoutPanel1.Controls.Add(fbCard);
                    }
                }
            }
        }
        private bool isQuizMode = true;

        private void button4_Click(object sender, EventArgs e)
        {
            isQuizMode = !isQuizMode;
            SetQuizMode(isQuizMode);
        }
        private void SetQuizMode(bool quizMode)
        {
            if (quizMode)
            {
                // Show quiz textbox, hide front/back, set image to button(1)3
                txtQuiz.Visible = true;
                txtfront.Visible = false;
                txtback.Visible = false;
                button4.BackgroundImage = Properties.Resources.Button__1_3; // Adjust resource name as needed
            }
            else
            {
                // Show front/back, hide quiz, set image to button(4)
                txtQuiz.Visible = false;
                txtfront.Visible = true;
                txtback.Visible = true;
                button4.BackgroundImage = Properties.Resources.Button__4_; // Adjust resource name as needed
                panel2.BackgroundImage = Properties.Resources.Text_input_container__2_; // Adjust resource name as needed
            }
        }

        private dynamic GetCurrentDeck()
        {
            JArray decks = UserData.decks;
            return decks.First(deck => (string)deck["id"]! == (string)DeckInfo.id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isQuizMode)
            {
                // Quiz mode: use QuizCardControl
                string quizText = txtQuiz.Text.Trim();
                if (!string.IsNullOrEmpty(quizText))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    using HttpClient client = new();
                    var endpoint = new Uri("https://gizbook.vercel.app/api/cards/" + (string)DeckInfo.id);

                    var newDeckJson = JsonConvert.SerializeObject(new Dictionary<string, string?>
                    {
                        { "type", "one-sided" },
                        { "question", quizText },
                        { "answer", null }
                    });

                    var payload = new StringContent(newDeckJson, Encoding.UTF8, "application/json");
                    var response = client.PostAsync(endpoint, payload).Result;
                    dynamic result = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result)!;

                    if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    {
                        var quizCard = new QuizCardControl();
                        quizCard.SetQuiz(quizText);
                        flowLayoutPanel1.Controls.Add(quizCard);
                        txtQuiz.Clear();

                        dynamic currentDeck = GetCurrentDeck();
                        JArray cards = currentDeck.cards;
                        cards.Add(result.card);
                        currentDeck.total_cards = ++TotalCards;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.");
                    }
                    label2.Text = $"Recently Added Cards ({TotalCards})";
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                // Front/Back mode: use FrontBackCardControl
                string front = txtfront.Text.Trim();
                string back = txtback.Text.Trim();
                if (!string.IsNullOrEmpty(front) && !string.IsNullOrEmpty(back))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    using HttpClient client = new();
                    var endpoint = new Uri("https://gizbook.vercel.app/api/cards/" + (string)DeckInfo.id);

                    var newDeckJson = JsonConvert.SerializeObject(new Dictionary<string, string>
                    {
                        { "type", "two-sided" },
                        { "question", front },
                        { "answer", back }
                    });

                    var payload = new StringContent(newDeckJson, Encoding.UTF8, "application/json");
                    var response = client.PostAsync(endpoint, payload).Result;
                    dynamic result = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result)!;

                    if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    {
                        var fbCard = new FrontBackCardControl();
                        fbCard.SetFrontBack(front, back);
                        flowLayoutPanel1.Controls.Add(fbCard);
                        txtfront.Clear();
                        txtback.Clear();

                        dynamic currentDeck = GetCurrentDeck();
                        JArray cards = currentDeck.cards;
                        cards.Add(result.card);
                        currentDeck.total_cards = ++TotalCards;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.");
                    }
                    label2.Text = $"Recently Added Cards ({TotalCards})";
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmDeckPage deckPage = new(UserData, true);
            deckPage.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLearn fl = new frmLearn(DeckInfo, (string)DeckInfo.title, (string)DeckInfo.color, UserData);
            fl.ShowDialog();
        }
    }
}
