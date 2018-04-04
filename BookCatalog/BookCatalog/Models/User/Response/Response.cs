using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Models.User.Response
{
    public class Response
    {
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "avatar_url")]
        public string Avatar_url { get; set; }

        [JsonProperty(PropertyName = "gravatar_id")]
        public string Gravatar_id { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "html_url")]
        public string Html_url { get; set; }

        [JsonProperty(PropertyName = "followers_url")]
        public string Followers_url { get; set; }

        [JsonProperty(PropertyName = "following_url")]
        public string Following_url { get; set; }

        [JsonProperty(PropertyName = "gists_url")]

        public string Gists_url { get; set; }

        [JsonProperty(PropertyName = "starred_url")]
        public string Starred_url { get; set; }

        [JsonProperty(PropertyName = "subscriptions_url")]
        public string Subscriptions_url { get; set; }

        [JsonProperty(PropertyName = "organizations_url")]
        public string Organizations_url { get; set; }

        [JsonProperty(PropertyName = "repos_url")]
        public string Repos_url { get; set; }

        [JsonProperty(PropertyName = "events_url")]
        public string Events_url { get; set; }

        [JsonProperty(PropertyName = "received_events_url")]
        public string Received_events_url { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "site_admin")]
        public bool Site_admin { get; set; }

        [JsonProperty(PropertyName = "name")]
        public object Name { get; set; }

        [JsonProperty(PropertyName = "company")]
        public object Company { get; set; }

        [JsonProperty(PropertyName = "blog")]
        public string Blog { get; set; }

        [JsonProperty(PropertyName = "location")]
        public object Location { get; set; }

        [JsonProperty(PropertyName = "email")]
        public object Email { get; set; }

        [JsonProperty(PropertyName = "hireable")]
        public object Hireable { get; set; }

        [JsonProperty(PropertyName = "bio")]
        public object Bio { get; set; }

        [JsonProperty(PropertyName = "public_repos")]
        public int Public_repos { get; set; }

        [JsonProperty(PropertyName = "public_gists")]
        public int Public_gists { get; set; }

        [JsonProperty(PropertyName = "followers")]
        public int Followers { get; set; }

        [JsonProperty(PropertyName = "following")]
        public int Following { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created_at { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime Updated_at { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "documentation_url")]
        public string Documentation_url { get; set; }
    }
}
