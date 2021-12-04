using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Data
{
    public enum MaturityRating
    {
        G = 1, PG, PG_13, R, NC_17, TV_MA, NR
    }
    public enum GenreType
    {
        Cartoon = 1, Comedy, Romance, RomCom, Drama, Action, Documentary, Thriller, Horror
    }
    public class Movie
    {
            [Key]
            public int MovieId { get; set; }
            [Required]
            public string Title { get; set; }
            [Required]
            public string Description { get; set; }
            [Required]
            public MaturityRating MaturityRating { get; set; }
            [Required]
            public GenreType TypeOfGenre { get; set; }
            [Required]
            public bool IsFamilyFriendly
            {
                get
                {
                    switch (MaturityRating)
                    {
                        case MaturityRating.G:
                        case MaturityRating.PG:
                            return true;
                        case MaturityRating.PG_13:
                        case MaturityRating.R:
                        case MaturityRating.NC_17:
                        case MaturityRating.TV_MA:
                        case MaturityRating.NR:
                        default:
                            return false;
                    }
                }
            }
            //public virtual List<Rating> Ratings { get; set; } = new List<Rating>();

        }
    }
