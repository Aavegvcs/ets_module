using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationETS.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "LkpBillPlanTypes",
            //    columns: table => new
            //    {
            //        bptCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        bptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        active = table.Column<bool>(type: "bit", nullable: true),
            //        createdBy = table.Column<int>(type: "int", nullable: true),
            //        modBy = table.Column<int>(type: "int", nullable: true),
            //        modOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        createdOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpBillPlanTypes", x => x.bptCode);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LkpCurrentStatuses",
            //    columns: table => new
            //    {
            //        currentStatusCode = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        currentStatusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        active = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpCurrentStatuses", x => x.currentStatusCode);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LkpFuelTypes",
            //    columns: table => new
            //    {
            //        fuelTypeCode = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        fuelTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        active = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpFuelTypes", x => x.fuelTypeCode);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LkpGpsProviders",
            //    columns: table => new
            //    {
            //        gpsProviderCode = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        gpsProviderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        active = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpGpsProviders", x => x.gpsProviderCode);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LkpVehicleModels",
            //    columns: table => new
            //    {
            //        modelId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        locCode = table.Column<int>(type: "int", nullable: true),
            //        vehicleTypeCode = table.Column<int>(type: "int", nullable: true),
            //        modelDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        active = table.Column<bool>(type: "bit", nullable: true),
            //        createdBy = table.Column<int>(type: "int", nullable: true),
            //        createdOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpVehicleModels", x => x.modelId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LkpVehicleStatuses",
            //    columns: table => new
            //    {
            //        vehicleStatusCode = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        vehicleStatusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        active = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpVehicleStatuses", x => x.vehicleStatusCode);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LkpVehicleTypes",
            //    columns: table => new
            //    {
            //        vehicleTypeCode = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        locCode = table.Column<int>(type: "int", nullable: false),
            //        vehicleTypeDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        capacity = table.Column<short>(type: "smallint", nullable: false),
            //        createdBy = table.Column<int>(type: "int", nullable: false),
            //        createdOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        modBy = table.Column<int>(type: "int", nullable: false),
            //        modOn = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LkpVehicleTypes", x => x.vehicleTypeCode);
            //    });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    vehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vehicleRegistrationNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    vehicleTypeCode = table.Column<int>(type: "int", nullable: false),
                    transporterId = table.Column<int>(type: "int", nullable: false),
                    bpId = table.Column<int>(type: "int", nullable: false),
                    trackeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trackeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicleStatus = table.Column<int>(type: "int", nullable: false),
                    locCode = table.Column<int>(type: "int", nullable: false),
                    vehicleRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vehicleInductionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    registrationExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    firstAidKidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    fireExtinguisherDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    driverId = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    model = table.Column<int>(type: "int", nullable: false),
                    chassisNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    permitExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    insuranceExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    fitnessExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    roadTaxValidityExpiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pucExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    kmsRunBeforeOnboarding = table.Column<int>(type: "int", nullable: true),
                    insuranceAgencyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ownerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ccpermitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ownerAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ownerType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    validTokenTaxDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    passengerTaxDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isGpsInstalled = table.Column<bool>(type: "bit", nullable: true),
                    gpsInstallationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    gpsProviderCode = table.Column<int>(type: "int", nullable: true),
                    fuelTypeCode = table.Column<int>(type: "int", nullable: false),
                    cngEndorsementInRc = table.Column<bool>(type: "bit", nullable: true),
                    currentStatus = table.Column<int>(type: "int", nullable: true),
                    mandatorySignage = table.Column<bool>(type: "bit", nullable: true),
                    engineCapacityCc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    modBy = table.Column<int>(type: "int", nullable: true),
                    modOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    makeYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    createdOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.vehicleId);
                });

            //migrationBuilder.CreateTable(
            //    name: "Vendors",
            //    columns: table => new
            //    {
            //        VendorId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        LOCCODE = table.Column<int>(type: "int", nullable: true),
            //        TRANSPORTERID = table.Column<int>(type: "int", nullable: true),
            //        VENDOR_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        BPID = table.Column<int>(type: "int", nullable: true),
            //        SINGLEPLAN = table.Column<bool>(type: "bit", nullable: true),
            //        PREFIXTAG = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        MOBILE = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EMAILID = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        REMARKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        MODBY = table.Column<int>(type: "int", nullable: true),
            //        MODON = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        ACTIVE = table.Column<bool>(type: "bit", nullable: true),
            //        ContactFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        ContactTo = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vendors", x => x.VendorId);
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_vehicleRegistrationNo",
                table: "Vehicles",
                column: "vehicleRegistrationNo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LkpBillPlanTypes");

            migrationBuilder.DropTable(
                name: "LkpCurrentStatuses");

            migrationBuilder.DropTable(
                name: "LkpFuelTypes");

            migrationBuilder.DropTable(
                name: "LkpGpsProviders");

            migrationBuilder.DropTable(
                name: "LkpVehicleModels");

            migrationBuilder.DropTable(
                name: "LkpVehicleStatuses");

            migrationBuilder.DropTable(
                name: "LkpVehicleTypes");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
