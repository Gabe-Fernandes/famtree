using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace famtree.Migrations;

/// <inheritdoc />
public partial class FamilyMemberPropsAdded : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "Education",
            table: "FamilyMembers",
            type: "nvarchar(max)",
            nullable: true);

        migrationBuilder.AddColumn<int>(
            name: "MarriedTo",
            table: "FamilyMembers",
            type: "int",
            nullable: false,
            defaultValue: 0);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Education",
            table: "FamilyMembers");

        migrationBuilder.DropColumn(
            name: "MarriedTo",
            table: "FamilyMembers");
    }
}
