namespace GizBookv2
{
    partial class DeckItemControl
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
            panelColor = new Panel();
            panel2 = new Panel();
            lblTotalCards = new Label();
            lblDeckName = new Label();
            panelColor.SuspendLayout();
            SuspendLayout();
            // 
            // panelColor
            // 
            panelColor.Controls.Add(panel2);
            panelColor.Location = new Point(0, 0);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(213, 45);
            panelColor.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Rating5;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(185, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(28, 45);
            panel2.TabIndex = 3;
            // 
            // lblTotalCards
            // 
            lblTotalCards.AutoEllipsis = true;
            lblTotalCards.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCards.Location = new Point(3, 79);
            lblTotalCards.Name = "lblTotalCards";
            lblTotalCards.Size = new Size(194, 21);
            lblTotalCards.TabIndex = 1;
            lblTotalCards.Text = "0 cards";
            // 
            // lblDeckName
            // 
            lblDeckName.AutoEllipsis = true;
            lblDeckName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeckName.Location = new Point(3, 54);
            lblDeckName.Name = "lblDeckName";
            lblDeckName.Size = new Size(205, 25);
            lblDeckName.TabIndex = 2;
            lblDeckName.Text = "Deck Title";
            // 
            // DeckItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblDeckName);
            Controls.Add(lblTotalCards);
            Controls.Add(panelColor);
            Cursor = Cursors.Hand;
            Name = "DeckItemControl";
            Size = new Size(211, 107);
            Load += DeckItemControl_Load;
            panelColor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelColor;
        private Panel panel2;
        private Label lblTotalCards;
        private Label lblDeckName;
    }
}
