using System;
using System.ComponentModel;

namespace DustyPig.TMDB.Models.Discover;

[Flags]
public enum WatchMonetizationTypes
{
    [Description("flatrate")]
    FlatRate = 1,

    [Description("free")]
    Free = 2,

    [Description("ads")]
    Ads = 4,

    [Description("rent")]
    Rent = 8,

    [Description("buy")]
    Buy = 16
}