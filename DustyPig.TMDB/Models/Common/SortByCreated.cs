using System.ComponentModel;

namespace DustyPig.TMDB.Models.Common;

public enum SortByCreated
{
    [Description("created_at.asc")]
    CreatedAtAsc,

    [Description("created_at.desc")]
    CreatedAtDesc
}