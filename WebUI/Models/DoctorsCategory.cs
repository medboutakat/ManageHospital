using System.Collections.Generic;

namespace   ManageHospital.WebUI.Models
{
    public class DoctorCategoryModel:NameRemarkModel
    {
        public DoctorCategoryModel()
        {
            DoctorsModel = new HashSet<DoctorModel>();
        }

        public ICollection<DoctorModel> DoctorsModel { get; set; }
    } 
}
