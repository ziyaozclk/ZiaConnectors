using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViaTim.Plugin.Core
{
    [JsonObject]
    public class ResponseBase
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}
