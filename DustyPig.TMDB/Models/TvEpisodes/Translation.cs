using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisodes;

public class Translation
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }
}
