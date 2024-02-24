using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movies;

public class AuthorDetails
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("avatar_path")]
    public string AvatarPath { get; set; }
}