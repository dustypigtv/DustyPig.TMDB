using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? Birthday { get; set; }

        public DateTime? Deathday { get; set; }

        public string Biography { get; set; }

        public List<PersonCredit> Credits { get; set; }
        
    }
}
