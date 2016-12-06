using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NitadoMAI
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public class Variables
        {
            public static string clientid = "<CLIENTID>";
            public static string secretid = "<CLIENTSECRET>";
        }
            private void login_Load(object sender, EventArgs e)
        {
            webbro.Navigate(new Uri("https://oauth.nitrado.net/oauth/v2/auth?client_id=" + Variables.clientid + "&scope=service%20user_info%20service_order&redirect_uri=https://nitradomai.marcsrv.de/empty.html&&response_type=code"));
            webbro.DocumentCompleted +=
            new WebBrowserDocumentCompletedEventHandler(webloaded);
        }

        private void webloaded(object sender,WebBrowserDocumentCompletedEventArgs e)
        {

            if (webbro.Url.ToString().Contains("https://nitradomai.marcsrv.de/empty.html?code=") == true)
            {
                string url = webbro.Url.ToString();
                string authtoken = url.Replace("https://nitradomai.marcsrv.de/empty.html?code=", "");
                
                makeaccessrequest(authtoken);


                update updateform = new update();
                updateform.ShowDialog();
                this.Close();
            }

            
            
            
               
            
            
               
           
            

        }



        
        public static string makeaccessrequest(string authtoken)
        {
            string UrlRequest = "https://oauth.nitrado.net/oauth/v2/token?grant_type=authorization_code&code=" +
                                 authtoken +
                                 "&redirect_uri=https://nitradomai.marcsrv.de/empty.html&%20client_id=" + Variables.clientid + "&%20client_secret=" + Variables.secretid;

            
            var request = WebRequest.Create(UrlRequest);
            request.ContentType = "application/json; charset=utf-8";
            string jsonesponse;
            var response = (HttpWebResponse)request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                jsonesponse = sr.ReadToEnd();
            }


            dynamic waffelresponse = JsonConvert.DeserializeObject(jsonesponse);

            string accesstoken = waffelresponse.access_token;
            Properties.Settings.Default.accesstoken = accesstoken;
            Properties.Settings.Default.Save();
            return null;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
