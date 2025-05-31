namespace GizBookv2
{
    partial class FrontBackCardControl
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
            lblFront = new Label();
            lblBack = new Label();
            SuspendLayout();
            // 
            // lblFront
            // 
            lblFront.AutoSize = true;
            lblFront.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFront.Location = new Point(34, 32);
            lblFront.Name = "lblFront";
            lblFront.Size = new Size(95, 45);
            lblFront.TabIndex = 0;
            lblFront.Text = "Front";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBack.Location = new Point(34, 120);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(85, 45);
            lblBack.TabIndex = 1;
            lblBack.Text = "Back";
            // 
            // FrontBackCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.Text_input_container__2_3;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(lblBack);
            Controls.Add(lblFront);
            Name = "FrontBackCardControl";
            Size = new Size(1181, 189);
            Load += FrontBackCardControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFront;
        private Label lblBack;
    }
}
