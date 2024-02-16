using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Network;

public class ImagesResponse
{
	public class LogosObject
	{
		[JsonPropertyName("aspect_ratio")]
		public float AspectRatio { get; set; }

		[JsonPropertyName("file_path")]
		public string FilePath { get; set; }

		[JsonPropertyName("height")]
		public int Height { get; set; }

		[JsonPropertyName("id")]
		public string Id { get; set; }

		[JsonPropertyName("file_type")]
		public string FileType { get; set; }

		[JsonPropertyName("vote_average")]
		public float VoteAverage { get; set; }

		[JsonPropertyName("vote_count")]
		public int VoteCount { get; set; }

		[JsonPropertyName("width")]
		public int Width { get; set; }
	}


	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("logos")]
	public List<LogosObject> Logos { get; set; } = [];
}
