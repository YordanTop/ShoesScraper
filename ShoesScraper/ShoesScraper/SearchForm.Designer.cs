namespace ShoesScraper
{
    partial class SearchForm
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
            textBox = new TextBox();
            SearchButton = new PictureBox();
            genderBox = new ComboBox();
            shopBox = new ComboBox();
            Frame = new FlowLayoutPanel();
            NoStorePanel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)SearchButton).BeginInit();
            Frame.SuspendLayout();
            NoStorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(399, 26);
            textBox.Name = "textBox";
            textBox.PlaceholderText = "Search...";
            textBox.Size = new Size(173, 27);
            textBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            SearchButton.BackgroundImage = Properties.Resources.SearchIcon;
            SearchButton.BackgroundImageLayout = ImageLayout.Zoom;
            SearchButton.BorderStyle = BorderStyle.FixedSingle;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Location = new Point(573, 26);
            SearchButton.Margin = new Padding(15);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(38, 27);
            SearchButton.TabIndex = 1;
            SearchButton.TabStop = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // genderBox
            // 
            genderBox.Cursor = Cursors.Hand;
            genderBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "(Select Gender)", "Male", "Female " });
            genderBox.Location = new Point(22, 25);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(151, 28);
            genderBox.TabIndex = 2;
            genderBox.Text = "(Select Gender)";
            genderBox.Tag = "";
            genderBox.SelectedIndexChanged += genderBox_SelectedIndexChanged;

            // 
            // shopBox
            // 
            shopBox.Cursor = Cursors.Hand;
            shopBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shopBox.FormattingEnabled = true;
            shopBox.Items.AddRange(new object[] { "(Select Shop)", "Glami", "Zappos" });
            shopBox.Location = new Point(179, 26);
            shopBox.Name = "shopBox";
            shopBox.Text = "(Select Shop)";
            shopBox.Size = new Size(151, 28);
            shopBox.TabIndex = 3;
            shopBox.SelectedIndexChanged += shopBox_SelectedIndexChanged;
            // 
            // Frame
            // 
            Frame.AutoScroll = true;
            Frame.Controls.Add(NoStorePanel);
            Frame.Location = new Point(30, 77);
            Frame.Name = "Frame";
            Frame.Size = new Size(604, 380);
            Frame.TabIndex = 4;
            // 
            // NoStorePanel
            // 
            NoStorePanel.Controls.Add(label1);
            NoStorePanel.Controls.Add(pictureBox1);
            NoStorePanel.Location = new Point(3, 3);
            NoStorePanel.Name = "NoStorePanel";
            NoStorePanel.Size = new Size(581, 364);
            NoStorePanel.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(149, 266);
            label1.Name = "label1";
            label1.Size = new Size(274, 38);
            label1.TabIndex = 1;
            label1.Text = "Searching for shoes?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.shoesimg;
            pictureBox1.Location = new Point(97, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 204, 153);
            panel1.Location = new Point(22, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 9);
            panel1.TabIndex = 5;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(635, 456);
            Controls.Add(panel1);
            Controls.Add(Frame);
            Controls.Add(shopBox);
            Controls.Add(genderBox);
            Controls.Add(SearchButton);
            Controls.Add(textBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchForm";
            Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)SearchButton).EndInit();
            Frame.ResumeLayout(false);
            NoStorePanel.ResumeLayout(false);
            NoStorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox textBox;
        private PictureBox SearchButton;
        private ComboBox genderBox;
        private ComboBox shopBox;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel NoStorePanel;
        private static FlowLayoutPanel Frame;
    }
}