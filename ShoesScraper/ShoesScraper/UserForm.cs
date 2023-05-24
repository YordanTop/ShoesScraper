using ShoesScraper.Collection;
using ShoesScraper.ScraperModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesScraper
{
    public partial class UserForm : Form
    {
        internal static List<Panel> products = new List<Panel>();
        public UserForm()
        {
            InitializeComponent();
            ShowProducts();
        }

        public void ShowProducts()
        {
            int productX = 0, productY = 10;

            if (products.Count > 0)
            {
                ItemDisplayer.Controls.Clear();
                NoResult.Visible = false;
            }

            for (int i = 1; i <= products.Count; i++)
            {
                if (i > 1)
                {
                    productX += 145;
                }

                if (i % 5 == 0)
                {
                    productX = 0;
                    productY += 155;
                }
                ItemDisplayer.Controls.Add(products[(i - 1)]);
                products[(i - 1)].Location = new Point(productX, productY);
            }
        }
    }
}
