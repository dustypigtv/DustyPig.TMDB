using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.JsonHelpers;

internal class StringToDateTimeConverter : JsonConverter<DateTime?>
{
    public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value.TmdbToDateTime();
    }

    public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.DateTimeToTmdb());
    }
}
