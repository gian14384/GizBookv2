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
    public partial class frmLearn : Form
    {
        private readonly dynamic selectedDeck;
        private readonly string deckName;
        private readonly string deckColor;
        private readonly dynamic UserData;
        public frmLearn(dynamic selectedDeck, string deckName, string deckColor, dynamic userdata)
        {
            InitializeComponent();
            this.selectedDeck = selectedDeck;
            this.UserData = userdata;
            this.deckName = deckName;
            this.deckColor = deckColor;
        }
   

        

        private enum LearnMode { None, Flip, Quiz }
        private LearnMode selectedMode = LearnMode.None;

        private void panel7_Click(object sender, EventArgs e)
        {
            frmDeckPage2 deckPage2 = new(UserData);
            deckPage2.Show();
            Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Properties.Resources.p2;
            panel2.BackgroundImageLayout = ImageLayout.Center;

            panel4.BackgroundImage = Properties.Resources.quiz_mode; // Replace with your actual resource name
            panel4.BackgroundImageLayout = ImageLayout.Center;

            selectedMode = LearnMode.Flip;
        }



        private void panel4_Click(object sender, EventArgs e)
        {
            panel4.BackgroundImage = Properties.Resources.p1;
            panel4.BackgroundImageLayout = ImageLayout.Center;

            panel2.BackgroundImage = Properties.Resources.flip_mode; // Replace with your actual resource name
            panel2.BackgroundImageLayout = ImageLayout.Center;

            selectedMode = LearnMode.Quiz;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (selectedMode == LearnMode.Flip)
            {
                var flipForm = new FlipMode(selectedDeck, deckName, deckColor);
                flipForm.ShowDialog(this);
            }
            else if (selectedMode == LearnMode.Quiz)
            {
                QuizMode quizForm = new(selectedDeck, deckName, deckColor, UserData);
                quizForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Please select a mode first.");
            }

        }

        private void frmLearn_Load(object sender, EventArgs e)
        {

        }
    }
}
