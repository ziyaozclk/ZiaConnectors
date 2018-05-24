using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ViaTim.Plugin.Core;

namespace ViaTim.Plugin.Entities.Error
{
    [JsonObject]
    public class MissingParams : ErrorBase
    {
        [JsonProperty(PropertyName = "errors")]
        public string[] Errors { get; set; }
    }
}
