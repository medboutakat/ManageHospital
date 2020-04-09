using System.Collections.Generic;

namespace   ManageHospitalModels.Models
{
    public class MaterialStatusModel : NameRemarkModel
    {
        public MaterialStatusModel()
        {
            MaterialsModel = new HashSet<MaterialModel>();
        }

        public ICollection<MaterialModel> MaterialsModel { get; set; }
    }
     
}
