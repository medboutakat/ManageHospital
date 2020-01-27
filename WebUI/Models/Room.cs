using System.Collections.Generic;

namespace   ManageHospital.WebUI.Models
{
    public class RoomModel : NameRemarkModel
    {
        public RoomModel()
        {
            MaterialsModel = new HashSet<MaterialModel>();
        }

        public int RoomNumber { get; set; }

        public ICollection<MaterialModel> MaterialsModel { get; set; }

        public RoomCategoryModel RoomCategoryModel { get; set; }
    } 
}
