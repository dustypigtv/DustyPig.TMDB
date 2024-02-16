using System;
using System.ComponentModel;

namespace DustyPig.TMDB.Models.Person;

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

	[Description("tagged_images")]
	TaggedImages = 32,

	[Description("translations")]
	Translations = 64,

	[Description("tv_credits")]
	TvCredits = 128
}