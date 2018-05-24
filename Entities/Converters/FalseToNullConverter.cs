using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViaTim.Plugin.Entities.Converters
{
    public class FalseToNullConverter<TEntity> : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var startObject = JObject.Load(reader);

                    var image = Activator.CreateInstance<TEntity>();

                    serializer.Populate(startObject.CreateReader(), image);

                    return image;
                case JsonToken.EndObject:
                    return Activator.CreateInstance<TEntity>();
                case JsonToken.Boolean:
                    return null;
                default:
                    return null;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(TEntity).IsAssignableFrom(objectType);
        }
    }
}
