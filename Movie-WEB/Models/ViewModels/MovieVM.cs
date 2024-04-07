using Movie_Core.Entities.Abstract;

namespace Movie_WEB.Models.ViewModels
{
    public class MovieVM
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public string? ImagePath { get; set; }
        public string Director { get; set; }
        public string? Cast { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ReleaseDateonly => ReleaseDate.ToShortDateString();
        public double ImdbRating { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string? TrailerPath { get; set; }
    }
}
