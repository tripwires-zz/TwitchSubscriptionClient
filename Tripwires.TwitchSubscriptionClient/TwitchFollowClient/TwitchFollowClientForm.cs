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
using Twitch.Net.Clients;
using Twitch.Net.Factories;
using Twitch.Net.Helpers;
using Twitch.Net.Interfaces;
using Twitch.Net.Model;

namespace TwitchFollowClient
{
    public partial class TwitchFollowClientForm : Form
    {
        private List<Follow> followers = new List<Follow>();
        private const int PageSize = 100;
        private string channelName = Properties.Settings.Default.ChannelName;
        private int timer = Properties.Settings.Default.Timer;

        public string ChannelName
        {
            get { return channelName; }
        } 
        public int Timer
        {
            get { return timer; }
        }
        private DateTime lastCheck;
        
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
            RestClient rClient = new RestClient("https://api.twitch.tv/kraken");
            rClient.AddHandler("application/json", new DynamicJsonDeserializer());
            rClient.AddDefaultHeader("Accept", "application/vnd.twitchtv.v2+json");
            TwitchClientFactory twitchClientFactory = new TwitchClientFactory();
            Func<string, Method, IRestRequest> requestFunc = (url, method) => new RestRequest(url, method);
            ITwitchStaticClient twitchClient = twitchClientFactory.CreateStaticReadonlyClient(rClient, requestFunc);
            PagingInfo pages = new PagingInfo();
            pages.PageSize = TwitchFollowClientForm.PageSize;
            TwitchList<Follow> followList = twitchClient.GetChannelFollowers(this.ChannelName);
            long totalSubs = followList.Total;
            long numberOfPages = totalSubs / TwitchFollowClientForm.PageSize;
            IEnumerable<Follow> newFollowers = from follower in followList.List where follower.CreatedAt > lastCheck select follower;
            if (updateLastCheckTime)
            {
                lastCheck = DateTime.UtcNow.AddSeconds(-this.Timer);
            }
            List<User> userList = new List<User>();
            foreach (Follow follower in newFollowers)
            {
                userList.Add(follower.User);
            }
            lstFollows.DisplayMember = "DisplayName";
            string test = "blah";
            lstFollows.DataSource = userList;
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            lstFollows.DataSource = null;
            GetNewFollowers(false);
        }

        private void TwitchFollowClientForm_Load(object sender, EventArgs e)
        {
            this.tmrUpdate.Interval = Properties.Settings.Default.Timer * 1000;
            this.channelName = Properties.Settings.Default.ChannelName;
        }
    }
}
