using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Credits;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.PeopleLists;

public class Popular : ModelBase
{
    private List<Movie> _knownForMovies = null;
    private List<Series> _knownForSeries = null;

    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("gender")]
    public CommonGender Gender { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("known_for")]
    public JsonElement KnownFor { get; set; }


    /// <summary>
    /// This property will contain items from <see cref="KnownFor"/> where <see cref="CommonMediaBase.MediaType"/> == <see cref="CommonMediaTypes.Movie"/>.
    /// </summary>
    [JsonIgnore]
    public List<Movie> KnownForMovies
    {
        get
        {
            if(_knownForMovies == null)
            {
                _knownForMovies = KnownFor.Deserialize<List<Movie>>();
                _knownForMovies.RemoveAll(_ => _.MediaType != CommonMediaTypes.Movie);
            }
            return _knownForMovies;
        }
    }

    /// <summary>
    /// This property will contain items from <see cref="KnownFor"/> where <see cref="CommonMediaBase.MediaType"/> == <see cref="CommonMediaTypes.TvSeries"/>.
    /// </summary>
    [JsonIgnore]
    public List<Series> KnownForTv
    {
        get
        {
            if (_knownForSeries == null)
            {
                _knownForSeries = KnownFor.Deserialize<List<Series>>();
                _knownForSeries.RemoveAll(_ => _.MediaType != CommonMediaTypes.TvSeries);
            }
            return _knownForSeries;
        }
    }



    [JsonPropertyName("known_for_department")]
    public string KnownForDepartment { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("popularity")]
    public float Popularity { get; set; }

    [JsonPropertyName("profile_path")]
    public string ProfilePath { get; set; }

    [JsonPropertyName("original_name")]
    public string OriginalName { get; set; }
}