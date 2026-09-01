using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class Series : CommonMediaBase
{
    public Series()
    {
        //Default
        MediaType = CommonMediaTypes.TvSeries;
    }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("original_name")]
    public string OriginalName { get; set; }

    [JsonPropertyName("first_air_date")]
    public string irstAirDate { get; set; }
}
