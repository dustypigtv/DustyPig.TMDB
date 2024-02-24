using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonAuthorDetails
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("avatar_path")]
    public string AvatarPath { get; set; }

    [JsonPropertyName("rating")]
    public float? Rating { get; set; }
}