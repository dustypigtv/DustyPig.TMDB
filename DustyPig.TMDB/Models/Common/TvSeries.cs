using DustyPig.TMDB.Enums;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class TvSeries : Media
{
    public TvSeries()
    {
        //Default
        MediaType = MediaTypes.TvSeries;
    }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("original_name")]
    public string OriginalName { get; set; }

    [JsonPropertyName("first_air_date")]
    public string FirstAirDate { get; set; }
}
