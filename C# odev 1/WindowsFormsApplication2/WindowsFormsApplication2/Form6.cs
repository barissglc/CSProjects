using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = 0; 

            r = Convert.ToInt32(textBox1.Text);

            int pi = 3; // Pi değeri
            double sonuc = 0;

           
            sonuc = (4.0 / 3.0) * pi * r * r * r;
            label2.Text = "Küre Hacmi: " + sonuc.ToString();

            
            sonuc = 4 * pi * r * r;
            label3.Text = "Küre Yüzey Alanı: " + sonuc.ToString();

            
            sonuc = pi * r * r;
            label4.Text = "Küre Kesit Alanı: " + sonuc.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
    }
}
