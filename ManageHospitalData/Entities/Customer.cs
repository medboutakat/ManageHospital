using System;

namespace ManageHospitalData.Entities
{
    public class Customer : User
    { 
        public string Code { get; set; }
        public string Name { get; set; }

        public decimal MaxCreadit { get; set; }

        public Guid CustomerCategoryId { get; set; }
        public DoctorCategory CustomerCategory { get; set; } 
    } 
}
