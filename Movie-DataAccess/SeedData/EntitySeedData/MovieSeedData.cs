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
    public class MovieSeedData : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData
                (
                    new Movie
                    {
                        Id = 1,
                        MovieName = "The Shawshank Redemption",
                        Description = "Two imprisoned",
                        ReleaseDate = new DateTime(1994, 10, 14),
                        ImdbRating = 9.3,
                        Director = "Frank Darabont",
                        Cast = "Tim Robbins, Morgan Freeman, Bob Gunton",
                        Genre = "Drama",
                        Duration = 142,
                        TrailerPath = "https://www.youtube.com/watch?v=6hB3S9bIaco",
                        ImagePath = "https://www.imdb.com/title/tt0111161/mediaviewer/rm10105600/"
                    },

                    new Movie
                    {
                        Id = 2,
                        MovieName = "The Godfather",
                        Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                        ReleaseDate = new DateTime(1972, 3, 24),
                        ImdbRating = 9.2,
                        Director = "Francis Ford Coppola",
                        Cast = "Marlon Brando, Al Pacino, James Caan",
                        Genre = "Crime",
                        Duration = 175,
                        TrailerPath = "https://www.youtube.com/watch?v=sY1S34973zA",
                        ImagePath = "https://www.imdb.com/title/tt0068646/mediaviewer/rm10105600/"
                    },

                    new Movie
                    {
                        Id = 3,
                        MovieName = "The Dark Knight",
                        Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                        ReleaseDate = new DateTime(2008, 7, 18),
                        ImdbRating = 9.0,
                        Director = "Christopher Nolan",
                        Cast = "Christian Bale, Heath Ledger, Aaron Eckhart",
                        Genre = "Action",
                        Duration = 152,
                        TrailerPath = "https://www.youtube.com/watch?v=EXeTwQWrcwY",
                        ImagePath = "https://www.imdb.com/title/tt0468569/mediaviewer/rm10105600/"
                    },



                    new Movie
                    {
                        Id = 4,
                        MovieName = "Inception",
                        Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                        ReleaseDate = new DateTime(2010, 7, 16),
                        ImdbRating = 8.8,
                        Director = "Christopher Nolan",
                        Cast = "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page",
                        Genre = "Action",
                        Duration = 148,
                        TrailerPath = "https://www.youtube.com/watch?v=YoHD9XEInc0",
                        ImagePath = "https://www.imdb.com/title/tt1375666/mediaviewer/rm10105600/"
                    
                    },

                    new Movie
                    {
                        Id = 5,
                        MovieName = "The Matrix",
                        Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                        ReleaseDate = new DateTime(1999, 3, 31),
                        ImdbRating = 8.7,
                        Director = "Lana Wachowski, Lilly Wachowski",
                        Cast = "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss",
                        Genre = "Action",
                        Duration = 136,
                        TrailerPath = "https://www.youtube.com/watch?v=m8e-FF8MsqU",
                        ImagePath = "https://www.imdb.com/title/tt0133093/mediaviewer/rm10105600/"
                    },

                    new Movie
                    {
                        Id = 6,
                        MovieName = "The Lord of the Rings: The Fellowship of the Ring",
                        Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                        ReleaseDate = new DateTime(2001, 12, 19),
                        ImdbRating = 8.8,
                        Director = "Peter Jackson",
                        Cast = "Elijah Wood, Ian McKellen, Orlando Bloom",
                        Genre = "Adventure",
                        Duration = 178,
                        TrailerPath = "https://www.youtube.com/watch?v=V75dMMIW2B4",
                        ImagePath = "https://www.imdb.com/title/tt0120737/mediaviewer/rm10105600/"
                    },

                    new Movie
                    {
                        Id = 7,
                        MovieName = "The Lord of the Rings: The Two Towers",
                        Description = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                        ReleaseDate = new DateTime(2002, 12, 18),
                        ImdbRating = 8.7,
                        Director = "Peter Jackson",
                        Cast = "Elijah Wood, Ian McKellen, Viggo Mortensen",
                        Genre = "Adventure",
                        Duration = 179,
                        TrailerPath = "https://www.youtube.com/watch?v=LbfMDwc4azU",
                        ImagePath = "https://www.imdb.com/title/tt0167261/mediaviewer/rm10105600/"
                    },

                    new Movie
                    {
                        Id = 8,
                        MovieName = "The Dark Knight Rises",
                        Description = "Eight years after the Joker's reign of anarchy, Batman, with the help of the enigmatic Catwoman, is forced from his exile to save Gotham City from the brutal",
                        ReleaseDate = new DateTime(2012, 7, 20),
                        ImdbRating = 8.4,
                        Director = "Christopher Nolan",
                        Cast = "Christian Bale, Tom Hardy, Anne Hathaway",
                        Genre = "Action",
                        Duration = 164,
                        TrailerPath = "https://www.youtube.com/watch?v=g8evyE9TuYk",
                        ImagePath = "https://www.imdb.com/title/tt1345836/mediaviewer/rm10105600/"
                    }


                );
        }
    }
}
