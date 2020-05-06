
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class ProductCategory : NameRemark
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public ICollection<Product> Products { get; set; }
    }
}