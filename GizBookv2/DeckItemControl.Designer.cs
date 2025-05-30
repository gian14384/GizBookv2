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
            deckColor = new Panel();
            panel9 = new Panel();
            deckName = new Label();
            label2 = new Label();
            deckColor.SuspendLayout();
            SuspendLayout();
            // 
            // deckColor
            // 
            deckColor.Controls.Add(panel9);
            deckColor.Location = new Point(0, 0);
            deckColor.Name = "deckColor";
            deckColor.Size = new Size(221, 45);
            deckColor.TabIndex = 8;
            deckColor.Paint += deckColor_Paint;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.BackgroundImage = Properties.Resources.Rating2;
            panel9.BackgroundImageLayout = ImageLayout.Center;
            panel9.Location = new Point(195, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(26, 45);
            panel9.TabIndex = 8;
            // 
            // deckName
            // 
            deckName.AutoSize = true;
            deckName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deckName.Location = new Point(14, 58);
            deckName.Name = "deckName";
            deckName.Size = new Size(113, 25);
            deckName.TabIndex = 9;
            deckName.Text = "Deck Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 83);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 10;
            label2.Text = "Cards Number";
            // 
            // DeckItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(deckName);
            Controls.Add(deckColor);
            Name = "DeckItemControl";
            Size = new Size(221, 117);
            Load += DeckItemControl_Load;
            deckColor.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel deckColor;
        private Panel panel9;
        private Label deckName;
        private Label label2;
    }
}
