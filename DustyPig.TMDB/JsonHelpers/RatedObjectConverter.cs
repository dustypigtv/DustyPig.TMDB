using DustyPig.TMDB.Models.Common;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.JsonHelpers;

internal class RatedObjectConverter : JsonConverter<float?>
{
    public override float? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        //TMDB will return 'false' instead of an object, so ignore non-objects
        if(reader.TokenType != JsonTokenType.StartObject)
            return null;

        float? ret = null;
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
                break;

            if (reader.TokenType == JsonTokenType.PropertyName)
            {
                var propertyName = reader.GetString();
                reader.Read();

                if (propertyName == "value")
                {
                    ret = reader.GetSingle();
                }
                else
                {
                    reader.Skip();
                }
            }
        }
        
        return ret;
    }

    public override void Write(Utf8JsonWriter writer, float? value, JsonSerializerOptions options)
    {
        if(value == null)
        {
            writer.WriteNullValue();
            return;
        }

        writer.WriteStartObject();
        writer.WriteNumber("value", value.Value);
        writer.WriteEndObject();
    }
}
