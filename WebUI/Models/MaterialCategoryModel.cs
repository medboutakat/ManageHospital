
using System.Collections.Generic;

namespace   ManageHospital.WebUI.Models
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