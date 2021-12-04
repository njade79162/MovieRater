using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Data
{
    public enum MovieMaturityRating
    {
        G = 1, PG, PG_13, R, NC_17, TV_MA, NR
    }
    public enum MovieGenreType
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
            public MovieMaturityRating MaturityRating { get; set; }
            [Required]
            public MovieGenreType TypeOfGenre { get; set; }
            [Required]
            public bool IsFamilyFriendly
            {
                get
                {
                    switch (MaturityRating)
                    {
                        case MovieMaturityRating.G:
                        case MovieMaturityRating.PG:
                            return true;
                        case MovieMaturityRating.PG_13:
                        case MovieMaturityRating.R:
                        case MovieMaturityRating.NC_17:
                        case MovieMaturityRating.TV_MA:
                        case MovieMaturityRating.NR:
                        default:
                            return false;
                    }
                }
            }
            //public virtual List<Rating> Ratings { get; set; } = new List<Rating>();

        }
    }
