using Movie_Core.Entities.Abstract;
using Movie_Core.Entities.Concrete;
using Movie_WEB.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Core.DTO_s.MovieDTO
{
    public class MovieDetailDTO
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public string? ImagePath { get; set; }
        public string Director { get; set; }
        public string? Cast { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double ImdbRating { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string? TrailerPath { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Status Status { get; set; }

        public string UserName { get; set; } 
        public string UserComment { get; set; } 

        public List<CommentVM> Comments { get; set; }
    }

}
