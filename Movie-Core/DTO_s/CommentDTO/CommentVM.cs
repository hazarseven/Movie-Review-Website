using Movie_Core.Entities.Concrete;

namespace Movie_WEB.Models.ViewModels
{
    public class CommentVM
    {
        public int? MovieId { get; set; }
        public string? MovieName { get; set; }
        public int? TvSeriesId { get; set; }
        public string? TvSeriesName { get; set; }
        public string UserComment { get; set; }
        public string UserName { get; set; }
    }
}
