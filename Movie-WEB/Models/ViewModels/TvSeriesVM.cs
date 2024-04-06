namespace Movie_WEB.Models.ViewModels
{
    public class TvSeriesVM
    {
        public int Id { get; set; }
        public string TvSeriesName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double ImdbRating { get; set; }
        public string Genre { get; set; }
        public string TrailerPath { get; set; }
    }
}
