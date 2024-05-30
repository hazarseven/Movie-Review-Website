using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Core.DTO_s.TvSeriesDTO
{
    public class AddTvSeriesDTO
    {
        [Display(Name = "Tv Series Name")]
        public string TvSeriesName { get; set; }
        [Display(Name = "Tv Series Description")]
        public string Description { get; set; }
        [Display(Name = "Cast")]
        public string Cast { get; set; }
        [Display(Name = "Director")]
        public string Director { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "IMDB Rating")]
        public double ImdbRating { get; set; }
        [Display(Name = "Genre")]
        public string Genre { get; set; }
        [Display(Name = "Tv Series Image")]
        public string? ImagePath { get; set; }
        [Display(Name = "Trailer")]
        public string? TrailerPath { get; set; }
    }
}
