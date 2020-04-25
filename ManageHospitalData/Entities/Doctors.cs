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

        public ICollection<DoctorOperation> DoctorOperations { get; set; }

        public DoctorCategory DoctorCategory { get; set; }
         
    }
}
