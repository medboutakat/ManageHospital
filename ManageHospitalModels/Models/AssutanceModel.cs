using System;

namespace   ManageHospitalModels.Models
{
    public class AssutanceModel : PersonModel
    {
        public Guid Age { get; set; }
        public string IdentityNo { get; set; }
        public string Assurance { get; set; } 
    }
}
