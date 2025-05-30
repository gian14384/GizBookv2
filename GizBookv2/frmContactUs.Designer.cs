namespace GizBookv2
{
    partial class frmContactUs
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
            panel5 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Frame_427319036;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(86, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 774);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.learn2;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(848, 680);
            panel5.Name = "panel5";
            panel5.Size = new Size(211, 54);
            panel5.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.home1;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(83, 769);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(9, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(62, 65);
            panel3.TabIndex = 0;
            panel3.Click += panel3_Click;
            // 
            // frmContactUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmContactUs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmContactUs";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel3;
    }
}