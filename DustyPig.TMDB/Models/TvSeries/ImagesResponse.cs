using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class ImagesResponse
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

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("logos")]
	public List<LogosObject> Logos { get; set; } = [];

	[JsonPropertyName("posters")]
	public List<PostersObject> Posters { get; set; } = [];
}
