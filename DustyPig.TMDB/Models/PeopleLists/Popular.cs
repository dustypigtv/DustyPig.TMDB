using DustyPig.TMDB.Enums;
using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.PeopleLists;

public class Popular : ModelBase
{
    private List<Movie> _knownForMovies = null;
    private List<Common.TvSeries> _knownForSeries = null;

    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("gender")]
    public Gender Gender { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("known_for")]
    public JsonElement KnownFor { get; set; }


    /// <summary>
    /// This property will contain items from <see cref="KnownFor"/> where <see cref="Media.MediaType"/> == <see cref="MediaTypes.Movie"/>.
    /// </summary>
    [JsonIgnore]
    public List<Movie> KnownForMovies
    {
        get
        {
            if (_knownForMovies == null)
            {
                _knownForMovies = KnownFor.Deserialize<List<Movie>>();
                _knownForMovies.RemoveAll(_ => _.MediaType != MediaTypes.Movie);
            }
            return _knownForMovies;
        }
    }

    /// <summary>
    /// This property will contain items from <see cref="KnownFor"/> where <see cref="Media.MediaType"/> == <see cref="MediaTypes.TvSeries"/>.
    /// </summary>
    [JsonIgnore]
    public List<Common.TvSeries> KnownForTv
    {
        get
        {
            if (_knownForSeries == null)
            {
                _knownForSeries = KnownFor.Deserialize<List<Common.TvSeries>>();
                _knownForSeries.RemoveAll(_ => _.MediaType != MediaTypes.TvSeries);
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