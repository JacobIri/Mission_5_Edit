using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission_4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryEntry",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEntry", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    FormId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Rating = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_Responses_CategoryEntry_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryEntry",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 24, "Undeclared" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 23, "Thriller" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 22, "Superhero" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 21, "Sports" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 20, "Spaghetti Western" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 19, "Romantic Comedy" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 18, "Romance" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 17, "Period Piece" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 16, "Parody" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 15, "Mystery" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 14, "Musical" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 13, "Kids" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 12, "Horror" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 11, "Heist" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 10, "Historical Epic" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 9, "Fantasy" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 8, "Family" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 7, "Drama Comedy" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 6, "Drama" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 5, "Documentary" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Cop / Detective" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Comedy" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Adventure" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 25, "Western" });

            migrationBuilder.InsertData(
                table: "CategoryEntry",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 26, "War" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FormId", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 3, "John Hughes", false, null, null, "PG13", "Ferris Bueller's Day Off", 1986 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FormId", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 3, "Danny Boyle", false, null, null, "PG13", "Yesterday", 2019 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FormId", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 7, "Taika Waititi", false, null, null, "PG13", "Jojo Rabbit", 2019 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CategoryId",
                table: "Responses",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "CategoryEntry");
        }
    }
}
