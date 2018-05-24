using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViaTim.Plugin.Entities.Communication
{
    [JsonObject]
    public class ViaTimCommunication : EntityBase<string>
    {
        [JsonProperty(PropertyName = "period")]
        public int Period { get; set; }

        [JsonProperty(PropertyName = "sent")]
        public int Sent { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
