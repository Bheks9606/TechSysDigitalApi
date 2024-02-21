using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechSysDigitalApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMusicianModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Musicians",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Musicians",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Musicians");
        }
    }
}
