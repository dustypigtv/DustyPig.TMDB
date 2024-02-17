using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class ChangesResponse
{
    public class ChangesObject
    {
        public class ItemsObject
        {
            public class ValueObject
            {
                public class PosterObject
                {
                    [JsonPropertyName("file_path")]
                    public string FilePath { get; set; }

                    /// <summary>
                    /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
                    /// </summary>
                    [JsonPropertyName("iso_639_1")]
                    public string LanguageCode { get; set; }
                }


                [JsonPropertyName("poster")]
                public PosterObject Poster { get; set; }
            }

            public class OriginalValueObject
            {
                public class PosterObject
                {
                    [JsonPropertyName("file_path")]
                    public string FilePath { get; set; }

                    /// <summary>
                    /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
                    /// </summary>
                    [JsonPropertyName("iso_639_1")]
                    public string LanguageCode { get; set; }
                }


                [JsonPropertyName("poster")]
                public PosterObject Poster { get; set; }
            }


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
            public ValueObject Value { get; set; }

            [JsonPropertyName("original_value")]
            public OriginalValueObject OriginalValue { get; set; }
        }


        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("items")]
        public List<ItemsObject> Items { get; set; } = [];
    }


    [JsonPropertyName("changes")]
    public List<ChangesObject> Changes { get; set; } = [];
}
