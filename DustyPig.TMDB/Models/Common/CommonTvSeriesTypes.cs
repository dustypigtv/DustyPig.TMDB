using System;
using System.ComponentModel;

namespace DustyPig.TMDB.Models.Common;

[Flags]
public enum CommonTvSeriesTypes
{
    [Description("0")]
    Documentary = 1,

    [Description("1")]
    News = 2,

    [Description("2")]
    Miniseries = 4,

    [Description("3")]
    Reality = 8,

    [Description("4")]
    Scripted = 16,

    [Description("5")]
    TalkShow = 32,

    [Description("6")]
    Video = 64
}