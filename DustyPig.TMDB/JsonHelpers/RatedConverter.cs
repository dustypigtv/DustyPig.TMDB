using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.JsonHelpers;

internal class RatedConverter : JsonConverter<float?>
{
    public override bool HandleNull => true;

    public override float? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.False)
        {
            return null;
        }
        else
        {
            reader.Read();
            reader.GetString();
            reader.Read();
            var ret = reader.GetSingle();
            reader.Read();
            return ret;
        }
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, float? value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteBooleanValue(false);
        }
        else
        {
            writer.WriteStartObject();
            writer.WriteNumber("value", value.Value);
            writer.WriteEndObject();
        }
    }
}