using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiFootball.Models
{
    public class LeagueTable
    {
        [JsonProperty("teams")]
        public List<Team> teams { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("competition")]
        public Competition competition { get; set; }
    }
}