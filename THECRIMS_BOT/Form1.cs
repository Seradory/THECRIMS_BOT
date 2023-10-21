using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace THECRIMS_BOT
{



    public partial class Form1 : Form
    {
        static string kullanici_adi;
        static string kullanici_sifre;
        static bool kullanici_bilgileri_kayitli=false;
        static FileStream kullanici_bilgileri_dosyasi;

        public Form1()
        {
            InitializeComponent();

            if (!(File.Exists(Directory.GetCurrentDirectory() + @"/data.txt")))
            {
                kullanici_bilgileri_dosyasi=File.Create((Directory.GetCurrentDirectory() + @"/data.txt"));
                kullanici_bilgileri_dosyasi.Close();
            }
            else 
            {
                
                if ((File.ReadAllText((Directory.GetCurrentDirectory() + @"/data.txt")).Length > 0)) {
                    kullanici_bilgileri_kayitli=true;
                }            
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {


            if (textBox_id.Text!=string.Empty && textBox_pw.Text!=string.Empty)
                {
                    kullanici_adi=textBox_id.Text;
                    kullanici_sifre=textBox_pw.Text;
                    if (checkBox1.Checked)
                    {
                        File.WriteAllLines("data.txt",[kullanici_adi,kullanici_sifre]);
                    }

                }

                else
                {
                    MessageBox.Show("Kullanıcı Adı Şifre Giriniz", "HATA");
                }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //kullanici_bilgileri_dosyasi = File.Open("data.txt", FileMode.Open, FileAccess.ReadWrite);
            if (kullanici_bilgileri_kayitli && checkBox1.Checked)
            {
                List<string> kullanici_data_list = File.ReadLines("data.txt").ToList();
                kullanici_adi = kullanici_data_list[0];
                kullanici_sifre = kullanici_data_list[1];
                textBox_id.Text=kullanici_adi;
                textBox_pw.Text=kullanici_sifre;

            }

            else
            {
            }

        }
    }
}
