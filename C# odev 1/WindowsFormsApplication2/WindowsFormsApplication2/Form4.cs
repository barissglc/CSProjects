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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = 0; 
            int h = 0; 

            r = Convert.ToInt32(textBox1.Text);
            h = Convert.ToInt32(textBox2.Text);

            int pi = 3; // Pi değeri
            int sonuc = 0; 

            sonuc = pi * r * r;
            label3.Text = "Taban Alanı: " + sonuc.ToString();

            sonuc = 2 * pi * r * h;
            label4.Text = "Yanal Alanı: " + sonuc.ToString();

            sonuc = pi * r * r * h;
            label5.Text = "Silindir Hacmi: " + sonuc.ToString();

            sonuc = 2 * pi * r * h + 2 * pi * r * r;
            label6.Text = "Toplam Yüzey Alanı: " + sonuc.ToString();

            sonuc = pi * r * r;
            label7.Text = "Kesit Alanı: " + sonuc.ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Yellow;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }


        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the Enter key from being processed by the current TextBox
                textBox2.Focus(); // Move focus to the next TextBox (textBox2 in this example)
            }
        }



        // Continue the pattern for additional TextBox controls

    }
}
