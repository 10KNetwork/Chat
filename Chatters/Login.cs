using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Handlers;

namespace Chatters
{
    public partial class Login : Form
    {
        RTMMessenger _messenger;
        public Login()
        {
            InitializeComponent();
        }
        public Login(ref RTMMessenger messenger) : this()
        {
            _messenger = messenger;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _messenger.email = txtEmail.Text;
            _messenger.password = txtPass.Text;
            _messenger.teamname = txtTeam.Text;            
            this.Close();
        }
    }
}
