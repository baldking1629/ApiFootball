using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ApiFootball.Models
{
    public class FixturesResults
    {

        [JsonProperty("team")]
        public Team team { get; set; }

        [JsonProperty("matches")]
        public List<Match> matches { get; set; }
    }
}