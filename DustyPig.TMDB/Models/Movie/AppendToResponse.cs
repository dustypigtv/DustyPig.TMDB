using System;
using System.ComponentModel;

namespace DustyPig.TMDB.Models.Movie;

[Flags]
public enum AppendToResponse
{
    [Description("account_states")]
    AccountStates = 1,

    [Description("alternative_titles")]
    AlternativeTitles = 2,

    [Description("changes")]
    Changes = 4,

    [Description("credits")]
    Credits = 8,

    [Description("external_ids")]
    ExternalIds = 16,

    [Description("images")]
    Images = 32,

    [Description("keywords")]
    Keywords = 64,

    [Description("lists")]
    Lists = 128,

    [Description("recommendations")]
    Recommendations = 256,

    [Description("release_dates")]
    ReleaseDates = 512,

    [Description("reviews")]
    Reviews = 1024,

    [Description("similar")]
    Similar = 2048,

    [Description("translations")]
    Translations = 4096,

    [Description("videos")]
    Videos = 8192
}