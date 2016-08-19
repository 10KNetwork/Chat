using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using JSONObjects;
using System.Collections.Specialized;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net.Http;

namespace Handlers
{
    class OAuthHandler
    {
        private string crumb = string.Empty;       
        private CookieWebClient client = new CookieWebClient();
        private string email;
        private string team;
        private string password;

        public OAuthHandler(string team, string email, string password) 
        {
            this.email = email;
            this.team = team;
            this.password = password;
        }
        public OAuthJSON authenticate() 
        {            
            browser1();
            browser2();
            string result = client.DownloadString("https://slack.com/oauth/authorize?client_id=46019978006.53710425472&scope=client");
            crumb = findCrumb(result);
            return browser3();
        }
        private string findCrumb(string body)
        {
            Regex regex = new Regex(@"\bs-\d{10}-\w{10}-");
            Match match = regex.Match(body);
            return match.Value + "%E2%98%83";
        }
        private void browser1()
        {
            byte[] post =
                this.client.UploadValues("https://" + this.team + ".slack.com/?redir=%2Foauth%2Freflow%3Fclient_id%3D46019978006.53710425472%26scope%3Dclient", new NameValueCollection()
                {
                                { "email", this.email },
                                { "password", this.password },
                                {"crumb", this.crumb },
                                {"signin", "1"},
                                {"redir","/oauth/reflow/?client_id=46019978006.56022780309&scope=client" }
                });
            string result = System.Text.Encoding.UTF8.GetString(post);
            this.crumb = findCrumb(result);
        }
        private void browser2() 
        {
            byte[] post =
                this.client.UploadValues(client.ResponseUri.ToString(), new NameValueCollection()
                {
                                { "email", this.email },
                                { "password", this.password },
                                {"crumb", this.crumb },
                                {"signin", "1"},
                                {"redir","%2Foauth%2Freflow%3Fclient_id%3D46019978006.53710425472%26scope%3Dclient" },
                                {"remember","on"}
                });
            string result = System.Text.Encoding.UTF8.GetString(post);
        }
        private OAuthJSON browser3()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(client.ResponseUri.ToString());
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            string postData = "create_authorization=1&crumb=" + this.crumb;
            byte[] bytes = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = bytes.Length;
            request.CookieContainer = client.CookieContainer;
            request.AllowAutoRedirect = false;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            HttpWebResponse webResponse;
            using (webResponse = (HttpWebResponse)request.GetResponse())
            {
                // Now look to see if it's a redirect
                if ((int)webResponse.StatusCode >= 300 && (int)webResponse.StatusCode <= 399)
                {
                    string uriString = webResponse.Headers["Location"];
                    
                    webResponse.Close(); // don't forget to close it - or bad things happen!
                    int index1 = (uriString.IndexOf('?')) + 1;
                    int index2 = (uriString.Length) - index1;
                    string test = uriString.Substring(index1, index2);
                    string json = "";
                    string tokenUrl = "https://slack.com/api/oauth.access?client_id=46019978006.53710425472&client_secret=d521167e2ae119f89dd043725479a217&" + test;
                    var Client = new HttpClient();
                    Task.Run(async () =>
                    {
                        json = await Client.GetStringAsync(tokenUrl);
                    }).Wait();
                    
                    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(OAuthJSON));
                    MemoryStream ms = new MemoryStream(System.Text.ASCIIEncoding.ASCII.GetBytes(json));
                    OAuthJSON User = (OAuthJSON)js.ReadObject(ms);
                    
                    return User;

                }
                return null;
            }
 
        }
    }
}
