using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpProject
{
    public partial class Hyrje : Form
    {
        List<Panel>listPanel = new List<Panel>();
        int index;
        public Hyrje()
        {
            InitializeComponent();
            Hyrje_Load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index > 0)
                ShowForm(--index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                ShowForm(++index); 
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Hyrje cr = new Hyrje();
            Form1 df = new Form1();
            cr.Close();
            df.Show();
        }
        private void Hyrje_Load(object sender, EventArgs e)
        {

        }
        private void Hyrje_Load()
        {
            listPanel.Add(Page1);
            listPanel.Add(Page2);
            listPanel.Add(Page3);
            ShowForm(0);
        }

        private void ShowForm(int index) {
            foreach (var page in listPanel)
            {
                page.Hide();
                page.SendToBack();
            }
            var pageToShow = listPanel[index];
            pageToShow.Show();

            if (index == listPanel.Count - 1)
            {
                nextButton.Hide();
                prevButton.Show();
            }
            else if (index == 0)
            {
                nextButton.Show();
                prevButton.Hide();
            }
            else {
                nextButton.Show();
                prevButton.Show();
            }
        }
    }
}
