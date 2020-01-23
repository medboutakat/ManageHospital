using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class Room : NameRemark
    {
        public Room()
        {
            Materials = new HashSet<Material>();
        }

        public int RoomNumber { get; set; }

        public ICollection<Material> Materials { get; set; }

        public RoomCategory RoomCategory { get; set; }
    }

}
