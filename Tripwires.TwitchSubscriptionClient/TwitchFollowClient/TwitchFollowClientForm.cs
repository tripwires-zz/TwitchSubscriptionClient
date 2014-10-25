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
        private List<Follow> followers=new List<Follow>();
        private const int PageSize = 100;
        public TwitchFollowClientForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient("https://api.twitch.tv/kraken");
            rClient.AddHandler("application/json", new DynamicJsonDeserializer());
            rClient.AddDefaultHeader("Accept", "application/vnd.twitchtv.v2+json");
            TwitchClientFactory twitchClientFactory = new TwitchClientFactory();
            Func<string, Method, IRestRequest> requestFunc = (url, method) => new RestRequest(url, method);
            ITwitchStaticClient twitchClient = twitchClientFactory.CreateStaticReadonlyClient(rClient, requestFunc);
            PagingInfo pages  = new PagingInfo();
            TwitchList<Follow> followList = twitchClient.GetChannelFollowers("testuser1");
            long totalSubs = followList.Total;
            long numberOfPages = totalSubs / TwitchFollowClientForm.PageSize;
            pages.PageSize = 100;
            for(int i = 0; i < numberOfPages;i++){
                pages.Page = 0;
                IEnumerable<Follow> f = twitchClient.GetChannelFollowers("testuser1", pages).List;
                followers.AddRange(f);
            }
            MessageBox.Show("All set and done");
        }
    }
}
