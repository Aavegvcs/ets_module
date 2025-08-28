using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationETS.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleRegistrationNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleTypeCode = table.Column<int>(type: "int", nullable: true),
                    TransporterId = table.Column<int>(type: "int", nullable: true),
                    Bpid = table.Column<int>(type: "int", nullable: true),
                    TrackeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleStatus = table.Column<int>(type: "int", nullable: true),
                    LocCode = table.Column<int>(type: "int", nullable: true),
                    VehicleRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VehicleInductionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VehicleNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationExpDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstAidKidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FireExtinguisherDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DriverId = table.Column<int>(type: "int", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChassisNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermitExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsuranceExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FitnessExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoadTaxValidityExpiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PucExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KmsRunBeforeOnboarding = table.Column<int>(type: "int", nullable: true),
                    InsuranceAgencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CcpermitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OwnerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidTokenTaxDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassengerTaxDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsGpsInstalled = table.Column<bool>(type: "bit", nullable: true),
                    GpsInstallationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GPSProviderCode = table.Column<int>(type: "int", nullable: true),
                    FuelTypeCode = table.Column<int>(type: "int", nullable: true),
                    CngEndorsementInRc = table.Column<bool>(type: "bit", nullable: true),
                    CurrentStatus = table.Column<int>(type: "int", nullable: true),
                    MandatorySignage = table.Column<bool>(type: "bit", nullable: true),
                    EngineCapacityCc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModBy = table.Column<int>(type: "int", nullable: true),
                    ModOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MakeYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
