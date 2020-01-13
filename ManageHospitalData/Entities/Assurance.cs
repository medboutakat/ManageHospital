using System;

namespace ManageHospitalData.Entities
{
    public class Assurance
    {
        public Guid Id { private set; get; }
        public string Name { set; get; }
        public Contact contact { get; set; }
        public Documents Documents { get; set; }
    }


}
