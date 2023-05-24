namespace ShoesScraper
{
    partial class AboutPage
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
            label1 = new Label();
            label2 = new Label();
            GlamiLogo = new PictureBox();
            ZapposLogo = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)GlamiLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ZapposLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Symbol", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(67, 90);
            label1.Name = "label1";
            label1.Size = new Size(510, 52);
            label1.TabIndex = 4;
            label1.Text = "This project takes information from.";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Symbol", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 357);
            label2.Name = "label2";
            label2.Size = new Size(623, 80);
            label2.TabIndex = 6;
            label2.Text = "This project is a specific scraper which trying to find good sales for your needs!";
            // 
            // GlamiLogo
            // 
            GlamiLogo.BackColor = Color.FromArgb(255, 204, 153);
            GlamiLogo.BackgroundImage = Properties.Resources.GLAMI_icon;
            GlamiLogo.BackgroundImageLayout = ImageLayout.Zoom;
            GlamiLogo.BorderStyle = BorderStyle.FixedSingle;
            GlamiLogo.Cursor = Cursors.Hand;
            GlamiLogo.Location = new Point(67, 181);
            GlamiLogo.Name = "GlamiLogo";
            GlamiLogo.Size = new Size(193, 145);
            GlamiLogo.TabIndex = 12;
            GlamiLogo.TabStop = false;
            GlamiLogo.Click += GlamiIcon_Click;
            // 
            // ZapposLogo
            // 
            ZapposLogo.BackColor = Color.FromArgb(255, 204, 153);
            ZapposLogo.BackgroundImage = Properties.Resources.ZAPPOS_icon3;
            ZapposLogo.BackgroundImageLayout = ImageLayout.Zoom;
            ZapposLogo.BorderStyle = BorderStyle.FixedSingle;
            ZapposLogo.Cursor = Cursors.Hand;
            ZapposLogo.Location = new Point(384, 181);
            ZapposLogo.Name = "ZapposLogo";
            ZapposLogo.Size = new Size(193, 145);
            ZapposLogo.TabIndex = 14;
            ZapposLogo.TabStop = false;
            ZapposLogo.Click += ZapposIcon_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 56);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 15;
            label3.Text = "Made by: Y. Topov ";
            // 
            // AboutPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(635, 456);
            Controls.Add(label3);
            Controls.Add(ZapposLogo);
            Controls.Add(GlamiLogo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AboutPage";
            Text = "AboutPage";
            ((System.ComponentModel.ISupportInitialize)GlamiLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ZapposLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox GlamiLogo;
        private PictureBox ZapposLogo;
        private Label label3;
    }
}