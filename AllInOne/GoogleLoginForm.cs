using Google.Apis.Auth.OAuth2;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AllInOne
{
    public partial class GoogleLoginForm : Form
    {
        readonly string authFile = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\auth.json";
        private static readonly string[] scopes = new string[] { "https://www.googleapis.com/auth/blogger", "profile", "email" };

        private static readonly string clientID = "377317774413-c7r1nt3jetsrg7k0u3122ac8meh3h03l.apps.googleusercontent.com";
        private static readonly string clientSecret = "2GUVXTAm5tVxMxKqG-l6NJ_x";

        UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = clientID,
                    ClientSecret = clientSecret,
                },
                 scopes,
                 "user",
                 CancellationToken.None).Result;
        public GoogleLoginForm()
        {
            InitializeComponent();
            checkTokenValid();
        }

        private void checkTokenValid() {
            try
            {  
                if (File.Exists(authFile))
                {
                    using (StreamReader sr = File.OpenText(authFile))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Models.AuthTokenGoogle authTokenGoogle = JsonConvert.DeserializeObject<Models.AuthTokenGoogle>(s);
                            if (credential.Token.IsExpired(credential.Flow.Clock))
                            {
                                if (credential.RefreshTokenAsync(CancellationToken.None).Result)
                                {
                                    authTokenGoogle.token = credential.Token.AccessToken;
                                    authTokenGoogle.refreshToken = credential.Token.RefreshToken;
                                    authTokenGoogle.expr = long.Parse(credential.Token.ExpiresInSeconds.ToString());
                                    if (saveToken(authTokenGoogle)) AllInOne.allInOne.openControllerForm(new AutoCrawlersBlogspot());
                                }
                                else
                                {
                                    panelCheckLogin.Visible = false;
                                }
                            }
                            else
                            {
                                AllInOne.allInOne.openControllerForm(new AutoCrawlersBlogspot());
                            }
                        }
                    }
                }
                else
                {
                    panelCheckLogin.Visible = false;
                }
            }
            catch (Exception Ex)
            {
                DialogResult dialog = MessageBox.Show("Something went wrong in login with google, please contact admin!", "All in One - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("https://m.me/tuanminpay");
                    Close();
                }
                Console.WriteLine(Ex.ToString());
            }
        }

        private bool saveToken(Models.AuthTokenGoogle authTokenGoogle)
        {
            string authData = JsonConvert.SerializeObject(authTokenGoogle, Formatting.None);
            try
            {
                if (File.Exists(authFile))
                {
                    File.Delete(authFile);
                }
                using (FileStream fs = File.Create(authFile))
                {
                    byte[] auth = new UTF8Encoding(true).GetBytes(authData);
                    fs.Write(auth, 0, authData.Length);
                }
                return true;
            }
            catch (Exception Ex)
            {
                /*DialogResult dialog = MessageBox.Show("Something went wrong in save token, please contact admin!", "All in One - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("https://m.me/tuanminpay");
                    Close();
                }*/
                Console.WriteLine(Ex.ToString());
                return true;
            }
        }

        private void btnLoginWithGoogle_Click(object sender, EventArgs e)
        {
            Oauth2Service oauthService = new Oauth2Service(new BaseClientService.Initializer() { HttpClientInitializer = credential });

            var userInfo = oauthService.Userinfo.Get().ExecuteAsync().Result;
            string userEmail = userInfo.Email;

            Models.AuthTokenGoogle authTokenGoogle = new Models.AuthTokenGoogle
            {
                email = userEmail,
                token = credential.Token.AccessToken,
                refreshToken = credential.Token.RefreshToken,
                expr = long.Parse(credential.Token.ExpiresInSeconds.ToString())
            };

            if (saveToken(authTokenGoogle)) AllInOne.allInOne.openControllerForm(new AutoCrawlersBlogspot());
        }
    }
}
