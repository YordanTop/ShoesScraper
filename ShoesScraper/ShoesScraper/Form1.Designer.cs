namespace ShoesScraper
{
    partial class Form1
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
            panelMenu = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            about = new Button();
            User = new Button();
            labelName = new Label();
            searchButton = new Button();
            menuIcon = new PictureBox();
            FormPanel = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuIcon).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(255, 204, 153);
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(about);
            panelMenu.Controls.Add(User);
            panelMenu.Controls.Add(labelName);
            panelMenu.Controls.Add(searchButton);
            panelMenu.Controls.Add(menuIcon);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(181, 456);
            panelMenu.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 424);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 6;
            label3.Text = "Dev's GitHub";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Github;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(47, 355);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 67);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // about
            // 
            about.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            about.AutoSize = true;
            about.BackColor = Color.FromArgb(238, 193, 149);
            about.FlatAppearance.BorderColor = Color.Black;
            about.FlatAppearance.BorderSize = 0;
            about.FlatStyle = FlatStyle.Flat;
            about.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            about.Location = new Point(0, 284);
            about.Name = "about";
            about.RightToLeft = RightToLeft.Yes;
            about.Size = new Size(181, 44);
            about.TabIndex = 4;
            about.Text = "About the project";
            about.UseVisualStyleBackColor = false;
            about.Click += AboutAppear;
            // 
            // User
            // 
            User.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            User.AutoSize = true;
            User.BackColor = Color.FromArgb(238, 193, 149);
            User.FlatAppearance.BorderColor = Color.Black;
            User.FlatAppearance.BorderSize = 0;
            User.FlatStyle = FlatStyle.Flat;
            User.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            User.Location = new Point(0, 233);
            User.Name = "User";
            User.RightToLeft = RightToLeft.Yes;
            User.Size = new Size(181, 44);
            User.TabIndex = 3;
            User.Text = "User";
            User.UseVisualStyleBackColor = false;
            User.Click += User_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(0, 125);
            labelName.Name = "labelName";
            labelName.Size = new Size(184, 38);
            labelName.TabIndex = 2;
            labelName.Text = "ShoesScraper";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchButton.AutoSize = true;
            searchButton.BackColor = Color.FromArgb(238, 193, 149);
            searchButton.BackgroundImageLayout = ImageLayout.Zoom;
            searchButton.FlatAppearance.BorderColor = Color.Black;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.ForeColor = Color.Black;
            searchButton.ImageAlign = ContentAlignment.MiddleRight;
            searchButton.Location = new Point(0, 183);
            searchButton.Name = "searchButton";
            searchButton.RightToLeft = RightToLeft.Yes;
            searchButton.Size = new Size(181, 44);
            searchButton.TabIndex = 1;
            searchButton.Text = "Searching";
            searchButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // menuIcon
            // 
            menuIcon.Image = Properties.Resources.Logo;
            menuIcon.Location = new Point(6, 0);
            menuIcon.Name = "menuIcon";
            menuIcon.Size = new Size(169, 153);
            menuIcon.SizeMode = PictureBoxSizeMode.Zoom;
            menuIcon.TabIndex = 0;
            menuIcon.TabStop = false;
            // 
            // FormPanel
            // 
            FormPanel.Dock = DockStyle.Fill;
            FormPanel.Location = new Point(181, 0);
            FormPanel.Name = "FormPanel";
            FormPanel.Size = new Size(635, 456);
            FormPanel.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(816, 456);
            Controls.Add(FormPanel);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(834, 503);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShoesScraper";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private PictureBox menuIcon;
        private Button searchButton;
        private Label labelName;
        private Button User;
        private Button about;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel FormPanel;
    }
}