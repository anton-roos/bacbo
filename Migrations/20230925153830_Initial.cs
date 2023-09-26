using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BacBo.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BacBoResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DrawDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PlayerFirstRoll = table.Column<int>(type: "INTEGER", nullable: false),
                    BankerFirstRoll = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerSecondRoll = table.Column<int>(type: "INTEGER", nullable: false),
                    BankerSecondRoll = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerScore = table.Column<int>(type: "INTEGER", nullable: false),
                    BankerScore = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerWins = table.Column<bool>(type: "INTEGER", nullable: false),
                    BankerWins = table.Column<bool>(type: "INTEGER", nullable: false),
                    Tie = table.Column<bool>(type: "INTEGER", nullable: false),
                    Source = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BacBoResults", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BacBoResults");
        }
    }
}
