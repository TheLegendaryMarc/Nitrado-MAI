using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NitadoMAI
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public class Variables
        {
            public static string clientid = "";
            public static string secretid = "";
            public static string passphrase = "";
        }
        private void login_Load(object sender, EventArgs e)
        {
            webbro.Navigate(new Uri("https://oauth.nitrado.net/oauth/v2/auth?client_id=" + Variables.clientid + "&scope=service%20user_info%20service_order&redirect_uri=https://server.nitrado.net/deu/gameserver-mieten&&response_type=code"));
        }

        public static string makeaccessrequest(string authtoken)
        {
            string UrlRequest = "https://oauth.nitrado.net/oauth/v2/token?grant_type=authorization_code&code=" +
             authtoken +
             "&redirect_uri=https://server.nitrado.net/deu/gameserver-mieten&%20client_id=" + Variables.clientid + "&%20client_secret=" + Variables.secretid;
            var request = WebRequest.Create(UrlRequest);
            request.ContentType = "application/json; charset=utf-8";
            string jsonesponse;
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                jsonesponse = sr.ReadToEnd();
            }
            dynamic waffelresponse = JsonConvert.DeserializeObject(jsonesponse);
            string accesstoken = waffelresponse.access_token;
            string cryptedaccesstoken = Encrypt(accesstoken, Variables.passphrase);
            accesstoken = "";
            string refreshtoken = waffelresponse.refresh_token;
            string cryptedrefreshtoken = Encrypt(refreshtoken, Variables.passphrase);
            refreshtoken = "";
            double expires = waffelresponse.expires_in;
            DateTime requesttime = Convert.ToDateTime(response.GetResponseHeader("Date"));
            double requesttimeunix = DateTimeToUnix(requesttime);
            double expiresin = requesttimeunix + expires;
            DateTime expireswhen = UnixToDateTime(expiresin);
            Properties.Settings.Default.refreshtoken = cryptedrefreshtoken;
            Properties.Settings.Default.accesstoken = cryptedaccesstoken;
            Properties.Settings.Default.expires = expireswhen;
            Properties.Settings.Default.Save();
            return null;
        }

        public static DateTime UnixToDateTime(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static double DateTimeToUnix(DateTime dateTime)
        {
            return (TimeZoneInfo.ConvertTimeToUtc(dateTime) -
             new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)).TotalSeconds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private
        const int Keysize = 256;
        private
        const int DerivationIterations = 1000;

        public static string Encrypt(string plainText, string passPhrase)
        {

            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        private void webbro_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webbro.Url.ToString().Contains("https://server.nitrado.net/deu/gameserver-mieten?code=") == true)
            {
                string url = webbro.Url.ToString();
                string authtoken = url.Replace("https://server.nitrado.net/deu/gameserver-mieten?code=", "");
                makeaccessrequest(authtoken);
                this.Hide();
                update updateform = new update();
                updateform.ShowDialog();
                this.Close();
            }
        }
    }
}