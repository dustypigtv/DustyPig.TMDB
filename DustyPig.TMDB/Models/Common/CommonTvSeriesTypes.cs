using System;
using System.ComponentModel;

namespace DustyPig.TMDB.Models.Common;

[Flags]
public enum CommonTvSeriesTypes
{
    [Description("0")]
    ReturningSeries = 1,

    [Description("1")]
    Planned = 2,

    [Description("2")]
    InProduction = 4,

    [Description("3")]
    Ended = 8,

    [Description("4")]
    Cancelled = 16,

    [Description("5")]
    Pilot = 32
}