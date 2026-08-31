using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

/// <summary>
/// This is the base class for all models
/// </summary>
public abstract class ModelBase
{
    /// <summary>
    /// The TMDB Api adds new properties to objects frequently. 
    /// New properties in the models that are not yet in this library will exist here
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement> AdditionalProperties { get; set; } = [];
}