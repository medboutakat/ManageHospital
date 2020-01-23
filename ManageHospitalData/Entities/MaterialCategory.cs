
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class MaterialCategory:NameRemark
    {
        public MaterialCategory()
        {
            Hospitals = new HashSet<Material>();
        }

        public ICollection<Material> Hospitals { get; set; }
    }
}