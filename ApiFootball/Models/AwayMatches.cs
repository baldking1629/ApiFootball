using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiFootball.Models
{
    public class AwayMatches
    {
        [JsonProperty("lost")]
        public int lost { get; set; }

        [JsonProperty("against")]
        public int against { get; set; }

        [JsonProperty("won")]
        public int won { get; set; }

        [JsonProperty("for")]
        public int _for { get; set; }

        [JsonProperty("drawn")]
        public int drawn { get; set; }

        [JsonProperty("played")]
        public int played { get; set; }
    }
}