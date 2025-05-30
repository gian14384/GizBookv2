namespace GizBookv2
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            panel12 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            txtpassword = new TextBox();
            panel7 = new Panel();
            panel4 = new Panel();
            txtusername = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Frame_427318962__2_;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(230, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 923);
            panel1.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BackgroundImage = Properties.Resources.title__2_;
            panel12.BackgroundImageLayout = ImageLayout.Center;
            panel12.Location = new Point(596, 709);
            panel12.Name = "panel12";
            panel12.Size = new Size(118, 32);
            panel12.TabIndex = 8;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.BackgroundImage = Properties.Resources.title;
            panel10.BackgroundImageLayout = ImageLayout.Center;
            panel10.Location = new Point(142, 709);
            panel10.Name = "panel10";
            panel10.Size = new Size(135, 32);
            panel10.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.BackgroundImage = Properties.Resources.title__1_;
            panel11.BackgroundImageLayout = ImageLayout.Center;
            panel11.Location = new Point(358, 709);
            panel11.Name = "panel11";
            panel11.Size = new Size(157, 32);
            panel11.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.Don_t_have_an_account__Create_one;
            panel9.BackgroundImageLayout = ImageLayout.Center;
            panel9.Location = new Point(313, 553);
            panel9.Name = "panel9";
            panel9.Size = new Size(240, 17);
            panel9.TabIndex = 6;
            panel9.Click += panel9_Click;
            // 
            // panel8
            // 
            panel8.BackgroundImage = Properties.Resources.Frame_22;
            panel8.BackgroundImageLayout = ImageLayout.Center;
            panel8.Location = new Point(142, 492);
            panel8.Name = "panel8";
            panel8.Size = new Size(572, 57);
            panel8.TabIndex = 5;
            panel8.Click += panel8_Click;
            panel8.Paint += panel8_Paint;
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.Password;
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Location = new Point(142, 400);
            panel6.Name = "panel6";
            panel6.Size = new Size(78, 22);
            panel6.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.Frame_427318909__1_;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Controls.Add(txtpassword);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(142, 429);
            panel5.Name = "panel5";
            panel5.Size = new Size(572, 48);
            panel5.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(17, 12);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "Enter your password";
            txtpassword.Size = new Size(505, 27);
            txtpassword.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.close;
            panel7.BackgroundImageLayout = ImageLayout.Center;
            panel7.Location = new Point(528, 14);
            panel7.Name = "panel7";
            panel7.Size = new Size(35, 23);
            panel7.TabIndex = 0;
            panel7.Click += panel7_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Frame_427318909__1_;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Controls.Add(txtusername);
            panel4.Location = new Point(142, 336);
            panel4.Name = "panel4";
            panel4.Size = new Size(572, 45);
            panel4.TabIndex = 2;
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(17, 9);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Enter your username";
            txtusername.Size = new Size(539, 27);
            txtusername.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(142, 306);
            panel3.Name = "panel3";
            panel3.Size = new Size(84, 24);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Group_53;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(142, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(563, 160);
            panel2.TabIndex = 0;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1366, 768);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel12;
        private Panel panel10;
        private Panel panel11;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private TextBox txtpassword;
        private TextBox txtusername;
    }
}
