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
            label1 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 79);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // lblDeckName
            // 
            lblDeckName.AutoSize = true;
            lblDeckName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeckName.Location = new Point(1, 54);
            lblDeckName.Name = "lblDeckName";
            lblDeckName.Size = new Size(65, 25);
            lblDeckName.TabIndex = 2;
            lblDeckName.Text = "label2";
            // 
            // DeckItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDeckName);
            Controls.Add(label1);
            Controls.Add(panelColor);
            Name = "DeckItemControl";
            Size = new Size(213, 109);
            Load += DeckItemControl_Load;
            panelColor.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelColor;
        private Panel panel2;
        private Label label1;
        private Label lblDeckName;
    }
}
