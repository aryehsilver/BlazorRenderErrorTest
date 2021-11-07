using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorRenderErrorTest.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Tel = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name", "Tel" },
                values: new object[] { 1, "Kceilorty", 77448545664L });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name", "Tel" },
                values: new object[] { 2, "Zurokiea", 77448545664L });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name", "Tel" },
                values: new object[] { 3, "Stymliea", 77448545664L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
