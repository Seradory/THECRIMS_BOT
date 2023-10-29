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
using Microsoft.Web.WebView2.Core;
using System.Threading;
using System.Runtime.InteropServices;
using System.Reflection;

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
        JS_Gecis js;
        public Form1()
        {
            InitializeComponent();
            try
            {
                
                thecrims_page = new web();
                web = thecrims_page.webView21;

                js=new JS_Gecis(web);
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
            //var x = 674+130;
            //var y = 215+22;

            var x = 245 + 90;
            var y = 241 + 8;

            var x_form = thecrims_page.Left;
            var y_form = thecrims_page.Top;

            var x_form_web = web.Left;
            var y_form_web = web.Top;
            
            Click(x_form + x + x_form_web, y_form + y + y_form_web);
            Click(x_form + x + x_form_web, y_form + y + y_form_web);
            thecrims_page.Activate(); // Child formunu aktif hale getir
            SendKeys.Send("{DOWN}");
            //SendKeys.SendWait(Keys.Down.ToString());


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
                    //this.Close();
                   
                }
            #endregion

            var res1=await js.script_uygula(js.id_password_gir, kullanici_adi, kullanici_sifre);
            //await js.giris_ekrani_check();
            var res=await js.script_uygula(js.soygun_menusune_git);
            //await js.script_uygula(js.reload);
            var list_dict=await js.soygun_listesi_getirAsync();
            listBox_soygun_listesi.Items.Clear();
            foreach (var item in list_dict)
            {
                listBox_soygun_listesi.Items.Add(item.Key);
            }
            //await js.robbery_ekrani_check();
            button_soygun_yap.Enabled = true;
            checkBox_use_all_stamina.Enabled = true;
            button_login.Enabled = false;
            await stat_guncelle();


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

        private void listBox_soygun_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a=js.script_uygula(js.sc_texte_gore_listeye_tikla, (listBox_soygun_listesi.SelectedIndex).ToString());
            soygunu_real_sec();
        }

        private void button_soygun_yap_Click(object sender, EventArgs e)
        {
            
        }



        private async void checkBox_use_all_stamina_CheckedChangedAsync(object sender, EventArgs e)
        {
            await js.script_uygula(js.full_stamina_toggle);
        }



        //private void listBox_soygun_listesi_SelectedIndexChangedAsync(object sender, EventArgs e)
        //{
        //   // _=js.script_uygulaAsync(js.sc_texte_gore_listeye_tikla, listBox_soygun_listesi.SelectedIndex.ToString());


        //}









       
        
            [DllImport("user32.dll")]
            public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

            private const int MOUSEEVENTF_LEFTDOWN = 0x02;
            private const int MOUSEEVENTF_LEFTUP = 0x04;
        
            public static void Click(int x, int y)
            {
                int top_offset = 25;
                var old_position = Cursor.Position;
                Cursor.Position = new System.Drawing.Point(x, y+ top_offset);
                
                Thread.Sleep(1);
                mouse_event(MOUSEEVENTF_LEFTDOWN, x, y+top_offset, 0, 0);
                
                mouse_event(MOUSEEVENTF_LEFTUP, x, y+top_offset, 0, 0);
                Cursor.Position=old_position;
            }



        public async void soygunu_real_sec()
        {
            
            int x=int.Parse((string)await js.script_uygula(js.koordinat_al_X));
            int y = int.Parse((string)await js.script_uygula(js.koordinat_al_Y));
            int width = int.Parse((string)await js.script_uygula(js.koordinat_al_width));
            int height = int.Parse((string)await js.script_uygula(js.koordinat_al_height));
            width = width / 2;
            height = height / 2;
            

            bool visible = thecrims_page.Visible;
            if (!thecrims_page.Visible) { thecrims_page.Show();}
            while (true) {
                if (thecrims_page.Visible) { break; }
            }

             // Child formunu aktif hale getir
            var x_form = thecrims_page.Left;
            var y_form = thecrims_page.Top;

            var x_form_web = web.Left;
            var y_form_web = web.Top;
            thecrims_page.Activate();
            Click(x_form + x + x_form_web+ width, y_form + y + y_form_web+ height);
            //Click(x_form + x + x_form_web + width, y_form + y + y_form_web + height);

            SendKeys.Send("{DOWN}");
            Click(x_form + x + x_form_web + width, y_form + y + y_form_web + height);
            if (!visible) { Thread.Sleep(10); thecrims_page.Hide(); this.Activate(); }

        }
        

        public async Task stat_guncelle()
        {
            string stamina=(string)await js.script_uygula(js.stamina_al,"0");
            string hp = (string)await js.script_uygula(js.stamina_al,"1");
            string bagimlilik = (string)await js.script_uygula(js.addiction_al);
            string sayginlik = (string)await js.script_uygula(js.stat_al,"4");
            string bilet = (string)await js.script_uygula(js.stat_al, "7");
            string zeka = (string)await js.script_uygula(js.stat_al, "8");
            string karizma = (string)await js.script_uygula(js.stat_al, "11");
            string guc = (string)await js.script_uygula(js.stat_al, "13");
            string tolerans = (string)await js.script_uygula(js.stat_al, "15");
            string para = (string)await js.script_uygula(js.stat_al, "17");
            string tekil_soygun_gucu = (string)await js.script_uygula(js.stat_al, "20");
            string cete_soygun_gucu = (string)await js.script_uygula(js.stat_al, "22");

            label_bagimlilik.Text = bagimlilik;
            label_hp.Text = hp;
            label_int.Text = zeka;
            label_stamina.Text = stamina;
            label_str.Text = guc;
            label_tickets.Text = bilet;
            label_karizma.Text= karizma;
            label_tolerans.Text = tolerans;
            label_para.Text = para; 
            label_soygun_gucu.Text=tekil_soygun_gucu;

        }
    }
}
