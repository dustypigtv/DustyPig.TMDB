using Newtonsoft.Json;
using System.Collections.Generic;

namespace DustyPig.TMDB.Models
{
    class InternalSearchResults
    {
        [JsonProperty("results")]
        public List<InternalSearchResult> Results { get; set; } = new List<InternalSearchResult>();
    }
}
