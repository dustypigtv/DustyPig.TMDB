using DustyPig.TMDB.Enums;
using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Credits;

public class Details : ModelBase
{
    private MovieMedia _movieMedia = null;
    private TvMedia _tvMedia = null;

    [JsonPropertyName("credit_type")]
    public string CreditType { get; set; }

    [JsonPropertyName("department")]
    public string Department { get; set; }

    [JsonPropertyName("job")]
    public string Job { get; set; }

    [JsonPropertyName("media")]
    [JsonInclude]
    public JsonElement Media { get; set; }

    /// <summary>
    /// This property will be populated if <see cref="MediaType"/> == <see cref="MediaTypes.Movie"/>. Otherwise this property will be null.
    /// </summary>
    [JsonIgnore]
    public MovieMedia MovieMedia
    {
        get
        {
            if (MediaType == MediaTypes.Movie)
                return _movieMedia ??= Media.Deserialize<MovieMedia>();

            return null;
        }
    }

    /// <summary>
    /// This property will be populated if <see cref="MediaType"/> == <see cref="MediaTypes.Tv"/>. Otherwise, this property will be null.
    /// </summary>
    [JsonIgnore]
    public TvMedia TvMedia
    {
        get
        {
            if (MediaType == MediaTypes.TvSeries)
                return _tvMedia ??= Media.Deserialize<TvMedia>();
            return null;
        }
    }

    [JsonPropertyName("media_type")]
    [JsonConverter(typeof(MediaTypesConverter))]
    public MediaTypes MediaType { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("person")]
    public Person Person { get; set; }
}
