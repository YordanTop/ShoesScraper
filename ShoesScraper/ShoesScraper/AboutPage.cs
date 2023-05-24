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
    public partial class AboutPage : Form
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void GlamiIcon_Click(object sender, EventArgs e)
        {
            MakeThread.WebStart("https://www.glami.bg/");
        }

        private void ZapposIcon_Click(object sender, EventArgs e)
        {
            MakeThread.WebStart("https://www.zappos.com/");
        }

    }
}
