using System;
using System.ComponentModel;

namespace DustyPig.TMDB.Models.TvSeries;

[Flags]
public enum AppendToResponse
{
	[Description("account_states")]
	AccountStates = 1,

	[Description("aggregate_credits")]
	AggregateCredits = 2,

	[Description("alternative_titles")]
	AlternativeTitles = 4,

	[Description("changes")]
	Changes = 8,

	[Description("content_ratings")]
	ContentRatings = 16,

	[Description("credits")]
	Credits = 32,

	[Description("episode_groups")]
	EpisodeGroups = 64,

	[Description("external_ids")]
	ExternalIds = 128,

	[Description("images")]
	Images = 256,

	[Description("keywords")]
	Keywords = 512,

	[Description("lists")]
	Lists = 1024,

	[Description("recommendations")]
	Recommendations = 2048,

	[Description("reviews")]
	Reviews = 4096,

	[Description("screened_theatrically")]
	ScreenedTheatrically = 8192,

	[Description("similar")]
	Similar = 16384,

	[Description("translations")]
	Translations = 32768,

	[Description("videos")]
	Videos = 65536
}