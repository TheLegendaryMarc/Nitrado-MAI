using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NitadoMAI
{
    public partial class gameswitcher : Form
    {
        public gameswitcher()
        {
            InitializeComponent();
        }

        private void gameswitcher_Load(object sender, EventArgs e)
        {
            int id2 = 0;
            DirectoryInfo dir = new DirectoryInfo(Application.CommonAppDataPath + "/gameimages");
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    this.gameicons.Images.Add(Image.FromFile(Application.CommonAppDataPath + "/gameimages/" + id2 + ".jpg"));
                    id2++;
                }
                catch
                {
                    
                }
            }
            int id = 0;
            dynamic dataresponse = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(Application.CommonAppDataPath + "/gamedb.txt"));
            foreach (var game in dataresponse.data.games.games)
            {
                string name = game.name;
                var item = new ListViewItem { Text = name, ImageIndex = id,Tag = game.folder_short};
                listgames.Items.Add(item);
                id++;
            }
            
        }

        private void listgames_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            order.Variables.gamename = listgames.SelectedItems[0].Text;
            order.Variables.gamefolder = listgames.SelectedItems[0].Tag.ToString();
            this.Close();
        }
    }
}
