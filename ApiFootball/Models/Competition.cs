using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace ApiFootball.Models
{
    public class Competition
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("generic-name")]
        public string genericname { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("full-name")]
        public string fullname { get; set; }

        [JsonProperty("rounds")]
        public List<Round> rounds { get; set; }
    }
}