using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ViaTim.Plugin.Entities.Types;

namespace ViaTim.Plugin.Entities.Recipient
{
    public class ViaTimRecipient : UserBase
    {
        [JsonProperty(PropertyName = "company_name")]
        public string CompanyName { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
    }
}
