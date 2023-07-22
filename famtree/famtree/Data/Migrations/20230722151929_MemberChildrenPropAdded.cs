using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace famtree.Migrations;

/// <inheritdoc />
public partial class MemberChildrenPropAdded : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "Children",
            table: "FamilyMembers",
            type: "nvarchar(max)",
            nullable: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Children",
            table: "FamilyMembers");
    }
}
