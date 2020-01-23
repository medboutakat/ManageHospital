using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class OperationCategory:NameRemark
    {
        public OperationCategory()
        {
            Operations = new HashSet<Operation>();
        }

        public ICollection<Operation> Operations { get; set; }
    } 
}
