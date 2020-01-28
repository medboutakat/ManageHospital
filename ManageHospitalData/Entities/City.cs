using System;

namespace ManageHospitalData.Entities
{
    public class City 
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Remark { set; get; }
        public int? RegionId { set; get; }
        public Region Region { set; get; }
    } 
}
