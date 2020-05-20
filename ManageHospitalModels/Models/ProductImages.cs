using System;
using System.Collections.Generic;

namespace   ManageHospitalModels.Models
{
    public class ProductImageModel
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public Guid ProductId { get; set; }
    }
}
