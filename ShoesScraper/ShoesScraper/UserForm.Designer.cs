namespace ShoesScraper
{
    partial class UserForm
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
            panel1 = new Panel();
            ItemDisplayer = new FlowLayoutPanel();
            NoResult = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            NoResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(169, 21);
            label1.Name = "label1";
            label1.Size = new Size(313, 38);
            label1.TabIndex = 2;
            label1.Text = "Your favorite shoes pair.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 204, 153);
            panel1.Location = new Point(22, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 9);
            panel1.TabIndex = 6;
            // 
            // ItemDisplayer
            // 
            ItemDisplayer.AutoScroll = true;
            ItemDisplayer.Location = new Point(30, 77);
            ItemDisplayer.Name = "ItemDisplayer";
            ItemDisplayer.Size = new Size(604, 380);
            ItemDisplayer.TabIndex = 7;
            // 
            // NoResult
            // 
            NoResult.AutoScroll = true;
            NoResult.Controls.Add(pictureBox1);
            NoResult.Controls.Add(label2);
            NoResult.Location = new Point(30, 77);
            NoResult.Name = "NoResult";
            NoResult.Size = new Size(581, 380);
            NoResult.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.giphy__1_;
            pictureBox1.Location = new Point(85, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(105, 300);
            label2.Name = "label2";
            label2.Size = new Size(347, 38);
            label2.TabIndex = 1;
            label2.Text = "There are not product yet?";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(635, 456);
            Controls.Add(NoResult);
            Controls.Add(ItemDisplayer);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            Text = "UserForm";
            NoResult.ResumeLayout(false);
            NoResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private FlowLayoutPanel ItemDisplayer;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel NoResult;
    }
}