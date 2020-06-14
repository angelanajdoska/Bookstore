﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Migrations
{
    public partial class Andromeda33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateofBirth = table.Column<DateTime>(nullable: false),
                    DateofDeath = table.Column<DateTime>(nullable: true),
                    Biography = table.Column<string>(nullable: true),
                    Rewards = table.Column<string>(nullable: true),
                    Books = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BooksID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(nullable: true),
                    Authorid = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    OriginalTitle = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Synopsis = table.Column<string>(nullable: true),
                    NumberofPages = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Publisher = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BooksID);
                    table.ForeignKey(
                        name: "FK_Book_Author_Authorid",
                        column: x => x.Authorid,
                        principalTable: "Author",
                        principalColumn: "AuthorID");
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Synopsis = table.Column<string>(nullable: true),
                    Trailer = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Movie_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BooksID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_Authorid",
                table: "Book",
                column: "Authorid");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_BookId",
                table: "Movie",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}