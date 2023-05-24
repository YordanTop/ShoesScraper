using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesScraper.Collection;
using ShoesScraper.ScraperModel;
using ShoesScraper.ShopsTemplates;

namespace ShoesScraper
{
    public partial class SearchForm : Form
    {
        private string Gender { get; set; } 
        private string Shop { get; set; }
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string getProp = textBox.Text;
            if (Gender == null || Shop == null || getProp.Equals(String.Empty))
            {
                SearchForm.ItemError("Your input is not \ncorrect!");
            }
            else
            {

                if (Shop.Equals("Glami"))
                {
                    using (Scraper scraper = new Scraper(new GlamiShop(getProp, Gender)))
                    {
                        scraper.DisplayItem();
                    }
                    Frame.Controls.Clear();

                }
                else

                if (Shop.Equals("Zappos"))
                {
                    using (Scraper scraper = new Scraper(new Zappos(getProp, Gender)))
                    {
                        scraper.DisplayItem();
                    }
                    Frame.Controls.Clear();
                }
            }


        }

        private void genderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genderBox.Text.Equals(null))
            {
                Gender = "Male";
            }
            else
            Gender = genderBox.Text;
        }

        private void shopBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (shopBox.Text.Equals(null))
            {
                Shop = "Glame";
            }
            else
                Shop = shopBox.Text;

        }

        public static void ItemError(string message)
        {
            Label notFoundLabel = new Label();
            PictureBox notFoundIcon = new PictureBox();
            Panel notFoundPanel = new Panel();

            Frame.Controls.Clear();

            Frame.Controls.Add(notFoundPanel);
            notFoundPanel.Controls.Add(notFoundLabel);
            notFoundPanel.Controls.Add(notFoundIcon);

            notFoundPanel.Location = new Point(3, 3);
            notFoundPanel.Name = "NoStorePanel";
            notFoundPanel.Size = new Size(581, 364);
            notFoundPanel.TabIndex = 6;

            notFoundLabel.AutoSize = true;
            notFoundLabel.BackColor = Color.White;
            notFoundLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            notFoundLabel.ForeColor = SystemColors.ButtonShadow;
            notFoundLabel.Location = new Point(149, 266);
            notFoundLabel.Name = "label1";
            notFoundLabel.Size = new Size(274, 38);
            notFoundLabel.TabIndex = 1;

            notFoundIcon.BackgroundImageLayout = ImageLayout.Zoom;
            notFoundIcon.Location = new Point(97, 10);
            notFoundIcon.Name = "pictureBox1";
            notFoundIcon.Size = new Size(366, 253);
            notFoundIcon.SizeMode = PictureBoxSizeMode.Zoom;
            notFoundIcon.TabIndex = 0;
            notFoundIcon.TabStop = false;


            notFoundLabel.Text = message;
            notFoundIcon.Image = Properties.Resources.searching;
        }
        /// <summary>
        /// This function displays the Shoes Item based of the paramenters.
        /// </summary>
        /// <param name="item">The product content.</param>
        /// <param name="x">Position X.</param>
        /// <param name="y">Position Y.</param>
        public static void ShoesFrame(Product item, int x, int y)
        {
            var frame = new Panel();
            var iconPanel = new Panel();
            var price = new Label();
            var hearthIcon = new PictureBox();
            var infoIcon = new PictureBox();
            var itemPicture = new PictureBox();


            Frame.Invoke(() =>
            {

                Frame.Controls.Add(frame);
                frame.BackColor = Color.White;
                frame.Location = new Point(x, y);
                frame.Size = new Size(136, 145);
                frame.BorderStyle = BorderStyle.FixedSingle;
                frame.Controls.Add(iconPanel);
                frame.Controls.Add(itemPicture);
                frame.Controls.Add(price);


                iconPanel.Height = 30;
                iconPanel.Dock = DockStyle.Bottom;
                iconPanel.BackColor = Color.FromArgb(255, 204, 153);

                iconPanel.Controls.Add(hearthIcon);
                iconPanel.Controls.Add(infoIcon);

                hearthIcon.BackgroundImage = Properties.Resources.heart__1_;
                hearthIcon.BackgroundImageLayout = ImageLayout.Zoom;
                hearthIcon.Location = new Point(85, 5);
                hearthIcon.Size = new Size(23, 23);

                hearthIcon.MouseHover += HearthIcon_MouseHover;

                hearthIcon.MouseLeave += HearthIcon_MouseLeave;

                hearthIcon.Click += HearthIcon_Click;

                infoIcon.BackgroundImage = Properties.Resources.clipboard;
                infoIcon.BackgroundImageLayout = ImageLayout.Zoom;
                infoIcon.Location = new Point(25, 3);
                infoIcon.Size = new Size(23, 23);

                itemPicture.Load(item.Img);
                itemPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                itemPicture.BackgroundImageLayout = ImageLayout.Zoom;

                itemPicture.Location = new Point(10, 0);
                itemPicture.Size = new Size(120, 120);

                price.Text = "Description: " + item.Price;
                price.Font = new Font("Segoe UI Symbol", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
                price.Dock = DockStyle.Fill;
                price.Visible = false;

            });


            void HearthIcon_MouseLeave(object? sender, EventArgs e)
            {
                hearthIcon.BackgroundImage = Properties.Resources.heart__1_;
            }

            void HearthIcon_MouseHover(object? sender, EventArgs e)
            {
                hearthIcon.BackgroundImage = Properties.Resources.heart;
            }

            void HearthIcon_Click(object? sender, EventArgs e)
            {
                if (item.isLiked == false)
                {
                    hearthIcon.BackgroundImage = Properties.Resources.heart;
                    hearthIcon.MouseHover -= HearthIcon_MouseHover;
                    hearthIcon.MouseLeave -= HearthIcon_MouseLeave;
                    item.isLiked = true;
                    UserForm.products.Add(frame);
                }
                else
                {
                    hearthIcon.BackgroundImage = Properties.Resources.heart__1_;
                    hearthIcon.MouseHover += HearthIcon_MouseHover;
                    hearthIcon.MouseLeave += HearthIcon_MouseLeave;
                    item.isLiked = false;
                    UserForm.products.Remove(frame);
                }

            }

        }
    }
}
