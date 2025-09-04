using System.ComponentModel.DataAnnotations;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class LkpFuelType
    {
        [Key]
        public int fuelTypeCode { get; set; }   // e.g. 1,2,3,4,5

        
        public string fuelTypeName { get; set; }   // e.g. Diesel, Petrol, CNG, EV, NotAssigned

        public bool? active { get; set; }   // 1 = Active, 0 = Inactive
    }
}
