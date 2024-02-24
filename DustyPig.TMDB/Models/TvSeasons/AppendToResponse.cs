using System;
using System.ComponentModel;

namespace DustyPig.TMDB.Models.TvSeasons;

[Flags]
public enum AppendToResponse
{
    [Description("account_states")]
    AccountStates = 1,

    [Description("aggregate_credits")]
    AggregateCredits = 2,

    [Description("credits")]
    Credits = 4,

    [Description("external_ids")]
    ExternalIds = 8,

    [Description("images")]
    Images = 16,

    [Description("translations")]
    Translations = 32,

    [Description("videos")]
    Videos = 64
}