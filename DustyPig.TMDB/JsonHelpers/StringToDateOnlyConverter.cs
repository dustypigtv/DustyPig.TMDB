using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.JsonHelpers;

internal class StringToDateOnlyConverter : JsonConverter<DateOnly?>
{
    public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value.TmdbToDateOnly();
    }

    public override void Write(Utf8JsonWriter writer, DateOnly? value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.DateOnlyToTmdb());
    }
}
