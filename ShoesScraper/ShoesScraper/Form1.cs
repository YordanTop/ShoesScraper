using System.Diagnostics;
using System.Windows.Forms;

namespace ShoesScraper
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            AddForm(new AboutPage());
        }

        private void AddForm(Form form)
        {
            FormPanel.Controls.Clear();
            form.TopLevel = false;
            FormPanel.Controls.Add(form);
            form.Show();
        }
        private void AboutAppear(object sender, EventArgs e)
        {
            AddForm(new AboutPage());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MakeThread.WebStart("https://github.com/YordanTop");
        }

        private void User_Click(object sender, EventArgs e)
        {
            AddForm(new UserForm());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            AddForm(new SearchForm());
        }


    }
}