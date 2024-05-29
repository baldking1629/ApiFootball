using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiFootball.Models
{
    public class Root
    {
        [JsonProperty("league-table")]
        public LeagueTable league_table { get; set; }

        [JsonProperty("fixtures-results")]
        public FixturesResults fixturesresults { get; set; }

        [JsonProperty("competitions")]
        public List<Competition> competitions { get; set; }
    }
}