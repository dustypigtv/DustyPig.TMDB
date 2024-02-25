using System;
using System.ComponentModel;

namespace DustyPig.TMDB.Models.People;

[Flags]
public enum AppendToResponse
{
    [Description("changes")]
    Changes = 1,

    [Description("combined_credits")]
    CombinedCredits = 2,

    [Description("external_ids")]
    ExternalIds = 4,

    [Description("images")]
    Images = 8,

    [Description("movie_credits")]
    MovieCredits = 16,

    [Description("translations")]
    Translations = 32,

    [Description("tv_credits")]
    TvCredits = 64
}