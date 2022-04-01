using DustyPig.TMDB.Models;
using Newtonsoft.Json;
using System;

namespace DustyPig.TMDB
{
    public static class Extensions
    {
        public static ErrorResponse GetErrorResponse(this Exception ex) => JsonConvert.DeserializeObject<ErrorResponse>(ex.Message);
    }
}
