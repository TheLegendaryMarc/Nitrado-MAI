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
using Newtonsoft.Json;
using System.Net;

namespace NitadoMAI
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            

            //Update GameDB
            labelupdateworker.Text = "Aktualisiere Gamedatenbank...";
            labelupdateworker.Image = Properties.Resources.squares;
            string gamedb = main.nitrapi("get", "gameserver/games");
            System.IO.File.WriteAllText(Application.CommonAppDataPath + @"\gamedb.txt", gamedb);

            //Download Gameimages
            labelupdateworker.Text = "Download von Gameicons...";
            string folderName = Application.CommonAppDataPath;
            string pathString = System.IO.Path.Combine(folderName, "gameimages");
            System.IO.Directory.CreateDirectory(pathString);


            int id = 0;
            dynamic dataresponse = JsonConvert.DeserializeObject(gamedb);
            foreach (var game in dataresponse.data.games.games)
            {
                string url = game.icons["x120"];
                string name = id.ToString();
                using (var client = new WebClient())
                {
                    client.DownloadFile(url, Application.CommonAppDataPath + "/gameimages/" + name + ".jpg");
                }
                id++;
            }

            //Update PaymentDB
            labelupdateworker.Text = "Aktualisiere Zahlungsmethoden...";
            string paymentdb = main.nitrapi("get", "order/payment/payment_methods");
            System.IO.File.WriteAllText(Application.CommonAppDataPath + @"\paymentdb.txt", paymentdb);

            

        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
               
                    labelupdateworker.Text = "Abgeschlossen";
                    labelupdateworker.Image = Properties.Resources.successicon;
                    this.Close();
                
            
           
            
            }

        private void update_Load(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }
    }
}
