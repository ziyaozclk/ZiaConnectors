using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ViaTim.Plugin.Core;

namespace ViaTim.Plugin.Entities.Address
{
    [JsonObject]
    public class AddressRoot : ResponseBase
    {
        [JsonProperty(PropertyName = "data")]
        public Address Address { get; set; }
    }
}
