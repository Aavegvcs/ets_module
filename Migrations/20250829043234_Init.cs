using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationETS.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lkpBillPlanTypes",
                columns: table => new
                {
                    BPTCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BPTNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ACTIVE = table.Column<bool>(type: "bit", nullable: false),
                    createdby = table.Column<int>(type: "int", nullable: false),
                    createdon = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lkpBillPlanTypes", x => x.BPTCODE);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleRegistrationNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    VehicleTypeCode = table.Column<int>(type: "int", nullable: false),
                    TransporterId = table.Column<int>(type: "int", nullable: false),
                    Bpid = table.Column<int>(type: "int", nullable: false),
                    TrackeeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrackeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VehicleStatus = table.Column<int>(type: "int", nullable: false),
                    LocCode = table.Column<int>(type: "int", nullable: false),
                    VehicleRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleInductionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstAidKidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FireExtinguisherDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ChassisNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PermitExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsuranceExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FitnessExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoadTaxValidityExpiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PucExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KmsRunBeforeOnboarding = table.Column<int>(type: "int", nullable: true),
                    InsuranceAgencyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OwnerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CcpermitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OwnerAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OwnerType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValidTokenTaxDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassengerTaxDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsGpsInstalled = table.Column<bool>(type: "bit", nullable: true),
                    GpsInstallationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GPSProviderCode = table.Column<int>(type: "int", nullable: true),
                    FuelTypeCode = table.Column<int>(type: "int", nullable: false),
                    CngEndorsementInRc = table.Column<bool>(type: "bit", nullable: true),
                    CurrentStatus = table.Column<int>(type: "int", nullable: true),
                    MandatorySignage = table.Column<bool>(type: "bit", nullable: true),
                    EngineCapacityCc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModBy = table.Column<int>(type: "int", nullable: true),
                    ModOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MakeYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOCCODE = table.Column<int>(type: "int", nullable: true),
                    TRANSPORTERID = table.Column<int>(type: "int", nullable: true),
                    VENDOR_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BPID = table.Column<int>(type: "int", nullable: true),
                    SINGLEPLAN = table.Column<bool>(type: "bit", nullable: true),
                    PREFIXTAG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOBILE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAILID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REMARKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODBY = table.Column<int>(type: "int", nullable: true),
                    MODON = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ACTIVE = table.Column<bool>(type: "bit", nullable: true),
                    ContactFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactTo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleRegistrationNo",
                table: "Vehicles",
                column: "VehicleRegistrationNo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lkpBillPlanTypes");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
