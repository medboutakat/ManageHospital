using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class HospitalCategory: NameRemark
    {

        public HospitalCategory()
        {
            Hospitals = new HashSet<Hospital>();
        }
          
        public ICollection<Hospital>  Hospitals { get; set; }
    } 

}
