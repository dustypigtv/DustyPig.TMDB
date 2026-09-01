using DustyPig.TMDB.Models.Common;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.JsonHelpers;


/// <summary>
/// This converts the sequaltal numbers used on TMDB to the flags enum used here
/// </summary>
internal class TvSeriesTypeConverter : JsonConverter<TvSeriesTypes?>
{
    public override TvSeriesTypes? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string strVal = null;
        if (reader.TokenType == JsonTokenType.String)
            strVal = reader.GetString();
        else if (reader.TokenType == JsonTokenType.Number)
            strVal = reader.GetInt32().ToString();

        if (strVal != null)
            foreach (TvSeriesTypes enumValue in Enum.GetValues(typeof(TvSeriesTypes)))
                if (enumValue.GetEnumDescription() == strVal)
                    return enumValue;

        return null;
    }

    public override void Write(Utf8JsonWriter writer, TvSeriesTypes? value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteNullValue();
        }
        else
        {
            var strValue = value.Value.GetEnumDescription();
            if (strValue == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                if (int.TryParse(strValue, out var intVal))
                    writer.WriteNumberValue(intVal);
                else
                    writer.WriteNullValue();
            }
        }
    }
}