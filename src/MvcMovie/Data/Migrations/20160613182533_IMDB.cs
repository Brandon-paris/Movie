using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Data.Migrations
{
    public partial class IMDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMDB_Score",
                table: "Movie");

            migrationBuilder.AddColumn<float>(
                name: "IMDB",
                table: "Movie",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMDB",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "IMDB_Score",
                table: "Movie",
                nullable: true);
        }
    }
}
