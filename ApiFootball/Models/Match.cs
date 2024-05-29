using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiFootball.Models
{
    public class Match
    {
        [JsonProperty("date")]
        public string date { get; set; }

        [JsonProperty("venue")]
        public string venue { get; set; }

        [JsonProperty("competition")]
        public Competition competition { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("time")]
        public string time { get; set; }

        [JsonProperty("home-team")]
        public HomeTeam hometeam { get; set; }

        [JsonProperty("referee")]
        public string referee { get; set; }

        [JsonProperty("away-team")]
        public AwayTeam awayteam { get; set; }

        [JsonProperty("attendance")]
        public int attendance { get; set; }

        [JsonProperty("status")]
        public Status status { get; set; }
    }
}