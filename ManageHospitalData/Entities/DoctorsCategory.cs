using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class DoctorCategory:NameRemark
    {
        public DoctorCategory()
        {
            Doctors = new HashSet<Doctor>();
        }

        public ICollection<Doctor>  Doctors  { get; set; }
    } 
}
