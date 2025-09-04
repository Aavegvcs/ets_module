using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationETS.Migrations
{
    /// <inheritdoc />
    public partial class AddLkpGpsProvidersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpGPSProviders",
                table: "LkpGPSProviders");

            migrationBuilder.RenameTable(
                name: "LkpGPSProviders",
                newName: "LkpGpsProviders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpGpsProviders",
                table: "LkpGpsProviders",
                column: "gpsProviderCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpGpsProviders",
                table: "LkpGpsProviders");

            migrationBuilder.RenameTable(
                name: "LkpGpsProviders",
                newName: "LkpGPSProviders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpGPSProviders",
                table: "LkpGPSProviders",
                column: "gpsProviderCode");
        }
    }
}
