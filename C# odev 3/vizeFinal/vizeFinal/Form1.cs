using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizeFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Load += new EventHandler(Form_Load);
           
            textBox3.Enabled = false;
            button1.BackColor = Color.LightGreen;
            button2.BackColor = Color.MediumPurple;
            button3.BackColor = Color.MediumPurple;
            button4.BackColor = Color.MediumPurple;
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        //private void Form_Load(object sender, EventArgs e)
        //{
        //    // textBox3'ü devre dışı bırak
        //    textBox3.Enabled = false;
        //}
        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not1, not2;
            if (!int.TryParse(textBox1.Text, out not1) || !int.TryParse(textBox2.Text, out not2))
            {

                MessageBox.Show("Notlar sayısal bir değer olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {

                MessageBox.Show("Lütfen her iki notu da girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            

            
            not1 = Convert.ToInt32(textBox1.Text);
            not2 = Convert.ToInt32(textBox2.Text);
            label9.Text = "";
            int sonuc = (not1 * 40 / 100) + (not2 * 60 / 100);

            if (not1 >= 0 && not1 <= 100 && not2 >= 0 && not2 <= 100)
            {
                if (sonuc >= 60 && sonuc <= 100)
                {
                    label12.Text = Convert.ToString(sonuc);
                    label10.Text = "Geçti";
                    label10.BackColor = Color.Purple;
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
                else
                {
                    label12.Text = Convert.ToString(sonuc);
                    label10.Text = "KALDI";
                    label10.BackColor = Color.Red;
                    label9.Text = "Bütünleme notu giriniz....";
                    label11.Text = "FF";
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
                if (sonuc >= 60 && sonuc <= 69)
                {
                    label11.Text = "CC";
                }
                else if (sonuc >= 70 && sonuc <= 74)
                {
                    label11.Text = "CB";
                }
                else if (sonuc >= 75 && sonuc <= 79)
                {
                    label11.Text = "BB";
                }
                else if (sonuc >= 80 && sonuc <= 84)
                {
                    label11.Text = "BA";
                }
                else if (sonuc >= 85 && sonuc <= 100)
                {
                    label11.Text = "AA";
                }

            }
            else 
            {
                MessageBox.Show("Notlar 0 ile 100 arasında olmalıdır.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label10.Text = "";
            label9.Text = "";
            label11.Text = "";
            label12.Text = "";
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            int not1 = Convert.ToInt32(textBox1.Text);
            if (string.IsNullOrEmpty(textBox3.Text))
            {

                MessageBox.Show("Lütfen her iki notu da girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int not3 = Convert.ToInt32(textBox3.Text);
            if (not3 < 0 || not3 > 100) //neden böyle anlamadım :D :D
            {
                MessageBox.Show("Bütünleme notu 0 ile 100 arasında olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //int not2 = Convert.ToInt32(textBox2.Text);
            label9.Text = "";
            int sonuc = (not1 * 40 / 100) + (not3 * 60 / 100);
            if (sonuc >= 60 && sonuc <= 100)
            {
                label12.Text = Convert.ToString(sonuc);
                label10.Text = "Geçti";
                label10.BackColor = Color.Purple;
                button2.Enabled = false;
            }
            else
            {
                label12.Text = Convert.ToString(sonuc);
                label10.Text = "KALDI";
                label10.BackColor = Color.Red;
                //label9.Text = "Bütünleme notu giriniz....";
                label11.Text = "FF";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = true;
                button1.Enabled = false;
            
            }
            if (sonuc >= 60 && sonuc <= 69)
            {
                label11.Text = "CC";
            }
            else if (sonuc >= 70 && sonuc <= 74)
            {
                label11.Text = "CB";
            }
            else if (sonuc >= 75 && sonuc <= 79)
            {
                label11.Text = "BB";
            }
            else if (sonuc >= 80 && sonuc <= 84)
            {
                label11.Text = "BA";
            }
            else if (sonuc >= 85 && sonuc <= 100)
            {
                label11.Text = "AA";
            }
            textBox3.Enabled = false;
        }

    }
}
