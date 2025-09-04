using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationETS.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumnsInMultipleTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_lkpVehicleTypes",
                table: "lkpVehicleTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lkpVehicleModels",
                table: "lkpVehicleModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lkpFuelTypes",
                table: "lkpFuelTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lkpBillPlanTypes",
                table: "lkpBillPlanTypes");

            migrationBuilder.RenameTable(
                name: "lkpVehicleTypes",
                newName: "LkpVehicleTypes");

            migrationBuilder.RenameTable(
                name: "lkpVehicleModels",
                newName: "LkpVehicleModels");

            migrationBuilder.RenameTable(
                name: "lkpFuelTypes",
                newName: "LkpFuelTypes");

            migrationBuilder.RenameTable(
                name: "lkpBillPlanTypes",
                newName: "LkpBillPlanTypes");

            migrationBuilder.RenameColumn(
                name: "VehicleTypeCode",
                table: "Vehicles",
                newName: "vehicleTypeCode");

            migrationBuilder.RenameColumn(
                name: "VehicleStatus",
                table: "Vehicles",
                newName: "vehicleStatus");

            migrationBuilder.RenameColumn(
                name: "VehicleRegistrationNo",
                table: "Vehicles",
                newName: "vehicleRegistrationNo");

            migrationBuilder.RenameColumn(
                name: "VehicleRegistrationDate",
                table: "Vehicles",
                newName: "vehicleRegistrationDate");

            migrationBuilder.RenameColumn(
                name: "VehicleInductionDate",
                table: "Vehicles",
                newName: "vehicleInductionDate");

            migrationBuilder.RenameColumn(
                name: "ValidTokenTaxDate",
                table: "Vehicles",
                newName: "validTokenTaxDate");

            migrationBuilder.RenameColumn(
                name: "TransporterId",
                table: "Vehicles",
                newName: "transporterId");

            migrationBuilder.RenameColumn(
                name: "TrackeeName",
                table: "Vehicles",
                newName: "trackeeName");

            migrationBuilder.RenameColumn(
                name: "TrackeeId",
                table: "Vehicles",
                newName: "trackeeId");

            migrationBuilder.RenameColumn(
                name: "RoadTaxValidityExpiry",
                table: "Vehicles",
                newName: "roadTaxValidityExpiry");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "Vehicles",
                newName: "remarks");

            migrationBuilder.RenameColumn(
                name: "RegistrationExpDate",
                table: "Vehicles",
                newName: "registrationExpDate");

            migrationBuilder.RenameColumn(
                name: "PucExpiryDate",
                table: "Vehicles",
                newName: "pucExpiryDate");

            migrationBuilder.RenameColumn(
                name: "PermitExpiryDate",
                table: "Vehicles",
                newName: "permitExpiryDate");

            migrationBuilder.RenameColumn(
                name: "PassengerTaxDate",
                table: "Vehicles",
                newName: "passengerTaxDate");

            migrationBuilder.RenameColumn(
                name: "OwnerType",
                table: "Vehicles",
                newName: "ownerType");

            migrationBuilder.RenameColumn(
                name: "OwnerName",
                table: "Vehicles",
                newName: "ownerName");

            migrationBuilder.RenameColumn(
                name: "OwnerAddress",
                table: "Vehicles",
                newName: "ownerAddress");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Vehicles",
                newName: "model");

            migrationBuilder.RenameColumn(
                name: "ModOn",
                table: "Vehicles",
                newName: "modOn");

            migrationBuilder.RenameColumn(
                name: "ModBy",
                table: "Vehicles",
                newName: "modBy");

            migrationBuilder.RenameColumn(
                name: "MandatorySignage",
                table: "Vehicles",
                newName: "mandatorySignage");

            migrationBuilder.RenameColumn(
                name: "MakeYear",
                table: "Vehicles",
                newName: "makeYear");

            migrationBuilder.RenameColumn(
                name: "LocCode",
                table: "Vehicles",
                newName: "locCode");

            migrationBuilder.RenameColumn(
                name: "KmsRunBeforeOnboarding",
                table: "Vehicles",
                newName: "kmsRunBeforeOnboarding");

            migrationBuilder.RenameColumn(
                name: "IsGpsInstalled",
                table: "Vehicles",
                newName: "isGpsInstalled");

            migrationBuilder.RenameColumn(
                name: "InsuranceExpiryDate",
                table: "Vehicles",
                newName: "insuranceExpiryDate");

            migrationBuilder.RenameColumn(
                name: "InsuranceAgencyName",
                table: "Vehicles",
                newName: "insuranceAgencyName");

            migrationBuilder.RenameColumn(
                name: "GpsInstallationDate",
                table: "Vehicles",
                newName: "gpsInstallationDate");

            migrationBuilder.RenameColumn(
                name: "GPSProviderCode",
                table: "Vehicles",
                newName: "gpsProviderCode");

            migrationBuilder.RenameColumn(
                name: "FuelTypeCode",
                table: "Vehicles",
                newName: "fuelTypeCode");

            migrationBuilder.RenameColumn(
                name: "FitnessExpiryDate",
                table: "Vehicles",
                newName: "fitnessExpiryDate");

            migrationBuilder.RenameColumn(
                name: "FirstAidKidDate",
                table: "Vehicles",
                newName: "firstAidKidDate");

            migrationBuilder.RenameColumn(
                name: "FireExtinguisherDate",
                table: "Vehicles",
                newName: "fireExtinguisherDate");

            migrationBuilder.RenameColumn(
                name: "EngineCapacityCc",
                table: "Vehicles",
                newName: "engineCapacityCc");

            migrationBuilder.RenameColumn(
                name: "DriverId",
                table: "Vehicles",
                newName: "driverId");

            migrationBuilder.RenameColumn(
                name: "CurrentStatus",
                table: "Vehicles",
                newName: "currentStatus");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Vehicles",
                newName: "createdOn");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Vehicles",
                newName: "createdBy");

            migrationBuilder.RenameColumn(
                name: "CngEndorsementInRc",
                table: "Vehicles",
                newName: "cngEndorsementInRc");

            migrationBuilder.RenameColumn(
                name: "ChassisNo",
                table: "Vehicles",
                newName: "chassisNo");

            migrationBuilder.RenameColumn(
                name: "CcpermitDate",
                table: "Vehicles",
                newName: "ccpermitDate");

            migrationBuilder.RenameColumn(
                name: "Bpid",
                table: "Vehicles",
                newName: "bpId");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Vehicles",
                newName: "vehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_VehicleRegistrationNo",
                table: "Vehicles",
                newName: "IX_Vehicles_vehicleRegistrationNo");

            migrationBuilder.RenameColumn(
                name: "VEHICLETYPEDESC",
                table: "LkpVehicleTypes",
                newName: "vehicleTypeDesc");

            migrationBuilder.RenameColumn(
                name: "LOCCODE",
                table: "LkpVehicleTypes",
                newName: "locCode");

            migrationBuilder.RenameColumn(
                name: "CREATEDON",
                table: "LkpVehicleTypes",
                newName: "createdOn");

            migrationBuilder.RenameColumn(
                name: "CREATEDBY",
                table: "LkpVehicleTypes",
                newName: "createdBy");

            migrationBuilder.RenameColumn(
                name: "CAPACITY",
                table: "LkpVehicleTypes",
                newName: "capacity");

            migrationBuilder.RenameColumn(
                name: "VEHICLETYPECODE",
                table: "LkpVehicleTypes",
                newName: "vehicleTypeCode");

            migrationBuilder.RenameColumn(
                name: "VEHICLETYPECODE",
                table: "LkpVehicleModels",
                newName: "vehicleTypeCode");

            migrationBuilder.RenameColumn(
                name: "MODELDESC",
                table: "LkpVehicleModels",
                newName: "modelDesc");

            migrationBuilder.RenameColumn(
                name: "LOCCODE",
                table: "LkpVehicleModels",
                newName: "locCode");

            migrationBuilder.RenameColumn(
                name: "CREATEDON",
                table: "LkpVehicleModels",
                newName: "createdOn");

            migrationBuilder.RenameColumn(
                name: "CREATEDBY",
                table: "LkpVehicleModels",
                newName: "createdBy");

            migrationBuilder.RenameColumn(
                name: "ACTIVE",
                table: "LkpVehicleModels",
                newName: "active");

            migrationBuilder.RenameColumn(
                name: "MODELID",
                table: "LkpVehicleModels",
                newName: "modelId");

            migrationBuilder.RenameColumn(
                name: "FuelTypeName",
                table: "LkpFuelTypes",
                newName: "fuelTypeName");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "LkpFuelTypes",
                newName: "active");

            migrationBuilder.RenameColumn(
                name: "FuelTypeCode",
                table: "LkpFuelTypes",
                newName: "fuelTypeCode");

            migrationBuilder.RenameColumn(
                name: "createdon",
                table: "LkpBillPlanTypes",
                newName: "createdOn");

            migrationBuilder.RenameColumn(
                name: "createdby",
                table: "LkpBillPlanTypes",
                newName: "createdBy");

            migrationBuilder.RenameColumn(
                name: "ModOn",
                table: "LkpBillPlanTypes",
                newName: "modOn");

            migrationBuilder.RenameColumn(
                name: "ModBy",
                table: "LkpBillPlanTypes",
                newName: "modBy");

            migrationBuilder.RenameColumn(
                name: "BPTNAME",
                table: "LkpBillPlanTypes",
                newName: "bptName");

            migrationBuilder.RenameColumn(
                name: "ACTIVE",
                table: "LkpBillPlanTypes",
                newName: "active");

            migrationBuilder.RenameColumn(
                name: "BPTCODE",
                table: "LkpBillPlanTypes",
                newName: "bptCode");

            migrationBuilder.AddColumn<int>(
                name: "modBy",
                table: "LkpVehicleTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "modOn",
                table: "LkpVehicleTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "LkpBillPlanTypes",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpVehicleTypes",
                table: "LkpVehicleTypes",
                column: "vehicleTypeCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpVehicleModels",
                table: "LkpVehicleModels",
                column: "modelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpFuelTypes",
                table: "LkpFuelTypes",
                column: "fuelTypeCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpBillPlanTypes",
                table: "LkpBillPlanTypes",
                column: "bptCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpVehicleTypes",
                table: "LkpVehicleTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpVehicleModels",
                table: "LkpVehicleModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpFuelTypes",
                table: "LkpFuelTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpBillPlanTypes",
                table: "LkpBillPlanTypes");

            migrationBuilder.DropColumn(
                name: "modBy",
                table: "LkpVehicleTypes");

            migrationBuilder.DropColumn(
                name: "modOn",
                table: "LkpVehicleTypes");

            migrationBuilder.RenameTable(
                name: "LkpVehicleTypes",
                newName: "lkpVehicleTypes");

            migrationBuilder.RenameTable(
                name: "LkpVehicleModels",
                newName: "lkpVehicleModels");

            migrationBuilder.RenameTable(
                name: "LkpFuelTypes",
                newName: "lkpFuelTypes");

            migrationBuilder.RenameTable(
                name: "LkpBillPlanTypes",
                newName: "lkpBillPlanTypes");

            migrationBuilder.RenameColumn(
                name: "vehicleTypeCode",
                table: "Vehicles",
                newName: "VehicleTypeCode");

            migrationBuilder.RenameColumn(
                name: "vehicleStatus",
                table: "Vehicles",
                newName: "VehicleStatus");

            migrationBuilder.RenameColumn(
                name: "vehicleRegistrationNo",
                table: "Vehicles",
                newName: "VehicleRegistrationNo");

            migrationBuilder.RenameColumn(
                name: "vehicleRegistrationDate",
                table: "Vehicles",
                newName: "VehicleRegistrationDate");

            migrationBuilder.RenameColumn(
                name: "vehicleInductionDate",
                table: "Vehicles",
                newName: "VehicleInductionDate");

            migrationBuilder.RenameColumn(
                name: "validTokenTaxDate",
                table: "Vehicles",
                newName: "ValidTokenTaxDate");

            migrationBuilder.RenameColumn(
                name: "transporterId",
                table: "Vehicles",
                newName: "TransporterId");

            migrationBuilder.RenameColumn(
                name: "trackeeName",
                table: "Vehicles",
                newName: "TrackeeName");

            migrationBuilder.RenameColumn(
                name: "trackeeId",
                table: "Vehicles",
                newName: "TrackeeId");

            migrationBuilder.RenameColumn(
                name: "roadTaxValidityExpiry",
                table: "Vehicles",
                newName: "RoadTaxValidityExpiry");

            migrationBuilder.RenameColumn(
                name: "remarks",
                table: "Vehicles",
                newName: "Remarks");

            migrationBuilder.RenameColumn(
                name: "registrationExpDate",
                table: "Vehicles",
                newName: "RegistrationExpDate");

            migrationBuilder.RenameColumn(
                name: "pucExpiryDate",
                table: "Vehicles",
                newName: "PucExpiryDate");

            migrationBuilder.RenameColumn(
                name: "permitExpiryDate",
                table: "Vehicles",
                newName: "PermitExpiryDate");

            migrationBuilder.RenameColumn(
                name: "passengerTaxDate",
                table: "Vehicles",
                newName: "PassengerTaxDate");

            migrationBuilder.RenameColumn(
                name: "ownerType",
                table: "Vehicles",
                newName: "OwnerType");

            migrationBuilder.RenameColumn(
                name: "ownerName",
                table: "Vehicles",
                newName: "OwnerName");

            migrationBuilder.RenameColumn(
                name: "ownerAddress",
                table: "Vehicles",
                newName: "OwnerAddress");

            migrationBuilder.RenameColumn(
                name: "model",
                table: "Vehicles",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "modOn",
                table: "Vehicles",
                newName: "ModOn");

            migrationBuilder.RenameColumn(
                name: "modBy",
                table: "Vehicles",
                newName: "ModBy");

            migrationBuilder.RenameColumn(
                name: "mandatorySignage",
                table: "Vehicles",
                newName: "MandatorySignage");

            migrationBuilder.RenameColumn(
                name: "makeYear",
                table: "Vehicles",
                newName: "MakeYear");

            migrationBuilder.RenameColumn(
                name: "locCode",
                table: "Vehicles",
                newName: "LocCode");

            migrationBuilder.RenameColumn(
                name: "kmsRunBeforeOnboarding",
                table: "Vehicles",
                newName: "KmsRunBeforeOnboarding");

            migrationBuilder.RenameColumn(
                name: "isGpsInstalled",
                table: "Vehicles",
                newName: "IsGpsInstalled");

            migrationBuilder.RenameColumn(
                name: "insuranceExpiryDate",
                table: "Vehicles",
                newName: "InsuranceExpiryDate");

            migrationBuilder.RenameColumn(
                name: "insuranceAgencyName",
                table: "Vehicles",
                newName: "InsuranceAgencyName");

            migrationBuilder.RenameColumn(
                name: "gpsProviderCode",
                table: "Vehicles",
                newName: "GPSProviderCode");

            migrationBuilder.RenameColumn(
                name: "gpsInstallationDate",
                table: "Vehicles",
                newName: "GpsInstallationDate");

            migrationBuilder.RenameColumn(
                name: "fuelTypeCode",
                table: "Vehicles",
                newName: "FuelTypeCode");

            migrationBuilder.RenameColumn(
                name: "fitnessExpiryDate",
                table: "Vehicles",
                newName: "FitnessExpiryDate");

            migrationBuilder.RenameColumn(
                name: "firstAidKidDate",
                table: "Vehicles",
                newName: "FirstAidKidDate");

            migrationBuilder.RenameColumn(
                name: "fireExtinguisherDate",
                table: "Vehicles",
                newName: "FireExtinguisherDate");

            migrationBuilder.RenameColumn(
                name: "engineCapacityCc",
                table: "Vehicles",
                newName: "EngineCapacityCc");

            migrationBuilder.RenameColumn(
                name: "driverId",
                table: "Vehicles",
                newName: "DriverId");

            migrationBuilder.RenameColumn(
                name: "currentStatus",
                table: "Vehicles",
                newName: "CurrentStatus");

            migrationBuilder.RenameColumn(
                name: "createdOn",
                table: "Vehicles",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "createdBy",
                table: "Vehicles",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "cngEndorsementInRc",
                table: "Vehicles",
                newName: "CngEndorsementInRc");

            migrationBuilder.RenameColumn(
                name: "chassisNo",
                table: "Vehicles",
                newName: "ChassisNo");

            migrationBuilder.RenameColumn(
                name: "ccpermitDate",
                table: "Vehicles",
                newName: "CcpermitDate");

            migrationBuilder.RenameColumn(
                name: "bpId",
                table: "Vehicles",
                newName: "Bpid");

            migrationBuilder.RenameColumn(
                name: "vehicleId",
                table: "Vehicles",
                newName: "VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_vehicleRegistrationNo",
                table: "Vehicles",
                newName: "IX_Vehicles_VehicleRegistrationNo");

            migrationBuilder.RenameColumn(
                name: "vehicleTypeDesc",
                table: "lkpVehicleTypes",
                newName: "VEHICLETYPEDESC");

            migrationBuilder.RenameColumn(
                name: "locCode",
                table: "lkpVehicleTypes",
                newName: "LOCCODE");

            migrationBuilder.RenameColumn(
                name: "createdOn",
                table: "lkpVehicleTypes",
                newName: "CREATEDON");

            migrationBuilder.RenameColumn(
                name: "createdBy",
                table: "lkpVehicleTypes",
                newName: "CREATEDBY");

            migrationBuilder.RenameColumn(
                name: "capacity",
                table: "lkpVehicleTypes",
                newName: "CAPACITY");

            migrationBuilder.RenameColumn(
                name: "vehicleTypeCode",
                table: "lkpVehicleTypes",
                newName: "VEHICLETYPECODE");

            migrationBuilder.RenameColumn(
                name: "vehicleTypeCode",
                table: "lkpVehicleModels",
                newName: "VEHICLETYPECODE");

            migrationBuilder.RenameColumn(
                name: "modelDesc",
                table: "lkpVehicleModels",
                newName: "MODELDESC");

            migrationBuilder.RenameColumn(
                name: "locCode",
                table: "lkpVehicleModels",
                newName: "LOCCODE");

            migrationBuilder.RenameColumn(
                name: "createdOn",
                table: "lkpVehicleModels",
                newName: "CREATEDON");

            migrationBuilder.RenameColumn(
                name: "createdBy",
                table: "lkpVehicleModels",
                newName: "CREATEDBY");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "lkpVehicleModels",
                newName: "ACTIVE");

            migrationBuilder.RenameColumn(
                name: "modelId",
                table: "lkpVehicleModels",
                newName: "MODELID");

            migrationBuilder.RenameColumn(
                name: "fuelTypeName",
                table: "lkpFuelTypes",
                newName: "FuelTypeName");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "lkpFuelTypes",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "fuelTypeCode",
                table: "lkpFuelTypes",
                newName: "FuelTypeCode");

            migrationBuilder.RenameColumn(
                name: "modOn",
                table: "lkpBillPlanTypes",
                newName: "ModOn");

            migrationBuilder.RenameColumn(
                name: "modBy",
                table: "lkpBillPlanTypes",
                newName: "ModBy");

            migrationBuilder.RenameColumn(
                name: "createdOn",
                table: "lkpBillPlanTypes",
                newName: "createdon");

            migrationBuilder.RenameColumn(
                name: "createdBy",
                table: "lkpBillPlanTypes",
                newName: "createdby");

            migrationBuilder.RenameColumn(
                name: "bptName",
                table: "lkpBillPlanTypes",
                newName: "BPTNAME");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "lkpBillPlanTypes",
                newName: "ACTIVE");

            migrationBuilder.RenameColumn(
                name: "bptCode",
                table: "lkpBillPlanTypes",
                newName: "BPTCODE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdon",
                table: "lkpBillPlanTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_lkpVehicleTypes",
                table: "lkpVehicleTypes",
                column: "VEHICLETYPECODE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lkpVehicleModels",
                table: "lkpVehicleModels",
                column: "MODELID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lkpFuelTypes",
                table: "lkpFuelTypes",
                column: "FuelTypeCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lkpBillPlanTypes",
                table: "lkpBillPlanTypes",
                column: "BPTCODE");
        }
    }
}
