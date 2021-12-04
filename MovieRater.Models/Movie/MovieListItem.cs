using MovieRater.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models.Movie
{
    public class MovieListItem
    {
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public GenreType TypeOfGenre { get; set; }
        public bool IsFamilyFriendly { get; set; }

    }
}
