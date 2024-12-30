using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace TheLine.Elements
{
    public class ElementTypeDictionaryConverter : JsonConverter<Dictionary<ElementType, int>>
    {
        public override Dictionary<ElementType, int> ReadJson(JsonReader reader, Type objectType, Dictionary<ElementType, int> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var dictionary = new Dictionary<ElementType, int>();

            if (reader.TokenType == JsonToken.StartObject)
            {
                JObject jObject = JObject.Load(reader);

                foreach (var property in jObject.Properties())
                {
                    if (Enum.TryParse<ElementType>(property.Name, true, out var elementType))
                    {
                        dictionary[elementType] = property.Value.ToObject<int>();
                    }
                    else
                    {
                        throw new JsonSerializationException($"Invalid ElementType key '{property.Name}' in JSON.");
                    }
                }
            }
            else
            {
                throw new JsonSerializationException("Expected StartObject token when deserializing Dictionary<ElementType, int>.");
            }

            return dictionary;
        }

        public override void WriteJson(JsonWriter writer, Dictionary<ElementType, int> value, JsonSerializer serializer)
        {
            writer.WriteStartObject();

            foreach (var kvp in value)
            {
                writer.WritePropertyName(kvp.Key.ToString());
                writer.WriteValue(kvp.Value);
            }

            writer.WriteEndObject();
        }
    }
}
