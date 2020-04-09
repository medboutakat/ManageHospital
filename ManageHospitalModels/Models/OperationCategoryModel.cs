using System.Collections.Generic;

namespace   ManageHospitalModels.Models
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
