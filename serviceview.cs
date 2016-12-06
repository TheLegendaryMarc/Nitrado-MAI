using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NitadoMAI
{
    public partial class serviceview : Form
    {
        public serviceview()
        {
            InitializeComponent();
        }

        public class Variables
        {
            public static int indexint;
            public static string game;
            public static string location;
            public static string ip;
            public static string port;
            public static string name;
            public static string serverstatus;
            public static string servertype;
            public static string gamestatus;
            public static string gamehuman;
            public static string gameslots;
            public static string gamegame;
            public static string gamekey;
            public static string server_human;
            public static dynamic srvresponse;
            public static DateTime serversuspending;
            public static DateTime servercreated;
            public static DateTime serverdelete;
            public static int ticker = 60;








        }

        private void serviceview_Load(object sender, EventArgs e)
        {
            
            worker.DoWork += new DoWorkEventHandler(workerdata_DoWork);
            
            labelservicetype.Text = main.Variables.servicetype;
            labelservice.Text = main.Variables.serviceid;
            btnrefresh.PerformClick();
            int indexint = 0;
            
            switch (labelservicetype.Text)
            {
                case "Clanpage":
                    indexint = 5;
                    break;
                case "Gameserver":
                    indexint = 0;
                    break;
                case "Voiceserver":
                    indexint = 2;
                    break;
                case "Webspace":
                    indexint = 3;
                    break;
            }
            Variables.indexint = indexint;
            tabmaster.SelectedIndex = indexint;
            this.Text = "Service - " + labelservice.Text + " - Nitrado MAI";
            
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
           
            worker.RunWorkerAsync();
        }

       

        void workerdata_DoWork(object sender, DoWorkEventArgs e)
        {
            labelworkerstatus.Text = "Lädt...";
            labelworkerstatus.Image = Properties.Resources.squares;


            //Work Service Data
            labelworkerstatus.Text = "Lädt Servicedaten...";
            
            dynamic dataresponse = JsonConvert.DeserializeObject(main.nitrapi("get","services/" + labelservice.Text));
            if(dataresponse.status == "error")
            {
                labelworkerstatus.Text = "Fehler: [" + dataresponse.status + "] " + dataresponse.message;
                labelworkerstatus.Image = Properties.Resources.deleteicon;
            }
            else
            {
                switch (labelservicetype.Text)
                {
                    case "Gameserver":
                        Variables.location = dataresponse.data.service.location_id;
                        Variables.serverstatus = dataresponse.data.service.status;
                        Variables.servertype = dataresponse.data.service.type;
                        Variables.server_human = dataresponse.data.service.type_human;
                        Variables.gamekey = dataresponse.data.service.details.folder_short;
                        labelworkerstatus.Text = "Lädt Gameserverdaten...";
                        dynamic srvresponse = JsonConvert.DeserializeObject(main.nitrapi("get", "services/" + labelservice.Text + "/gameservers"));
                        Variables.srvresponse = srvresponse;
                        Variables.gamestatus = srvresponse.data.gameserver.status;
                        Variables.ip = srvresponse.data.gameserver.ip;
                        Variables.port = srvresponse.data.gameserver.port;
                        Variables.gamegame = srvresponse.data.gameserver.game;
                        Variables.ip = srvresponse.data.gameserver.ip;
                        Variables.gamehuman = srvresponse.data.gameserver.game_human;
                        Variables.servercreated = dataresponse.data.service.start_date;
                        Variables.serversuspending = dataresponse.data.service.suspend_date;
                        Variables.serverdelete = dataresponse.data.service.delete_date;
                        Variables.gameslots = srvresponse.data.gameserver.slots;
                        break;
                        
                }
            }



        }

        private void worker_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {


            if (Variables.srvresponse.status == "error")
            {
                labelworkerstatus.Text = "Fehler: [" + Variables.srvresponse.status + "] " + Variables.srvresponse.message;
                labelworkerstatus.Image = Properties.Resources.deleteicon;
            }
            else
            {
                switch (labelservicetype.Text)
                {
                    case "Gameserver":
                        labelgameserver.Text = Variables.gamehuman + " " + Variables.gameslots + " Slots";
                        labelip.Text = Variables.ip + ":" + Variables.port;
                        switch (Variables.gamestatus)
                        {
                            case "started":
                                labelgamestatus.Text = "Online";
                                labelgamestatus.BackColor = Color.Green;
                                break;
                            case "stopped":
                                labelgamestatus.Text = "Offline";
                                labelgamestatus.BackColor = Color.Red;
                                break;
                            case "stopping":
                                labelgamestatus.Text = "Wird gestoppt";
                                labelgamestatus.BackColor = Color.Orange;
                                break;
                            case "restarting":
                                labelgamestatus.Text = "Neustarten";
                                labelgamestatus.BackColor = Color.Orange;
                                break;
                            case "suspended":
                                labelgamestatus.Text = "Deaktiviert";
                                labelgamestatus.BackColor = Color.Blue;
                                break;
                            case "guardian_locked":
                                labelgamestatus.Text = "Elternschutz aktiviert";
                                labelgamestatus.BackColor = Color.Orange;
                                break;
                            case "gs_installation":
                                labelgamestatus.Text = "Gameswitching";
                                labelgamestatus.BackColor = Color.Blue;
                                break;
                            case "backup_restore":
                                labelgamestatus.Text = "Backup wird wiederhergestellt";
                                labelgamestatus.BackColor = Color.Blue;
                                break;
                            case "backup_creation":
                                labelgamestatus.Text = "Backup wird erstellt";
                                labelgamestatus.BackColor = Color.Blue;
                                break;
                            default:
                                labelgamestatus.Text = "Unknow";
                                labelgamestatus.BackColor = Color.White;
                                break;

                        }
                        labelgamesuspendtime.Text = Variables.serversuspending.ToString("dd.MM.yyyy H:mm");
                        switch (Variables.serverstatus)
                        {
                            case "active":
                                labelservicestatus.Text = "Aktiv";
                                labelservicestatus.BackColor = Color.Green;
                                break;
                            case "installing":
                                labelservicestatus.Text = "wird installiert";
                                labelservicestatus.BackColor = Color.Orange;
                                break;
                            case "suspended":
                                labelservicestatus.Text = "Abgelaufen";
                                labelservicestatus.BackColor = Color.Red;
                                break;
                            case "adminlocked":
                                labelservicestatus.Text = "Adminlock aktiv, bitte Support kontaktieren";
                                labelservicestatus.BackColor = Color.Red;
                                break;
                            case "adminlocked_suspended":
                                labelservicestatus.Text = "Adminlock aktiv und abgelaufen";
                                labelservicestatus.BackColor = Color.Red;
                                break;
                        }
                        
                        dynamic gamedb = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(Application.CommonAppDataPath + "/gamedb.txt"));
                        //gamedb.data.games.location
                            foreach (var location in gamedb.data.games.locations)
                        {
                            if(location.id == Variables.location)
                            {
                                labellocation.Text = location.country + ", " + location.city;
                            }
                        }
                            labelgamestarttime.Text = Variables.servercreated.ToString("dd.MM.yyyy H:mm");
                        serverimage.ImageLocation = "https://static.nitrado.net/cdn/gameicons/120/" + Variables.gamekey + ".jpg";

                        break;
                }


                labelworkerstatus.Text = "Abgeschlossen";
                labelworkerstatus.Image = Properties.Resources.successicon;
            }
           
            
        }

        private void tabmaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabmaster.SelectedIndex != Variables.indexint)
            {
                tabmaster.SelectedIndex = Variables.indexint;
            }
            
        }

        private void timermaschine_Tick(object sender, EventArgs e)
        {
            if(labelnextupdate.Text == "0")
            {
                worker.RunWorkerAsync();
                labelnextupdate.Text = "60";
                
            }else {
                int nextint = Convert.ToInt32(labelnextupdate.Text);
                nextint--;
                labelnextupdate.Text = nextint.ToString();
            }
            
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if(timermaschine.Tag.ToString() == "stopped")
            {
                timermaschine.Start();
                timermaschine.Tag = "started";
                btntimerstartstop.Text = "Automatische Aktualisierung - ON";
            }else if(timermaschine.Tag.ToString() == "started")
            {
                timermaschine.Stop();
                timermaschine.Tag = "stopped";
                btntimerstartstop.Text = "Automatische Aktualisierung - OFF";
            }
        }
    }
}
