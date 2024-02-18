using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class DetailsResponse
{
    public class CreatedByObject
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("credit_id")]
        public string CreditId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("profile_path")]
        public string ProfilePath { get; set; }
    }

    public class GenresObject
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class LastEpisodeToAirObject
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; }

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }

        [JsonPropertyName("air_date")]
        [JsonConverter(typeof(StringToDateOnlyConverter))]
        public DateOnly? AirDate { get; set; }

        [JsonPropertyName("episode_number")]
        public int EpisodeNumber { get; set; }

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
    }

    public class NetworksObject
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

    public class ProductionCompaniesObject
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

    public class ProductionCountriesObject
    {
        /// <summary>
        /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
        /// </summary>
        [JsonPropertyName("iso_3166_1")]
        public string CountryCode { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class SeasonsObject
    {
        [JsonPropertyName("air_date")]
        [JsonConverter(typeof(StringToDateOnlyConverter))]
        public DateOnly? AirDate { get; set; }

        [JsonPropertyName("episode_count")]
        public int EpisodeCount { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; }

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; }

        [JsonPropertyName("season_number")]
        public int SeasonNumber { get; set; }

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }
    }

    public class SpokenLanguagesObject
    {
        [JsonPropertyName("english_name")]
        public string EnglishName { get; set; }

        /// <summary>
        /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
        /// </summary>
        [JsonPropertyName("iso_639_1")]
        public string LanguageCode { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
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

    public class AppendAggregateCreditsObject
    {
        public class CastObject
        {
            public class RolesObject
            {
                [JsonPropertyName("credit_id")]
                public string CreditId { get; set; }

                [JsonPropertyName("character")]
                public string Character { get; set; }

                [JsonPropertyName("episode_count")]
                public int EpisodeCount { get; set; }
            }


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

            [JsonPropertyName("roles")]
            public List<RolesObject> Roles { get; set; } = [];

            [JsonPropertyName("total_episode_count")]
            public int TotalEpisodeCount { get; set; }

            [JsonPropertyName("order")]
            public int Order { get; set; }
        }

        public class CrewObject
        {
            public class JobsObject
            {
                [JsonPropertyName("credit_id")]
                public string CreditId { get; set; }

                [JsonPropertyName("job")]
                public string Job { get; set; }

                [JsonPropertyName("episode_count")]
                public int EpisodeCount { get; set; }
            }


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

            [JsonPropertyName("jobs")]
            public List<JobsObject> Jobs { get; set; } = [];

            [JsonPropertyName("department")]
            public string Department { get; set; }

            [JsonPropertyName("total_episode_count")]
            public int TotalEpisodeCount { get; set; }
        }


        [JsonPropertyName("cast")]
        public List<CastObject> Cast { get; set; } = [];

        [JsonPropertyName("crew")]
        public List<CrewObject> Crew { get; set; } = [];
    }

    public class AppendAlternativeTitlesObject
    {
        public class ResultsObject
        {
            /// <summary>
            /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
            /// </summary>
            [JsonPropertyName("iso_3166_1")]
            public string CountryCode { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("type")]
            public string Type { get; set; }
        }


        [JsonPropertyName("results")]
        public List<ResultsObject> Results { get; set; } = [];
    }

    public class AppendChangesObject
    {
        public class ChangesObject
        {
            public class ItemsObject
            {
                public class ValueObject
                {
                    public class PosterObject
                    {
                        [JsonPropertyName("file_path")]
                        public string FilePath { get; set; }

                        /// <summary>
                        /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
                        /// </summary>
                        [JsonPropertyName("iso_639_1")]
                        public string LanguageCode { get; set; }
                    }


                    [JsonPropertyName("poster")]
                    public PosterObject Poster { get; set; }
                }

                public class OriginalValueObject
                {
                    public class PosterObject
                    {
                        [JsonPropertyName("file_path")]
                        public string FilePath { get; set; }

                        /// <summary>
                        /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
                        /// </summary>
                        [JsonPropertyName("iso_639_1")]
                        public string LanguageCode { get; set; }
                    }


                    [JsonPropertyName("poster")]
                    public PosterObject Poster { get; set; }
                }


                [JsonPropertyName("id")]
                public string Id { get; set; }

                [JsonPropertyName("action")]
                public string Action { get; set; }

                [JsonPropertyName("time")]
                [JsonConverter(typeof(StringToDateTimeConverter))]
                public DateTime? Time { get; set; }

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

                [JsonPropertyName("value")]
                public ValueObject Value { get; set; }

                [JsonPropertyName("original_value")]
                public OriginalValueObject OriginalValue { get; set; }
            }


            [JsonPropertyName("key")]
            public string Key { get; set; }

            [JsonPropertyName("items")]
            public List<ItemsObject> Items { get; set; } = [];
        }


        [JsonPropertyName("changes")]
        public List<ChangesObject> Changes { get; set; } = [];
    }

    public class AppendContentRatingsObject
    {
        public class ResultsObject
        {
            /// <summary>
            /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
            /// </summary>
            [JsonPropertyName("iso_3166_1")]
            public string CountryCode { get; set; }

            [JsonPropertyName("rating")]
            public string Rating { get; set; }
        }


        [JsonPropertyName("results")]
        public List<ResultsObject> Results { get; set; } = [];
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

            [JsonPropertyName("credit_id")]
            public string CreditId { get; set; }

            [JsonPropertyName("department")]
            public string Department { get; set; }

            [JsonPropertyName("job")]
            public string Job { get; set; }
        }


        [JsonPropertyName("cast")]
        public List<CastObject> Cast { get; set; } = [];

        [JsonPropertyName("crew")]
        public List<CrewObject> Crew { get; set; } = [];
    }

    public class AppendEpisodeGroupsObject
    {
        public class ResultsObject
        {
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

            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("network")]
            public NetworkObject Network { get; set; }

            [JsonPropertyName("type")]
            public int Type { get; set; }
        }


        [JsonPropertyName("results")]
        public List<ResultsObject> Results { get; set; } = [];
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

        [JsonPropertyName("facebook_id")]
        public string FacebookId { get; set; }

        [JsonPropertyName("instagram_id")]
        public string InstagramId { get; set; }

        [JsonPropertyName("twitter_id")]
        public string TwitterId { get; set; }
    }

    public class AppendImagesObject
    {
        public class BackdropsObject
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

        public class LogosObject
        {
            [JsonPropertyName("aspect_ratio")]
            public float AspectRatio { get; set; }

            [JsonPropertyName("height")]
            public int Height { get; set; }

            /// <summary>
            /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
            /// </summary>
            [JsonPropertyName("iso_639_1")]
            public string LanguageCode { get; set; }

            [JsonPropertyName("file_path")]
            public string FilePath { get; set; }

            [JsonPropertyName("vote_average")]
            public float VoteAverage { get; set; }

            [JsonPropertyName("vote_count")]
            public int VoteCount { get; set; }

            [JsonPropertyName("width")]
            public int Width { get; set; }
        }

        public class PostersObject
        {
            [JsonPropertyName("aspect_ratio")]
            public float AspectRatio { get; set; }

            [JsonPropertyName("height")]
            public int Height { get; set; }

            /// <summary>
            /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
            /// </summary>
            [JsonPropertyName("iso_639_1")]
            public string LanguageCode { get; set; }

            [JsonPropertyName("file_path")]
            public string FilePath { get; set; }

            [JsonPropertyName("vote_average")]
            public float VoteAverage { get; set; }

            [JsonPropertyName("vote_count")]
            public int VoteCount { get; set; }

            [JsonPropertyName("width")]
            public int Width { get; set; }
        }


        [JsonPropertyName("backdrops")]
        public List<BackdropsObject> Backdrops { get; set; } = [];

        [JsonPropertyName("logos")]
        public List<LogosObject> Logos { get; set; } = [];

        [JsonPropertyName("posters")]
        public List<PostersObject> Posters { get; set; } = [];
    }

    public class AppendKeywordsObject
    {
        public class ResultsObject
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("id")]
            public int Id { get; set; }
        }


        [JsonPropertyName("results")]
        public List<ResultsObject> Results { get; set; } = [];
    }

    public class AppendListsObject
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("favorite_count")]
        public int FavoriteCount { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("item_count")]
        public int ItemCount { get; set; }

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
    }

    public class AppendRecommendationsObject
    {
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonPropertyName("original_name")]
        public string OriginalName { get; set; }

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

        [JsonPropertyName("first_air_date")]
        [JsonConverter(typeof(StringToDateOnlyConverter))]
        public DateOnly? FirstAirDate { get; set; }

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }

        [JsonPropertyName("origin_country")]
        public List<string> OriginCountry { get; set; } = [];
    }

    public class AppendReviewsObject
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

    public class AppendScreenedTheatricallyObject
    {
        public class ResultsObject
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("episode_number")]
            public int EpisodeNumber { get; set; }

            [JsonPropertyName("season_number")]
            public int SeasonNumber { get; set; }
        }


        [JsonPropertyName("results")]
        public List<ResultsObject> Results { get; set; } = [];
    }

    public class AppendSimilarObject
    {
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonPropertyName("genre_ids")]
        public List<int> GenreIds { get; set; } = [];

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("origin_country")]
        public List<string> OriginCountry { get; set; } = [];

        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonPropertyName("original_name")]
        public string OriginalName { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; }

        [JsonPropertyName("popularity")]
        public float Popularity { get; set; }

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; }

        [JsonPropertyName("first_air_date")]
        [JsonConverter(typeof(StringToDateOnlyConverter))]
        public DateOnly? FirstAirDate { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }
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

                [JsonPropertyName("homepage")]
                public string Homepage { get; set; }

                [JsonPropertyName("tagline")]
                public string Tagline { get; set; }
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


    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string BackdropPath { get; set; }

    [JsonPropertyName("created_by")]
    public List<CreatedByObject> CreatedBy { get; set; } = [];

    [JsonPropertyName("episode_run_time")]
    public List<int> EpisodeRunTime { get; set; } = [];

    [JsonPropertyName("first_air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? FirstAirDate { get; set; }

    [JsonPropertyName("genres")]
    public List<GenresObject> Genres { get; set; } = [];

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("in_production")]
    public bool InProduction { get; set; }

    [JsonPropertyName("languages")]
    public List<string> Languages { get; set; } = [];

    [JsonPropertyName("last_air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? LastAirDate { get; set; }

    [JsonPropertyName("last_episode_to_air")]
    public LastEpisodeToAirObject LastEpisodeToAir { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("networks")]
    public List<NetworksObject> Networks { get; set; } = [];

    [JsonPropertyName("number_of_episodes")]
    public int NumberOfEpisodes { get; set; }

    [JsonPropertyName("number_of_seasons")]
    public int NumberOfSeasons { get; set; }

    [JsonPropertyName("origin_country")]
    public List<string> OriginCountry { get; set; } = [];

    [JsonPropertyName("original_language")]
    public string OriginalLanguage { get; set; }

    [JsonPropertyName("original_name")]
    public string OriginalName { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("popularity")]
    public float Popularity { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; }

    [JsonPropertyName("production_companies")]
    public List<ProductionCompaniesObject> ProductionCompanies { get; set; } = [];

    [JsonPropertyName("production_countries")]
    public List<ProductionCountriesObject> ProductionCountries { get; set; } = [];

    [JsonPropertyName("seasons")]
    public List<SeasonsObject> Seasons { get; set; } = [];

    [JsonPropertyName("spoken_languages")]
    public List<SpokenLanguagesObject> SpokenLanguages { get; set; } = [];

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("account_states")]
    public AppendAccountStatesObject AccountStates { get; set; }

    [JsonPropertyName("aggregate_credits")]
    public AppendAggregateCreditsObject AggregateCredits { get; set; }

    [JsonPropertyName("alternative_titles")]
    public AppendAlternativeTitlesObject AlternativeTitles { get; set; }

    [JsonPropertyName("changes")]
    public AppendChangesObject Changes { get; set; }

    [JsonPropertyName("content_ratings")]
    public AppendContentRatingsObject ContentRatings { get; set; }

    [JsonPropertyName("credits")]
    public AppendCreditsObject Credits { get; set; }

    [JsonPropertyName("episode_groups")]
    public AppendEpisodeGroupsObject EpisodeGroups { get; set; }

    [JsonPropertyName("external_ids")]
    public AppendExternalIdsObject ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public AppendImagesObject Images { get; set; }

    [JsonPropertyName("keywords")]
    public AppendKeywordsObject Keywords { get; set; }

    [JsonPropertyName("lists")]
    public PagedResult<AppendListsObject> Lists { get; set; }

    [JsonPropertyName("recommendations")]
    public PagedResult<AppendRecommendationsObject> Recommendations { get; set; }

    [JsonPropertyName("reviews")]
    public PagedResult<AppendReviewsObject> Reviews { get; set; }

    [JsonPropertyName("screened_theatrically")]
    public AppendScreenedTheatricallyObject ScreenedTheatrically { get; set; }

    [JsonPropertyName("similar")]
    public PagedResult<AppendSimilarObject> Similar { get; set; }

    [JsonPropertyName("translations")]
    public AppendTranslationsObject Translations { get; set; }

    [JsonPropertyName("videos")]
    public AppendVideosObject Videos { get; set; }
}
