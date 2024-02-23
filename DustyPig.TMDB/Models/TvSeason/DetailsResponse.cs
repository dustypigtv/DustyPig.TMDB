using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeason;

public class DetailsResponse
{
    public class EpisodesObject
    {
        public class CrewObject
        {
            [JsonPropertyName("department")]
            public string Department { get; set; }

            [JsonPropertyName("job")]
            public string Job { get; set; }

            [JsonPropertyName("credit_id")]
            public string CreditId { get; set; }

            [JsonPropertyName("adult")]
            public bool Adult { get; set; }

            [JsonPropertyName("gender")]
            public int Gender { get; set; }

            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("known_for_department")]
            public string KnownForDepartment { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("original_name")]
            public string OriginalName { get; set; }

            [JsonPropertyName("popularity")]
            public float Popularity { get; set; }

            [JsonPropertyName("profile_path")]
            public string ProfilePath { get; set; }
        }

        public class GuestStarsObject
        {
            [JsonPropertyName("character")]
            public string Character { get; set; }

            [JsonPropertyName("credit_id")]
            public string CreditId { get; set; }

            [JsonPropertyName("order")]
            public int Order { get; set; }

            [JsonPropertyName("adult")]
            public bool Adult { get; set; }

            [JsonPropertyName("gender")]
            public int Gender { get; set; }

            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("known_for_department")]
            public string KnownForDepartment { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("original_name")]
            public string OriginalName { get; set; }

            [JsonPropertyName("popularity")]
            public float Popularity { get; set; }

            [JsonPropertyName("profile_path")]
            public string ProfilePath { get; set; }
        }


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

        [JsonPropertyName("runtime")]
        public int Runtime { get; set; }

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

        [JsonPropertyName("crew")]
        public List<CrewObject> Crew { get; set; } = [];

        [JsonPropertyName("guest_stars")]
        public List<GuestStarsObject> GuestStars { get; set; } = [];
    }

    [JsonPropertyName("_id")]
    public string _Id { get; set; }

    [JsonPropertyName("air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? AirDate { get; set; }

    [JsonPropertyName("episodes")]
    public List<EpisodesObject> Episodes { get; set; } = [];

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; }

    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("account_states")]
    public ListResultWithId<AccountStatesResponse> AccountStates { get; set; }

    [JsonPropertyName("aggregate_credits")]
    public AggregateCreditsResponse AggregateCredits { get; set; }

    [JsonPropertyName("credits")]
    public CreditsResponse Credits { get; set; }

    [JsonPropertyName("external_ids")]
    public ExternalIdsResponse ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public ImagesResponse Images { get; set; }

    [JsonPropertyName("translations")]
    public TranslationsResponse Translations { get; set; }

    [JsonPropertyName("videos")]
    public ListResultWithId<VideosResponse> Videos { get; set; }
}
