
using System.Collections.Generic;

namespace   ManageHospitalModels.Models
{
    public class MaterialCategoryModel : NameRemarkModel
    {
        public MaterialCategoryModel()
        {
            HospitalsModel = new HashSet<MaterialModel>();
        }

        public ICollection<MaterialModel> HospitalsModel { get; set; }
    }
}