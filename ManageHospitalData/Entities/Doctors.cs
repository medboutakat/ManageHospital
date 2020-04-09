using System;
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class Doctor : Person
    {
        public Doctor() : base()
        {
            this.DoctorOperations = new HashSet<DoctorOperation>();
        }
        public DoctorCategory DoctorCategory { get; set; }
         
        public ICollection<DoctorOperation> DoctorOperations { get; set; }
    }
}
