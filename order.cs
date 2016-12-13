using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NitadoMAI
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        public class Variables
        {
            public static dynamic pricedb;
            public static string gamename;
            public static string gamefolder;
        }

            private void order_Load(object sender, EventArgs e)
        {
            labelguthaben.Text = main.Variables.credit + " €";
            dynamic gamedb = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(Application.CommonAppDataPath + "/gamedb.txt"));
            foreach (var location in gamedb.data.games.locations)
            {
                listlocations.Items.Add(location.country + ", " + location.city);
                    //location.country + ", " + location.city;
                    listlocationts.Items.Add(location.country + ", " + location.city);

            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < listlocations.Items.Count; ++ix)
                if (ix != e.Index)
                {
                    listlocations.SetItemChecked(ix, false);
                    listlocations.Enabled = false;
                }
            labellocation.Text = listlocations.SelectedItem.ToString();
            worker.RunWorkerAsync();
            groupserver.Enabled = true;
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            labelpriceworkerstatus.Text = "lädt Preisdatenbank für Location " + labellocation.Text + "...";
            labelpriceworkerstatus.Image = Properties.Resources.squares;

            //location

            int locationid = 2;

            switch (labelservicetype.Tag.ToString())
            {
                case "gameserver":
                    //Gameserver

                    dynamic dataresponse = JsonConvert.DeserializeObject(main.nitrapi("get", "order/pricing/gameserver?location=" + locationid));
                    Variables.pricedb = dataresponse;
                    
                    if (dataresponse.status == "error")
                    {
                        labelpriceworkerstatus.Text = "Fehler: [" + dataresponse.status + "] " + dataresponse.message;
                        labelpriceworkerstatus.Image = Properties.Resources.deleteicon;
                    }
                    else
                    {
                        /*
                        foreach (var servertype in dataresponse.data.prices.dimensions[0].values)
                        {
                            
                           

                        }
                        */
                        labelpriceworkerstatus.Text = "Abgeschlossen";
                        labelpriceworkerstatus.Image = Properties.Resources.successicon;
                    }
                    break;
                case "voiceserver":
                    //Voiceserver

                    dynamic dataresponsets = JsonConvert.DeserializeObject(main.nitrapi("get", "order/pricing/teamspeak3?location=" + locationid));
                    Variables.pricedb = dataresponsets;

                    if (dataresponsets.status == "error")
                    {
                        labelpriceworkerstatus.Text = "Fehler: [" + dataresponsets.status + "] " + dataresponsets.message;
                        labelpriceworkerstatus.Image = Properties.Resources.deleteicon;
                    }
                    else
                    {
                        /*
                        foreach (var servertype in dataresponse.data.prices.dimensions[0].values)
                        {
                            
                           

                        }
                        */
                        labelpriceworkerstatus.Text = "Abgeschlossen";
                        labelpriceworkerstatus.Image = Properties.Resources.successicon;
                    }
                    break;
                case "webspace":
                    //Webspace
                    break;
                case "musicbot":
                    //MusicBot
                    break;
                case "ventrillo":
                    //Ventrillo
                    break;
                case "mumble":
                    //Mumble
                    break;
                case "bouncer":
                    //Bouncer
                    break;
            }
            
            

            }

        private void listservertype_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            button1.Enabled = true;
            trackslots.Value = 4;
            labelslots.Text = "4";
            labelslots.Tag = "4";
            for (int ix = 0; ix < listservertype.Items.Count; ++ix)
                if (ix != e.Index) listservertype.SetItemChecked(ix, false);
            labelservertype.Text = listservertype.SelectedItem.ToString();
            
            switch (labelservertype.Text)
            {
                case "Publicserver Basic":
                    labelservertype.Tag = "basic";
                    trackupgrade.Enabled = false;
                    groupramupgrade.Enabled = false;
                    trackslots.Maximum = 100;
                    labelmaxslots.Text = "100";
                    break;
                case "Publicserver":
                    labelservertype.Tag = "publicserver";
                    trackupgrade.Enabled = true;
                    groupramupgrade.Enabled = true;
                    trackslots.Maximum = 200;
                    labelmaxslots.Text = "200";
                    break;
                case "EPS Publicserver":
                    labelservertype.Tag = "eps";
                    trackupgrade.Enabled = false;
                    groupramupgrade.Enabled = false;
                    trackslots.Maximum = 100;
                    labelmaxslots.Text = "100";
                    break;
                default:
                    
                    break;
            }
            updateprice();
            groupslots.Enabled = true;
                
           
               
            
        }

        private void taborder_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelservicetype.Text = taborder.SelectedTab.Text;
            labelservicetype.Tag = taborder.SelectedTab.Tag.ToString();
        }

        private void trackslots_Scroll(object sender, EventArgs e)
        {
            string server = labelservertype.Tag.ToString();
            int slots = trackslots.Value;
            bool found = false;
            //dynamic testvar = Variables.pricedb.data.prices.dimensions[1].values[server];
            foreach (var valislot in Variables.pricedb.data.prices.dimensions[1].values[server])
            {
                if (valislot == slots)
                {
                    found = true;
                    break;
                    
                }
            }
            if(found == true)
            {

                
                labelslots.Text = slots.ToString();
                    updateprice();
            }else
            {
                labelslots.Text = slots.ToString() + " Slots ist nicht verfügbar bitte mehr oder weniger angeben";
                btnorder.Enabled = false;
            }
            Laufzeit.Enabled = true;
            
        }

        private void trackupgrade_Scroll(object sender, EventArgs e)
        {
            switch (trackupgrade.Value)
            {
                case 0:
                    labelserverram.Text = "Standart";
                    labelserverram.Tag = "0";
                    break;
                case 1:
                    labelserverram.Text = "Advanced";
                    labelserverram.Tag = "1";
                    break;
                case 2:
                    labelserverram.Text = "Professional";
                    labelserverram.Tag = "2";
                    break;
                case 3:
                    labelserverram.Text = "Ultimate";
                    labelserverram.Tag = "3";
                    break;
            }
            string newram = "0";
            int ramindex = Convert.ToInt32(labelserverram.Tag.ToString());
            try
            {
                 newram = Variables.pricedb.data.prices.dimensions[2]["values"].publicserver[labelslots.Text][ramindex];
            }
            catch
            {

            }
           
                    labelserverram.Tag = newram;
                    labelserverram.Text = newram + " MB";
                
                
            
            
            
            updateprice();
        }
        //Preisbuilder
        public string updateprice()
        {
            
            string server = labelservertype.Tag.ToString();
            string slots = labelslots.Text;
            string ram = labelserverram.Tag.ToString();
            string laufzeit = tracklaufzeit.Value.ToString();
            switch (laufzeit)
            {
                case "0":
                    laufzeit = "72";
                    break;
                case "1":
                    laufzeit = "720";
                    break;
                case "2":
                    laufzeit = "2160";
                    break;
                        case "3":
                    laufzeit = "8760";
                    break;
            }

            //RAMRECHNER
            try
            {
                switch (trackupgrade.Value)
                {
                    case 0:
                        labelserverram.Text = "Standart";
                        labelserverram.Tag = "0";
                        break;
                    case 1:
                        labelserverram.Text = "Advanced";
                        labelserverram.Tag = "1";
                        break;
                    case 2:
                        labelserverram.Text = "Professional";
                        labelserverram.Tag = "2";
                        break;
                    case 3:
                        labelserverram.Text = "Ultimate";
                        labelserverram.Tag = "3";
                        break;
                }
                int ramindex = Convert.ToInt32(labelserverram.Tag.ToString());

                string newram = Variables.pricedb.data.prices.dimensions[2]["values"].publicserver[slots][ramindex];


                labelserverram.Tag = newram;
                labelserverram.Text = newram + " MB";
            }catch
            {

            }

            double price = 0;
            string id = "0";
            try
            {
                if(server == "publicserver")
                {
                    price = Variables.pricedb.data.prices.prices[server][slots][ram][laufzeit].price;
                    id = Variables.pricedb.data.prices.prices[server][slots][ram][laufzeit].id;
                }
                else
                {

                
                price = Variables.pricedb.data.prices.prices[server][slots][laufzeit].price;
                id = Variables.pricedb.data.prices.prices[server][slots][laufzeit].id;
                }
                btnorder.Tag = id;
               
                double pricefin = price / 100;
                labelprice.Text = pricefin.ToString("C2");
                labelprice.Tag = price;


            }
            catch
            {
                labelprice.Text = "N/A";
                
            }
                  
            
            return null;
        }

        private void tracklaufzeit_Scroll(object sender, EventArgs e)
        {
            updateprice();
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            updatetsprice();
            /*
            labelpriceworkerstatus.Text = "Abgeschlossen";
            labelpriceworkerstatus.Image = Properties.Resources.successicon;
            */
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            int locationid = 2;
            dynamic gamedb = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(Application.CommonAppDataPath + "/gamedb.txt"));
            //gamedb.data.games.location
            foreach (var location in gamedb.data.games.locations)
            {
                if (location.country + ", " + location.city == labellocation.Text)
                {
                    locationid = location.id;
                }
            }
            string server = labelservertype.Tag.ToString();
            string slots = labelslots.Text;
            string ram = labelserverram.Tag.ToString();
            string laufzeit = tracklaufzeit.Value.ToString();
            switch (laufzeit)
            {
                case "0":
                    laufzeit = "72";
                    break;
                case "1":
                    laufzeit = "720";
                    break;
                case "2":
                    laufzeit = "2160";
                    break;
                case "3":
                    laufzeit = "8760";
                    break;
            }
            
                string game = labelinstallgame.Tag.ToString();
            
            dynamic dataresponse = JsonConvert.DeserializeObject(main.nitrapi("Post", "order/order/gameserver?location=" + locationid + "&price=" + labelprice.Tag.ToString() + "&rental_time=" + laufzeit + "&dimensions[type]=" + server + "&dimensions[slot]=" + slots + "&dimensions[upgrade]=" + ram + "&additionals[game]=" + game));
            if (dataresponse.status == "error")
            {
                labelpriceworkerstatus.Text = "Fehler: [" + dataresponse.status + "] " + dataresponse.message;
                labelpriceworkerstatus.Image = Properties.Resources.deleteicon;
            }else
            {
                labelpriceworkerstatus.Text = "Abgeschlossen";
                labelpriceworkerstatus.Image = Properties.Resources.successicon;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameswitcher gameswitcherform = new gameswitcher();
            gameswitcherform.ShowDialog();
            if (Variables.gamefolder == "")
            {
                labelinstallgame.Text = "Kein Spiel ausgewählt";
            }
            else
            {
                labelinstallgame.Text = Variables.gamename;
                labelinstallgame.Tag = Variables.gamefolder;
                btnorder.Enabled = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int slots = tracktsslots.Value;
            labelslotsts.Text = slots.ToString();
            updatetsprice();
        }

        private void listlocationts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            btnorderts.Enabled = true;
            for (int ix = 0; ix < listlocationts.Items.Count; ++ix)
                if (ix != e.Index)
                {
                   listlocationts.SetItemChecked(ix, false);
                    listlocationts.Enabled = false;
                }
            //labellocation.Text = listlocations.SelectedItem.ToString();
            worker.RunWorkerAsync();
            groupslotsts.Enabled = true;
            labeltslocation.Text = listlocationts.SelectedItem.ToString();
            updatetsprice();
        }

        private void tracklaufzeitts_Scroll(object sender, EventArgs e)
        {
            updatetsprice();
        }

        public string updatetsprice()
        {
            int slots = tracktsslots.Value;
            int laufzeit = tracklaufzeitts.Value;
            
            double price = 0;
            
            int locationid = 2;
            dynamic gamedb = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(Application.CommonAppDataPath + "/gamedb.txt"));
            //gamedb.data.games.location
            foreach (var location in gamedb.data.games.locations)
            {
                if (location.country + ", " + location.city == labeltslocation.Text)
                {
                    locationid = location.id;
                }
            }
            slots = slots - 4;
            try
            {
                price = Variables.pricedb.data.prices.parts[0].rental_times[laufzeit].prices[slots].price;
                //id = Variables.pricedb.data.prices.prices[server][slots][laufzeit].id;
                double pricefin = price / 100;
                labeltsprice.Text = pricefin.ToString("C2");
                
                labeltsprice.Tag = price;
            }
            catch
            {
                labeltsprice.Text = "N/A";

            }
            return null;
        }

        private void btnorderts_Click(object sender, EventArgs e)
        {
            int locationid = 2;
            dynamic gamedb = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(Application.CommonAppDataPath + "/gamedb.txt"));
            //gamedb.data.games.location
            foreach (var location in gamedb.data.games.locations)
            {
                if (location.country + ", " + location.city == labeltslocation.Text)
                {
                    locationid = location.id;
                }
            }

            int slots = tracktsslots.Value;
            string laufzeit = tracklaufzeit.Value.ToString();
            switch (laufzeit)
            {
                case "0":
                    laufzeit = "720";
                    break;
                case "1":
                    laufzeit = "2160";
                    break;
                case "2":
                    laufzeit = "8760";
                    break;
                
            }
            dynamic dataresponse = JsonConvert.DeserializeObject(main.nitrapi("Post", "order/order/teamspeak3?location=" + locationid + "&price=" + labeltsprice.Tag.ToString() + "&rental_time=" + laufzeit + "&parts[slot]=" + slots));
            if (dataresponse.status == "error")
            {
                labelpriceworkerstatus.Text = "Fehler: [" + dataresponse.status + "] " + dataresponse.message;
                labelpriceworkerstatus.Image = Properties.Resources.deleteicon;
            }
            else
            {
                labelpriceworkerstatus.Text = "Abgeschlossen";
                labelpriceworkerstatus.Image = Properties.Resources.successicon;
                this.Close();
            }
        }
    }
}
