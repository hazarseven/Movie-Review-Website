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
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImdbRating = table.Column<double>(type: "float", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    TrailerPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImdbRating = table.Column<double>(type: "float", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    TvSeriesId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_TvSeries_TvSeriesId",
                        column: x => x.TvSeriesId,
                        principalTable: "TvSeries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Cast", "CreatedDate", "DeletedDate", "Description", "Director", "Duration", "Genre", "ImagePath", "ImdbRating", "MovieName", "ReleaseDate", "Status", "TrailerPath", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Tim Robbins, Morgan Freeman, Bob Gunton", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(5866), null, "Two imprisoned", "Frank Darabont", 142, "Drama", "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_.jpg", 9.3000000000000007, "The Shawshank Redemption", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=6hB3S9bIaco", null },
                    { 2, "Marlon Brando, Al Pacino, James Caan", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(5891), null, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "Francis Ford Coppola", 175, "Crime", "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg", 9.1999999999999993, "The Godfather", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=sY1S34973zA", null },
                    { 3, "Christian Bale, Heath Ledger, Aaron Eckhart", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(5894), null, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "Christopher Nolan", 152, "Action", "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg", 9.0, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=EXeTwQWrcwY", null },
                    { 4, "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(5897), null, "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "Christopher Nolan", 148, "Action", "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg", 8.8000000000000007, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=YoHD9XEInc0", null },
                    { 5, "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(5900), null, "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", "Lana Wachowski, Lilly Wachowski", 136, "Action", "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg", 8.6999999999999993, "The Matrix", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=m8e-FF8MsqU", null },
                    { 6, "Elijah Wood, Ian McKellen, Orlando Bloom", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(5902), null, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "Peter Jackson", 178, "Adventure", "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_.jpg", 8.8000000000000007, "The Lord of the Rings: The Fellowship of the Ring", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=V75dMMIW2B4", null },
                    { 7, "Elijah Wood, Ian McKellen, Viggo Mortensen", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(5904), null, "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.", "Peter Jackson", 179, "Adventure", "https://m.media-amazon.com/images/M/MV5BZTUxNzg3MDUtYjdmZi00ZDY1LTkyYTgtODlmOGY5N2RjYWUyXkEyXkFqcGdeQXVyMTA0MTM5NjI2._V1_FMjpg_UX1000_.jpg", 8.6999999999999993, "The Lord of the Rings: The Two Towers", new DateTime(2002, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=LbfMDwc4azU", null },
                    { 8, "Christian Bale, Tom Hardy, Anne Hathaway", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(5906), null, "Eight years after the Joker's reign of anarchy, Batman, with the help of the enigmatic Catwoman, is forced from his exile to save Gotham City from the brutal", "Christopher Nolan", 164, "Action", "https://m.media-amazon.com/images/M/MV5BMTk4ODQzNDY3Ml5BMl5BanBnXkFtZTcwODA0NTM4Nw@@._V1_FMjpg_UX1000_.jpg", 8.4000000000000004, "The Dark Knight Rises", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=g8evyE9TuYk", null }
                });

            migrationBuilder.InsertData(
                table: "TvSeries",
                columns: new[] { "Id", "Cast", "CreatedDate", "DeletedDate", "Description", "Director", "Genre", "ImagePath", "ImdbRating", "ReleaseDate", "Status", "TrailerPath", "TvSeriesName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Bryan Cranston, Aaron Paul, Anna Gunn", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6239), null, "A high school chemistry teacher turned meth maker", "Vince Gilligan", "Crime", "https://m.media-amazon.com/images/M/MV5BYmQ4YWMxYjUtNjZmYi00MDQ1LWFjMjMtNjA5ZDdiYjdiODU5XkEyXkFqcGdeQXVyMTMzNDExODE5._V1_.jpg", 9.5, new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=HhesaQXLuRY", "Breaking Bad", null },
                    { 2, "Emilia Clarke, Peter Dinklage, Kit Harington", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6246), null, "Nine noble families fight for control over the lands of Westeros", "David Benioff, D.B. Weiss", "Action", "https://m.media-amazon.com/images/M/MV5BN2IzYzBiOTQtNGZmMi00NDI5LTgxMzMtN2EzZjA1NjhlOGMxXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_.jpg", 9.3000000000000007, new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=rlR4PJn8b8I", "Game of Thrones", null },
                    { 3, "Benedict Cumberbatch, Martin Freeman, Una Stubbs", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6249), null, "A modern update finds the famous sleuth and his doctor partner solving crime in 21st century London.", "Mark Gatiss, Steven Moffat", "Crime", "https://m.media-amazon.com/images/M/MV5BMWEzNTFlMTQtMzhjOS00MzQ1LWJjNjgtY2RhMjFhYjQwYjIzXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_.jpg", 9.0999999999999996, new DateTime(2010, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=qlcWFoNqZHc", "Sherlock", null },
                    { 4, "Jennifer Aniston, Courteney Cox, Lisa Kudrow", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6252), null, "Follows the personal and professional lives of six twenty to thirty-something-year-old friends living in Manhattan.", "David Crane, Marta Kauffman", "Comedy", "https://m.media-amazon.com/images/M/MV5BNDVkYjU0MzctMWRmZi00NTkxLTgwZWEtOWVhYjZlYjllYmU4XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_FMjpg_UX1000_.jpg", 8.9000000000000004, new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=hDNNmeeJs1Q", "Friends", null },
                    { 5, "Steve Carell, Jenna Fischer, John Krasinski", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6254), null, "A mockumentary on a group of typical office workers", "Greg Daniels, Ricky Gervais, Stephen Merchant", "Comedy", "https://m.media-amazon.com/images/M/MV5BMDNkOTE4NDQtMTNmYi00MWE0LWE4ZTktYTc0NzhhNWIzNzJiXkEyXkFqcGdeQXVyMzQ2MDI5NjU@._V1_.jpg", 8.9000000000000004, new DateTime(2005, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=UZj2xu6lQ34", "The Office", null },
                    { 6, "Úrsula Corberó, Álvaro Morte, Itziar Ituño", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6256), null, "An unusual group of robbers attempt to carry out the most perfect robbery", "Álex Pina", "Action", "https://m.media-amazon.com/images/M/MV5BODI0ZTljYTMtODQ1NC00NmI0LTk1YWUtN2FlNDM1MDExMDlhXkEyXkFqcGdeQXVyMTM0NTUzNDIy._V1_FMjpg_UX1000_.jpg", 8.3000000000000007, new DateTime(2017, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=htqXL94Rza4", "Money Heist", null },
                    { 7, "Millie Bobby Brown, Finn Wolfhard, Winona Ryder", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6258), null, "When a", "Matt Duffer, Ross Duffer", "Drama", "https://m.media-amazon.com/images/I/81l6XqCYYQL._AC_UF1000,1000_QL80_.jpg", 8.6999999999999993, new DateTime(2016, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=XcnHOQ-cHa0", "Stranger Things", null },
                    { 8, "Claire Foy, Olivia Colman, Imelda Staunton", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6260), null, "Follows the political rivalries and romance of Queen Elizabeth II's reign", "Peter Morgan", "Drama", "https://image.tmdb.org/t/p/w500/1M876KPjulVwppEpldhdc8V4o68.jpg", 8.6999999999999993, new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=JWtnJjn6ng0", "The Crown", null },
                    { 9, "Pedro Pascal, Carl Weathers, Gina Carano", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6262), null, "The travels of a lone bounty hunter in the outer reaches of the galaxy", "Jon Favreau", "Action", "https://m.media-amazon.com/images/M/MV5BN2M5YWFjN2YtYzU2YS00NzBlLTgwZWUtYWQzNWFhNDkyYjg3XkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_FMjpg_UX1000_.jpg", 8.8000000000000007, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=eW7Twd85m2g", "The Mandalorian", null },
                    { 10, "Henry Cavill, Freya Allan, Anya Chalotra", new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6264), null, "Geralt of Rivia, a solitary monster hunter", "Lauren Schmidt", "Action", "https://m.media-amazon.com/images/M/MV5BMDEwOWVlY2EtMWI0ZC00OWVmLWJmZGItYTk3YjYzN2Y0YmFkXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_.jpg", 8.1999999999999993, new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=ndl1W4ltcmg", "The Witcher", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "Password", "Status", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6604), null, "johndoe@gmail.com", "John", "Doe", "123", 1, null, "johndoe" },
                    { 2, new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6611), null, "janedoe@gmail.com", "Jane", "Doe", "123", 1, null, "janedoe" },
                    { 3, new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6613), null, "alicesmith@gmail.com", "Alice", "Smith", "123", 1, null, "alicesmith" },
                    { 4, new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6615), null, "bobsmith@gmail.com", "Bob", "Smith", "123", 1, null, "bobsmith" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "MovieId", "Status", "TvSeriesId", "UpdatedDate", "UserComment", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6752), null, null, 1, 1, null, "This is awesome!", null, "johndoe" },
                    { 2, new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6756), null, null, 1, 4, null, "I love this series!", null, "janedoe" },
                    { 3, new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6757), null, 2, 1, null, null, "This movie is great!", null, "alicesmith" },
                    { 4, new DateTime(2024, 5, 29, 17, 7, 23, 967, DateTimeKind.Local).AddTicks(6759), null, 3, 1, null, null, "This movie is amazing!", null, "bobsmith" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MovieId",
                table: "Comments",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TvSeriesId",
                table: "Comments",
                column: "TvSeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");
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
