using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ViaTim.Plugin.Core;

namespace ViaTim.Plugin.Entities.Error
{
    [JsonObject]
    public class ErrorBase : ResponseBase
    {
        [JsonProperty(PropertyName = "message")]
        public object Message { get; set; }
    }
}
