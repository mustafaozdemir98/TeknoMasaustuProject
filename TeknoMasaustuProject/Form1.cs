using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.IO;

namespace TeknoMasaustuProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSonuc1_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxSonuc.Text = Convert.ToString((Convert.ToInt32(txtBoxSayi1.Text.Trim()) + Convert.ToInt32(txtBoxSayi2.Text.Trim())) * Convert.ToInt32(txtBoxSayi3.Text.Trim()));
            }
            catch (Exception)
            {
                MessageBox.Show("Sayi 1 , Sayi 2 ve Sayi 3 Değerlerini Giriniz.");
            }
            
        }
        private void buttonSayilar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 200; i++)
            {
                listBoxSayilar.Items.Add(i);
                if (i < 100 && i % 15 == 0)
                {
                    listBoxSayilar.Items.Remove(i);
                    listBoxSayilar.Items.Add("zigzag");
                }
                else if (i > 100 && i % 15 == 0)
                {
                    listBoxSayilar.Items.Remove(i);
                    listBoxSayilar.Items.Add("zagzig");
                }
                else if (i % 3 == 0)
                {
                    listBoxSayilar.Items.Remove(i);
                    listBoxSayilar.Items.Add("zig");
                }
                else if (i % 5 == 0)
                {
                    listBoxSayilar.Items.Remove(i);
                    listBoxSayilar.Items.Add("zag");

                }
            }
        }
        private void buttonSonuc3_Click(object sender, EventArgs e)
        {
            try
            {
                var n = Convert.ToInt32(textBoxCT.Text.Trim());
                for (int i = 1; i <= n; i++)
                {
                    string ekle = "";
                    for (int k = 1; k <= n; k++)
                    {
                        int a = (k * i);
                        string x = Convert.ToString(a);

                        if (x.Length == 1)
                            ekle += k + " * " + i + " = " + a + "         ";
                        // Burada sondaki boşlukları hizalamak için kullanıyoruz... Düzgün bir görüntü elde etmek için...
                        else if (a == 108 && i == 9)
                        {
                            ekle += k + " * " + i + " = " + a + "     ";
                        }
                        else if (a == 104 && i == 8)
                        {
                            ekle += k + " * " + i + " = " + a + "     ";
                        }
                        else if (a == 117 && i == 9)
                        {
                            ekle += k + " * " + i + " = " + a + "     ";
                        }
                        else if (a == 112 && i == 8)
                        {
                            ekle += k + " * " + i + " = " + a + "     ";
                        }
                        else if (a == 126 && i == 9)
                        {
                            ekle += k + " * " + i + " = " + a + "     ";
                        }
                        else if (x.Length == 3)
                        {
                            ekle += k + " * " + i + " = " + a + "   ";
                        }

                        else if (i == 13)
                            ekle += k + " * " + i + " = " + a + "     ";
                        else if (i == 14)
                            ekle += k + " * " + i + " = " + a + "     ";
                        else if (i == 15)
                            ekle += k + " * " + i + " = " + a + "     ";



                        else if (i == 10)
                            ekle += k + " * " + i + " = " + a + "     ";

                        else if (i == 11)
                            ekle += k + " * " + i + " = " + a + "     ";
                        else if (i == 12)
                            ekle += k + " * " + i + " = " + a + "     ";


                        else if (x.Length == 2)
                            ekle += k + " * " + i + " = " + a + "       ";

                    }
                    listBoxCT.Items.Add(ekle);
                    ekle = "";
                }
                string cizgiler = "--------------------------------------";
                listBoxCT.Items.Add(cizgiler);

            }
            catch (Exception)
            {
                MessageBox.Show("Girilen Sayi Değerini Giriniz");
            }
        }
        private void buttonDosya_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.ShowDialog();
                string FileName = dosya.FileName;
                string FileText = File.ReadAllText(FileName);
                var c = FileText.Trim(' ').Split(' ');
                double[] sayilar;
                sayilar = Array.ConvertAll(c, i => double.Parse(i));

                double temp = 0;
                var n = sayilar.Length;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (sayilar[i] <= sayilar[j])
                        {
                            temp = sayilar[i];
                            sayilar[i] = sayilar[j];
                            sayilar[j] = temp;
                        }
                    }
                }

                foreach (var item in sayilar)
                {
                    listBoxDosya.Items.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dosya Seçmediniz. Dosya seçiniz.");
            }
        }
        private void buttonFibo_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                int y = 1;
                int sayi = Convert.ToInt32(textBoxFiboSira.Text);
                if (sayi <= 0)
                {
                    textBoxFibo.Text = "Sıfırdan Büyük Sayı Giriniz";
                }
                else if (sayi == 1)
                {
                    int sayi2 = 0;
                    textBoxFibo.Text = sayi2.ToString();
                }
                else if (sayi == 2)
                {
                    int sayi3 = 1;
                    textBoxFibo.Text = sayi3.ToString();
                }
                else
                {
                    for (int i = 3; i <= sayi; i++)
                    {

                        int z = x + y;
                        textBoxFibo.Text = z.ToString();
                        x = y;
                        y = z;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("İstenilen Sırayi Giriniz");
            }
        }

        private void txtBoxSayi1_TextChanged(object sender, EventArgs e)
        {
            //var sayi1 = Convert.ToInt32(Console.ReadLine());
        }

        private void txtBoxSayi2_TextChanged(object sender, EventArgs e)
        {
            //var sayi2 = Convert.ToInt32(Console.ReadLine());
        }

        private void txtBoxSayi3_TextChanged(object sender, EventArgs e)
        {
            //var sayi3 = Convert.ToInt32(Console.ReadLine());
        }

        private void textBoxCT_TextChanged(object sender, EventArgs e)
        {
            //var sayi4 = Convert.ToInt32(Console.ReadLine());
        }

        private void textBoxDosya_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxSayilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxSonuc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
