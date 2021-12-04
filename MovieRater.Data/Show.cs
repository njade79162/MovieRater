using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Data
{
   public class Show
    {
        public enum GenreType
        {
            Action = 1,
            Adventure,
            Comedy,
            Fantasy,
            Horror,
            Mystery,
            Drama,
            Fiction,
            Nonfiction
        }

        public enum MaturityRating
        {
            G = 1,
            PG,
            PG_13,
            R,
            NC_17,
            TV_MA,
            NR
        }

        public class Show
        {
            [Key]
            public int ShowId { get; set; }


            public int SeaseonCount { get; set; }
            public int EpisodeCount { get; set; }
            public double RoundedRuntime { get; set; }
            public List<Episode> Episodes { get; set; }
            public GenreType TypeOfGenre { get; set; }


            public MaturityRating MaturityRating { get; set; }
            public bool IsFamilyFriendly { get; set; }

            [Required]
            public string Description { get; set; }

            [Required]
            public string Title { get; set; }
            public virtual List<Rating> Ratings { get; set; } = new List<Rating>();
            public double StarRating { get; set; }
        }

        public class Episode
        {
            public string Title { get; set; }
            public string EpisodeDescription { get; set; }
            public string ActorDescription { get; set; }
            public double Runtime { get; set; }
            public int SeasonCount { get; set; }
            public virtual List<Rating> EpisodeRatings { get; set; } = new List<Rating>();
            public double EpisodeRating { get; set; }
        }
    }
}
