using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisode;

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
