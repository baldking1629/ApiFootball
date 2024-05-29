using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiFootball.Models
{
    public class Team
    {
        [JsonProperty("all-matches")]
        public AllMatches allmatches { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("home-matches")]
        public HomeMatches homematches { get; set; }

        [JsonProperty("away-matches")]
        public AwayMatches awaymatches { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("position")]
        public int position { get; set; }

        [JsonProperty("total-points")]
        public int totalpoints { get; set; }

        [JsonProperty("outcome")]
        public string outcome { get; set; }

        [JsonProperty("zone")]
        public string zone { get; set; }

        [JsonProperty("points-deducted")]
        public int? pointsdeducted { get; set; }
    }
}