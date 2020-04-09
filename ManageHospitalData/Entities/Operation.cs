using System;
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class Operation
    {
        public Operation()
        {
            DoctorOperations = new HashSet<DoctorOperation>();
        }

        public Guid Id { private set; get; }

        public DateTime Date { set; get; }
        public string Price { set; get; }
        public string TotalStayNight { set; get; }

         
        public ICollection<DoctorOperation> DoctorOperations { get; set; }

        public Guid? OperationCategoryId { get; set; }
        public OperationCategory OperationCategory { get; set; }
        public Room Room { get; set; }
    }


}
