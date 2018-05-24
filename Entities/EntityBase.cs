using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViaTim.Plugin.Entities
{
    public class EntityBase<TKey>
    {
        [JsonProperty(PropertyName = "id")]
        public TKey Id { get; set; }
    }
}
