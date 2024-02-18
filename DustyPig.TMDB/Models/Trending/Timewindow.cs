using System.ComponentModel;

namespace DustyPig.TMDB.Models.Trending;

public enum Timewindow
{
    [Description("day")]
    Day,

    [Description("week")]
    Week
}