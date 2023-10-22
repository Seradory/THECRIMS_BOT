using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HtmlAgilityPack;
using System.Windows.Forms;

namespace THECRIMS_BOT
{
    public class JS_Gecis
    {

        Microsoft.Web.WebView2.WinForms.WebView2 webView;

        public JS_Gecis(Microsoft.Web.WebView2.WinForms.WebView2 ww)
        {

            webView = ww;
        }

        public async Task<String> FindElementById_EnterValue(string id, string value)
        {

            var result = await webView.ExecuteScriptAsync("var element=document.getElementById('" + id + "').value = '" + value + "';");
            string element = result.ToString();
            return element;
        }

        public async Task<string> FindElementByAttiribute_Read(string att_name, string att_val)
        {

            //string sc= "document.querySelector('[placeholder=\"Username\"][required=\"required\"][data-custom-attribute=\"value\"]');";

            string sc = String.Format("var element = document.querySelector('[{0}=" + att_val + "]'); element.value;", att_name, att_val);
            var result = await webView.ExecuteScriptAsync(sc);
            string res = result.ToString();
            return res;

        }

        public async void FindElementByAttiribute_Write(string att_name, string att_val, string yazilacak_data)
        {

            //string sc= "document.querySelector('[placeholder=\"Username\"][required=\"required\"][data-custom-attribute=\"value\"]');";

            string sc = String.Format("var element = document.querySelector('[{0}=" + att_val + "]'); element.value = '{2}';", att_name, att_val, yazilacak_data);
            var result = await webView.ExecuteScriptAsync(sc);
            string res = result.ToString();

        }

        public async Task<string> FindElementByAttiribute_Read(string att_name, string att_val, string att_name_2, string att_val_2)
        {

            //string sc= "document.querySelector('[placeholder=\"Username\"][required=\"required\"][data-custom-attribute=\"value\"]');";

            string sc = String.Format("var element = document.querySelector('[{0}=" + att_val + "][{2}=" + att_val_2 + "]'); element.value;", att_name, att_val, att_name_2, att_val_2);
            var result = await webView.ExecuteScriptAsync(sc);
            string res = result.ToString();
            return res;

        }

        public async void FindElementByAttiribute_Write(string att_name, string att_val, string att_name_2, string att_val_2, string yazilacak_data)
        {

            //string sc= "document.querySelector('[placeholder=\"Username\"][required=\"required\"][data-custom-attribute=\"value\"]');";

            string sc = String.Format("var element = document.querySelector('[{0}=" + att_val + "][{2}=" + att_val_2 + "]'); element.value = '{2}';", att_name, att_val, att_name_2, att_val_2, yazilacak_data);
            var result = await webView.ExecuteScriptAsync(sc);
            string res = result.ToString();

        }


        #region
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

        public async Task soygun_listesi_getirAsync()
        {
            
            //string sc = "var selectElement = document.getElementById('singlerobbery-select-robbery'); selectElement.innerHTML;";
            string sc = "var selectElement = document.getElementById('content_left'); selectElement.innerHTML;";
            var result = await webView.ExecuteScriptAsync(sc);






        }
    }
}
