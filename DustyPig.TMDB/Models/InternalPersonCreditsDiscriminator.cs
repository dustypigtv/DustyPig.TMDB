using System.Collections.Generic;

namespace DustyPig.TMDB.Models
{
    internal class InternalPersonCreditsDiscriminator<T>
    {
        public List<T> Cast { get; set; }
       
        public List<T> Crew { get; set; }
    }
}
