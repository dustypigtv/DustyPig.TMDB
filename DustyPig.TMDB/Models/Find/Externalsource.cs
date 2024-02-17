using System.ComponentModel;

namespace DustyPig.TMDB.Models.Find;

public enum Externalsource
{
    [Description("imdb_id")]
    ImdbId,

    [Description("facebook_id")]
    FacebookId,

    [Description("instagram_id")]
    InstagramId,

    [Description("tvdb_id")]
    TvdbId,

    [Description("tiktok_id")]
    TiktokId,

    [Description("twitter_id")]
    TwitterId,

    [Description("wikidata_id")]
    WikidataId,

    [Description("youtube_id")]
    YoutubeId
}