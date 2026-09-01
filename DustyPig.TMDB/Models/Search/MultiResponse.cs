using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Search;

public class MultiResponse : ModelBase
{
    private List<Person> _people = null;
    private List<Movie> _movies = null;
    private List<Common.TvSeries> _tv = null;

    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }

    [JsonPropertyName("results")]
    public JsonElement Results { get; set; }


    /// <summary>
    /// This property will contain items from <see cref="Results"/> where <see cref="Media.MediaType"/> == <see cref="MediaTypes.Movie"/>.
    /// </summary>
    [JsonIgnore]
    public List<Movie> Movies
    {
        get
        {
            if (_movies == null)
            {
                _movies = [];
                foreach (var item in Results.EnumerateArray())
                {
                    if (item.TryGetProperty("media_type", out var mediaTypeProperty))
                    {
                        string mediaType = mediaTypeProperty.GetString();
                        if (mediaType == "movie")
                        {
                            var movie = JsonSerializer.Deserialize<Movie>(item.GetRawText());
                            if (movie != null)
                                _movies.Add(movie);
                        }
                    }
                }
            }
            return _movies;
        }
    }

    /// <summary>
    /// This property will contain items from <see cref="Results"/> where <see cref="Media.MediaType"/> == <see cref="MediaTypes.Person"/>.
    /// </summary>
    [JsonIgnore]
    public List<Person> People
    {
        get
        {
            if (_people == null)
            {
                _people = [];
                foreach (var item in Results.EnumerateArray())
                {
                    if (item.TryGetProperty("media_type", out var mediaTypeProperty))
                    {
                        string mediaType = mediaTypeProperty.GetString();
                        if (mediaType == "person")
                        {
                            var person = JsonSerializer.Deserialize<Person>(item.GetRawText());
                            if (person != null)
                                _people.Add(person);
                        }
                    }
                }
            }
            return _people;
        }
    }

    /// <summary>
    /// This property will contain items from <see cref="Results"/> where <see cref="Media.MediaType"/> == <see cref="MediaTypes.TvSeries"/>.
    /// </summary>
    [JsonIgnore]
    public List<Common.TvSeries> TvSeries
    {
        get
        {
            if (_tv == null)
            {
                _tv = [];
                foreach (var item in Results.EnumerateArray())
                {
                    if (item.TryGetProperty("media_type", out var mediaTypeProperty))
                    {
                        string mediaType = mediaTypeProperty.GetString();
                        if (mediaType == "tv")
                        {
                            var series = JsonSerializer.Deserialize<Common.TvSeries>(item.GetRawText());
                            if (series != null)
                                _tv.Add(series);
                        }
                    }
                }
            }
            return _tv;
        }
    }
}
