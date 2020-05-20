using System.Collections.Generic;

namespace   ManageHospitalModels.Models
{
    public class ProductCategoryModel : NameRemarkModel
    {
        public ProductCategoryModel()
        {
            ProductsModel = new HashSet<ProductModel>();
        }

        public ICollection<ProductModel> ProductsModel { get; set; }
    } 
}
