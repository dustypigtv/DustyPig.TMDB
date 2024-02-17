using DustyPig.TMDB.JsonHelpers;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Review;

public class DetailsResponse
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


	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("author")]
	public string Author { get; set; }

	[JsonPropertyName("author_details")]
	public AuthorDetailsObject AuthorDetails { get; set; }

	[JsonPropertyName("content")]
	public string Content { get; set; }

	[JsonPropertyName("created_at")]
	[JsonConverter(typeof(StringToDateTimeConverter))]
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
	/// </summary>
	[JsonPropertyName("iso_639_1")]
	public string LanguageCode { get; set; }

	[JsonPropertyName("media_id")]
	public int MediaId { get; set; }

	[JsonPropertyName("media_title")]
	public string MediaTitle { get; set; }

	[JsonPropertyName("media_type")]
	public string MediaType { get; set; }

	[JsonPropertyName("updated_at")]
	[JsonConverter(typeof(StringToDateTimeConverter))]
	public DateTime? UpdatedAt { get; set; }

	[JsonPropertyName("url")]
	public string Url { get; set; }
}
