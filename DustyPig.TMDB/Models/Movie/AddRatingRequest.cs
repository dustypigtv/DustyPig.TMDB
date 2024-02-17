using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class AddRatingRequest
{
	[JsonPropertyName("value")]
	public float Value { get; set; }
}
