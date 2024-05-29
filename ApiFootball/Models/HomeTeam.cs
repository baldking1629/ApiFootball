using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiFootball.Models
{
    public class HomeTeam
    {
        [JsonProperty("score")]
        public int score { get; set; }

        [JsonProperty("half-time-score")]
        public int halftimescore { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }
    }
}