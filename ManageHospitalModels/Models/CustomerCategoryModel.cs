using System;
using System.Collections.Generic;

namespace   ManageHospitalModels.Models
{
    public class CustomerCategoryModel : NameRemarkModel
    {
        public CustomerCategoryModel()
        {
            CustomersModel = new HashSet<CustomerModel>();
        }
        

        public ICollection<CustomerModel> CustomersModel { get; set; }
    } 
}
