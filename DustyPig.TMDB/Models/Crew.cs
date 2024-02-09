using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    public class Crew
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonPropertyName("profile_path")]
        public string ProfilePath { get; set; }

        public string Job { get; set; }
    }
}
