using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Configuration;

public class TimezonesResponse
{
	/// <summary>
	/// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
	/// </summary>
	[JsonPropertyName("iso_3166_1")]
	public string CountryCode { get; set; }

	[JsonPropertyName("zones")]
	public List<string> Zones { get; set; } = [];
}
