using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace THECRIMS_BOT
{
    public class JS_Gecis
    {
        #region
        public string sc_texte_gore_listeye_tikla = "var el=document.getElementById('singlerobbery-select-robbery');el.selectedIndex={0};";
        public string soygun_menusune_git = "var el=document.getElementById('menu-robbery');el.click();";
        public string id_password_gir = "var el=document.querySelector(\"[name='username'][placeholder='Username']\");el.value=\"{0}\";var el2=document.querySelector(\"[name='password'][placeholder='Password']\");el2.value=\"{1}\";var el=document.querySelector(\"[class='btn btn-large btn-inverse btn-block'][type='submit']\").click();";
        public string sayfa_yuklendi_mi = "document.readyState;";
        public string reload = "location.reload();";
        public string full_stamina_toggle = "var el=document.querySelector(\"[for='full-stamina-robbery-toggle']\").click();";
        public string koordinat_al_X = "var el=document.getElementById('singlerobbery-select-robbery');var coord=el.getBoundingClientRect();coord.x;";
        public string koordinat_al_Y = "var el=document.getElementById('singlerobbery-select-robbery');var coord=el.getBoundingClientRect();coord.y;";
        public string koordinat_al_width = "var el=document.getElementById('singlerobbery-select-robbery');var coord=el.getBoundingClientRect();coord.width;";
        public string koordinat_al_height = "var el=document.getElementById('singlerobbery-select-robbery');var coord=el.getBoundingClientRect();coord.height;";

        public string stamina_al = "var el = document.getElementsByClassName(\"AI8gJpfqwFNYI7UQIdIKXg==\");\r\nel[{0}].getAttributeNames();\r\nvar t1 = el[{0}].getAttribute('style');\r\nt1 = t1.replace(\"width: \", \"\");";
        public string addiction_al = "var el=document.getElementsByClassName(\"m+0rywACk0dJh3Za1YRM2w==\");\r\nel[0].getAttributeNames();\r\nvar t1 = el[0].getAttribute('style');\r\nt1 =t1.replace(\"width: \",\"\");\r\nt1;";
        public string stat_al = "var el=document.getElementsByClassName(\"menuyellowtext\");el[{0}].innerText;";
        // public string check_giris_ekrani = "var el=document.getElementsByClassName('front-header');el[0].innerText;";
        // public string check_robbery_ekrani = "var el=document.getElementsByClassName('sectioninfo');console.log(el[0].innerText);";
        #endregion



        Microsoft.Web.WebView2.WinForms.WebView2 webView;

        public JS_Gecis(Microsoft.Web.WebView2.WinForms.WebView2 ww)
        {

            webView = ww;
        }
        

        #region
        //public async Task<String> FindElementById_EnterValue(string id, string value)
        //{

        //    var result = await webView.ExecuteScriptAsync("var element=document.getElementById('" + id + "').value = '" + value + "';");
        //    string element = result.ToString();
        //    return element;
        //}

        //public async Task<string> FindElementByAttiribute_Read(string att_name, string att_val)
        //{

        //    //string sc= "document.querySelector('[placeholder=\"Username\"][required=\"required\"][data-custom-attribute=\"value\"]');";

        //    string sc = String.Format("var element = document.querySelector('[{0}=" + att_val + "]'); element.value;", att_name, att_val);
        //    var result = await webView.ExecuteScriptAsync(sc);
        //    string res = result.ToString();
        //    return res;

        //}

        //public async Task<object> FindElementByAttiribute_Write(string att_name, string att_val, string yazilacak_data)
        //{

        //    //string sc= "document.querySelector('[placeholder=\"Username\"][required=\"required\"][data-custom-attribute=\"value\"]');";

        //    string sc = String.Format("var element = document.querySelector('[{0}=" + att_val + "]'); element.value = '{2}';", att_name, att_val, yazilacak_data);
        //    var result = await webView.ExecuteScriptAsync(sc);
        //    string res = result.ToString();
        //    return res;
        //}

        //public async Task<string> FindElementByAttiribute_Read(string att_name, string att_val, string att_name_2, string att_val_2)
        //{

        //    //string sc= "document.querySelector('[placeholder=\"Username\"][required=\"required\"][data-custom-attribute=\"value\"]');";

        //    string sc = String.Format("var element = document.querySelector('[{0}=" + att_val + "][{2}=" + att_val_2 + "]'); element.value;", att_name, att_val, att_name_2, att_val_2);
        //    var result = await webView.ExecuteScriptAsync(sc);
        //    string res = result.ToString();
        //    return res;

        //}

        //public async void FindElementByAttiribute_Write(string att_name, string att_val, string att_name_2, string att_val_2, string yazilacak_data)
        //{

        //    //string sc= "document.querySelector('[placeholder=\"Username\"][required=\"required\"][data-custom-attribute=\"value\"]');";

        //    string sc = String.Format("var element = document.querySelector('[{0}=" + att_val + "][{2}=" + att_val_2 + "]'); element.value = '{2}';", att_name, att_val, att_name_2, att_val_2, yazilacak_data);
        //    var result = await webView.ExecuteScriptAsync(sc);
        //    string res = result.ToString();

        //}
  

       
        //public async Task<List<string>> FindElementsByAttributeAsync(string att_name, string att_val)
        //{

        //    //string sc = "var elements = document.querySelectorAll('["+ att_name + "="+ att_val+ "]');";
        //    string sc = "var elements = document.querySelectorAll('[" + att_name + "=\"" + att_val + "\"]'); elements;";

        //    var result = await webView.ExecuteScriptAsync(sc);

        //    // result, NodeList koleksiyonunu içerir, bunu işleyerek döndürelim
        //    List<string> elementList = new List<string>();
        //    if (result != null)
        //    {
        //        var elements = result.ToString().Split(',');
        //        elementList.AddRange(elements);
        //    }







        //    return elementList;
        //}
        #endregion

        public async Task<Dictionary<string,int>> soygun_listesi_getirAsync()
        {
            await sayfa_hazir_waitAsync();
            string sc = "var selectElement = document.getElementById('singlerobbery-select-robbery'); selectElement.length;";
            var result = await webView.ExecuteScriptAsync(sc);
            int numberofelements=int.Parse(result.ToString());
            Dictionary<string,int> list =new Dictionary<string, int>();

            for (int i = 0; i < numberofelements; i++)
            {

                sc = $"selectElement[{i}].innerText";
                result = await webView.ExecuteScriptAsync(sc);
                string res = result.ToString();
                if (res.Contains("SP")) 
                {
                    list.Add(res.Substring(11, res.Length - 20), i);
                }
                
            }
            return list;   
            
        }


        public async Task<object> script_uygula(string sc)
        {
            await sayfa_hazir_waitAsync();
            var result = await webView.ExecuteScriptAsync(sc);
            await sayfa_hazir_waitAsync();
            return result;
        }
        public async Task<object> script_uygula(string sc, string arg1)
        {
            await sayfa_hazir_waitAsync();
            string hzr = string.Format(sc, arg1);
            var result = await webView.ExecuteScriptAsync(hzr);
            await sayfa_hazir_waitAsync();
            return result;
        }
        public async Task<object> script_uygula(string sc, string arg1, string arg2)
        {
            await sayfa_hazir_waitAsync();
            string hzr = string.Format(sc, arg1, arg2);
            var result = await webView.ExecuteScriptAsync(hzr);
            await sayfa_hazir_waitAsync();
            return result;

        }
        public async Task<object> script_uygula(string sc, string arg1, string arg2, string arg3)
        {
            await sayfa_hazir_waitAsync();
            string hzr =string.Format(sc, arg1, arg2, arg3);
            var result = await webView.ExecuteScriptAsync(hzr);
            await sayfa_hazir_waitAsync();
            return result;
        }

        private async Task sayfa_hazir_waitAsync()
        {
            string txt = string.Empty;
            int timeout = 0;
            while(true) 
            {
                txt=await webView.ExecuteScriptAsync(sayfa_yuklendi_mi);

                if(txt == "\"complete\"") { break; }
                else
                {
                    timeout++;
                    if (timeout > 5000000)
                    {
                        await webView.ExecuteScriptAsync(reload);
                        timeout = 0;
                    }
                }
            }
        }

        #region
        //\"Welcome to a new reality!\"


        //public async Task giris_ekrani_check()
        //{
        //    await sayfa_hazir_waitAsync();
        //    string txt = string.Empty;
        //    while (true)
        //    {
        //        txt =await webView.ExecuteScriptAsync(check_giris_ekrani);
        //        if (txt != "\"Welcome to a new reality!\"")
        //        {
        //            break;
        //        }
        //    }
        //}

        //public async Task robbery_ekrani_check()
        //{
        //    await sayfa_hazir_waitAsync();
        //    string txt = string.Empty;
        //    while (true)
        //    {
        //        txt = await webView.ExecuteScriptAsync(check_giris_ekrani);
        //        if (txt != "\"Rumor says that the perfect crime is to stab someone with an icicle. Self-destructing evidence...Make it fast and clean then maybe you will get away with some fresh dineros. Some crimes are too hard to handle by your own, to succeed you will need help from your homies in the gang. You will discover more and harder robberies after completing new levels!\"")
        //        {
        //            break;
        //        }
        //    }
        //}
        #endregion
    }
}
