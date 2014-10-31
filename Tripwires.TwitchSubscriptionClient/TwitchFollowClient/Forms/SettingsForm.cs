using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twitch.Net.Factories;
using Twitch.Net.Helpers;
using Twitch.Net.Interfaces;
using Twitch.Net.Model;
using MediaPlayer;
using System.IO;
using System.Media;

namespace TwitchFollowClient
{
    public partial class SettingsForm : Form
    {
        private RestClient rClient;
        private bool channelNameValueEmpty;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ChannelnameIsValid(txtChannelName.Text))
            {
                Properties.Settings.Default.ChannelName = txtChannelName.Text;
                Properties.Settings.Default.Timer = nmrTimer.Value;
                Properties.Settings.Default.Save();
                this.FindForm().Close();
            }
            else
            {
                MessageBox.Show("Invalid channelname. Please enter a valid username", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ChannelnameIsValid(string channelName)
        {
            bool result = false;
            this.initRestClient();
            TwitchClientFactory twitchClientFactory = new TwitchClientFactory();
            Func<string, Method, IRestRequest> requestFunc = (url, method) => new RestRequest(url, method);
            ITwitchStaticClient twitchClient = twitchClientFactory.CreateStaticReadonlyClient(this.rClient, requestFunc);
            Channel channel = twitchClient.GetChannel(channelName);
            if (!string.IsNullOrEmpty(channel.DisplayName)) {
                result = true;
            }
            return result;

        }

        private void initRestClient()
        {
            this.rClient = new RestClient(Properties.Settings.Default.ApiUrl);
            this.rClient.AddHandler("application/json", new DynamicJsonDeserializer());
            this.rClient.AddDefaultHeader("Accept", "application/vnd.twitchtv.v2+json");
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            this.FindForm().Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            this.txtChannelName.Update();
            this.nmrTimer.Update();
            this.nmrFollowsPerTick.Update();
            this.txtNotificationSound.Update();
        }

        private void txtChannelName_TextChanged(object sender, EventArgs e)
        {
            this.channelNameValueEmpty = string.IsNullOrEmpty(txtChannelName.Text);
            this.btnOk.Enabled = !this.channelNameValueEmpty;
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            this.channelNameValueEmpty = string.IsNullOrEmpty(txtChannelName.Text);
            this.btnOk.Enabled = !this.channelNameValueEmpty;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ntfSoundFileDialog.ShowDialog();
        }

        private void ntfSoundFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.NotificationSoundFile = ntfSoundFileDialog.FileName;
        }

    }
}
