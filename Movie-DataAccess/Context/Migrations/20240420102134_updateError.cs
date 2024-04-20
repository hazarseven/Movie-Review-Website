using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_DataAccess.Context.Migrations
{
    /// <inheritdoc />
    public partial class updateError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5583), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5586), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5587), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5587), null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 21, 34, 460, DateTimeKind.Local).AddTicks(5496));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Movies_MovieId",
                table: "Comments",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_TvSeries_TvSeriesId",
                table: "Comments",
                column: "TvSeriesId",
                principalTable: "TvSeries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Movies_MovieId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_TvSeries_TvSeriesId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_MovieId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_TvSeriesId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 17, 50, 46, 415, DateTimeKind.Local).AddTicks(2261));
        }
    }
}
