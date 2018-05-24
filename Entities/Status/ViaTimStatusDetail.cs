using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ViaTim.Plugin.Entities.Types;

namespace ViaTim.Plugin.Entities.Status
{
    [JsonObject]
    public class ViaTimStatusDetail : ViaTimStatus
    {
        [JsonProperty(PropertyName = "status")]
        public TrackingStatus Status { get; set; }
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime Timestamp { get; set; }
        [JsonProperty(PropertyName = "user_id")]
        public int UserId { get; set; }
    }
}
