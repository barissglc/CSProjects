using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesiv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.Text += "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textBox1.BackColor = Color.White;
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.Text += "2";
        }

        public void button4_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            label2.Text = textBox1.Text + "+";
            textBox1.Clear();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "";
            label1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            label2.Text = textBox1.Text + "-";
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            if (label2.Text.EndsWith("+")) {
                int sayi1 = Convert.ToInt32(label2.Text.TrimEnd('+'));
                int sayi2 = Convert.ToInt32(textBox1.Text);
                int sonuc = sayi1 + sayi2;
                label1.Text = sonuc.ToString();
                label2.Text = sonuc.ToString();
            }
            else if (label2.Text.EndsWith("-"))
            {
                int sayi1 = Convert.ToInt32(label2.Text.TrimEnd('-'));
                int sayi2 = Convert.ToInt32(textBox1.Text);
                int sonuc = sayi1 - sayi2;
                label1.Text = sonuc.ToString();
                label2.Text = sonuc.ToString();
            }
            else if (label2.Text.EndsWith("/"))
            {
                int sayi1 = Convert.ToInt32(label2.Text.TrimEnd('/'));
                int sayi2 = Convert.ToInt32(textBox1.Text);
                int sonuc = sayi1 / sayi2;
                label1.Text = sonuc.ToString();
                label2.Text = sonuc.ToString();
            }
            else if (label2.Text.EndsWith("*"))
            {
                int sayi1 = Convert.ToInt32(label2.Text.TrimEnd('*'));
                int sayi2 = Convert.ToInt32(textBox1.Text);
                int sonuc = sayi1 * sayi2;
                label1.Text = sonuc.ToString();
                label2.Text = sonuc.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            textBox1.Text += "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            label2.Text = textBox1.Text + "*";
            textBox1.Clear();
            //textBox1.Text += "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            label2.Text = textBox1.Text + "/";
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        

        
    }
}
