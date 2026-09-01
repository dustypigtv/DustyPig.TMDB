using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Search;

public class MultiObject : CommonMediaBase
{
    [JsonPropertyName("gender")]
    public CommonGender Gender { get; set; }

    [JsonPropertyName("known_for")]
    public List<CommonMediaBase> KnownFor { get; set; } = [];

    [JsonPropertyName("known_for_department")]
    public string KnownForDepartment { get; set; }

    [JsonPropertyName("profile_path")]
    public string ProfilePath { get; set; }
}