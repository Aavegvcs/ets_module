using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationETS.Migrations
{
    /// <inheritdoc />
    public partial class AddLkpCurrentStatusesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LkpCurrentStatuses",
                columns: table => new
                {
                    currentStatusCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    currentStatusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LkpCurrentStatuses", x => x.currentStatusCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LkpCurrentStatuses");
        }
    }
}
