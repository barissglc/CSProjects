using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int a = 0;
        int b = 0;
        int c = 0;
        int sonucCevre = 0;
        int sonucAlan = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            sonucCevre = a + b + c;
            textBox4.Text = sonucCevre.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox12.Text);
            b = Convert.ToInt32(textBox11.Text);
            sonucAlan = b * a * a;
            sonucCevre = 2 * a * b;
            textBox9.Text = sonucAlan.ToString();
            textBox10.Text = sonucCevre.ToString();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox8.Text); // veri aldik
            b = Convert.ToInt32(textBox6.Text); // veri aldik
            sonucCevre = (a + b);
            sonucAlan =  (a * b);
            textBox5.Text = sonucCevre.ToString();
            textBox7.Text = sonucAlan.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox16.Text);
            sonucAlan = a * a;
            sonucCevre = a * 4;
            textBox13.Text = sonucAlan.ToString();
            textBox14.Text = sonucCevre.ToString();

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
