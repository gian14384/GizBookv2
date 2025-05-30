namespace GizBookv2
{
    partial class frmRegister
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
            panel12 = new Panel();
            panel11 = new Panel();
            sdada = new Panel();
            txtconfirmpass = new TextBox();
            sdsadas = new Panel();
            txtpassword = new TextBox();
            sdasd = new Panel();
            txtusername = new TextBox();
            dsda = new Panel();
            txtname = new TextBox();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            sdada.SuspendLayout();
            sdsadas.SuspendLayout();
            sdasd.SuspendLayout();
            dsda.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Frame_427318962__1_;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(sdada);
            panel1.Controls.Add(sdsadas);
            panel1.Controls.Add(sdasd);
            panel1.Controls.Add(dsda);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(238, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 657);
            panel1.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Transparent;
            panel12.BackgroundImage = Properties.Resources.Already_have_an_account__Sign_in_instead_;
            panel12.BackgroundImageLayout = ImageLayout.Center;
            panel12.Cursor = Cursors.Hand;
            panel12.Location = new Point(279, 570);
            panel12.Name = "panel12";
            panel12.Size = new Size(284, 19);
            panel12.TabIndex = 1;
            panel12.Click += panel12_Click;
            // 
            // panel11
            // 
            panel11.BackgroundImage = Properties.Resources.Sign_up1;
            panel11.BackgroundImageLayout = ImageLayout.Center;
            panel11.Cursor = Cursors.Hand;
            panel11.Location = new Point(125, 511);
            panel11.Name = "panel11";
            panel11.Size = new Size(577, 55);
            panel11.TabIndex = 8;
            panel11.Click += panel11_Click;
            // 
            // sdada
            // 
            sdada.BackgroundImage = Properties.Resources.Text_input__1_;
            sdada.BackgroundImageLayout = ImageLayout.Center;
            sdada.Controls.Add(txtconfirmpass);
            sdada.Location = new Point(125, 433);
            sdada.Name = "sdada";
            sdada.Size = new Size(577, 51);
            sdada.TabIndex = 7;
            // 
            // txtconfirmpass
            // 
            txtconfirmpass.BorderStyle = BorderStyle.None;
            txtconfirmpass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtconfirmpass.Location = new Point(19, 12);
            txtconfirmpass.Multiline = true;
            txtconfirmpass.Name = "txtconfirmpass";
            txtconfirmpass.PlaceholderText = "Repeat your password";
            txtconfirmpass.Size = new Size(539, 27);
            txtconfirmpass.TabIndex = 1;
            // 
            // sdsadas
            // 
            sdsadas.BackgroundImage = Properties.Resources.Text_input__1_;
            sdsadas.BackgroundImageLayout = ImageLayout.Center;
            sdsadas.Controls.Add(txtpassword);
            sdsadas.Location = new Point(125, 336);
            sdsadas.Name = "sdsadas";
            sdsadas.Size = new Size(577, 56);
            sdsadas.TabIndex = 6;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(19, 14);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Enter your password";
            txtpassword.Size = new Size(539, 27);
            txtpassword.TabIndex = 1;
            // 
            // sdasd
            // 
            sdasd.BackgroundImage = Properties.Resources.Text_input__1_;
            sdasd.BackgroundImageLayout = ImageLayout.Center;
            sdasd.Controls.Add(txtusername);
            sdasd.Location = new Point(125, 242);
            sdasd.Name = "sdasd";
            sdasd.Size = new Size(577, 54);
            sdasd.TabIndex = 6;
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(19, 14);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Enter your username";
            txtusername.Size = new Size(539, 27);
            txtusername.TabIndex = 1;
            // 
            // dsda
            // 
            dsda.BackgroundImage = Properties.Resources.Text_input__1_;
            dsda.BackgroundImageLayout = ImageLayout.Center;
            dsda.Controls.Add(txtname);
            dsda.Location = new Point(125, 151);
            dsda.Name = "dsda";
            dsda.Size = new Size(577, 54);
            dsda.TabIndex = 5;
            // 
            // txtname
            // 
            txtname.BorderStyle = BorderStyle.None;
            txtname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(19, 13);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.PlaceholderText = "Enter your name";
            txtname.Size = new Size(539, 27);
            txtname.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.Confirm_Password;
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Location = new Point(125, 406);
            panel6.Name = "panel6";
            panel6.Size = new Size(127, 23);
            panel6.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.Password1;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(125, 309);
            panel5.Name = "panel5";
            panel5.Size = new Size(76, 24);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Username;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(125, 215);
            panel4.Name = "panel4";
            panel4.Size = new Size(76, 24);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Name;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(125, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(59, 21);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Frame_427318941;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(125, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 57);
            panel2.TabIndex = 0;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1366, 768);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GizBook";
            panel1.ResumeLayout(false);
            sdada.ResumeLayout(false);
            sdada.PerformLayout();
            sdsadas.ResumeLayout(false);
            sdsadas.PerformLayout();
            sdasd.ResumeLayout(false);
            sdasd.PerformLayout();
            dsda.ResumeLayout(false);
            dsda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel dsda;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel sdada;
        private Panel sdsadas;
        private Panel sdasd;
        private Panel panel11;
        private Panel panel12;
        private TextBox txtname;
        private TextBox txtconfirmpass;
        private TextBox txtpassword;
        private TextBox txtusername;
    }
}