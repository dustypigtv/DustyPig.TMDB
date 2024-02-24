using DustyPig.TMDB.Models.Common;
using System.Text.Json;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.JsonHelpers;

internal class MediaTypesConverter : JsonConverter<MediaTypes>
{
    public override MediaTypes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetString() switch
        {
            "movie" => MediaTypes.Movie,
            "tv" => MediaTypes.TvSeries,
            "person" => MediaTypes.Person,
            _ => MediaTypes.Unknown,
        };
    }

    public override void Write(Utf8JsonWriter writer, MediaTypes value, JsonSerializerOptions options)
    {
        string str = value switch
        {
            MediaTypes.Movie => "movie",
            MediaTypes.TvSeries => "tv",
            MediaTypes.Person => "person",
            _ => string.Empty
        };

        writer.WriteStringValue(str);
    }
}