using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class ChangesResponse
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