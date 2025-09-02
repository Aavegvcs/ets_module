using System.ComponentModel.DataAnnotations;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class lkpFuelType
    {
        [Key]
        public int FuelTypeCode { get; set; }   // e.g. 1,2,3,4,5

        
        public string FuelTypeName { get; set; }   // e.g. Diesel, Petrol, CNG, EV, NotAssigned

        public bool? Active { get; set; }   // 1 = Active, 0 = Inactive
    }
}
