using System.Collections.Generic;

namespace  ManageHospitalApi.Models
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
