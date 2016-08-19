using Handlers;
using JSONObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatters
{
    public partial class Main : Form
    {
        private List<Group> Groups = new List<Group>();
        private List<Channel> Channels = new List<Channel>();
        RTMMessenger messenger = new RTMMessenger();
        public Main()
        {
            InitializeComponent();
        }

        private void Page_loaded(object sender, EventArgs e)
        {
            Login _login = new Login(ref messenger);
            _login.ShowDialog();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            txtChat.Enabled = true;
            //await Task.Delay(10000);
            txtChat.DataBindings.Add("Text",
                                messenger,
                                "received",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);            
            await messenger.Connect();
            Groups.AddRange(messenger.response.Groups);
            lstChannels.DataSource = Groups;
            lstChannels.DisplayMember = "Name";
            lstChannels.ValueMember = "Id";
            Groups.AddRange(messenger.response.Groups);
            lstGroups.DataSource = Groups;
            lstGroups.DisplayMember = "Name";
            lstGroups.ValueMember = "Id";
            lstGroups.Enabled = true;
            txtMessage.Enabled = true;
            btnSend.Enabled = true;    
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await messenger.Send(txtMessage.Text, (string)lstChannels.SelectedValue);
        }
    }
}
