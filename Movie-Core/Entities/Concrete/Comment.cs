using Movie_Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Core.Entities.Concrete
{
    public class Comment : BaseEntity
    {
        public string UserComment { get; set; }
        public string UserName { get; set; }

        public int? MovieId { get; set; }
        public Movie Movie { get; set; }

        public int? TvSeriesId { get; set; }
        public TvSeries TvSeries { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

    }
}
