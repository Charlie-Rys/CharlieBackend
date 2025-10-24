using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharlieBackend.Infrastructure.Migrations.ApplicationDb
{
    public partial class Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mms_Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthDate = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unq_Authors_Id", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mms_AuthorDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Biography = table.Column<string>(type: "LONGTEXT", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Website = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SocialMediaHandle = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Awards = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unq_AuthorDetails_Id", x => x.Id);
                    table.ForeignKey(
                        name: "fk_AuthorDetails_Author",
                        column: x => x.AuthorId,
                        principalTable: "mms_Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mms_Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    ISBN = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublishDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unq_Books_Id", x => x.Id);
                    table.ForeignKey(
                        name: "fk_Books_Author",
                        column: x => x.AuthorId,
                        principalTable: "mms_Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mms_BookDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    Publisher = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Language = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unq_BookDetails_Id", x => x.Id);
                    table.ForeignKey(
                        name: "fk_BookDetails_Book",
                        column: x => x.BookId,
                        principalTable: "mms_Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "mms_Authors",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(1903, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", "Orwell" });

            migrationBuilder.InsertData(
                table: "mms_Authors",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "J.K.", "Rowling" });

            migrationBuilder.InsertData(
                table: "mms_Authors",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName" },
                values: new object[] { 3, new DateTime(1949, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haruki", "Murakami" });

            migrationBuilder.InsertData(
                table: "mms_AuthorDetails",
                columns: new[] { "Id", "AuthorId", "Awards", "Biography", "SocialMediaHandle", "Website" },
                values: new object[,]
                {
                    { 1, 1, "Prometheus Hall of Fame Award", "English novelist and essayist, journalist and critic.", "@orwell_official", "https://georgeorwell.org" },
                    { 2, 2, "Hugo Award, British Book Award", "British author, best known for the Harry Potter series.", "@jk_rowling", "https://jkrowling.com" },
                    { 3, 3, "Franz Kafka Prize", "Japanese writer known for surreal and melancholic novels.", "@murakami_haruki", "https://harukimurakami.com" }
                });

            migrationBuilder.InsertData(
                table: "mms_Books",
                columns: new[] { "Id", "AuthorId", "ISBN", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "9780451524935", new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "1984" },
                    { 2, 2, "9780590353427", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Sorcerer’s Stone" },
                    { 3, 3, "9780375704024", new DateTime(1987, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norwegian Wood" }
                });

            migrationBuilder.InsertData(
                table: "mms_BookDetails",
                columns: new[] { "Id", "BookId", "Genre", "Language", "PageCount", "Publisher" },
                values: new object[] { 1, 1, "Dystopian", "English", 0, "Secker & Warburg" });

            migrationBuilder.InsertData(
                table: "mms_BookDetails",
                columns: new[] { "Id", "BookId", "Genre", "Language", "PageCount", "Publisher" },
                values: new object[] { 2, 2, "Fantasy", "English", 0, "Bloomsbury" });

            migrationBuilder.InsertData(
                table: "mms_BookDetails",
                columns: new[] { "Id", "BookId", "Genre", "Language", "PageCount", "Publisher" },
                values: new object[] { 3, 3, "Romance / Psychological Fiction", "Japanese", 0, "Kodansha" });

            migrationBuilder.CreateIndex(
                name: "IX_mms_AuthorDetails_AuthorId",
                table: "mms_AuthorDetails",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_mms_BookDetails_BookId",
                table: "mms_BookDetails",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_mms_Books_AuthorId",
                table: "mms_Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mms_AuthorDetails");

            migrationBuilder.DropTable(
                name: "mms_BookDetails");

            migrationBuilder.DropTable(
                name: "mms_Books");

            migrationBuilder.DropTable(
                name: "mms_Authors");
        }
    }
}
