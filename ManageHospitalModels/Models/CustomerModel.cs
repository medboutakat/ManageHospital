using System;

namespace   ManageHospitalModels.Models
{
    public class CustomerModel : PersonModel
    {
        public Guid CustomerCategoryId { get; set; }

        public CustomerCategoryModel CustomerCategoryModel { get; set; }
    }  
}
