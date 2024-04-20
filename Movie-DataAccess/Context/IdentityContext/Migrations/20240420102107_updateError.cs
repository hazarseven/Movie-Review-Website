using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_DataAccess.Context.IdentityContext.Migrations
{
    /// <inheritdoc />
    public partial class updateError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9b73c15-946c-4cf4-beae-6d6132f8d3cc", new DateTime(2024, 4, 20, 13, 21, 7, 72, DateTimeKind.Local).AddTicks(6014), "AQAAAAIAAYagAAAAEBgTBUx8vBzAIgQW2Gao45VdV30h4IUZX9ljf1S9Z+eshUwdRGzjsufqeFAEXv8t4Q==", "24722d3f-e2a3-4c44-ae93-997c0efae21f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4f4f4f4-4f4f-4f4f-4f4f-4f4f4f4f4f4f",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9da1636-8baa-43da-baac-d62ba639bd02", new DateTime(2024, 4, 20, 13, 21, 7, 27, DateTimeKind.Local).AddTicks(1483), "AQAAAAIAAYagAAAAEPv91SHfieGXpxNbcFSl8f0Tc4+pxbJdiHHkIcVucxTplge3xuJ6OWVstnLnaCsDZg==", "c36b06f9-407c-4a05-a43a-38ecdae5e834" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aed088fe-e1c9-451e-8cf4-250028c2f93a", new DateTime(2024, 4, 8, 17, 51, 32, 31, DateTimeKind.Local).AddTicks(4763), "AQAAAAIAAYagAAAAENXvtqVHmwrfiD7AJk4ou/M+gmz3nVPCYkVcvD3/c1vXA3KLDpvx6ADObL79MdQFzg==", "b4c6ad05-17cd-47f5-be4b-9abfb90150ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4f4f4f4-4f4f-4f4f-4f4f-4f4f4f4f4f4f",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ad804c8-dd46-4035-be34-03bb95200b13", new DateTime(2024, 4, 8, 17, 51, 31, 963, DateTimeKind.Local).AddTicks(6223), "AQAAAAIAAYagAAAAENmLb/4YjKC+UqjvxRgiDvUNu5AHXW06f2jyFFg5CZLm5vZvWsWJpgH+RisQs0GB9w==", "2f867908-e718-4bb3-a5ef-89ef36a9b1e9" });
        }
    }
}
