using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class MaterialStatus : NameRemark
    {
        public MaterialStatus()
        { 
            Materials = new HashSet<Material>();
        }

        public ICollection<Material>   Materials { get; set; }
    }
     
}
