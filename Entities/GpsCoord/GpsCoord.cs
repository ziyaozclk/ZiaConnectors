using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ViaTim.Plugin.Entities.Converters;

namespace ViaTim.Plugin.Entities.GpsCoord
{
    [JsonObject]
    [JsonConverter(typeof(FalseToNullConverter<GpsCoord>))]
    public class GpsCoord
    {
        [JsonProperty(PropertyName = "lat")]
        public double Lat { get; set; }
        [JsonProperty(PropertyName = "lon")]
        public double Lon { get; set; }
    }
}
