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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = 0; // Koni tabanının yarıçapı
            int h = 0; // Koni yüksekliği
            int a = 0; // Koninin üçgenin tabanının uzunluğu

            r = Convert.ToInt32(textBox1.Text);
            h = Convert.ToInt32(textBox2.Text);
            a = Convert.ToInt32(textBox3.Text);

            int pi = 3; // Pi değeri
            int sonuc = 0;

            sonuc = pi * r * r;
            label5.Text = "Taban Alanı: " + sonuc.ToString();

            sonuc = pi * r * a; // Yanal Alanı hesaplaması değiştirildi
            label4.Text = "Yanal Alan: " + sonuc.ToString();

            sonuc = pi * r * r + pi * r * a; // Toplam Yüzey Alanı hesaplaması değiştirildi
            label7.Text = "Toplam Yüzey Alanı: " + sonuc.ToString();

            sonuc = (int)((1.0 / 3.0) * pi * r * r * h);
            label6.Text = "Koni Hacmi: " + sonuc.ToString();
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

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Yellow;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the Enter key from being processed by the current TextBox
                textBox2.Focus(); // Move focus to the next TextBox (textBox2 in this example)
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the Enter key from being processed by the current TextBox
                textBox3.Focus(); // Move focus to the next TextBox (textBox2 in this example)
            }
            if (e. == Keys.Control) 
            {
                e.Handled = true; // Prevent the default behavior of Ctrl + Up Arrow
                textBox1.Focus(); // Move focus to the previous TextBox (textBox1 in this example)
            }
        }
    }
}
