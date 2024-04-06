using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_DataAccess.Context.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    UserComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImdbRating = table.Column<double>(type: "float", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    TrailerPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TvSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TvSeriesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImdbRating = table.Column<double>(type: "float", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvSeries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "MovieId", "Status", "UpdatedDate", "UserComment", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9315), null, 1, 1, null, "This movie is awesome!", "johndoe" },
                    { 2, new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9317), null, 4, 1, null, "I love this movie!", "janedoe" },
                    { 3, new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9318), null, 2, 1, null, "This movie is great!", "alicesmith" },
                    { 4, new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9319), null, 3, 1, null, "This movie is amazing!", "bobsmith" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Cast", "CreatedDate", "DeletedDate", "Description", "Director", "Duration", "Genre", "ImagePath", "ImdbRating", "MovieName", "ReleaseDate", "Status", "TrailerPath", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Tim Robbins, Morgan Freeman, Bob Gunton", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(8856), null, "Two imprisoned", "Frank Darabont", 142, "Drama", "https://www.imdb.com/title/tt0111161/mediaviewer/rm10105600/", 9.3000000000000007, "The Shawshank Redemption", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=6hB3S9bIaco", null },
                    { 2, "Marlon Brando, Al Pacino, James Caan", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(8878), null, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "Francis Ford Coppola", 175, "Crime", "https://www.imdb.com/title/tt0068646/mediaviewer/rm10105600/", 9.1999999999999993, "The Godfather", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=sY1S34973zA", null },
                    { 3, "Christian Bale, Heath Ledger, Aaron Eckhart", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(8882), null, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "Christopher Nolan", 152, "Action", "https://www.imdb.com/title/tt0468569/mediaviewer/rm10105600/", 9.0, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=EXeTwQWrcwY", null },
                    { 4, "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(8884), null, "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "Christopher Nolan", 148, "Action", "https://www.imdb.com/title/tt1375666/mediaviewer/rm10105600/", 8.8000000000000007, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=YoHD9XEInc0", null },
                    { 5, "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(8885), null, "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", "Lana Wachowski, Lilly Wachowski", 136, "Action", "https://www.imdb.com/title/tt0133093/mediaviewer/rm10105600/", 8.6999999999999993, "The Matrix", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=m8e-FF8MsqU", null },
                    { 6, "Elijah Wood, Ian McKellen, Orlando Bloom", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(8887), null, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "Peter Jackson", 178, "Adventure", "https://www.imdb.com/title/tt0120737/mediaviewer/rm10105600/", 8.8000000000000007, "The Lord of the Rings: The Fellowship of the Ring", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=V75dMMIW2B4", null },
                    { 7, "Elijah Wood, Ian McKellen, Viggo Mortensen", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(8888), null, "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.", "Peter Jackson", 179, "Adventure", "https://www.imdb.com/title/tt0167261/mediaviewer/rm10105600/", 8.6999999999999993, "The Lord of the Rings: The Two Towers", new DateTime(2002, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=LbfMDwc4azU", null },
                    { 8, "Christian Bale, Tom Hardy, Anne Hathaway", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(8890), null, "Eight years after the Joker's reign of anarchy, Batman, with the help of the enigmatic Catwoman, is forced from his exile to save Gotham City from the brutal", "Christopher Nolan", 164, "Action", "https://www.imdb.com/title/tt1345836/mediaviewer/rm10105600/", 8.4000000000000004, "The Dark Knight Rises", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=g8evyE9TuYk", null }
                });

            migrationBuilder.InsertData(
                table: "TvSeries",
                columns: new[] { "Id", "Cast", "CreatedDate", "DeletedDate", "Description", "Director", "Genre", "ImagePath", "ImdbRating", "ReleaseDate", "Status", "TrailerPath", "TvSeriesName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Bryan Cranston, Aaron Paul, Anna Gunn", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9050), null, "A high school chemistry teacher turned meth maker", "Vince Gilligan", "Crime", "https://www.imdb.com/title/tt0903747/mediaviewer/rm10105600/", 9.5, new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=HhesaQXLuRY", "Breaking Bad", null },
                    { 2, "Emilia Clarke, Peter Dinklage, Kit Harington", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9057), null, "Nine noble families fight for control over the lands of Westeros", "David Benioff, D.B. Weiss", "Action", "https://www.imdb.com/title/tt0944947/mediaviewer/rm10105600/", 9.3000000000000007, new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=rlR4PJn8b8I", "Game of Thrones", null },
                    { 3, "Benedict Cumberbatch, Martin Freeman, Una Stubbs", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9059), null, "A modern update finds the famous sleuth and his doctor partner solving crime in 21st century London.", "Mark Gatiss, Steven Moffat", "Crime", "https://www.imdb.com/title/tt1475582/mediaviewer/rm10105600/", 9.0999999999999996, new DateTime(2010, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=qlcWFoNqZHc", "Sherlock", null },
                    { 4, "Jennifer Aniston, Courteney Cox, Lisa Kudrow", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9060), null, "Follows the personal and professional lives of six twenty to thirty-something-year-old friends living in Manhattan.", "David Crane, Marta Kauffman", "Comedy", "https://www.imdb.com/title/tt0108778/mediaviewer/rm10105600/", 8.9000000000000004, new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=hDNNmeeJs1Q", "Friends", null },
                    { 5, "Steve Carell, Jenna Fischer, John Krasinski", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9062), null, "A mockumentary on a group of typical office workers", "Greg Daniels, Ricky Gervais, Stephen Merchant", "Comedy", "https://www.imdb.com/title/tt0386676/mediaviewer/rm10105600/", 8.9000000000000004, new DateTime(2005, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=UZj2xu6lQ34", "The Office", null },
                    { 6, "Úrsula Corberó, Álvaro Morte, Itziar Ituño", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9063), null, "An unusual group of robbers attempt to carry out the most perfect robbery", "Álex Pina", "Action", "https://www.imdb.com/title/tt6468322/mediaviewer/rm10105600/", 8.3000000000000007, new DateTime(2017, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=htqXL94Rza4", "Money Heist", null },
                    { 7, "Millie Bobby Brown, Finn Wolfhard, Winona Ryder", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9064), null, "When a", "Matt Duffer, Ross Duffer", "Drama", "https://www.imdb.com/title/tt4574334/mediaviewer/rm10105600/", 8.6999999999999993, new DateTime(2016, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=XcnHOQ-cHa0", "Stranger Things", null },
                    { 8, "Claire Foy, Olivia Colman, Imelda Staunton", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9066), null, "Follows the political rivalries and romance of Queen Elizabeth II's reign", "Peter Morgan", "Drama", "https://www.imdb.com/title/tt4786824/mediaviewer/rm10105600/", 8.6999999999999993, new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=JWtnJjn6ng0", "The Crown", null },
                    { 9, "Pedro Pascal, Carl Weathers, Gina Carano", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9067), null, "The travels of a lone bounty hunter in the outer reaches of the galaxy", "Jon Favreau", "Action", "https://www.imdb.com/title/tt8111088/mediaviewer/rm10105600/", 8.8000000000000007, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=eW7Twd85m2g", "The Mandalorian", null },
                    { 10, "Henry Cavill, Freya Allan, Anya Chalotra", new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9069), null, "Geralt of Rivia, a solitary monster hunter", "Lauren Schmidt", "Action", "https://www.imdb.com/title/tt5180504/mediaviewer/rm10105600/", 8.1999999999999993, new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=ndl1W4ltcmg", "The Witcher", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "Password", "Status", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9247), null, "johndoe@gmail.com", "John", "Doe", "123", 1, null, "johndoe" },
                    { 2, new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9249), null, "janedoe@gmail.com", "Jane", "Doe", "123", 1, null, "janedoe" },
                    { 3, new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9251), null, "alicesmith@gmail.com", "Alice", "Smith", "123", 1, null, "alicesmith" },
                    { 4, new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 9, 58, 7, 785, DateTimeKind.Local).AddTicks(9252), null, "bobsmith@gmail.com", "Bob", "Smith", "123", 1, null, "bobsmith" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "TvSeries");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
