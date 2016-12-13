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
        //DATENSPEICHER
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
            public static string servicetype;
            public static dynamic dataresponse;


        }

        private void main_Load(object sender, EventArgs e)
        {
            mainworker.DoWork += new DoWorkEventHandler(workerdata_DoWork);
            if (Properties.Settings.Default.accesstoken == "")
            {
                login frm = new login();
                frm.ShowDialog();

            }

            btnrefresh.PerformClick();
        }


        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listservices.Clear();
            //insert User Data
            labelusername.Text = Variables.username;
            labelrealname.Text = Variables.name;
            labeluserid.Text = "UserID: " + Variables.userid;
            picavatar.ImageLocation = Variables.avtarurl;
            labelregistered.Text = "Mitglied seit: " + Variables.registered.ToString("dd.MM.yyyy H:mm:ss");
            labelcredit.Text = "Guthaben: " + Variables.credit + " €";
            //Insert Services
            if (Variables.dataresponse.status == "error")
            {
                labelworker.Text = "Fehler: [" + Variables.dataresponse.status + "] " + Variables.dataresponse.message;
                labelworker.Image = Properties.Resources.deleteicon;
            }
            else
            {
                foreach (var service in Variables.dataresponse.data.services)
                {
                    string type = Convert.ToString(service.type);


                    Boolean showgame = false;
                    listservices.LargeImageList = serviceiconlist;
                    string inklammertext = Convert.ToString(service.id);
                    if (showgame == true)
                    {
                        inklammertext = Convert.ToString(service.details.game);
                    }
                    int imgindex = 0;
                    switch (type)
                    {
                        case "gameserver":
                            imgindex = 0;

                            showgame = true;
                            break;
                        case "voiceserver":
                            imgindex = 1;

                            break;
                        case "webspace":
                            imgindex = 2;

                            break;
                        case "domain":
                            imgindex = 3;

                            break;
                        case "clanpage":
                            imgindex = 4;

                            break;
                        case "bouncer":
                            imgindex = 5;

                            break;

                    }

                    int imgintindex = Convert.ToInt32(imgindex);

                    var thegroup = listservices.Groups[type];
                    var item = new ListViewItem { Text = Convert.ToString(service.type_human) + " (" + (inklammertext) + ")", Group = thegroup, ImageIndex = imgintindex, Tag = Convert.ToString(service.id) };
                    listservices.Items.Add(item);


                }

                Variables.dataresponse = "0";
                labelworker.Text = "Abgeschlossen";
                labelworker.Image = Properties.Resources.successicon;
            }




        }




        //API ADAPTER

        public static string nitrapi(string method, string uri)
        {
            string jsonesponse = "0";


            string UrlRequest = "https://api.nitrado.net/" + uri;
            var request = WebRequest.Create(UrlRequest);
            request.ContentType = "application/json; charset=utf-8";
            request.Headers.Add("Authorization: " + Properties.Settings.Default.accesstoken);
            request.Method = method;
            
            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    jsonesponse = sr.ReadToEnd();
                }
                
                

            }
            catch (WebException e)
            {
                string errorjson = "0";
                if (e.Response == null)
                {

                    jsonesponse = "{\"status\":\"error\",\"message\":\"Keine Internetverbindung!\"}";
                    Variables.dataresponse = jsonesponse;
                }
                else
                {
                    using (var sr = new StreamReader(e.Response.GetResponseStream()))
                    {
                        errorjson = sr.ReadToEnd();
                    }
                    dynamic errorresponse = JsonConvert.DeserializeObject(errorjson);

                    jsonesponse = errorjson;
                    Variables.dataresponse = errorjson;
                }
            }


            //dynamic dataresponse = JsonConvert.DeserializeObject(jsonesponse);

            return jsonesponse;


        }
        //Nutzerdaten holen
        public string getuserdata()
        {

            dynamic dataresponse = JsonConvert.DeserializeObject(nitrapi("get", "user"));
            if (dataresponse.status == "success")
            {


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
            }
            else
            {
                labelworker.Text = "Fehler: [" + dataresponse.status + "] " + dataresponse.message;
                labelworker.Image = Properties.Resources.deleteicon;

            }

            return null;


        }




        private void btnrefresh_Click(object sender, EventArgs e)
        {

            //mainworker.DoWork += new DoWorkEventHandler(workerdata_DoWork);
            mainworker.RunWorkerAsync();

        }



        private void btnsettings_Click(object sender, EventArgs e)
        {
            settings settingfenster = new settings();
            settingfenster.ShowDialog();
        }

        void workerdata_DoWork(object sender, DoWorkEventArgs e)
        {
            labelworker.Text = "Lädt...";
            labelworker.Image = Properties.Resources.squares;


            //work User Data
            labelworker.Text = "Lädt Accountdaten...";






            getuserdata();



            //work Services

            labelworker.Text = "Lädt Services...";

            Variables.dataresponse = JsonConvert.DeserializeObject(nitrapi("get", "services"));
        }

        private void listservices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Variables.serviceid = Convert.ToString(listservices.SelectedItems[0].Tag);
            Variables.servicetype = Convert.ToString(listservices.SelectedItems[0].Group);
            Form serviceview = new serviceview();
            serviceview.Show();
        }

        private void btncharge_Click(object sender, EventArgs e)
        {
            payment paymentform = new payment();
            paymentform.ShowDialog();
                
        }

        private void btnorderservice_Click(object sender, EventArgs e)
        {
            order orderform = new order();
            orderform.ShowDialog();
        }
    }
}