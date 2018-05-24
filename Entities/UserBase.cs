using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ViaTim.Plugin.Entities.Types;

namespace ViaTim.Plugin.Entities
{
    public class UserBase : EntityBase<string>
    {
        [JsonProperty(PropertyName = "date_created")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty(PropertyName = "postcode")]
        public string Postcode { get; set; }

        [JsonProperty(PropertyName = "housenr")]
        public string Housenr { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "streetname")]
        public string Streetname { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "type")]
        public UserTypes Type { get; set; }

        [JsonProperty(PropertyName = "initials")]
        public string Initials { get; set; }

        [JsonProperty(PropertyName = "firstname")]
        public string Firstname { get; set; }

        [JsonProperty(PropertyName = "middlename")]
        public string Middlename { get; set; }

        [JsonProperty(PropertyName = "lastname")]
        public string Lastname { get; set; }

        [JsonProperty(PropertyName = "fullname")]
        public string Fullname { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "gps_coords")]
        public GpsCoord.GpsCoord GpsCoords { get; set; }
    }
}
