using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeasons;

public class AccountState : ModelBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("episode_number")]
    public int EpisodeNumber { get; set; }

    //[JsonPropertyName("rated")]
    //public CommonRated Rated { get; set; }

    public float? Rated
    {
        get
        {
            if (AdditionalProperties.TryGetValue("rated", out var je))
            {
                if (je.ValueKind == System.Text.Json.JsonValueKind.Number)
                {
                    return je.GetSingle();
                }
            }

            return null;
        }
    }
}