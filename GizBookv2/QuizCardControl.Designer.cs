namespace GizBookv2
{
    partial class QuizCardControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuiz = new Label();
            SuspendLayout();
            // 
            // lblQuiz
            // 
            lblQuiz.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuiz.Location = new Point(18, 18);
            lblQuiz.Name = "lblQuiz";
            lblQuiz.Size = new Size(1139, 143);
            lblQuiz.TabIndex = 0;
            lblQuiz.Text = "label1";
            lblQuiz.Click += lblQuiz_Click;
            // 
            // QuizCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.Text_input__9_2;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(lblQuiz);
            DoubleBuffered = true;
            Name = "QuizCardControl";
            Size = new Size(1177, 177);
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuiz;
    }
}
