using Microsoft.EntityFrameworkCore;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.Compliances.VendorCompliances;
using WebApplicationETS.Model; // Namespace for your models

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
    }
}
