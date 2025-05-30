namespace GizBookv2
{
    partial class frmLogout
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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Confirm_logout_Text;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(122, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 44);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.exit_logo;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(219, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(105, 107);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.Are_you_sure_you_want_to_log_out_Text;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(100, 205);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 29);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.cancel_button;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(78, 254);
            panel4.Name = "panel4";
            panel4.Size = new Size(161, 48);
            panel4.TabIndex = 3;
            panel4.Click += panel4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.confirm_button;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(315, 254);
            panel5.Name = "panel5";
            panel5.Size = new Size(161, 48);
            panel5.TabIndex = 4;
            panel5.Click += panel5_Click;
            // 
            // frmLogout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(564, 398);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogout";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}