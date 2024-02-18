using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisodeGroup;

public class DetailsResponse
{
    public class GroupsObject
    {
        public class EpisodesObject
        {
            [JsonPropertyName("air_date")]
            [JsonConverter(typeof(StringToDateOnlyConverter))]
            public DateOnly? AirDate { get; set; }

            [JsonPropertyName("episode_number")]
            public int EpisodeNumber { get; set; }

            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("overview")]
            public string Overview { get; set; }

            [JsonPropertyName("production_code")]
            public string ProductionCode { get; set; }

            [JsonPropertyName("season_number")]
            public int SeasonNumber { get; set; }

            [JsonPropertyName("show_id")]
            public int ShowId { get; set; }

            [JsonPropertyName("still_path")]
            public string StillPath { get; set; }

            [JsonPropertyName("vote_average")]
            public float VoteAverage { get; set; }

            [JsonPropertyName("vote_count")]
            public int VoteCount { get; set; }

            [JsonPropertyName("order")]
            public int Order { get; set; }
        }


        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("order")]
        public int Order { get; set; }

        [JsonPropertyName("episodes")]
        public List<EpisodesObject> Episodes { get; set; } = [];

        [JsonPropertyName("locked")]
        public bool Locked { get; set; }
    }

    public class NetworkObject
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("logo_path")]
        public string LogoPath { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("origin_country")]
        public string OriginCountry { get; set; }
    }


    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("episode_count")]
    public int EpisodeCount { get; set; }

    [JsonPropertyName("group_count")]
    public int GroupCount { get; set; }

    [JsonPropertyName("groups")]
    public List<GroupsObject> Groups { get; set; } = [];

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("network")]
    public NetworkObject Network { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }
}
