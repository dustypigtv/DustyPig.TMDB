using DustyPig.TMDB.Models;
using System;
using System.Text.Json;

namespace DustyPig.TMDB
{
    public static class Extensions
    {
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new(JsonSerializerDefaults.Web);

        public static ErrorResponse GetErrorResponse(this Exception ex) => JsonSerializer.Deserialize<ErrorResponse>(ex.Message, _jsonSerializerOptions);
    }
}
