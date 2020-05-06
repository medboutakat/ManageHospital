using System.Collections.Generic;

namespace   ManageHospitalModels.Models
{
    public class ProductCategoryModel : NameRemarkModel
    {
        public ProductCategoryModel()
        {
            OperationsModel = new HashSet<OperationModel>();
        }

        public ICollection<OperationModel> OperationsModel { get; set; }
    } 
}
