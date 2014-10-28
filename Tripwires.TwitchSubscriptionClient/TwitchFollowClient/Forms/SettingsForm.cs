using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchFollowClient
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ChannelName = txtChannelName.Text;
            Properties.Settings.Default.Timer = nmrTimer.Value;
            Properties.Settings.Default.Save();
            this.FindForm().Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            this.FindForm().Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            this.FindForm().Close();
        }

    }
}
