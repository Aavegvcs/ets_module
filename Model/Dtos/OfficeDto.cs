namespace WebApplicationETS.Model.Dtos
{
    public class OfficeDto
    {
        public int locCode { get; set; }
        public string locName { get; set; }
        public decimal lat { get; set; }
        public decimal lng { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string dispName { get; set; }
        public string shortName { get; set; }
        public short locGroup { get; set; }
        public string cityZone { get; set; }
        public string helpDeskContactNumber { get; set; }
        public string sosContactNumber { get; set; }
        public string driverAppIVRNumber { get; set; }
        public string userAppIVRNumber { get; set; }
        public bool active { get; set; }
        public int modBy { get; set; }
        public bool isAutoPenalty { get; set; }
        public bool isPanicSound { get; set; }
        public int disableTransportCutoffDays { get; set; }
        public bool disableTransportJob { get; set; }
    }
}
