using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Companies;

public class Details : CommonCompany
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("headquarters")]
    public string Headquarters { get; set; }

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("parent_company")]
    public string ParentCompany { get; set; }
}
