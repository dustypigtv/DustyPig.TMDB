using System.ComponentModel;

namespace DustyPig.TMDB.Models.Account;

public enum Sortby
{
    [Description("created_at.asc")]
    CreatedAtAsc,

    [Description("created_at.desc")]
    CreatedAtDesc
}