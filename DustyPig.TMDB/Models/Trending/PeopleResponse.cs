using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Trending;

public class PeopleResponse
{
    public class ResultsObject
    {
        public class KnownForObject
        {
            [JsonPropertyName("adult")]
            public bool Adult { get; set; }

            [JsonPropertyName("backdrop_path")]
            public string BackdropPath { get; set; }

            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("original_language")]
            public string OriginalLanguage { get; set; }

            [JsonPropertyName("original_title")]
            public string OriginalTitle { get; set; }

            [JsonPropertyName("overview")]
            public string Overview { get; set; }

            [JsonPropertyName("poster_path")]
            public string PosterPath { get; set; }

            [JsonPropertyName("media_type")]
            public string MediaType { get; set; }

            [JsonPropertyName("genre_ids")]
            public List<int> GenreIds { get; set; } = [];

            [JsonPropertyName("popularity")]
            public float Popularity { get; set; }

            [JsonPropertyName("release_date")]
            [JsonConverter(typeof(StringToDateOnlyConverter))]
            public DateOnly? ReleaseDate { get; set; }

            [JsonPropertyName("video")]
            public bool Video { get; set; }

            [JsonPropertyName("vote_average")]
            public float VoteAverage { get; set; }

            [JsonPropertyName("vote_count")]
            public int VoteCount { get; set; }
        }


        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("original_name")]
        public string OriginalName { get; set; }

        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }

        [JsonPropertyName("popularity")]
        public float Popularity { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("known_for_department")]
        public string KnownForDepartment { get; set; }

        [JsonPropertyName("profile_path")]
        public string ProfilePath { get; set; }

        [JsonPropertyName("known_for")]
        public List<KnownForObject> KnownFor { get; set; } = [];
    }


    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("results")]
    public List<ResultsObject> Results { get; set; } = [];

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }
}
