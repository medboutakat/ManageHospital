using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class CustomerCategory:NameRemark
    {
        public CustomerCategory()
        {
            Customers = new HashSet<Customer>();
        }

        public ICollection<Customer> Customers { get; set; }
    } 
}
