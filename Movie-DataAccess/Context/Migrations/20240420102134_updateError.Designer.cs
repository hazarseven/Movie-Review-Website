﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movie_DataAccess.Context;

#nullable disable

namespace Movie_DataAccess.Context.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240420102134_updateError")]
    partial class updateError
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Movie_Core.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("TvSeriesId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("TvSeriesId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5583),
                            Status = 1,
                            TvSeriesId = 1,
                            UserComment = "This is awesome!",
                            UserName = "johndoe"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5586),
                            Status = 1,
                            TvSeriesId = 4,
                            UserComment = "I love this series!",
                            UserName = "janedoe"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5587),
                            MovieId = 2,
                            Status = 1,
                            UserComment = "This movie is great!",
                            UserName = "alicesmith"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5587),
                            MovieId = 3,
                            Status = 1,
                            UserComment = "This movie is amazing!",
                            UserName = "bobsmith"
                        });
                });

            modelBuilder.Entity("Movie_Core.Entities.Concrete.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ImdbRating")
                        .HasColumnType("float");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TrailerPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cast = "Tim Robbins, Morgan Freeman, Bob Gunton",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5243),
                            Description = "Two imprisoned",
                            Director = "Frank Darabont",
                            Duration = 142,
                            Genre = "Drama",
                            ImagePath = "https://www.imdb.com/title/tt0111161/mediaviewer/rm10105600/",
                            ImdbRating = 9.3000000000000007,
                            MovieName = "The Shawshank Redemption",
                            ReleaseDate = new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=6hB3S9bIaco"
                        },
                        new
                        {
                            Id = 2,
                            Cast = "Marlon Brando, Al Pacino, James Caan",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5261),
                            Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                            Director = "Francis Ford Coppola",
                            Duration = 175,
                            Genre = "Crime",
                            ImagePath = "https://www.imdb.com/title/tt0068646/mediaviewer/rm10105600/",
                            ImdbRating = 9.1999999999999993,
                            MovieName = "The Godfather",
                            ReleaseDate = new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=sY1S34973zA"
                        },
                        new
                        {
                            Id = 3,
                            Cast = "Christian Bale, Heath Ledger, Aaron Eckhart",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5263),
                            Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            Director = "Christopher Nolan",
                            Duration = 152,
                            Genre = "Action",
                            ImagePath = "https://www.imdb.com/title/tt0468569/mediaviewer/rm10105600/",
                            ImdbRating = 9.0,
                            MovieName = "The Dark Knight",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=EXeTwQWrcwY"
                        },
                        new
                        {
                            Id = 4,
                            Cast = "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5265),
                            Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                            Director = "Christopher Nolan",
                            Duration = 148,
                            Genre = "Action",
                            ImagePath = "https://www.imdb.com/title/tt1375666/mediaviewer/rm10105600/",
                            ImdbRating = 8.8000000000000007,
                            MovieName = "Inception",
                            ReleaseDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=YoHD9XEInc0"
                        },
                        new
                        {
                            Id = 5,
                            Cast = "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5266),
                            Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                            Director = "Lana Wachowski, Lilly Wachowski",
                            Duration = 136,
                            Genre = "Action",
                            ImagePath = "https://www.imdb.com/title/tt0133093/mediaviewer/rm10105600/",
                            ImdbRating = 8.6999999999999993,
                            MovieName = "The Matrix",
                            ReleaseDate = new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=m8e-FF8MsqU"
                        },
                        new
                        {
                            Id = 6,
                            Cast = "Elijah Wood, Ian McKellen, Orlando Bloom",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5288),
                            Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                            Director = "Peter Jackson",
                            Duration = 178,
                            Genre = "Adventure",
                            ImagePath = "https://www.imdb.com/title/tt0120737/mediaviewer/rm10105600/",
                            ImdbRating = 8.8000000000000007,
                            MovieName = "The Lord of the Rings: The Fellowship of the Ring",
                            ReleaseDate = new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=V75dMMIW2B4"
                        },
                        new
                        {
                            Id = 7,
                            Cast = "Elijah Wood, Ian McKellen, Viggo Mortensen",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5289),
                            Description = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                            Director = "Peter Jackson",
                            Duration = 179,
                            Genre = "Adventure",
                            ImagePath = "https://www.imdb.com/title/tt0167261/mediaviewer/rm10105600/",
                            ImdbRating = 8.6999999999999993,
                            MovieName = "The Lord of the Rings: The Two Towers",
                            ReleaseDate = new DateTime(2002, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=LbfMDwc4azU"
                        },
                        new
                        {
                            Id = 8,
                            Cast = "Christian Bale, Tom Hardy, Anne Hathaway",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5291),
                            Description = "Eight years after the Joker's reign of anarchy, Batman, with the help of the enigmatic Catwoman, is forced from his exile to save Gotham City from the brutal",
                            Director = "Christopher Nolan",
                            Duration = 164,
                            Genre = "Action",
                            ImagePath = "https://www.imdb.com/title/tt1345836/mediaviewer/rm10105600/",
                            ImdbRating = 8.4000000000000004,
                            MovieName = "The Dark Knight Rises",
                            ReleaseDate = new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=g8evyE9TuYk"
                        });
                });

            modelBuilder.Entity("Movie_Core.Entities.Concrete.TvSeries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cast")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ImdbRating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TrailerPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TvSeriesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TvSeries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cast = "Bryan Cranston, Aaron Paul, Anna Gunn",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5415),
                            Description = "A high school chemistry teacher turned meth maker",
                            Director = "Vince Gilligan",
                            Genre = "Crime",
                            ImagePath = "https://www.imdb.com/title/tt0903747/mediaviewer/rm10105600/",
                            ImdbRating = 9.5,
                            ReleaseDate = new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=HhesaQXLuRY",
                            TvSeriesName = "Breaking Bad"
                        },
                        new
                        {
                            Id = 2,
                            Cast = "Emilia Clarke, Peter Dinklage, Kit Harington",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5421),
                            Description = "Nine noble families fight for control over the lands of Westeros",
                            Director = "David Benioff, D.B. Weiss",
                            Genre = "Action",
                            ImagePath = "https://www.imdb.com/title/tt0944947/mediaviewer/rm10105600/",
                            ImdbRating = 9.3000000000000007,
                            ReleaseDate = new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=rlR4PJn8b8I",
                            TvSeriesName = "Game of Thrones"
                        },
                        new
                        {
                            Id = 3,
                            Cast = "Benedict Cumberbatch, Martin Freeman, Una Stubbs",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5423),
                            Description = "A modern update finds the famous sleuth and his doctor partner solving crime in 21st century London.",
                            Director = "Mark Gatiss, Steven Moffat",
                            Genre = "Crime",
                            ImagePath = "https://www.imdb.com/title/tt1475582/mediaviewer/rm10105600/",
                            ImdbRating = 9.0999999999999996,
                            ReleaseDate = new DateTime(2010, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=qlcWFoNqZHc",
                            TvSeriesName = "Sherlock"
                        },
                        new
                        {
                            Id = 4,
                            Cast = "Jennifer Aniston, Courteney Cox, Lisa Kudrow",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5424),
                            Description = "Follows the personal and professional lives of six twenty to thirty-something-year-old friends living in Manhattan.",
                            Director = "David Crane, Marta Kauffman",
                            Genre = "Comedy",
                            ImagePath = "https://www.imdb.com/title/tt0108778/mediaviewer/rm10105600/",
                            ImdbRating = 8.9000000000000004,
                            ReleaseDate = new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=hDNNmeeJs1Q",
                            TvSeriesName = "Friends"
                        },
                        new
                        {
                            Id = 5,
                            Cast = "Steve Carell, Jenna Fischer, John Krasinski",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5425),
                            Description = "A mockumentary on a group of typical office workers",
                            Director = "Greg Daniels, Ricky Gervais, Stephen Merchant",
                            Genre = "Comedy",
                            ImagePath = "https://www.imdb.com/title/tt0386676/mediaviewer/rm10105600/",
                            ImdbRating = 8.9000000000000004,
                            ReleaseDate = new DateTime(2005, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=UZj2xu6lQ34",
                            TvSeriesName = "The Office"
                        },
                        new
                        {
                            Id = 6,
                            Cast = "Úrsula Corberó, Álvaro Morte, Itziar Ituño",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5427),
                            Description = "An unusual group of robbers attempt to carry out the most perfect robbery",
                            Director = "Álex Pina",
                            Genre = "Action",
                            ImagePath = "https://www.imdb.com/title/tt6468322/mediaviewer/rm10105600/",
                            ImdbRating = 8.3000000000000007,
                            ReleaseDate = new DateTime(2017, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=htqXL94Rza4",
                            TvSeriesName = "Money Heist"
                        },
                        new
                        {
                            Id = 7,
                            Cast = "Millie Bobby Brown, Finn Wolfhard, Winona Ryder",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5428),
                            Description = "When a",
                            Director = "Matt Duffer, Ross Duffer",
                            Genre = "Drama",
                            ImagePath = "https://www.imdb.com/title/tt4574334/mediaviewer/rm10105600/",
                            ImdbRating = 8.6999999999999993,
                            ReleaseDate = new DateTime(2016, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=XcnHOQ-cHa0",
                            TvSeriesName = "Stranger Things"
                        },
                        new
                        {
                            Id = 8,
                            Cast = "Claire Foy, Olivia Colman, Imelda Staunton",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5430),
                            Description = "Follows the political rivalries and romance of Queen Elizabeth II's reign",
                            Director = "Peter Morgan",
                            Genre = "Drama",
                            ImagePath = "https://www.imdb.com/title/tt4786824/mediaviewer/rm10105600/",
                            ImdbRating = 8.6999999999999993,
                            ReleaseDate = new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=JWtnJjn6ng0",
                            TvSeriesName = "The Crown"
                        },
                        new
                        {
                            Id = 9,
                            Cast = "Pedro Pascal, Carl Weathers, Gina Carano",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5431),
                            Description = "The travels of a lone bounty hunter in the outer reaches of the galaxy",
                            Director = "Jon Favreau",
                            Genre = "Action",
                            ImagePath = "https://www.imdb.com/title/tt8111088/mediaviewer/rm10105600/",
                            ImdbRating = 8.8000000000000007,
                            ReleaseDate = new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=eW7Twd85m2g",
                            TvSeriesName = "The Mandalorian"
                        },
                        new
                        {
                            Id = 10,
                            Cast = "Henry Cavill, Freya Allan, Anya Chalotra",
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5432),
                            Description = "Geralt of Rivia, a solitary monster hunter",
                            Director = "Lauren Schmidt",
                            Genre = "Action",
                            ImagePath = "https://www.imdb.com/title/tt5180504/mediaviewer/rm10105600/",
                            ImdbRating = 8.1999999999999993,
                            ReleaseDate = new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrailerPath = "https://www.youtube.com/watch?v=ndl1W4ltcmg",
                            TvSeriesName = "The Witcher"
                        });
                });

            modelBuilder.Entity("Movie_Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5491),
                            Email = "johndoe@gmail.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "123",
                            Status = 1,
                            UserName = "johndoe"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5493),
                            Email = "janedoe@gmail.com",
                            FirstName = "Jane",
                            LastName = "Doe",
                            Password = "123",
                            Status = 1,
                            UserName = "janedoe"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5494),
                            Email = "alicesmith@gmail.com",
                            FirstName = "Alice",
                            LastName = "Smith",
                            Password = "123",
                            Status = 1,
                            UserName = "alicesmith"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5496),
                            Email = "bobsmith@gmail.com",
                            FirstName = "Bob",
                            LastName = "Smith",
                            Password = "123",
                            Status = 1,
                            UserName = "bobsmith"
                        });
                });

            modelBuilder.Entity("Movie_Core.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("Movie_Core.Entities.Concrete.Movie", "Movie")
                        .WithMany("Comments")
                        .HasForeignKey("MovieId");

                    b.HasOne("Movie_Core.Entities.Concrete.TvSeries", "TvSeries")
                        .WithMany("Comments")
                        .HasForeignKey("TvSeriesId");

                    b.HasOne("Movie_Core.Entities.Concrete.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");

                    b.Navigation("Movie");

                    b.Navigation("TvSeries");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Movie_Core.Entities.Concrete.Movie", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Movie_Core.Entities.Concrete.TvSeries", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Movie_Core.Entities.Concrete.User", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
