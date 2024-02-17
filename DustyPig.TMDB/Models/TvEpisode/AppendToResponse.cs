using System;
using System.ComponentModel;

namespace DustyPig.TMDB.Models.TvEpisode;

[Flags]
public enum AppendToResponse
{
    [Description("account_states")]
    AccountStates = 1,

    [Description("credits")]
    Credits = 2,

    [Description("external_ids")]
    ExternalIds = 4,

    [Description("images")]
    Images = 8,

    [Description("translations")]
    Translations = 16,

    [Description("videos")]
    Videos = 32
}