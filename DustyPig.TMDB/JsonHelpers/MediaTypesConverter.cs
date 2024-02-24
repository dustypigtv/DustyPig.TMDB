using DustyPig.TMDB.Models.Common;
using System.Text.Json;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.JsonHelpers;

internal class MediaTypesConverter : JsonConverter<CommonMediaTypes>
{
    public override CommonMediaTypes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetString() switch
        {
            "movie" => CommonMediaTypes.Movie,
            "tv" => CommonMediaTypes.TvSeries,
            "person" => CommonMediaTypes.Person,
            _ => CommonMediaTypes.Unknown,
        };
    }

    public override void Write(Utf8JsonWriter writer, CommonMediaTypes value, JsonSerializerOptions options)
    {
        string str = value switch
        {
            CommonMediaTypes.Movie => "movie",
            CommonMediaTypes.TvSeries => "tv",
            CommonMediaTypes.Person => "person",
            _ => string.Empty
        };

        writer.WriteStringValue(str);
    }
}