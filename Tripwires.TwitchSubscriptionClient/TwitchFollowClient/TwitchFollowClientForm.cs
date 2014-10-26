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
        private const string ChannelName = "taniauncensored";
        private DateTime lastCheck;
        public TwitchFollowClientForm()
        {
            InitializeComponent();
            lastCheck = DateTime.UtcNow.AddMinutes(-1);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            lstFollows.DataSource = null;
            GetNewFollowers(true);
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
            TwitchList<Follow> followList = twitchClient.GetChannelFollowers(TwitchFollowClientForm.ChannelName);
            long totalSubs = followList.Total;
            long numberOfPages = totalSubs / TwitchFollowClientForm.PageSize;
            IEnumerable<Follow> newFollowers = from follower in followList.List where follower.CreatedAt > lastCheck select follower;
            if (updateLastCheckTime)
            {
                lastCheck = DateTime.UtcNow.AddMinutes(-1);
            }
            List<User> userList = new List<User>();
            foreach (Follow follower in newFollowers)
            {
                userList.Add(follower.User);
            }
            lstFollows.DisplayMember = "DisplayName";
            lstFollows.DataSource = userList;
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            lstFollows.DataSource = null;
            GetNewFollowers(false);
        }
    }
}
