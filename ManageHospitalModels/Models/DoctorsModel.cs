using System;

namespace   ManageHospitalModels.Models
{
    public class DoctorModel : PersonModel
    {
        public Guid DoctorCategoryId { get; set; }
        public DoctorCategoryModel DoctorCategoryModel { get; set; } 
    }  
}
