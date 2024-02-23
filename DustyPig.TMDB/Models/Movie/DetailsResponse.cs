using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class DetailsResponse
{
    public class GenresObject
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
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
        [JsonPropertyName("favorite")]
        public bool Favorite { get; set; }

        [JsonPropertyName("rated")]
        [JsonConverter(typeof(RatedConverter))]
        public float? Rated { get; set; }


        [JsonPropertyName("watchlist")]
        public bool Watchlist { get; set; }
    }

    public class AppendAlternativeTitlesObject
    {
        public class TitlesObject
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


        [JsonPropertyName("titles")]
        public List<TitlesObject> Titles { get; set; } = [];
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

            [JsonPropertyName("cast_id")]
            public int CastId { get; set; }

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

    public class AppendExternalIdsObject
    {
        [JsonPropertyName("imdb_id")]
        public string ImdbId { get; set; }

        [JsonPropertyName("facebook_id")]
        public string FacebookId { get; set; }
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
        public class KeywordsObject
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }
        }


        [JsonPropertyName("keywords")]
        public List<KeywordsObject> Keywords { get; set; } = [];
    }

    public class AppendListsObject
    {
        public class ResultsObject
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

            [JsonPropertyName("list_type")]
            public string ListType { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }
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

    public class AppendRecommendationsObject
    {
        public class ResultsObject
        {
            [JsonPropertyName("adult")]
            public bool Adult { get; set; }

            [JsonPropertyName("backdrop_path")]
            public string BackdropPath { get; set; }

            [JsonPropertyName("genre_ids")]
            public List<int> GenreIds { get; set; } = [];

            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("original_language")]
            public string OriginalLanguage { get; set; }

            [JsonPropertyName("original_title")]
            public string OriginalTitle { get; set; }

            [JsonPropertyName("overview")]
            public string Overview { get; set; }

            [JsonPropertyName("popularity")]
            public float Popularity { get; set; }

            [JsonPropertyName("poster_path")]
            public string PosterPath { get; set; }

            [JsonPropertyName("release_date")]
            [JsonConverter(typeof(StringToDateOnlyConverter))]
            public DateOnly? ReleaseDate { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("video")]
            public bool Video { get; set; }

            [JsonPropertyName("vote_average")]
            public float VoteAverage { get; set; }

            [JsonPropertyName("vote_count")]
            public int VoteCount { get; set; }

            [JsonPropertyName("media_type")]
            public string MediaType { get; set; }
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

    public class AppendReleaseDatesObject
    {
        public class ResultsObject
        {
            public class ReleaseDatesObject
            {
                [JsonPropertyName("certification")]
                public string Certification { get; set; }

                /// <summary>
                /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
                /// </summary>
                [JsonPropertyName("iso_639_1")]
                public string LanguageCode { get; set; }

                [JsonPropertyName("note")]
                public string Note { get; set; }

                [JsonPropertyName("release_date")]
                [JsonConverter(typeof(StringToDateOnlyConverter))]
                public DateOnly? ReleaseDate { get; set; }

                [JsonPropertyName("type")]
                public int Type { get; set; }
            }


            /// <summary>
            /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
            /// </summary>
            [JsonPropertyName("iso_3166_1")]
            public string CountryCode { get; set; }

            [JsonPropertyName("release_dates")]
            public List<ReleaseDatesObject> ReleaseDates { get; set; } = [];
        }


        [JsonPropertyName("results")]
        public List<ResultsObject> Results { get; set; } = [];
    }

    public class AppendReviewsObject
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


        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("results")]
        public List<ResultsObject> Results { get; set; } = [];

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }

    public class AppendSimilarObject
    {
        public class ResultsObject
        {
            [JsonPropertyName("adult")]
            public bool Adult { get; set; }

            [JsonPropertyName("backdrop_path")]
            public string BackdropPath { get; set; }

            [JsonPropertyName("genre_ids")]
            public List<int> GenreIds { get; set; } = [];

            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("original_language")]
            public string OriginalLanguage { get; set; }

            [JsonPropertyName("original_title")]
            public string OriginalTitle { get; set; }

            [JsonPropertyName("overview")]
            public string Overview { get; set; }

            [JsonPropertyName("popularity")]
            public float Popularity { get; set; }

            [JsonPropertyName("poster_path")]
            public string PosterPath { get; set; }

            [JsonPropertyName("release_date")]
            [JsonConverter(typeof(StringToDateOnlyConverter))]
            public DateOnly? ReleaseDate { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("video")]
            public bool Video { get; set; }

            [JsonPropertyName("vote_average")]
            public float VoteAverage { get; set; }

            [JsonPropertyName("vote_count")]
            public int VoteCount { get; set; }
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

    public class AppendTranslationsObject
    {
        public class TranslationsObject
        {
            public class DataObject
            {
                [JsonPropertyName("homepage")]
                public string Homepage { get; set; }

                [JsonPropertyName("overview")]
                public string Overview { get; set; }

                [JsonPropertyName("runtime")]
                public int Runtime { get; set; }

                [JsonPropertyName("tagline")]
                public string Tagline { get; set; }

                [JsonPropertyName("title")]
                public string Title { get; set; }
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

    [JsonPropertyName("budget")]
    public int Budget { get; set; }

    [JsonPropertyName("genres")]
    public List<GenresObject> Genres { get; set; } = [];

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("imdb_id")]
    public string ImdbId { get; set; }

    [JsonPropertyName("original_language")]
    public string OriginalLanguage { get; set; }

    [JsonPropertyName("original_title")]
    public string OriginalTitle { get; set; }

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

    [JsonPropertyName("release_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? ReleaseDate { get; set; }

    [JsonPropertyName("revenue")]
    public int Revenue { get; set; }

    [JsonPropertyName("runtime")]
    public int Runtime { get; set; }

    [JsonPropertyName("spoken_languages")]
    public List<SpokenLanguagesObject> SpokenLanguages { get; set; } = [];

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("video")]
    public bool Video { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("account_states")]
    public AppendAccountStatesObject AccountStates { get; set; }

    [JsonPropertyName("alternative_titles")]
    public AppendAlternativeTitlesObject AlternativeTitles { get; set; }

    [JsonPropertyName("changes")]
    public AppendChangesObject Changes { get; set; }

    [JsonPropertyName("credits")]
    public AppendCreditsObject Credits { get; set; }

    [JsonPropertyName("external_ids")]
    public AppendExternalIdsObject ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public AppendImagesObject Images { get; set; }

    [JsonPropertyName("keywords")]
    public AppendKeywordsObject Keywords { get; set; }

    [JsonPropertyName("lists")]
    public AppendListsObject Lists { get; set; }

    [JsonPropertyName("recommendations")]
    public AppendRecommendationsObject Recommendations { get; set; }

    [JsonPropertyName("release_dates")]
    public AppendReleaseDatesObject ReleaseDates { get; set; }

    [JsonPropertyName("reviews")]
    public AppendReviewsObject Reviews { get; set; }

    [JsonPropertyName("similar")]
    public AppendSimilarObject Similar { get; set; }

    [JsonPropertyName("translations")]
    public AppendTranslationsObject Translations { get; set; }

    [JsonPropertyName("videos")]
    public AppendVideosObject Videos { get; set; }
}
