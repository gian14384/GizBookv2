namespace GizBookv2
{
    partial class frmFAQ
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
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.left__1_1;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(87, 774);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(12, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(64, 55);
            panel2.TabIndex = 1;
            panel2.Click += panel2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.FAQ;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(641, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(128, 63);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.Component_19;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(93, 84);
            panel4.Name = "panel4";
            panel4.Size = new Size(1266, 87);
            panel4.TabIndex = 2;
            panel4.Click += panel4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.GizBook_is_a_learning_platform_where_users_create__study__and_share_flashcard_decks__You_can_challenge_others__climb_leaderboards__and_learn_smarter_through_friendly_competition_;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(93, 172);
            panel5.Name = "panel5";
            panel5.Size = new Size(1138, 83);
            panel5.TabIndex = 3;
            panel5.Visible = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.Component_27;
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Location = new Point(92, 173);
            panel6.Name = "panel6";
            panel6.Size = new Size(1266, 87);
            panel6.TabIndex = 3;
            // 
            // frmFAQ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFAQ";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFAQ";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}