using System.Collections.Generic;

namespace   ManageHospital.WebUI.Models
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
