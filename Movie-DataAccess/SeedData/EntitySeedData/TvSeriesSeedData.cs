using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie_Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.SeedData.EntitySeedData
{
    public class TvSeriesSeedData : IEntityTypeConfiguration<TvSeries>
    {
        public void Configure(EntityTypeBuilder<TvSeries> builder)
        {
            builder.HasData
                (
                    new TvSeries
                    {

                        Id = 1,
                        TvSeriesName = "Breaking Bad",
                        Description = "A high school chemistry teacher turned meth maker",
                        ReleaseDate = new DateTime(2008, 1, 20),
                        ImdbRating = 9.5,
                        Director = "Vince Gilligan",
                        Cast = "Bryan Cranston, Aaron Paul, Anna Gunn",
                        Genre = "Crime",
                        TrailerPath = "https://www.youtube.com/watch?v=HhesaQXLuRY",
                        ImagePath = "https://m.media-amazon.com/images/M/MV5BYmQ4YWMxYjUtNjZmYi00MDQ1LWFjMjMtNjA5ZDdiYjdiODU5XkEyXkFqcGdeQXVyMTMzNDExODE5._V1_.jpg"
                    },

                    new TvSeries
                    {
                        Id = 2,
                        TvSeriesName = "Game of Thrones",
                        Description = "Nine noble families fight for control over the lands of Westeros",
                        ReleaseDate = new DateTime(2011, 4, 17),
                        ImdbRating = 9.3,
                        Director = "David Benioff, D.B. Weiss",
                        Cast = "Emilia Clarke, Peter Dinklage, Kit Harington",
                        Genre = "Action",
                        TrailerPath = "https://www.youtube.com/watch?v=rlR4PJn8b8I",
                        ImagePath = "https://m.media-amazon.com/images/M/MV5BN2IzYzBiOTQtNGZmMi00NDI5LTgxMzMtN2EzZjA1NjhlOGMxXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_.jpg"
                    },

                    new TvSeries
                    {
                        Id = 3,
                        TvSeriesName = "Sherlock",
                        Description = "A modern update finds the famous sleuth and his doctor partner solving crime in 21st century London.",
                        ReleaseDate = new DateTime(2010, 7, 25),
                        ImdbRating = 9.1,
                        Director = "Mark Gatiss, Steven Moffat",
                        Cast = "Benedict Cumberbatch, Martin Freeman, Una Stubbs",
                        Genre = "Crime",
                        TrailerPath = "https://www.youtube.com/watch?v=qlcWFoNqZHc",
                        ImagePath = "https://m.media-amazon.com/images/M/MV5BMWEzNTFlMTQtMzhjOS00MzQ1LWJjNjgtY2RhMjFhYjQwYjIzXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_.jpg"
                    },

                    new TvSeries
                    {
                        Id = 4,
                        TvSeriesName = "Friends",
                        Description = "Follows the personal and professional lives of six twenty to thirty-something-year-old friends living in Manhattan.",
                        ReleaseDate = new DateTime(1994, 9, 22),
                        ImdbRating = 8.9,
                        Director = "David Crane, Marta Kauffman",
                        Cast = "Jennifer Aniston, Courteney Cox, Lisa Kudrow",
                        Genre = "Comedy",
                        TrailerPath = "https://www.youtube.com/watch?v=hDNNmeeJs1Q",
                        ImagePath = "https://m.media-amazon.com/images/M/MV5BNDVkYjU0MzctMWRmZi00NTkxLTgwZWEtOWVhYjZlYjllYmU4XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_FMjpg_UX1000_.jpg"
                    },

                    new TvSeries
                    {
                        Id = 5,
                        TvSeriesName = "The Office",
                        Description = "A mockumentary on a group of typical office workers",
                        ReleaseDate = new DateTime(2005, 3, 24),
                        ImdbRating = 8.9,
                        Director = "Greg Daniels, Ricky Gervais, Stephen Merchant",
                        Cast = "Steve Carell, Jenna Fischer, John Krasinski",
                        Genre = "Comedy",
                        TrailerPath = "https://www.youtube.com/watch?v=UZj2xu6lQ34",
                        ImagePath = "https://m.media-amazon.com/images/M/MV5BMDNkOTE4NDQtMTNmYi00MWE0LWE4ZTktYTc0NzhhNWIzNzJiXkEyXkFqcGdeQXVyMzQ2MDI5NjU@._V1_.jpg"
                    },

                    new TvSeries
                    {
                        Id = 6,
                        TvSeriesName = "Money Heist",
                        Description = "An unusual group of robbers attempt to carry out the most perfect robbery",
                        ReleaseDate = new DateTime(2017, 5, 2),
                        ImdbRating = 8.3,
                        Director = "Álex Pina",
                        Cast = "Úrsula Corberó, Álvaro Morte, Itziar Ituño",
                        Genre = "Action",
                        TrailerPath = "https://www.youtube.com/watch?v=htqXL94Rza4",
                        ImagePath = "https://m.media-amazon.com/images/M/MV5BODI0ZTljYTMtODQ1NC00NmI0LTk1YWUtN2FlNDM1MDExMDlhXkEyXkFqcGdeQXVyMTM0NTUzNDIy._V1_FMjpg_UX1000_.jpg"
                    },

                    new TvSeries
                    {
                        Id = 7,
                        TvSeriesName = "Stranger Things",
                        Description = "When a",
                        ReleaseDate = new DateTime(2016, 7, 15),
                        ImdbRating = 8.7,
                        Director = "Matt Duffer, Ross Duffer",
                        Cast = "Millie Bobby Brown, Finn Wolfhard, Winona Ryder",
                        Genre = "Drama",
                        TrailerPath = "https://www.youtube.com/watch?v=XcnHOQ-cHa0",
                        ImagePath = "https://m.media-amazon.com/images/I/81l6XqCYYQL._AC_UF1000,1000_QL80_.jpg"
                    },

                    new TvSeries
                    {
                        Id = 8,
                        TvSeriesName = "The Crown",
                        Description = "Follows the political rivalries and romance of Queen Elizabeth II's reign",
                        ReleaseDate = new DateTime(2016, 11, 4),
                        ImdbRating = 8.7,
                        Director = "Peter Morgan",
                        Cast = "Claire Foy, Olivia Colman, Imelda Staunton",
                        Genre = "Drama",
                        TrailerPath = "https://www.youtube.com/watch?v=JWtnJjn6ng0",
                        ImagePath = "https://image.tmdb.org/t/p/w500/1M876KPjulVwppEpldhdc8V4o68.jpg"
                    },

                    new TvSeries
                    {
                        Id = 9,
                        TvSeriesName = "The Mandalorian",
                        Description = "The travels of a lone bounty hunter in the outer reaches of the galaxy",
                        ReleaseDate = new DateTime(2019, 11, 12),
                        ImdbRating = 8.8,
                        Director = "Jon Favreau",
                        Cast = "Pedro Pascal, Carl Weathers, Gina Carano",
                        Genre = "Action",
                        TrailerPath = "https://www.youtube.com/watch?v=eW7Twd85m2g",
                        ImagePath = "https://m.media-amazon.com/images/M/MV5BN2M5YWFjN2YtYzU2YS00NzBlLTgwZWUtYWQzNWFhNDkyYjg3XkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_FMjpg_UX1000_.jpg"
                    },

                    new TvSeries
                    {
                        Id = 10,
                        TvSeriesName = "The Witcher",
                        Description = "Geralt of Rivia, a solitary monster hunter",
                        ReleaseDate = new DateTime(2019, 12, 20),
                        ImdbRating = 8.2,
                        Director = "Lauren Schmidt",
                        Cast = "Henry Cavill, Freya Allan, Anya Chalotra",
                        Genre = "Action",
                        TrailerPath = "https://www.youtube.com/watch?v=ndl1W4ltcmg",
                        ImagePath = "https://m.media-amazon.com/images/M/MV5BMDEwOWVlY2EtMWI0ZC00OWVmLWJmZGItYTk3YjYzN2Y0YmFkXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_.jpg"
                    }
                );
        }
    }
}
