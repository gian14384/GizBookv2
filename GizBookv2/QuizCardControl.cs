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
