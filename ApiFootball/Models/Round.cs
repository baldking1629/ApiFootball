using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiFootball.Models
{
    public class Round
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }
    }
}