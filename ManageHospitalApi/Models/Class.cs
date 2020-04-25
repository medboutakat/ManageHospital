using ManageHospitalModels.Models;
using Microsoft.AspNetCore.Http;

namespace ManageHospitalApi
{ 
    public class HospitalDto : HospitalModel
    {
        public IFormFile ImageProfileForm { get; set; }
        public IFormFile ImageCoverForm { get; set; } 
    }
}
