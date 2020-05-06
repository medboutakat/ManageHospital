
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class MaterialCategory:NameRemark
    {
        public MaterialCategory()
        {
            Materials = new HashSet<Material>();
        }

        public ICollection<Material> Materials { get; set; }
    }
}