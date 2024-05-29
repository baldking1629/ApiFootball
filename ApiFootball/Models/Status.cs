using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiFootball.Models
{
    public class Status
    {
        [JsonProperty("short")]
        public string _short { get; set; }

        [JsonProperty("full")]
        public string full { get; set; }
    }
}