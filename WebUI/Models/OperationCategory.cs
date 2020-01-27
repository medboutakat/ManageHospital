using System.Collections.Generic;

namespace   ManageHospital.WebUI.Models
{
    public class OperationCategoryModel : NameRemarkModel
    {
        public OperationCategoryModel()
        {
            OperationsModel = new HashSet<OperationModel>();
        }

        public ICollection<OperationModel> OperationsModel { get; set; }
    } 
}
