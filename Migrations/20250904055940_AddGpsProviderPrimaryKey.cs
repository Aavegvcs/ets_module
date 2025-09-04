using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationETS.Migrations
{
    /// <inheritdoc />
    public partial class AddGpsProviderPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LkpGPSProviders",
                columns: table => new
                {
                    gpsProviderCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gpsProviderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LkpGPSProviders", x => x.gpsProviderCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LkpGPSProviders");
        }
    }
}
