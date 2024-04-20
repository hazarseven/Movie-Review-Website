using Movie_Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Core.Entities.Concrete
{
    public class TvSeries : BaseEntity
    {
        public TvSeries()
        {
            Comments = new List<Comment>();
        }
        public string TvSeriesName { get; set; }
        public string Description { get; set; }
        public string? ImagePath { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double ImdbRating { get; set; }
        public string Genre { get; set; }
        public string? TrailerPath { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
