using IrcDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicIrcConnectivityClient
{
    public partial class Form1 : Form
    {
        public IrcUserRegistrationInfo RegistrationInfo
        {
            get;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(IrcClient c = new IrcClient()){
                
                RegistrationInfo.NickName = "tripwires";
                RegistrationInfo.Password = "2ckqn0neu7wseh6rrjcgiottus088fd";
                c.Connect(new Uri("irc.twitch.tv"), (IrcRegistrationInfo)this.RegistrationInfo);
                foreach (IrcChannel channel in c.Channels)
                {
                   string test =  channel.Name;
                }
            }

        }
    }
}
