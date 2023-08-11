using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using Newtonsoft.Json;


namespace MultiLogin_Google
{
    public partial class Form1 : Form
    {
        private UserCredential credential;
        private string[] scopes = { YouTubeService.Scope.YoutubeReadonly };
        private string tokenPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("tokens");
            tokenPath = Path.Combine("tokens", $"token_{textEmail.Text}.json");
            LoadToken();
        }
        private void LoadToken()
        {
            if (File.Exists(tokenPath))
            {
                using (var stream = new FileStream(tokenPath, FileMode.Open, FileAccess.Read))
                {
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(tokenPath, true)).Result;
                }
            }
        }

        private void SaveToken()
        {
            if (credential != null)
            {
                using (var stream = new FileStream(tokenPath, FileMode.Create, FileAccess.Write))
                {
                    new FileDataStore(Path.GetDirectoryName(tokenPath), true).StoreAsync<UserCredential>("user", credential).Wait();
                }
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = "950183854299-iutofpdh9aemuc0lnb3hau68mpvrinr7.apps.googleusercontent.com",
                    ClientSecret = "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"
                },
                scopes,
                "user",
                CancellationToken.None, // Perubahan pada argumen ini
                new FileDataStore(tokenPath, true)).Result;

            if (credential != null)
            {
                MessageBox.Show("Login Berhasil");
                SaveToken();
                btnRelogin.Enabled = true;
            }
            else
            {
                MessageBox.Show("Login gagal. Silakan coba lagi.");
            }

        }


        private void btnRelogin_Click(object sender, EventArgs e)
        {
            LoadToken();

        }
    }
}
