using Movie_Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Core.DTO_s.CommentDTO
{
    public class AddCommentDTO
    {
        [Display(Name = "User Comment")]
        public string? UserComment { get; set; }
        [Display(Name = "User Name")]
        public string? UserName { get; set; }

        [Display(Name = "Movie")]
        public int? MovieId { get; set; }

        [Display(Name = "Tv Series")]
        public int? TvSeriesId { get; set; }

        [Display(Name = "User")]
        public int? UserId { get; set; }


        public List<User>? Users { get; set; }
        public List<Movie>? Movies { get; set; }
        public List<TvSeries>? TvSeries { get; set; }
    }
}
