using System.Runtime.Serialization;

namespace JSONObjects
{
    public class OAuthJSON
    {

        [DataMember(Name = "ok")]
        public bool ok;

        [DataMember(Name = "access_token")]
        public string access_token;

        [DataMember(Name = "scope")]
        public string scope;

        [DataMember(Name = "user_id")]
        public string user_id;

        [DataMember(Name = "team_name")]
        public string team_name;

        [DataMember(Name = "team_id")]
        public string team_id;
    }
}
