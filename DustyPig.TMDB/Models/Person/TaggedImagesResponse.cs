using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class TaggedImagesResponse : PagedResult<TaggedImagesResponse.ResultsObject>
{
    public class ResultsObject
    {
        public class MediaObject
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


        [JsonPropertyName("aspect_ratio")]
        public float AspectRatio { get; set; }

        [JsonPropertyName("file_path")]
        public string FilePath { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
        /// </summary>
        [JsonPropertyName("iso_639_1")]
        public string LanguageCode { get; set; }

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("image_type")]
        public string ImageType { get; set; }

        [JsonPropertyName("media")]
        public MediaObject Media { get; set; }

        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }
    }


    [JsonPropertyName("id")]
    public int Id { get; set; }
}