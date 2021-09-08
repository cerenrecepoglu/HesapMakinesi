using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_2.Final_15._12._2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void sadece_rakam(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '+' &&
            e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar != '%' && e.KeyChar != '^';

            if (e.KeyChar == (Char) Keys.Enter)  // enter tuşuna basıldığı zaman
            {
                label1.Text = label1.Text + textBox1.Text;
                esittir();
                textBox1.Text = "";
            }
            else if (e.KeyChar == (43))  // '+' tuşuna basıldığı zaman
            {
                    label1.Text = textBox1.Text;
                    toplama();  
            }
            else if (e.KeyChar == (45))  // '-' tuşuna basıldığı zaman
            {     
                    label1.Text = textBox1.Text;
                    cikarma();           
            }
            else if (e.KeyChar == (42))  // '*' tuşuna basıldığı zaman
            {   
                    label1.Text = textBox1.Text;
                    carpma();   
            }
            else if (e.KeyChar == (47))  // '/' tuşuna basıldığı zaman
            {        
                    label1.Text = textBox1.Text;
                    bolme();
            }
            else if (e.KeyChar == (94))  // '^' tuşuna basıldığı zaman
            {
                label1.Text = textBox1.Text;
                kuvvet();
            }
            else if (e.KeyChar == (37))   // '%' tuşuna basıldığı zaman
            {
                label1.Text = textBox1.Text;
                mod();
            }
            else if (e.KeyChar == (33))   // '!' tuşuna basıldığı zaman
            {
                label1.Text = textBox1.Text;
                faktoriyel();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SONUÇ:")
            {
                textBox1.Text = "7";
                label1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
                label1.Text = label1.Text + "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SONUÇ:")
            {
                textBox1.Text = "8";
                label1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
                label1.Text = label1.Text + "8";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SONUÇ:")
            {
                textBox1.Text = "9";
                label1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
                label1.Text = label1.Text + "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SONUÇ:")
            {
                textBox1.Text = "4";
                label1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
                label1.Text = label1.Text + "4";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SONUÇ:")
            {
                textBox1.Text = "5";
                label1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
                label1.Text = label1.Text + "5";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SONUÇ:")
            {
                textBox1.Text = "6";
                label1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
                label1.Text = label1.Text + "6";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SONUÇ:")
            {
                textBox1.Text = "1";
                label1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                label1.Text = label1.Text + "1";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SONUÇ:")
            {
                textBox1.Text = "2";
                label1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
                label1.Text = label1.Text + "2";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SONUÇ:")
            {
                textBox1.Text = "3";
                label1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
                label1.Text = label1.Text + "3";
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SONUÇ:")
            {
                textBox1.Text = "0";
                label1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
                label1.Text = label1.Text + "0";
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SONUÇ:")
            {
                textBox1.Text = ",";
                label1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
                label1.Text = label1.Text + ",";
            }
        }
        int sayac = 1;
        private void button22_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Bir rakam girmelisiniz");
            }
            else if (textBox1.Text != "0")
            {
                if (sayac == 1)
                {
                    textBox1.Text = "-" + label1.Text.ToString();
                    label1.Text = textBox1.Text.ToString();
                    sayac++;
                }
                else if (sayac == 2)
                {
                    int a = label1.Text.IndexOf("-");

                    if (a == -1)
                    {                  
                        textBox1.Text = label1.Text;
                        label1.Text = textBox1.Text.ToString();
                        sayac--;
                    }
                    else
                    {
                        string degisken = label1.Text.Substring(1);
                        textBox1.Text = degisken;
                        label1.Text = textBox1.Text.ToString();
                        sayac--;
                    }

                }
            }
        }
        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void C_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "SONUÇ:";
        }

        private void silme_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Silinecek bir şey yok");
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        private void bolme1_Click(object sender, EventArgs e)
        {
            bolme();
        }
        
        private void toplama1_Click(object sender, EventArgs e)
        {
            toplama();
        }

        private void cikarma1_Click_1(object sender, EventArgs e)
        {
            cikarma();
        }

        private void carpma1_Click_1(object sender, EventArgs e)
        {
            carpma();
            
        }
        int sayi1 = 0;
        int sayi2 = 0;
        double sayi = 0;
        double sayii = 0;
        private void esittir1_Click_1(object sender, EventArgs e)
        {
            esittir();
        }
        private void toplama()
        {
            if (label1.Text == "SONUÇ:")
            {
                MessageBox.Show("Önce bir sayı girmelisiniz");
            }
            else
            {
                label1.Text = label1.Text + "" + "+";
            } 
            if(label1.Text.IndexOf(",")>0)
            {
                sayi = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else if(label1.Text.IndexOf("+") > 0)
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
            }
        }
        private void cikarma()
        {
            if (label1.Text == "SONUÇ:")
            {
                MessageBox.Show("Önce bir sayı girmelisiniz");
            }
            else
            {
                label1.Text = label1.Text + "" + "-";
            } 
            if (label1.Text.IndexOf(",") > 0)
            {
                sayi = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else if (label1.Text.IndexOf("-") > 0)
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
            }
        }
        private void carpma()
        {
            if (label1.Text == "SONUÇ:")
            {
                MessageBox.Show("Önce bir sayı girmelisiniz");
            }
            else
            {
                label1.Text = label1.Text + "" + "*";
            }
            if (label1.Text.IndexOf(",") > 0)
            {
                sayi = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else if (label1.Text.IndexOf("*") > 0)
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
            }
        }
        private void bolme()
        {
            if (label1.Text == "SONUÇ:")
            {
                MessageBox.Show("Önce bir sayı girmelisiniz");
            }
            else
            {
                label1.Text = label1.Text + "" + "/";
            }
            if (label1.Text.IndexOf(",") > 0)
            {
                sayi = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else if (label1.Text.IndexOf("/") > 0)
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
            }
        }
        int us;
        int kuvvett;
        private void esittir()
        {
            if(label1.Text=="SONUÇ:")
            {
                MessageBox.Show("Önce bir sayı girmelisiniz");
            }
            else
            {
                label1.Text = label1.Text + "" + "=";
            }  
            if (label1.Text.IndexOf("+")>0 && label1.Text.IndexOf(",")>0)
            {
                sayii = Convert.ToDouble(textBox1.Text);
                double toplam = Convert.ToDouble(sayi + sayii);
                label1.Text = label1.Text + toplam.ToString();
            }
            else if(label1.Text.IndexOf("+")>0)
            {
                sayi2 = Convert.ToInt32(textBox1.Text);
                int toplam = Convert.ToInt32(sayi1 + sayi2);
                label1.Text = label1.Text + toplam.ToString();
            }
           else if (label1.Text.IndexOf("-") > 0 && label1.Text.IndexOf(",") > 0)
            {
                sayii = Convert.ToDouble(textBox1.Text);
                double cikarma = Convert.ToDouble(sayi - sayii);
                label1.Text = label1.Text + cikarma.ToString();
            }
            else if(label1.Text.IndexOf("-")>0)
            {
                sayi2 = Convert.ToInt32(textBox1.Text);
                int cikarma = Convert.ToInt32(sayi1 - sayi2);
                label1.Text = label1.Text + cikarma.ToString();
            }
            else if (label1.Text.IndexOf("*") > 0 && label1.Text.IndexOf(",") > 0)
            {
                sayii = Convert.ToDouble(textBox1.Text);
                double carpma = Convert.ToDouble(sayi + sayii);
                label1.Text = label1.Text + carpma.ToString();
            }
            else if(label1.Text.IndexOf("*")>0)
            {
                sayi2 = Convert.ToInt32(textBox1.Text);
                int carpma = Convert.ToInt32(sayi1 * sayi2);
                label1.Text = label1.Text + carpma.ToString();
            }
            else if (label1.Text.IndexOf("/") > 0 && label1.Text.IndexOf(",") > 0)
            {
                sayii = Convert.ToDouble(textBox1.Text);
                double bolme = Convert.ToDouble(sayi + sayii);
                label1.Text = label1.Text + bolme.ToString();
            }
            else if(label1.Text.IndexOf("/")>0)
            {
                sayi2 = Convert.ToInt32(textBox1.Text);
                int bolme = Convert.ToInt32(sayi1 / sayi2);
                label1.Text = label1.Text + bolme.ToString();
            }
            else if (label1.Text.IndexOf("^") > 0)
            {
                us = Convert.ToInt32(textBox1.Text);
                label1.Text = label1.Text + Math.Pow(kuvvett,us);
            }
            else if(label1.Text.IndexOf("%") > 0)
            {
                sayi2 = Convert.ToInt32(textBox1.Text);
                label1.Text = label1.Text + Convert.ToInt32(sayi1 % sayi2);
            }
            else if(label1.Text.IndexOf("!") > 0)
            {
                double faktoriyel = 1;

                for (int i = 1; i <= sayi1; i++)
                {
                    faktoriyel = faktoriyel * i;
                }
                label1.Text = label1.Text + faktoriyel.ToString();
            }
        }
        private void Kare_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Önce bir sayı girmelisiniz");
            }
            else
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
                label1.Text = sayi1 + " * " + sayi1 + " = " + Convert.ToInt32(sayi1 * sayi1).ToString();
            }

        }
        private void Kuvvet_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Önce bir sayı girmelisiniz");
            }
            else
            {
                kuvvet();
            }
        }
        private void kuvvet()
        {
            kuvvett = Convert.ToInt32(textBox1.Text);
            label1.Text = kuvvett + "^";
            textBox1.Text = "";
        }
        private void Karekok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Önce bir sayı girmelisiniz");
            }
            else
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
                label1.Text = sayi1 + "=" + Math.Sqrt(sayi1);
            }  
        }
        private void Mod_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Önce bir sayı girmelisiniz");
            }
            else
            {
                mod();
            }
        }
        private void mod()
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            label1.Text = sayi1 + "%";
            textBox1.Text = "";
        }
        private void Faktoriyel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Önce bir sayı girmelisiniz");
            }
            else
            {
                faktoriyel();
            }
        }
        private void faktoriyel()
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            label1.Text = sayi1 + "!";
            textBox1.Text = "";
        }
    }
}

