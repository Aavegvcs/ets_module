using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationETS.Data;
using WebApplicationETS.Factories;

//using WebApplicationETS.Factories;
using WebApplicationETS.Middleware;
using WebApplicationETS.Service.CompliancesServices.VehicleServices;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.BillPlanService;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.CurrentStatusService;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.FuelTypeService;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.GpsProviderService;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleModelService;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleStatusService;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleTypeService; // ✅ Correct namespace for DataContext

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidateModelAttribute>();   // 👈 our global validation filter
});

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    // Prevent automatic 400 response
    options.SuppressModelStateInvalidFilter = true;
});



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<IBillPlanService, BillPlanService>();
builder.Services.AddScoped<IFuelTypeService,FuelTypeService>();
builder.Services.AddScoped<IVehicleModelService, VehicleModelService>();
builder.Services.AddScoped<IVehicleTypeService,VehicleTypeService>();
builder.Services.AddScoped<IVehicleStatusService, VehicleStatusService>();
builder.Services.AddScoped<ICurrentStatusService, CurrentStatusService>();
builder.Services.AddScoped<IGpsProviderService, GpsProviderService>();
builder.Services.AddScoped<IVehicleFactory, VehicleFactory>();
builder.Services.AddScoped<IBillPlanFactory, BillPlanFactory>();


// Register EF Core DbContext
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions => sqlOptions.EnableRetryOnFailure()
    )
);

var app = builder.Build();
app.UseMiddleware<GlobalExceptionMiddleware>();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
