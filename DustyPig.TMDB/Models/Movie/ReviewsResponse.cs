using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class ReviewsResponse
{
    public class ResultsObject
    {
        public class AuthorDetailsObject
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("username")]
            public string Username { get; set; }

            [JsonPropertyName("avatar_path")]
            public string AvatarPath { get; set; }
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


    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("results")]
    public List<ResultsObject> Results { get; set; } = [];

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }
}
