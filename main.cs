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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NitadoMAI
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        //DATENSOEICHER
        public class Variables
        {
            public static string name;
            public static string userid;
            public static string username;
            public static string email;
            public static double credit;
            public static DateTime registered;
            public static string lang;
            public static string avtarurl = "https://server.nitrado.net/img.nitrado/unknown-user.jpg";
            public static string currency;
            public static Boolean employee;
            public static string serviceid;

        }

        private void main_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.accesstoken == "")
            {
                login frm = new login();
                frm.ShowDialog(); 

            }
            textBox1.Text = Properties.Settings.Default.accesstoken;
            btnrefresh.PerformClick();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            labelworker.Text = "Working...";
            labelworker.Image = Properties.Resources.squares;

            //work

             nitrapi("get", "user");

            getuserdata();
            
            

        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            labelusername.Text = Variables.username;
            labelrealname.Text = Variables.name;
            labeluserid.Text = "UserID: " + Variables.userid;
            picavatar.ImageLocation = Variables.avtarurl;
            labelregistered.Text = "Mitglied seit: " + Variables.registered.ToString("dd.MM.yyyy H:mm:ss");


            labelworker.Text = "Complete";
            labelworker.Image = Properties.Resources.successicon;
        }

        


        //API ADAPTER

        public static string nitrapi(string method,string uri)
        {
            string UrlRequest = "https://api.nitrado.net/" + uri;
            var request = WebRequest.Create(UrlRequest);
            request.ContentType = "application/json; charset=utf-8";
            request.Headers.Add("Authorization: " + Properties.Settings.Default.accesstoken);
            request.Method = method;
            string jsonesponse;
            var response = (HttpWebResponse)request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                jsonesponse = sr.ReadToEnd();
            }
            //dynamic dataresponse = JsonConvert.DeserializeObject(jsonesponse);
           
            return jsonesponse;

            
        }
        //Nutzerdaten holen
        public static string getuserdata()
        {

            dynamic dataresponse = JsonConvert.DeserializeObject(nitrapi("get","user"));
            Variables.userid = dataresponse.data.user.user_id;
            Variables.username = dataresponse.data.user.username;
            Variables.email = dataresponse.data.user.email;
            double creditit = Convert.ToDouble(dataresponse.data.user.credit);
            Variables.credit = creditit / 100;
            Variables.registered = dataresponse.data.user.registred;
            Variables.lang = dataresponse.data.user.language;
            Variables.avtarurl = dataresponse.data.user.avatar;
            Variables.name = dataresponse.data.user.profile.name;
            Variables.currency = dataresponse.data.user.currency;


            return null;


        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
           

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            MessageBox.Show("Account aus Client entfernt [Programm Neustart erforderlich]");
            Application.Exit();
        }
    }
}
