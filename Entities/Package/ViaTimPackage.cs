using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ViaTim.Plugin.Entities.Owner;
using ViaTim.Plugin.Entities.Recipient;
using ViaTim.Plugin.Entities.Sender;
using ViaTim.Plugin.Entities.Types;

namespace ViaTim.Plugin.Entities.Package
{
    [JsonObject]
    public class ViaTimPackage : EntityBase<string>
    {
        [JsonProperty(PropertyName = "date_created")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty(PropertyName = "tracktrace")]
        public string Tracktrace { get; set; }

        [JsonProperty(PropertyName = "type")]
        public PackageTypes Type { get; set; }

        [JsonProperty(PropertyName = "size")]
        public object Size { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public double Weight { get; set; }

        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }

        [JsonProperty(PropertyName = "instructions")]
        public object Instructions { get; set; }

        [JsonProperty(PropertyName = "mark")]
        public object Mark { get; set; }

        [JsonProperty(PropertyName = "external_nr")]
        public object ExternalNr { get; set; }

        [JsonProperty(PropertyName = "external_reference")]
        public object ExternalReference { get; set; }

        [JsonProperty(PropertyName = "sender")]
        public ViaTimSender Sender { get; set; }

        [JsonProperty(PropertyName = "owner")]
        public ViaTimOwner Owner { get; set; }

        [JsonProperty(PropertyName = "recipient")]
        public ViaTimRecipient Recipient { get; set; }

        [JsonProperty(PropertyName = "status")]
        public Status.ViaTimStatus Status { get; set; }
    }
}
