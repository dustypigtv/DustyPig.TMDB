using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Network;

public class LogosObject
{
    [JsonPropertyName("aspect_ratio")]
    public float AspectRatio { get; set; }

    [JsonPropertyName("file_path")]
    public string FilePath { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("file_type")]
    public string FileType { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }
}