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
using static System.Net.WebRequestMethods;

namespace NitadoMAI
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void payment_Load(object sender, EventArgs e)
        {
            dynamic paymentdb = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(Application.CommonAppDataPath + "/paymentdb.txt"));
            
            
        }

       


        private void btnnext_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("http://google.com");

            double amount = Convert.ToDouble(txtamount.Text);
            amount = amount * 100;
            
            //paymentswitch
            string method = "gc_paypal";
            switch (listpaymentbox.Text)
            {
                case "PayPal":
                    method = "gc_paypal";
                    break;
                case "Visa":
                    method = "gc_visa";
                    break;
                case "American Express":
                    method = "gcamex";
                    break;
                case "Banküberweisung":
                    method = "gcbanktransfer";
                    break;
                case "Visa Debit":
                    method = "gc_visadebit";
                    break;
                case "Mastercard Debit":
                    method = "gc_mastercarddebit";
                    break;
                case "Mastercard":
                    method = "gc_mastercard";
                    break;
                case "GiroPay":
                    method = "gc_giropay";
                    break;
                case "Skrill / Moneybookers":
                    method = "gc_paysafecard";
                    break;
                case "Sofortüberweisung":
                    method = "gc_sofort";
                    break;
                case "Barzahlen":
                    method = "barzahlen";
                    break;
                case "Telefon (Festnetz)":
                    method = "mit_call";
                    break;
                case "Telefon (Mobil)":
                    method = "mit_sms";
                    break;
                case "Gutscheincode":
                    method = "voucher";
                    break;
                case "iDeal":
                    method = "gc_ideal";
                    break;
                default:
                    MessageBox.Show("Keine korrekte Bezahlmethode gewählt");
                    break;
            }
            
            dynamic jsonresult = JsonConvert.DeserializeObject(main.nitrapi("post", "order/payment/charge?method=" + method + "&amount=" + amount.ToString() + "&country=DE"));
            string url = jsonresult.data.payment.url;
            System.Diagnostics.Process.Start(url);
            this.Close();

        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtamount.Text != "")
                {
                    double amount = Convert.ToDouble(txtamount.Text);
                    //amount = amount * 100;
                    labelguthaben.Text = amount.ToString();
                }
                
            }
            catch
            {
                MessageBox.Show("Kein gültigen Geldbetrag eingeben");
                txtamount.Text = "0,00";
            }
        }

        private void listpaymentbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool founded = false;
            labelpayment.Text = listpaymentbox.Text;
            foreach (var item in listpaymentbox.Items)
            {
                if(listpaymentbox.Text == item.ToString())
                {
                    founded = true;
                }
            }
            if(founded == false)
            {
                listpaymentbox.SelectedIndex = 1;
            }
        }
    }
}
