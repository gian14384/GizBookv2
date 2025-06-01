namespace GizBookv2
{
    partial class FlipMode
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
            label1 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.home2;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(87, 771);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(601, 52);
            label1.Name = "label1";
            label1.Size = new Size(191, 45);
            label1.TabIndex = 2;
            label1.Text = "Deck Name";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Slider;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(798, 58);
            button1.Name = "button1";
            button1.Size = new Size(48, 35);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.Text_input__5_1;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(126, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(1185, 352);
            panel3.TabIndex = 7;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 31);
            label3.Name = "label3";
            label3.Size = new Size(1098, 289);
            label3.TabIndex = 0;
            label3.Text = "Cards Content";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.Slider__2_;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(409, 560);
            button2.Name = "button2";
            button2.Size = new Size(104, 74);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.Slider__1_;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(938, 560);
            button3.Name = "button3";
            button3.Size = new Size(104, 74);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.Frame_427318999;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(534, 555);
            button4.Name = "button4";
            button4.Size = new Size(382, 84);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(558, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(37, 33);
            panel2.TabIndex = 11;
            // 
            // FlipMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlipMode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlipMode";
            Load += FlipMode_Load;
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Panel panel3;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel2;
    }
}