using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class LatestResponse
{
	[JsonPropertyName("adult")]
	public bool Adult { get; set; }

	[JsonPropertyName("biography")]
	public string Biography { get; set; }

	[JsonPropertyName("gender")]
	public int Gender { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("popularity")]
	public int Popularity { get; set; }
}
