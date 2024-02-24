using System;
using System.ComponentModel;

namespace DustyPig.TMDB.Models.Discover;

[Flags]
public enum ReleaseTypes
{
    [Description("1")]
    Premier = 1,

    [Description("2")]
    TheatricalLimited = 2,

    [Description("3")]
    Theatrical = 4,

    [Description("4")]
    Digital = 8,

    [Description("5")]
    Physical = 16,

    [Description("6")]
    TV = 32
}