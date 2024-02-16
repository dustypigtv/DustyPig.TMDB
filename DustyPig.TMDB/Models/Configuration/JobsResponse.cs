using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Configuration;

public class JobsResponse
{
	[JsonPropertyName("department")]
	public string Department { get; set; }

	[JsonPropertyName("jobs")]
	public List<string> Jobs { get; set; } = [];
}
