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
            

        }

        private void serviceview_Load(object sender, EventArgs e)
        {
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
            worker.DoWork += new DoWorkEventHandler(workerdata_DoWork);
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
                        //Gameserver
                        break;

                }
            }



        }

        private void worker_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {

            
            //Worker done
            
                labelworkerstatus.Text = "Abgeschlossen";
                labelworkerstatus.Image = Properties.Resources.successicon;
            
           
            
        }

        private void tabmaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabmaster.SelectedIndex != Variables.indexint)
            {
                tabmaster.SelectedIndex = Variables.indexint;
            }
        }
    }
}
