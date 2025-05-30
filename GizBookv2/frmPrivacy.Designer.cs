namespace GizBookv2
{
    partial class frmPrivacy
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
            panel8 = new Panel();
            panel7 = new Panel();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Change_Privacy_txt;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(96, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 62);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Frame_427319052;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(141, 199);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 59);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.Frame_427319051;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(120, 273);
            panel3.Name = "panel3";
            panel3.Size = new Size(359, 59);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.privacy_modal1;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(852, 288);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 44);
            panel4.TabIndex = 3;
            panel4.Click += panel4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.Frame_427319055;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(854, 214);
            panel5.Name = "panel5";
            panel5.Size = new Size(168, 44);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.Expanded_privacy1;
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(854, 288);
            panel6.Name = "panel6";
            panel6.Size = new Size(169, 158);
            panel6.TabIndex = 5;
            panel6.Visible = false;
            // 
            // panel8
            // 
            panel8.Location = new Point(120, 1);
            panel8.Name = "panel8";
            panel8.Size = new Size(49, 30);
            panel8.TabIndex = 7;
            panel8.Click += panel8_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = Properties.Resources.left__1_2;
            panel7.BackgroundImageLayout = ImageLayout.Center;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(86, 77);
            panel7.TabIndex = 6;
            panel7.Click += panel7_Click;
            // 
            // frmPrivacy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 542);
            Controls.Add(panel4);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrivacy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrivacy";
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
    }
}