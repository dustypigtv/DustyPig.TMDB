using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Lists;

public class Details : ModelBase
{
    private List<Movie> _movies = null;
    private List<Series> _tv = null;

    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("favorite_count")]
    public int FavoriteCount { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    //[JsonPropertyName("items")]
    //public List<CommonMediaBase> Items { get; set; } = [];

    [JsonPropertyName("items")]
    public JsonElement Items { get; set; }

    /// <summary>
    /// This property will contain items from <see cref="Items"/> where <see cref="CommonMediaBase.MediaType"/> == <see cref="CommonMediaTypes.Movie"/>.
    /// </summary>
    [JsonIgnore]
    public List<Movie> Movies
    {
        get
        {
            if (_movies == null)
            {
                _movies = [];
                foreach (var item in Items.EnumerateArray())
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
    /// This property will contain items from <see cref="Items"/> where <see cref="CommonMediaBase.MediaType"/> == <see cref="CommonMediaTypes.TvSeries"/>.
    /// </summary>
    [JsonIgnore]
    public List<Series> TvSeries
    {
        get
        {
            if (_tv == null)
            {
                _tv = [];
                foreach (var item in Items.EnumerateArray())
                {
                    if (item.TryGetProperty("media_type", out var mediaTypeProperty))
                    {
                        string mediaType = mediaTypeProperty.GetString();
                        if (mediaType == "tv")
                        {
                            var series = JsonSerializer.Deserialize<Series>(item.GetRawText());
                            if (series != null)
                                _tv.Add(series);
                        }
                    }
                }
            }
            return _tv;
        }
    }


    [JsonPropertyName("item_count")]
    public int ItemCount { get; set; }

    /// <summary>
    /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
    /// </summary>
    [JsonPropertyName("iso_639_1")]
    public string ISO_639_1 { get; set; }

    /// <summary>
    /// Links to <see cref="ISO_639_1"/>. 
    /// This property is not serialized.
    /// </summary>
    [JsonIgnore]
    public string LanguageCode
    {
        get => ISO_639_1;
        set => ISO_639_1 = value;
    }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; }

    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }
}
