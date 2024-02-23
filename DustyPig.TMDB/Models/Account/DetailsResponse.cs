using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class DetailsResponse
{
    public class AvatarObject
    {
        public class GravatarObject
        {
            [JsonPropertyName("hash")]
            public string Hash { get; set; }
        }

        public class TmdbObject
        {
            [JsonPropertyName("avatar_path")]
            public string AvatarPath { get; set; }
        }


        [JsonPropertyName("gravatar")]
        public GravatarObject Gravatar { get; set; }

        [JsonPropertyName("tmdb")]
        public TmdbObject Tmdb { get; set; }
    }


    [JsonPropertyName("avatar")]
    public AvatarObject Avatar { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
    /// </summary>
    [JsonPropertyName("iso_639_1")]
    public string LanguageCode { get; set; }

    /// <summary>
    /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
    /// </summary>
    [JsonPropertyName("iso_3166_1")]
    public string CountryCode { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("include_adult")]
    public bool IncludeAdult { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }
}
