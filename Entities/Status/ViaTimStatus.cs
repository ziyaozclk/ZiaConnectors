using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViaTim.Plugin.Entities.Status
{
    [JsonObject]
    public class ViaTimStatus : EntityBase<string>
    {
        [JsonProperty(PropertyName = "photo_path")]
        public string PhotoPath { get; set; }
        [JsonProperty(PropertyName = "gps_coords")]
        public GpsCoord.GpsCoord GpsCoords { get; set; }
    }
}
