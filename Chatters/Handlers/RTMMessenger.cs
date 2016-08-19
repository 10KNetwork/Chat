using JSONObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Handlers
{
    public class RTMMessenger:INotifyPropertyChanged
    {
        private string _token;
        private string _email;
        private string _teamName;
        private string _password;
        private string _message;
        private CancellationTokenSource cts = new CancellationTokenSource();
        private ClientWebSocket socket = new ClientWebSocket();
        public Response response;
        private string _received = string.Empty;
        public event PropertyChangedEventHandler PropertyChanged;
        Response ato = new Response();
        /// <summary>
        /// Gets received from Slack real Time Messaging server.
        /// Optional and used only for debugging purposes.
        /// </summary>
        public string received
        {
            get { return _received; }
            private set
            {
                if (value != _received)
                {
                    _received = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        public RTMMessenger() { }
        /// <summary>
        /// Gets and sets password
        /// </summary>
        public string password
        {
            get { return _password; }
            set { _password = value; }

        }
        /// <summary>
        /// Gets and sets team name
        /// </summary>
        public string teamname
        {
            get { return _teamName; }
            set { _teamName = value; }
        }
        /// <summary>
        /// Gets and sets email.
        /// </summary>
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        /// <summary>
        /// Gets and sets message.
        /// </summary>
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        ///<summary>
        ///Class constructor to build object. 
        ///Supply team name, username and password.
        ///<param name="teamName">Slack team name</param>
        ///<param name="username"> Slack user name</param>
        ///<param name="password"> Slack password</param>
        ///</summary>
        public RTMMessenger(string teamName,
            string email, string password)
        {
            this.email = email;
            this.teamname = teamName;
            this.password = password;
        }

        /// <summary>
        /// Performs OAuth2.0 authentication
        /// Initiates Slack RTM Start method
        /// And Connects to RTM Web socket.
        /// </summary>
        public async Task Connect()
        {
            OAuthHandler handler = new OAuthHandler(
                _teamName,
                _email,
                _password);
            
            await Connect(response = await Start(handler.authenticate()));         
        }
        private async Task<Response> Start(OAuthJSON user)
        {
            var client = new HttpClient();
            string json = "";
            json = await client.GetStringAsync("https://slack.com/api/rtm.start?token=" + user.access_token);
            return JsonConvert.DeserializeObject<Response>(json);
        }
        private async Task Connect(Response response)
        {
            await socket.ConnectAsync(new Uri(response.Url), cts.Token);
            Task.Factory.StartNew(
                async () =>
                {
                    var rcvBytes = new byte[128];
                    var rcvBuffer = new ArraySegment<byte>(rcvBytes);
                    while (true)
                    {
                        WebSocketReceiveResult rcvResult = await socket.ReceiveAsync(rcvBuffer, cts.Token);
                        byte[] msgBytes = rcvBuffer.Skip(rcvBuffer.Offset).Take(rcvResult.Count).ToArray();
                        received = Encoding.UTF8.GetString(msgBytes);
                    }
                }, cts.Token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }
        /// <summary>
        /// Sends message to specified channel via Slack Real Time messaging API
        /// </summary>
        /// <param name="mymessage"> Specify message to be sent.</param>
        /// <param name="grpId">Specify which channel to send the message.</param>
        /// <returns></returns>
        public async Task Send(string mymessage, string grpId)
        {
            Message msg = new Message();
            msg.Id = 1;
            msg.Channel = grpId;
            msg.Text = mymessage;
            msg.Type = "message";
            string message = JsonConvert.SerializeObject(msg);
            byte[] sendBytes = Encoding.UTF8.GetBytes(message);
            var sendBuffer = new ArraySegment<byte>(sendBytes);
            await socket.SendAsync(sendBuffer, WebSocketMessageType.Text, endOfMessage: true, cancellationToken: cts.Token);
        }
    }
}
