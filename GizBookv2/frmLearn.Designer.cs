namespace GizBookv2
{
    partial class frmLearn
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Choose_your_learning_style;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(199, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 46);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.flip_mode;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(89, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 181);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.add_decks_btn;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(298, 340);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 61);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.quiz_mode;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(423, 131);
            panel4.Name = "panel4";
            panel4.Size = new Size(284, 181);
            panel4.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = Properties.Resources.left__1_2;
            panel7.BackgroundImageLayout = ImageLayout.Center;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(86, 77);
            panel7.TabIndex = 7;
            panel7.Click += panel7_Click;
            // 
            // frmLearn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLearn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLearn";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel7;
    }
}