using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ViaTim.Plugin.Entities.Communication;
using ViaTim.Plugin.Entities.Owner;
using ViaTim.Plugin.Entities.Recipient;
using ViaTim.Plugin.Entities.Status;

namespace ViaTim.Plugin.Entities.Package
{
    [JsonObject]
    public class ViaTimPackageDetail : ViaTimPackage
    {
        [JsonProperty(PropertyName = "agreed_delivery_timestamp")]
        public object AgreedDeliveryTimestamp { get; set; }

        [JsonProperty(PropertyName = "estimated_delivery_window")]
        public DeliveryWindow EstimatedDeliveryWindow { get; set; }

        [JsonProperty(PropertyName = "actual_delivery_timestamp")]
        public object ActualDeliveryTimestamp { get; set; }

        [JsonProperty(PropertyName = "concept")]
        public bool Concept { get; set; }

        [JsonProperty(PropertyName = "current_recipient")]
        public ViaTimRecipient CurrentRecipient { get; set; }

        [JsonProperty(PropertyName = "current_owner")]
        public ViaTimOwner CurrentOwner { get; set; }

        [JsonProperty(PropertyName = "last_status")]
        public ViaTimStatusDetail LastStatus { get; set; }

        [JsonProperty(PropertyName = "last_communication")]
        public ViaTimCommunication LastCommunication { get; set; }

        public class DeliveryWindow
        {
            public object start { get; set; }
            public object end { get; set; }
        }
    }
}
