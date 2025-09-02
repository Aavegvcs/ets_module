using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationETS.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lkpVehicleModels",
                columns: table => new
                {
                    MODELID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOCCODE = table.Column<int>(type: "int", nullable: true),
                    VEHICLETYPECODE = table.Column<int>(type: "int", nullable: true),
                    MODELDESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACTIVE = table.Column<bool>(type: "bit", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDON = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lkpVehicleModels", x => x.MODELID);
                });

            migrationBuilder.CreateTable(
                name: "lkpVehicleTypes",
                columns: table => new
                {
                    VEHICLETYPECODE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOCCODE = table.Column<int>(type: "int", nullable: true),
                    VEHICLETYPEDESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAPACITY = table.Column<short>(type: "smallint", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDON = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lkpVehicleTypes", x => x.VEHICLETYPECODE);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lkpVehicleModels");

            migrationBuilder.DropTable(
                name: "lkpVehicleTypes");
        }
    }
}
