using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace famtree.Migrations;

/// <inheritdoc />
public partial class FamilyMemberPropsUpdated1 : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "MarriedTo",
            table: "FamilyMembers",
            newName: "PartnerId");

        migrationBuilder.AddColumn<string>(
            name: "Nickname",
            table: "FamilyMembers",
            type: "nvarchar(max)",
            nullable: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Nickname",
            table: "FamilyMembers");

        migrationBuilder.RenameColumn(
            name: "PartnerId",
            table: "FamilyMembers",
            newName: "MarriedTo");
    }
}
