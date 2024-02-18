using DustyPig.TMDB.JsonHelpers;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class ReviewsResponse
{
    public class AuthorDetailsObject
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


    [JsonPropertyName("author")]
    public string Author { get; set; }

    [JsonPropertyName("author_details")]
    public AuthorDetailsObject AuthorDetails { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }

    [JsonPropertyName("created_at")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}