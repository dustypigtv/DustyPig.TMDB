using System.ComponentModel;

namespace DustyPig.TMDB.Models.Discover;

public enum Sortby2
{
    [Description("first_air_date.asc")]
    FirstAirDateAsc,

    [Description("first_air_date.desc")]
    FirstAirDateDesc,

    [Description("name.asc")]
    NameAsc,

    [Description("name.desc")]
    NameDesc,

    [Description("original_name.asc")]
    OriginalNameAsc,

    [Description("original_name.desc")]
    OriginalNameDesc,

    [Description("popularity.asc")]
    PopularityAsc,

    [Description("popularity.desc")]
    PopularityDesc,

    [Description("vote_average.asc")]
    VoteAverageAsc,

    [Description("vote_average.desc")]
    VoteAverageDesc,

    [Description("vote_count.asc")]
    VoteCountAsc,

    [Description("vote_count.desc")]
    VoteCountDesc
}