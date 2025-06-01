namespace GizBookv2
{
    partial class frmCreateDeck
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            txtQuiz = new TextBox();
            txtback = new TextBox();
            txtfront = new TextBox();
            button4 = new Button();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.left__1_3;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(87, 773);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(195, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 26);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 34);
            label1.Name = "label1";
            label1.Size = new Size(582, 45);
            label1.TabIndex = 2;
            label1.Text = "Deck Name";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Slider;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(139, 44);
            button1.Name = "button1";
            button1.Size = new Size(48, 35);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.Button_container;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(833, 27);
            button2.Name = "button2";
            button2.Size = new Size(225, 56);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.Text_input__1_2;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(1084, 27);
            button3.Name = "button3";
            button3.Size = new Size(225, 56);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Text_input__9_;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(txtQuiz);
            panel2.Controls.Add(txtback);
            panel2.Controls.Add(txtfront);
            panel2.Location = new Point(127, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(1182, 191);
            panel2.TabIndex = 6;
            // 
            // txtQuiz
            // 
            txtQuiz.BackColor = Color.White;
            txtQuiz.BorderStyle = BorderStyle.None;
            txtQuiz.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuiz.Location = new Point(26, 21);
            txtQuiz.Multiline = true;
            txtQuiz.Name = "txtQuiz";
            txtQuiz.PlaceholderText = "Write something to remember ... e.g., Pi is approximately 3.1416.";
            txtQuiz.Size = new Size(1135, 149);
            txtQuiz.TabIndex = 8;
            txtQuiz.Visible = false;
            // 
            // txtback
            // 
            txtback.BackColor = Color.White;
            txtback.BorderStyle = BorderStyle.None;
            txtback.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtback.Location = new Point(28, 117);
            txtback.Multiline = true;
            txtback.Name = "txtback";
            txtback.PlaceholderText = "Write something to remember ... e.g., Pi is approximately 3.1416.";
            txtback.Size = new Size(1135, 53);
            txtback.TabIndex = 15;
            txtback.Visible = false;
            // 
            // txtfront
            // 
            txtfront.BackColor = Color.White;
            txtfront.BorderStyle = BorderStyle.None;
            txtfront.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtfront.Location = new Point(26, 31);
            txtfront.Multiline = true;
            txtfront.Name = "txtfront";
            txtfront.PlaceholderText = "Write something to remember ... e.g., Pi is approximately 3.1416.";
            txtfront.Size = new Size(1135, 53);
            txtfront.TabIndex = 14;
            txtfront.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.Button__1_4;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(127, 310);
            button4.Name = "button4";
            button4.Size = new Size(217, 53);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 382);
            label2.Name = "label2";
            label2.Size = new Size(417, 37);
            label2.TabIndex = 9;
            label2.Text = "Recently added cards (number)";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(127, 434);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1227, 322);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // frmCreateDeck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCreateDeck";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCreateDeck";
            Load += frmCreateDeck_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private Button button4;
        private Label label2;
        private TextBox txtQuiz;
        private TextBox txtback;
        private TextBox txtfront;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}