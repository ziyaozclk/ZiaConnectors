using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ViaTim.Plugin.Core;

namespace ViaTim.Plugin.Entities.Package
{
    [JsonObject]
    public class PackageRoot : ResponseBase
    {
        [JsonProperty(PropertyName = "package")]
        public ViaTimPackageDetail Package { get; set; }
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
        [JsonProperty(PropertyName = "photo_upload_key")]
        public string PhotoUploadKey { get; set; }
    }
}
