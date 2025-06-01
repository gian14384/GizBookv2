namespace GizBookv2
{
    partial class frmDeckPage
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
            panel10 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.left__1_;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel10);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 777);
            panel1.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.Cursor = Cursors.Hand;
            panel10.Location = new Point(10, 11);
            panel10.Name = "panel10";
            panel10.Size = new Size(69, 57);
            panel10.TabIndex = 8;
            panel10.Click += panel10_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.My_decks;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(116, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 54);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.learn1;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(736, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 55);
            panel3.TabIndex = 2;
            panel3.Click += panel3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.add1;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(1040, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(286, 55);
            panel4.TabIndex = 3;
            panel4.Click += panel4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.Line_61;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(107, 102);
            panel5.Name = "panel5";
            panel5.Size = new Size(1230, 10);
            panel5.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Center;
            flowLayoutPanel1.Location = new Point(116, 128);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1210, 606);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // frmDeckPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDeckPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDeckPage";
            Load += frmDeckPage_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel10;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}