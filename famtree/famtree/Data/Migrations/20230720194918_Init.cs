using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace famtree.Migrations;

/// <inheritdoc />
public partial class Init : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "FamilyMembers",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                DOP = table.Column<DateTime>(type: "datetime2", nullable: false),
                Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Pfp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                BirthLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Interests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Anecdotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                CitiesLived = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Photos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                LanguagesSpoken = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_FamilyMembers", x => x.Id);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "FamilyMembers");
    }
}
