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
            labelupdateworker.Text = "Aktualisiere Gamedatenbank...";
            labelupdateworker.Image = Properties.Resources.squares;
            string gamedb = main.nitrapi("get", "gameserver/games");
            System.IO.File.WriteAllText(Application.CommonAppDataPath + @"\gamedb.txt", gamedb);
            
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
