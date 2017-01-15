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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void settings_Load(object sender, EventArgs e)
        {
            DateTime expiretext = Properties.Settings.Default.expires;
            labelexpire.Text = expiretext.ToString("dd.MM.yyyy H:mm:ss");
            labelname.Text = main.Variables.name;
            labelusername.Text = main.Variables.username;
            labelid.Text = main.Variables.userid;
            labelemail.Text = main.Variables.email;
            labelprogramm.Text = Application.ProductName;
            labelversion.Text = Application.ProductVersion;
            labelcodename.Text = "Return";
            txtaccesstoken.Text = login.Decrypt(Properties.Settings.Default.accesstoken, login.Variables.passphrase);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.accesstoken = "";
            Properties.Settings.Default.refreshtoken = "";
            Properties.Settings.Default.expires = DateTime.Now;
            Properties.Settings.Default.Save();
            MessageBox.Show("Account aus Client entfernt [Programm Neustart erforderlich]");
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            update updatefrom = new update();
            updatefrom.ShowDialog();
        }

        private void btnsavesettings_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
