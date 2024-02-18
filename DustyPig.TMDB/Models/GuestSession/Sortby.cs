using System.ComponentModel;

namespace DustyPig.TMDB.Models.GuestSession;

public enum Sortby
{
    [Description("created_at.asc")]
    CreatedAtAsc,

    [Description("created_at.desc")]
    CreatedAtDesc
}