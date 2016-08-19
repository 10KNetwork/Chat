using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Handlers
{
    class CookieWebClient : WebClient
    {
        Uri _responseUri;
        public Uri ResponseUri
        {
            get { return _responseUri; }
        }
        public CookieContainer CookieContainer { get; private set; }

        /// <summary>
        /// This will instantiate an internal CookieContainer.
        /// </summary>
        public CookieWebClient() { this.CookieContainer = new CookieContainer(); }

        /// <summary>
        /// Use this if you want to control the CookieContainer outside this class.
        /// <param name="cookieContainer"> The Cookie container to be used.</param>
        /// </summary>
        public CookieWebClient(CookieContainer cookieContainer)
        {
            this.CookieContainer = cookieContainer;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address) as HttpWebRequest;
            if (request == null) return base.GetWebRequest(address);
            request.CookieContainer = CookieContainer;
            return request;
        }
        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = null;
            try
            {
                response = base.GetWebResponse(request);
                _responseUri = response.ResponseUri;
            }
            catch
            {
            }
            return response;
        }
    }
}
