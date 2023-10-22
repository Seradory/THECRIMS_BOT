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
using Microsoft.Web.WebView2.WinForms;

namespace THECRIMS_BOT
{



    public partial class Form1 : Form
    {
        static string kullanici_adi;
        static string kullanici_sifre;
        static bool kullanici_bilgileri_kayitli=false;
        static FileStream kullanici_bilgileri_dosyasi;
        static web thecrims_page;
        WebView2 web;
        public Form1()
        {
            InitializeComponent();
            try
            {
                
                thecrims_page = new web();
                web = thecrims_page.webView21;
                
            }
            catch (Exception)
            {

                MessageBox.Show("Siteye Bağlanılamadı.");
            }
            
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

        private async void button_login_Click(object sender, EventArgs e)
        {

            #region 
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
            #endregion

            JS_Gecis login = new JS_Gecis(web);
            login.FindElementByAttiribute_Write("autocomplete", "username", "Serador123");
            string str =await login.FindElementByAttiribute_Read("autocomplete", "username");
            MessageBox.Show(str);


            // var res = await login.FindElementsByAttributeAsync("data-v-1f898bd1", s);
            await login.soygun_listesi_getirAsync();


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

        private void button_unhide_hide_browser_Click(object sender, EventArgs e)
        {
            if (thecrims_page.Visible)
            {
                thecrims_page.Hide();
            }
            else
            {
                thecrims_page.Show();
            }
        }
    }
}
