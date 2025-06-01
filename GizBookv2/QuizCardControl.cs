namespace GizBookv2
{
    public partial class QuizCardControl : UserControl
    {
        public QuizCardControl()
        {
            InitializeComponent();
        }

        private void lblQuiz_Click(object sender, EventArgs e)
        {

        }

        public void SetQuiz(string quizText)
        {
            lblQuiz.Text = quizText;
        }
    }
}
