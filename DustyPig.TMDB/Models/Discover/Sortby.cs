using System.ComponentModel;

namespace DustyPig.TMDB.Models.Discover;

public enum Sortby
{
	[Description("original_title.asc")]
	OriginalTitleAsc,

	[Description("original_title.desc")]
	OriginalTitleDesc,

	[Description("popularity.asc")]
	PopularityAsc,

	[Description("popularity.desc")]
	PopularityDesc,

	[Description("revenue.asc")]
	RevenueAsc,

	[Description("revenue.desc")]
	RevenueDesc,

	[Description("primary_release_date.asc")]
	PrimaryReleaseDateAsc,

	[Description("title.asc")]
	TitleAsc,

	[Description("title.desc")]
	TitleDesc,

	[Description("primary_release_date.desc")]
	PrimaryReleaseDateDesc,

	[Description("vote_average.asc")]
	VoteAverageAsc,

	[Description("vote_average.desc")]
	VoteAverageDesc,

	[Description("vote_count.asc")]
	VoteCountAsc,

	[Description("vote_count.desc")]
	VoteCountDesc
}