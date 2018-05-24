using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViaTim.Plugin.Entities.Error
{
    [JsonObject]
    public class MultipleUsersFound : ErrorBase
    {
        [JsonProperty(PropertyName = "records")]
        public Records Record { get; set; }
    }
    [JsonObject]
    public class Records
    {
        [JsonProperty(PropertyName = "for")]
        public string WhoFor { get; set; }
        [JsonProperty(PropertyName = "users")]
        public UserBase[] Users { get; set; }
    }
}
