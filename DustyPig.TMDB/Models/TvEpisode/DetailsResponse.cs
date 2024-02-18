using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisode;

public class DetailsResponse
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

    public class AppendAccountStatesObject
    {
        public class RatedObject
        {
            [JsonPropertyName("value")]
            public int Value { get; set; }
        }


        [JsonPropertyName("favorite")]
        public bool Favorite { get; set; }

        [JsonPropertyName("rated")]
        public RatedObject Rated { get; set; }

        [JsonPropertyName("watchlist")]
        public bool Watchlist { get; set; }
    }

    public class AppendCreditsObject
    {
        public class CastObject
        {
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

            [JsonPropertyName("character")]
            public string Character { get; set; }

            [JsonPropertyName("credit_id")]
            public string CreditId { get; set; }

            [JsonPropertyName("order")]
            public int Order { get; set; }
        }

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


        [JsonPropertyName("cast")]
        public List<CastObject> Cast { get; set; } = [];

        [JsonPropertyName("crew")]
        public List<CrewObject> Crew { get; set; } = [];

        [JsonPropertyName("guest_stars")]
        public List<GuestStarsObject> GuestStars { get; set; } = [];
    }

    public class AppendExternalIdsObject
    {
        [JsonPropertyName("imdb_id")]
        public string ImdbId { get; set; }

        [JsonPropertyName("freebase_mid")]
        public string FreebaseMid { get; set; }

        [JsonPropertyName("freebase_id")]
        public string FreebaseId { get; set; }

        [JsonPropertyName("tvdb_id")]
        public int TvdbId { get; set; }

        [JsonPropertyName("tvrage_id")]
        public int TvrageId { get; set; }

        [JsonPropertyName("wikidata_id")]
        public string WikidataId { get; set; }
    }

    public class AppendImagesObject
    {
        public class StillsObject
        {
            [JsonPropertyName("aspect_ratio")]
            public float AspectRatio { get; set; }

            [JsonPropertyName("height")]
            public int Height { get; set; }

            [JsonPropertyName("file_path")]
            public string FilePath { get; set; }

            [JsonPropertyName("vote_average")]
            public float VoteAverage { get; set; }

            [JsonPropertyName("vote_count")]
            public int VoteCount { get; set; }

            [JsonPropertyName("width")]
            public int Width { get; set; }
        }


        [JsonPropertyName("stills")]
        public List<StillsObject> Stills { get; set; } = [];
    }

    public class AppendTranslationsObject
    {
        public class TranslationsObject
        {
            public class DataObject
            {
                [JsonPropertyName("name")]
                public string Name { get; set; }

                [JsonPropertyName("overview")]
                public string Overview { get; set; }
            }


            /// <summary>
            /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
            /// </summary>
            [JsonPropertyName("iso_3166_1")]
            public string CountryCode { get; set; }

            /// <summary>
            /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
            /// </summary>
            [JsonPropertyName("iso_639_1")]
            public string LanguageCode { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("english_name")]
            public string EnglishName { get; set; }

            [JsonPropertyName("data")]
            public DataObject Data { get; set; }
        }


        [JsonPropertyName("translations")]
        public List<TranslationsObject> Translations { get; set; } = [];
    }

    public class AppendVideosObject
    {
        public class ResultsObject
        {
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

            [JsonPropertyName("key")]
            public string Key { get; set; }

            [JsonPropertyName("site")]
            public string Site { get; set; }

            [JsonPropertyName("size")]
            public int Size { get; set; }

            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("official")]
            public bool Official { get; set; }

            [JsonPropertyName("published_at")]
            [JsonConverter(typeof(StringToDateTimeConverter))]
            public DateTime? PublishedAt { get; set; }

            [JsonPropertyName("id")]
            public string Id { get; set; }
        }


        [JsonPropertyName("results")]
        public List<ResultsObject> Results { get; set; } = [];
    }


    [JsonPropertyName("air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? AirDate { get; set; }

    [JsonPropertyName("crew")]
    public List<CrewObject> Crew { get; set; } = [];

    [JsonPropertyName("episode_number")]
    public int EpisodeNumber { get; set; }

    [JsonPropertyName("guest_stars")]
    public List<GuestStarsObject> GuestStars { get; set; } = [];

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("production_code")]
    public string ProductionCode { get; set; }

    [JsonPropertyName("runtime")]
    public int Runtime { get; set; }

    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }

    [JsonPropertyName("still_path")]
    public string StillPath { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("account_states")]
    public AppendAccountStatesObject AccountStates { get; set; }

    [JsonPropertyName("credits")]
    public AppendCreditsObject Credits { get; set; }

    [JsonPropertyName("external_ids")]
    public AppendExternalIdsObject ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public AppendImagesObject Images { get; set; }

    [JsonPropertyName("translations")]
    public AppendTranslationsObject Translations { get; set; }

    [JsonPropertyName("videos")]
    public AppendVideosObject Videos { get; set; }
}
