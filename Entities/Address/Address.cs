using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViaTim.Plugin.Entities.Address
{
    [JsonObject]
    public class Address
    {
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }

        [JsonProperty(PropertyName = "municipality")]
        public string Municipality { get; set; }

        [JsonProperty(PropertyName = "gps")]
        public GpsCoord.GpsCoord Gps { get; set; }
    }
}
