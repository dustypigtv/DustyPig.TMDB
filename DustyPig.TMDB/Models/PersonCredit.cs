using System;

namespace DustyPig.TMDB.Models
{
    public class PersonCredit : IComparable<PersonCredit>
    {
        public int Id { get; set; }

        public EntityTypes EntityType { get; set; }

        public string TItle { get; set; }

        public string PosterPath { get; set; }

        public string BackdropPath { get; set; }

        public string Overview { get; set; }

        public double Popularity { get; set; }

        public int CompareTo(PersonCredit other)
        {
            var ret = -Popularity.CompareTo(other.Popularity);
            if(ret == 0)
                ret = TItle.CompareTo(other.TItle);
            return ret;
        }
    }
}
