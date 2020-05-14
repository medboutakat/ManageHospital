using ManageHospitalModels.Models;
using Microsoft.AspNetCore.Http;
using System;

namespace ManageHospitalApi
{
    public class ProductImageModelForm
    {
        public Guid Id { get; set; }
        public IFormFile ImageCoverForm { get; set; }
    }
}
