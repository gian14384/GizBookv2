using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GizBookv2
{
    public partial class QuizMode : Form
    {
        private static int points = 0;
        private List<dynamic>? cards;
        private dynamic? currentCard;
        private static int currentIndex;
        private Random rng = new();
        private dynamic UserData;
        private static int timeLeft;
        private static int hearts = 5;
        private readonly int totalCards;
        public QuizMode(dynamic selectedDeck, string deckName, string deckColor, dynamic userdata)
        {
            InitializeComponent();
            totalCards = (int)selectedDeck.total_cards;
            label1.Text = deckName;
            UserData = userdata;
            panel3.BackColor = ColorTranslator.FromHtml(deckColor);
       

            // Extract and shuffle cards
            var cardsArray = selectedDeck?.cards as JArray;
            cards = cardsArray != null ? cardsArray.ToObject<List<dynamic>>() : new List<dynamic>();
            ShuffleCards();
            currentIndex = 0;

            // Wire up click events for answer labels
            lblfirstchoice.Click += ChoiceLabel_Click;
            lblsecondchoice.Click += ChoiceLabel_Click;
            lblthirdchoice.Click += ChoiceLabel_Click;
            lblfourthchoice.Click += ChoiceLabel_Click;

            ShowCurrentCard();
        }

        private void ShuffleCards()
        {
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
            if (cards == null || currentIndex >= totalCards || currentIndex >= cards.Count)
            {
                MessageBox.Show("Quiz finished!");
                Cursor.Current = Cursors.WaitCursor;
                using HttpClient client = new();
                var endpoint = new Uri($"https://gizbook.vercel.app/api/users/score/{(string)UserData!.username}?score={points}");

                var response = client.PostAsync(endpoint, null).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    frmHomePage homePage = new((string)UserData!.username);
                    homePage.Show();
                    Close();
                }
                return;
            }

            currentCard = cards[currentIndex];
            string type = (string)currentCard.type;

            if (type == "two-sided")
            {
                label5.Text = (string)currentCard.question;
                List<string> choices = new();

                if (currentCard.choices != null)
                {
                    if (currentCard.choices is JArray jarr)
                        choices = jarr.ToObject<List<string>>() ?? new List<string>();
                    else if (currentCard.choices is List<string> list)
                        choices = list;
                }

                // Defensive: ensure at least 4 choices
                while (choices.Count < 4)
                    choices.Add("");

                lblfirstchoice.Text = choices[0];
                lblsecondchoice.Text = choices[1];
                lblthirdchoice.Text = choices[2];
                lblfourthchoice.Text = choices[3];
                choices = choices.Where(c => c != (string)currentCard.answer).Distinct().ToList();

                // Tag correct answer
                lblfirstchoice.Tag = lblfirstchoice.Text == (string)currentCard.answer;
                lblsecondchoice.Tag = lblsecondchoice.Text == (string)currentCard.answer;
                lblthirdchoice.Tag = lblthirdchoice.Text == (string)currentCard.answer;
                lblfourthchoice.Tag = lblfourthchoice.Text == (string)currentCard.answer;

                button2.Visible = button3.Visible = button4.Visible = button5.Visible = true;
                lblfirstchoice.Visible = lblsecondchoice.Visible = lblthirdchoice.Visible = lblfourthchoice.Visible = true;
                timeLeft = 30;
                label3.Text = FormatTime(timeLeft);
                timer1.Interval = 1000;
                timer1.Tick -= Timer1_Tick;
                timer1.Tick += Timer1_Tick;
                timer1.Start();
            }
            else // one-sided
            {
                label5.Text = (string)currentCard.question;
                button2.Visible = button3.Visible = button4.Visible = button5.Visible = false;
                lblfirstchoice.Visible = lblsecondchoice.Visible = lblthirdchoice.Visible = lblfourthchoice.Visible = false;
                timeLeft = 10;
                label3.Text = FormatTime(timeLeft);
                timer1.Interval = 1000;
                timer1.Tick -= Timer1_Tick;
                timer1.Tick += Timer1_Tick;
                timer1.Start();
            }
            labelHearts.Text = hearts.ToString();
            labelPoints.Text = points.ToString();
        }

        // Add this method to handle answer clicks
        private void ChoiceLabel_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (sender is not System.Windows.Forms.Label lbl || lbl.Tag is not bool isCorrect)
                return;
            lbl.Visible = false;
            if (isCorrect)
            {
                points += 5;
            }
            else
            {
                hearts--;
                if (points > 0)
                {
                  
                    if (points < 0) points = 0;
                }
                if (hearts <= 0)
                {
                    labelHearts.Text = hearts.ToString();
                    MessageBox.Show("No more hearts! Quiz over.");
                    this.Hide();
                    frmHomePage fh = new frmHomePage();
                    fh.Show();
                    this.Close();
                    return;
                }
            }
            labelHearts.Text = hearts.ToString();
            labelPoints.Text = points.ToString();
            currentIndex++;
            ShowCurrentCard();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            label3.Text = FormatTime(timeLeft);
            if (timeLeft <= 0)
            {
                timer1.Stop();
                string type = (string)currentCard!.type;
                if (type == "two-sided")
                {
                    hearts--;
                    labelHearts.Text = hearts.ToString();
                    if (hearts <= 0)
                    {
                        MessageBox.Show("No more hearts! Quiz over.");
                        this.Hide();
                        frmHomePage fh = new frmHomePage();
                        fh.Show();
                        this.Close();
                        return;
                    }
                }
                currentIndex++;
                ShowCurrentCard();
            }
        }

        private string FormatTime(int seconds)
        {
            int min = seconds / 60;
            int sec = seconds % 60;
            return $"{min:00}:{sec:00}";
        }


        public QuizMode()
        {
            InitializeComponent();
            cards = new List<dynamic>();
            currentCard = null;
        }

        private void QuizMode_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
