using System;

namespace   ManageHospital.WebUI.Models
{
    public class AssutanceModel : PersonModel
    {
        public Guid Age { get; set; }
        public string IdentityNo { get; set; }
        public string Assurance { get; set; } 
    }
}
