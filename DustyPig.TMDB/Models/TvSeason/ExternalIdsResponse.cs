using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeason;

public class ExternalIdsResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("freebase_mid")]
    public string FreebaseMid { get; set; }

    [JsonPropertyName("freebase_id")]
    public string FreebaseId { get; set; }

    [JsonPropertyName("tvdb_id")]
    public int TvdbId { get; set; }

    [JsonPropertyName("wikidata_id")]
    public string WikidataId { get; set; }
}
