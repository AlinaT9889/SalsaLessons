using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class SalsaVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Movie",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Movie",
                newName: "WarmUp");

            migrationBuilder.AddColumn<string>(
                name: "Choreo",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Technics",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Choreo",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Technics",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "WarmUp",
                table: "Movie",
                newName: "Genre");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Movie",
                newName: "ReleaseDate");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Movie",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
