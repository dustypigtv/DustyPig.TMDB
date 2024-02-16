using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class AddRatingRequest
{
	[JsonPropertyName("value")]
	public float Value { get; set; }
}
