using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ViaTim.Plugin.Entities.Recipient;
using ViaTim.Plugin.Entities.Types;

namespace ViaTim.Plugin.Entities.Package
{
    [JsonObject]
    public class ViaTimPackageInputFields : EntityBase<string>
    {
        [JsonProperty(PropertyName = "type")]
        public PackageTypes Type { get; set; }

        [JsonProperty(PropertyName = "recipient")]
        public ViaTimRecipientInputFields Recipient { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public double Weight { get; set; }

        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }

        [JsonProperty(PropertyName = "photo")]
        public bool Photo { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
    }
}
