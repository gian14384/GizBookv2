namespace GizBookv2
{
    partial class frmDeckPage2
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
            pnlDeck = new Panel();
            lblDeckNumber = new Label();
            lblDeckTitle = new Label();
            picDeckColor = new PictureBox();
            panel5 = new Panel();
            button3 = new Button();
            pnlDecks = new Panel();
            lblSelectedDeck = new Label();
            pnlDeck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDeckColor).BeginInit();
            pnlDecks.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.left__1_5;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(85, 774);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Pick_a_deck;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(606, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 54);
            panel2.TabIndex = 1;
            // 
            // pnlDeck
            // 
            pnlDeck.BackColor = Color.Transparent;
            pnlDeck.BackgroundImage = Properties.Resources.decks_v21;
            pnlDeck.BackgroundImageLayout = ImageLayout.Center;
            pnlDeck.Controls.Add(lblDeckNumber);
            pnlDeck.Controls.Add(lblDeckTitle);
            pnlDeck.Controls.Add(picDeckColor);
            pnlDeck.Location = new Point(24, 13);
            pnlDeck.Name = "pnlDeck";
            pnlDeck.Size = new Size(815, 110);
            pnlDeck.TabIndex = 2;
            // 
            // lblDeckNumber
            // 
            lblDeckNumber.AutoSize = true;
            lblDeckNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeckNumber.Location = new Point(88, 65);
            lblDeckNumber.Name = "lblDeckNumber";
            lblDeckNumber.Size = new Size(168, 32);
            lblDeckNumber.TabIndex = 4;
            lblDeckNumber.Text = "Cards Number";
            // 
            // lblDeckTitle
            // 
            lblDeckTitle.AutoSize = true;
            lblDeckTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeckTitle.Location = new Point(83, 18);
            lblDeckTitle.Name = "lblDeckTitle";
            lblDeckTitle.Size = new Size(94, 47);
            lblDeckTitle.TabIndex = 3;
            lblDeckTitle.Text = "Title";
            // 
            // picDeckColor
            // 
            picDeckColor.BackColor = SystemColors.ActiveCaptionText;
            picDeckColor.BackgroundImageLayout = ImageLayout.Center;
            picDeckColor.Location = new Point(727, 27);
            picDeckColor.Name = "picDeckColor";
            picDeckColor.Size = new Size(58, 57);
            picDeckColor.TabIndex = 3;
            picDeckColor.TabStop = false;
            // 
            // panel5
            // 
            panel5.Location = new Point(518, 216);
            panel5.Name = "panel5";
            panel5.Size = new Size(8, 8);
            panel5.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.Segmented_picker;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(310, 565);
            button3.Name = "button3";
            button3.Size = new Size(815, 91);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = false;
            // 
            // pnlDecks
            // 
            pnlDecks.AutoScroll = true;
            pnlDecks.AutoScrollMinSize = new Size(0, 550);
            pnlDecks.Controls.Add(pnlDeck);
            pnlDecks.Location = new Point(286, 72);
            pnlDecks.Name = "pnlDecks";
            pnlDecks.Size = new Size(864, 465);
            pnlDecks.TabIndex = 7;
            // 
            // lblSelectedDeck
            // 
            lblSelectedDeck.Font = new Font("Segoe UI", 12F);
            lblSelectedDeck.Location = new Point(310, 668);
            lblSelectedDeck.Name = "lblSelectedDeck";
            lblSelectedDeck.Size = new Size(815, 23);
            lblSelectedDeck.TabIndex = 8;
            lblSelectedDeck.Text = "Selected Deck: None";
            lblSelectedDeck.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDeckPage2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Controls.Add(lblSelectedDeck);
            Controls.Add(pnlDecks);
            Controls.Add(button3);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDeckPage2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDeckPage2";
            Load += frmDeckPage2_Load;
            pnlDeck.ResumeLayout(false);
            pnlDeck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDeckColor).EndInit();
            pnlDecks.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlDeck;
        private PictureBox picDeckColor;
        private Label lblDeckNumber;
        private Label lblDeckTitle;
        private Panel panel5;
        private Button button3;
        private Panel pnlDecks;
        private Label lblSelectedDeck;
    }
}