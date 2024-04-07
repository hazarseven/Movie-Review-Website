using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Core.DTO_s.MovieDTO
{
    public class AddMovieDTO
    {
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }
        [Display(Name = "Movie Description")]
        public string Description { get; set; }
        [Display(Name = "Director")]
        public string Director { get; set; }
        [Display(Name = "Movie Genre")]
        public string Genre { get; set; }
        [Display(Name = "Movie Cast")]
        public string Cast { get; set; }
        [Display(Name = "Movie Duration")]
        public int Duration { get; set; }
        [Display(Name = "Movie Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Movie IMDB Rating")]
        public double ImdbRating { get; set; }
        [Display(Name = "Movie Image")]
        public string? ImagePath { get; set; }
        [Display(Name = "Movie Trailer")]
        public string? TrailerPath { get; set; }

    }
}
