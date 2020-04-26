using ManageHospitalModels.Models;
using Microsoft.AspNetCore.Http;
using System;

namespace ManageHospitalApi
{
    public class HospitalImages
    { 
        public IFormFile ImageProfileForm { get; set; }
        public IFormFile ImageCoverForm { get; set; }
    }
}
