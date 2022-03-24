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
            Hyrje_Load();
            InitializeComponent();
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
                listPanel[--index].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
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
            listPanel[index].BringToFront();

        }
    }
}
