using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

internal class FloatValueWrapper
{
    public FloatValueWrapper() { }

    public FloatValueWrapper(float value) => Value = value;

    [JsonPropertyName("value")]
    public float Value { get; set; }
}
