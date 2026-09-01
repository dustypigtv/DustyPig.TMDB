using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class CombinedCredits : ModelBase
{
    private List<MovieCast> _movieCast = null;
    private List<MovieCrew> _movieCrew = null;
    private List<TvSeriesCast> _tvCast = null;
    private List<TvSeriesCrew> _tvCrew = null;

    //[JsonPropertyName("cast")]
    //public List<Cast> Cast { get; set; } = [];

    [JsonPropertyName("cast")]
    public JsonElement Cast { get; set; }

    [JsonIgnore]
    public List<MovieCast> MovieCast
    {
        get
        {
            if (_movieCast == null)
            {
                _movieCast = [];
                foreach (var item in Cast.EnumerateArray())
                {
                    if (item.TryGetProperty("media_type", out var mediaType) && mediaType.GetString() == "movie")
                    {
                        _movieCast.Add(item.Deserialize<MovieCast>());
                    }
                }
            }
            return _movieCast;
        }
    }

    [JsonIgnore]
    public List<TvSeriesCast> TvCast
    {
        get
        {
            if (_tvCast == null)
            {
                _tvCast = [];
                foreach (var item in Cast.EnumerateArray())
                {
                    if (item.TryGetProperty("media_type", out var mediaType) && mediaType.GetString() == "tv")
                    {
                        _tvCast.Add(item.Deserialize<TvSeriesCast>());
                    }
                }
            }
            return _tvCast;
        }
    }


    //[JsonPropertyName("crew")]
    //public List<MovieCrew> Crew { get; set; } = [];

    [JsonPropertyName("crew")]
    public JsonElement Crew { get; set; }

    [JsonIgnore]
    public List<MovieCrew> MovieCrew
    {
        get
        {
            if (_movieCrew == null)
            {
                _movieCrew = [];
                foreach (var item in Crew.EnumerateArray())
                {
                    if (item.TryGetProperty("media_type", out var mediaType) && mediaType.GetString() == "movie")
                    {
                        _movieCrew.Add(item.Deserialize<MovieCrew>());
                    }
                }
            }
            return _movieCrew;
        }
    }

    [JsonIgnore]
    public List<TvSeriesCrew> TvCrew
    {
        get
        {
            if (_tvCrew == null)
            {
                _tvCrew = [];
                foreach (var item in Crew.EnumerateArray())
                {
                    if (item.TryGetProperty("media_type", out var mediaType) && mediaType.GetString() == "tv")
                    {
                        _tvCrew.Add(item.Deserialize<TvSeriesCrew>());
                    }
                }
            }
            return _tvCrew;
        }
    }


    [JsonPropertyName("id")]
    public int Id { get; set; }
}
