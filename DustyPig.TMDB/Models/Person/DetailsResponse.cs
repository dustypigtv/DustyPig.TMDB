using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class DetailsResponse
{
	public class AppendChangesObject
	{
		public class ChangesObject
		{
			public class ItemsObject
			{
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
				public string Value { get; set; }
			}


			[JsonPropertyName("key")]
			public string Key { get; set; }

			[JsonPropertyName("items")]
			public List<ItemsObject> Items { get; set; } = [];
		}


		[JsonPropertyName("changes")]
		public List<ChangesObject> Changes { get; set; } = [];
	}

	public class AppendCombinedCreditsObject
	{
		public class CastObject
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

			[JsonPropertyName("character")]
			public string Character { get; set; }

			[JsonPropertyName("credit_id")]
			public string CreditId { get; set; }

			[JsonPropertyName("order")]
			public int Order { get; set; }

			[JsonPropertyName("media_type")]
			public string MediaType { get; set; }
		}

		public class CrewObject
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

			[JsonPropertyName("credit_id")]
			public string CreditId { get; set; }

			[JsonPropertyName("department")]
			public string Department { get; set; }

			[JsonPropertyName("job")]
			public string Job { get; set; }

			[JsonPropertyName("media_type")]
			public string MediaType { get; set; }
		}


		[JsonPropertyName("cast")]
		public List<CastObject> Cast { get; set; } = [];

		[JsonPropertyName("crew")]
		public List<CrewObject> Crew { get; set; } = [];
	}

	public class AppendExternalIdsObject
	{
		[JsonPropertyName("freebase_mid")]
		public string FreebaseMid { get; set; }

		[JsonPropertyName("freebase_id")]
		public string FreebaseId { get; set; }

		[JsonPropertyName("imdb_id")]
		public string ImdbId { get; set; }

		[JsonPropertyName("tvrage_id")]
		public int TvrageId { get; set; }

		[JsonPropertyName("wikidata_id")]
		public string WikidataId { get; set; }

		[JsonPropertyName("facebook_id")]
		public string FacebookId { get; set; }

		[JsonPropertyName("instagram_id")]
		public string InstagramId { get; set; }

		[JsonPropertyName("tiktok_id")]
		public string TiktokId { get; set; }

		[JsonPropertyName("twitter_id")]
		public string TwitterId { get; set; }
	}

	public class AppendImagesObject
	{
		public class ProfileObject
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


		[JsonPropertyName("profiles")]
		public List<ProfileObject> Profiles { get; set; } = [];
	}

	public class AppendMovieCreditsObject
	{
		public class CastObject
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

	public class AppendTaggedImagesObject
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
				[JsonPropertyName("biography")]
				public string Biography { get; set; }
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

	public class AppendTvCreditsObject
	{
		public class CastObject
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

			[JsonPropertyName("character")]
			public string Character { get; set; }

			[JsonPropertyName("credit_id")]
			public string CreditId { get; set; }

			[JsonPropertyName("episode_count")]
			public int EpisodeCount { get; set; }
		}

		public class CrewObject
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

			[JsonPropertyName("credit_id")]
			public string CreditId { get; set; }

			[JsonPropertyName("department")]
			public string Department { get; set; }

			[JsonPropertyName("episode_count")]
			public int EpisodeCount { get; set; }

			[JsonPropertyName("job")]
			public string Job { get; set; }
		}


		[JsonPropertyName("cast")]
		public List<CastObject> Cast { get; set; } = [];

		[JsonPropertyName("crew")]
		public List<CrewObject> Crew { get; set; } = [];
	}


	[JsonPropertyName("adult")]
	public bool Adult { get; set; }

	[JsonPropertyName("also_known_as")]
	public List<string> AlsoKnownAs { get; set; } = [];

	[JsonPropertyName("biography")]
	public string Biography { get; set; }

	[JsonPropertyName("birthday")]
	[JsonConverter(typeof(StringToDateOnlyConverter))]
	public DateOnly? Birthday { get; set; }

	[JsonPropertyName("gender")]
	public int Gender { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("imdb_id")]
	public string ImdbId { get; set; }

	[JsonPropertyName("known_for_department")]
	public string KnownForDepartment { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("place_of_birth")]
	public string PlaceOfBirth { get; set; }

	[JsonPropertyName("popularity")]
	public float Popularity { get; set; }

	[JsonPropertyName("profile_path")]
	public string ProfilePath { get; set; }

	[JsonPropertyName("changes")]
	public AppendChangesObject Changes { get; set; }

	[JsonPropertyName("combined_credits")]
	public AppendCombinedCreditsObject CombinedCredits { get; set; }

	[JsonPropertyName("external_ids")]
	public AppendExternalIdsObject ExternalIds { get; set; }

	[JsonPropertyName("images")]
	public AppendImagesObject Images { get; set; }

	[JsonPropertyName("movie_credits")]
	public AppendMovieCreditsObject MovieCredits { get; set; }

	[JsonPropertyName("tagged_images")]
	public AppendTaggedImagesObject TaggedImages { get; set; }

	[JsonPropertyName("translations")]
	public AppendTranslationsObject Translations { get; set; }

	[JsonPropertyName("tv_credits")]
	public AppendTvCreditsObject TvCredits { get; set; }
}
