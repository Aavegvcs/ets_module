using Microsoft.EntityFrameworkCore;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.Compliances.VendorCompliances;
using WebApplicationETS.Model;
using WebApplicationETS.Model.Compliances.Office;


namespace WebApplicationETS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // Add DbSets for your entities
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<LkpBillPlanType> LkpBillPlanTypes { get; set; }
        public DbSet<LkpFuelType> LkpFuelTypes { get; set; }

        public DbSet<LkpVehicleType> LkpVehicleTypes { get; set; }

        public DbSet<LkpVehicleModel> LkpVehicleModels { get; set; }

        public DbSet<LkpVehicleStatus> LkpVehicleStatuses { get; set; }
        public DbSet<LkpCurrentStatus> LkpCurrentStatuses { get; set; }

        public DbSet<LkpGpsProvider> LkpGpsProviders { get; set; }

        public DbSet<Office> Office { get; set; }
    }

}
