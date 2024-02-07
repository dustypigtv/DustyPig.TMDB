using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB
{
    internal class EmptyStringDateTimeConverter : JsonConverter<DateTime?>
    {
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            try { return DateTime.Parse(reader.GetString()); }
            catch { return null; }
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value == null)
                writer.WriteNullValue();
            else
                writer.WriteStringValue(value.ToString());
        }
    }
}
