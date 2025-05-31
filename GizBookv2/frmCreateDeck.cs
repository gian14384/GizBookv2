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
    public partial class frmCreateDeck : Form
    {

        public frmCreateDeck()
        {
            InitializeComponent();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCreateDeck_Load(object sender, EventArgs e)
        {

            SetQuizMode(true);

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (isQuizMode)
            {
                // Quiz mode: use QuizCardControl
                string quizText = txtQuiz.Text.Trim();
                if (!string.IsNullOrEmpty(quizText))
                {
                    var quizCard = new QuizCardControl();
                    quizCard.SetQuiz(quizText);
                    flowLayoutPanel1.Controls.Add(quizCard);
                    txtQuiz.Clear();
                }
            }
            else
            {
                // Front/Back mode: use FrontBackCardControl
                string front = txtfront.Text.Trim();
                string back = txtback.Text.Trim();
                if (!string.IsNullOrEmpty(front) && !string.IsNullOrEmpty(back))
                {
                    var fbCard = new FrontBackCardControl();
                    fbCard.SetFrontBack(front, back);
                    flowLayoutPanel1.Controls.Add(fbCard);
                    txtfront.Clear();
                    txtback.Clear();
                }
            }
        }
    }
}
