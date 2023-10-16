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
    public partial class Form2 : Form
    {
        int a = 0;
        int sonuc = 0;
        public Form2()
        {
            InitializeComponent();
        }
        // keyf

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.ForeColor = Color.Red;
            //textBox1.BackColor = Color.Red;
            label2.Text = ("Yüzey Alanı : " + Convert.ToString(a * a * 6));
            label2.ForeColor = Color.Red;
            label3.Text = ("Kesit Alanı : " + Convert.ToString(a * a));
            label3.ForeColor = Color.Red;
            label4.Text = ("Küp Hacmi : " + Convert.ToString(a * a * a));
            label4.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }
    }
}
