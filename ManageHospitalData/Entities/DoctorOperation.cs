using System;
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class DoctorOperation
    {
        public DoctorOperation()
        { 
        }

        public Guid Id { private set; get; } 

        public Guid? DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public Guid? OperationId { get; set; }
        public Operation Operation { get; set; }
    }


}
