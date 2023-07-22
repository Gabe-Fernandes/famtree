using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace famtree.Migrations;

/// <inheritdoc />
public partial class IsAlivePropAddedToFamilyMember : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<bool>(
            name: "IsAlive",
            table: "FamilyMembers",
            type: "bit",
            nullable: false,
            defaultValue: false);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "IsAlive",
            table: "FamilyMembers");
    }
}
