using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Configuration;

public class LanguagesResponse
{
	/// <summary>
	/// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
	/// </summary>
	[JsonPropertyName("iso_639_1")]
	public string LanguageCode { get; set; }

	[JsonPropertyName("english_name")]
	public string EnglishName { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }
}
