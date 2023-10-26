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

        //int secim = 0;

        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            hesapla();
        }

        private void hesapla()
        {
            if (hata1(textBox1.Text, textBox2.Text) == -1)
            {
                return;
            }
            int vize1 = Convert.ToInt32(textBox1.Text);
            int final = Convert.ToInt32(textBox2.Text);
            double sonuc = vize1 * 0.4 + final * 0.6;
            label11.Text = Convert.ToString(sonuc);

            if (sonuc >= 60)
            {
                label11.BackColor = Color.LightPink;
                label10.BackColor = Color.LightPink;
                label8.BackColor = Color.LightPink;
                label9.BackColor = Color.BlueViolet;
                label9.Text = "GEÇTİ";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = false;

                if (sonuc >= 60 && sonuc <= 69)
                {
                    label8.Text = "CC";
                }
                else if (sonuc >= 70 && sonuc <= 74)
                {
                    label8.Text = "CB";
                }
                else if (sonuc >= 75 && sonuc <= 79)
                {
                    label8.Text = "BB";
                }
                else if (sonuc >= 80 && sonuc <= 84)
                {
                    label8.Text = "BA";
                }
                else if (sonuc >= 85 && sonuc <= 100)
                {
                    label8.Text = "AA";
                }
            }
            else
            {
                label11.BackColor = Color.LightPink;
                label10.BackColor = Color.LightPink;
                label8.BackColor = Color.LightPink;
                label9.BackColor = Color.BlueViolet;
                label8.Text = "FF";
                label9.Text = "KALDI";
                label10.Text = "büt notunu giriniz";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = true;
                button1.Text = "hesapla2";
                button1.BackColor = Color.Green;
            }

            // Büt notu girildiğinde hesaplamaları yap
            if (textBox3.Enabled)
            {
                int but;
                if (int.TryParse(textBox3.Text, out but))
                {
                    sonuc = vize1 * 0.4 + but * 0.6;
                    label11.Text = Convert.ToString(sonuc);

                    if (sonuc >= 60)
                    {
                        label11.BackColor = Color.Goldenrod;
                        label10.BackColor = Color.Goldenrod;
                        label8.BackColor = Color.Goldenrod;
                        label9.BackColor = Color.Goldenrod;
                        label10.Text = "";
                        label9.Text = "GEÇTİ";
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        button1.Enabled = false;
                        textBox3.Enabled = false;

                        if (sonuc >= 60 && sonuc <= 69)
                        {
                            label8.Text = "CC";
                        }
                        else if (sonuc >= 70 && sonuc <= 74)
                        {
                            label8.Text = "CB";
                        }
                        else if (sonuc >= 75 && sonuc <= 79)
                        {
                            label8.Text = "BB";
                        }
                        else if (sonuc >= 80 && sonuc <= 84)
                        {
                            label8.Text = "BA";
                        }
                        else if (sonuc >= 85 && sonuc <= 100)
                        {
                            label8.Text = "AA";
                        }
                    }
                    else
                    {
                        textBox3.Enabled = false;
                        button1.Enabled = false;
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            button1.Enabled = true;
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

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Yellow;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }
        private int hata1(String vize_str, String final_str)
        {
            if (vize_str.Equals("") || final_str.Equals(""))
            {
                MessageBox.Show("Vize ve final boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            int vize = Convert.ToInt32(vize_str);
            int final = Convert.ToInt32(final_str);
            if (vize > 100 || final > 100)
            {
                MessageBox.Show("Vize ve final notu 0-100 arasında olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return 0;
        }


    }
}


