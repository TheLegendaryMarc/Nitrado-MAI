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
    public partial class support : Form
    {
        public support()
        {
            InitializeComponent();
        }

        private void support_Load(object sender, EventArgs e)
        {
            label6.Text = main.Variables.userid;
        }
    }
}
