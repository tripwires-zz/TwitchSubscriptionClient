using RestSharp;
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
using Twitch.Net.Clients;
using Twitch.Net.Factories;
using Twitch.Net.Helpers;
using Twitch.Net.Interfaces;
using Twitch.Net.Model;
using TwitchFollowClient.Forms;

namespace TwitchFollowClient
{
    public partial class TwitchFollowClientForm : Form
    {
        private List<Follow> followers = new List<Follow>();
        private DateTime lastCheck;
        private RestClient rClient;
        private List<User> newList;
        private List<User> oldList;
        public int PageSize
        {
            get { return Decimal.ToInt32(Properties.Settings.Default.PageSize); }
        }
        public string ChannelName
        {
            get { return Properties.Settings.Default.ChannelName; }
        }
        public int Timer
        {
            get { return Decimal.ToInt32(Properties.Settings.Default.Timer); }
        }

        public TwitchFollowClientForm()
        {
            InitializeComponent();
            lastCheck = DateTime.UtcNow.AddSeconds(-this.Timer);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            lstFollows.DataSource = null;
            GetNewFollowers(true);
            tmrUpdate.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstFollows.DataSource = null;
            GetNewFollowers(true);
        }

        private void GetNewFollowers(bool updateLastCheckTime)
        {
            initRestClient();
            TwitchClientFactory twitchClientFactory = new TwitchClientFactory();
            Func<string, Method, IRestRequest> requestFunc = (url, method) => new RestRequest(url, method);
            ITwitchStaticClient twitchClient = twitchClientFactory.CreateStaticReadonlyClient(this.rClient, requestFunc);
            TwitchList<Follow> followList = twitchClient.GetChannelFollowers(this.ChannelName, CreatePageInfo());
            long totalSubs = followList.Total;
            this.lblTotalFollows.Text = "Total Follows: " + totalSubs;
            if (followList.List != null)
            {
                IEnumerable<Follow> newFollowers = from follower in followList.List where follower.CreatedAt > lastCheck select follower;
                if (updateLastCheckTime)
                {
                    lastCheck = DateTime.UtcNow.AddSeconds(-this.Timer);
                }
                lstFollows.DisplayMember = "DisplayName";
                if (this.newList != null)
                {
                    this.oldList = this.newList;
                }
                this.newList = CreateGenericUserList(newFollowers);
                if (this.oldList != null && this.newList.Count > this.oldList.Count)
                {
                    PlayNotificationSound();
                }
                lstFollows.DataSource = this.newList;
            }
        }

        private static void PlayNotificationSound()
        {
            string filename = Properties.Settings.Default.NotificationSoundFile;
            if (!Path.IsPathRooted(Properties.Settings.Default.NotificationSoundFile))
            {
                filename = AppDomain.CurrentDomain.BaseDirectory + Properties.Settings.Default.NotificationSoundFile;
            }
            MediaPlayer.MediaPlayer mp = new MediaPlayer.MediaPlayer();
            mp.Open(filename);
        }

        private PagingInfo CreatePageInfo()
        {
            PagingInfo pages = new PagingInfo();
            pages.PageSize = this.PageSize;
            return pages;
        }

        private void initRestClient()
        {
            this.rClient = new RestClient(Properties.Settings.Default.ApiUrl);
            this.rClient.AddHandler("application/json", new DynamicJsonDeserializer());
            this.rClient.AddDefaultHeader("Accept", "application/vnd.twitchtv.v2+json");
        }

        private List<User> CreateGenericUserList(IEnumerable<Follow> newFollowers)
        {
            List<User> userList = new List<User>();
            foreach (Follow follower in newFollowers)
            {
                userList.Add(follower.User);
            }
            return userList;
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            lstFollows.DataSource = null;
            GetNewFollowers(false);
        }

        private void TwitchFollowClientForm_Load(object sender, EventArgs e)
        {
            this.tmrUpdate.Interval = this.Timer * 1000;
        }

        private void settingsToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
