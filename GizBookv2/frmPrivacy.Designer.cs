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
            picPostDefault = new PictureBox();
            panel6 = new Panel();
            picPostFriends = new PictureBox();
            picPostPublic = new PictureBox();
            picPostOnlyMe = new PictureBox();
            panel8 = new Panel();
            panel7 = new Panel();
            picLeaderboard = new PictureBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPostDefault).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPostFriends).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPostPublic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPostOnlyMe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLeaderboard).BeginInit();
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
            panel4.BackgroundImage = Properties.Resources.privacy_modal2;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(picPostDefault);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(852, 288);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 44);
            panel4.TabIndex = 3;
            panel4.Click += panel4_Click;
            // 
            // picPostDefault
            // 
            picPostDefault.Cursor = Cursors.Default;
            picPostDefault.Image = Properties.Resources.Only_Me;
            picPostDefault.Location = new Point(0, 0);
            picPostDefault.Name = "picPostDefault";
            picPostDefault.Size = new Size(128, 41);
            picPostDefault.SizeMode = PictureBoxSizeMode.CenterImage;
            picPostDefault.TabIndex = 0;
            picPostDefault.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.Expanded_privacy2;
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Controls.Add(picPostFriends);
            panel6.Controls.Add(picPostPublic);
            panel6.Controls.Add(picPostOnlyMe);
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(854, 288);
            panel6.Name = "panel6";
            panel6.Size = new Size(169, 158);
            panel6.TabIndex = 5;
            panel6.Visible = false;
            // 
            // picPostFriends
            // 
            picPostFriends.Cursor = Cursors.Hand;
            picPostFriends.Image = Properties.Resources.Friends;
            picPostFriends.Location = new Point(3, 106);
            picPostFriends.Name = "picPostFriends";
            picPostFriends.Size = new Size(136, 33);
            picPostFriends.SizeMode = PictureBoxSizeMode.CenterImage;
            picPostFriends.TabIndex = 8;
            picPostFriends.TabStop = false;
            picPostFriends.Click += picPostFriends_Click;
            // 
            // picPostPublic
            // 
            picPostPublic.Cursor = Cursors.Hand;
            picPostPublic.Image = Properties.Resources.Public1;
            picPostPublic.Location = new Point(3, 67);
            picPostPublic.Name = "picPostPublic";
            picPostPublic.Size = new Size(136, 33);
            picPostPublic.SizeMode = PictureBoxSizeMode.CenterImage;
            picPostPublic.TabIndex = 8;
            picPostPublic.TabStop = false;
            picPostPublic.Click += picPostPublic_Click;
            // 
            // picPostOnlyMe
            // 
            picPostOnlyMe.Cursor = Cursors.Hand;
            picPostOnlyMe.Image = Properties.Resources.Only_Me;
            picPostOnlyMe.Location = new Point(3, 28);
            picPostOnlyMe.Name = "picPostOnlyMe";
            picPostOnlyMe.Size = new Size(136, 33);
            picPostOnlyMe.SizeMode = PictureBoxSizeMode.CenterImage;
            picPostOnlyMe.TabIndex = 8;
            picPostOnlyMe.TabStop = false;
            picPostOnlyMe.Click += picPostOnlyMe_Click;
            // 
            // panel8
            // 
            panel8.Cursor = Cursors.Hand;
            panel8.Location = new Point(120, 1);
            panel8.Name = "panel8";
            panel8.Size = new Size(49, 40);
            panel8.TabIndex = 7;
            panel8.Click += panel8_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = Properties.Resources.left__1_2;
            panel7.BackgroundImageLayout = ImageLayout.Center;
            panel7.Cursor = Cursors.Hand;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(86, 77);
            panel7.TabIndex = 6;
            panel7.Click += panel7_Click;
            // 
            // picLeaderboard
            // 
            picLeaderboard.Cursor = Cursors.Hand;
            picLeaderboard.Image = Properties.Resources.buttonOff;
            picLeaderboard.Location = new Point(917, 206);
            picLeaderboard.Name = "picLeaderboard";
            picLeaderboard.Size = new Size(40, 43);
            picLeaderboard.SizeMode = PictureBoxSizeMode.Zoom;
            picLeaderboard.TabIndex = 7;
            picLeaderboard.TabStop = false;
            picLeaderboard.Click += picLeaderboard_Click;
            // 
            // frmPrivacy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 542);
            Controls.Add(picLeaderboard);
            Controls.Add(panel4);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrivacy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrivacy";
            Load += frmPrivacy_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPostDefault).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPostFriends).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPostPublic).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPostOnlyMe).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLeaderboard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private PictureBox picLeaderboard;
        private PictureBox picPostDefault;
        private PictureBox picPostFriends;
        private PictureBox picPostPublic;
        private PictureBox picPostOnlyMe;
    }
}