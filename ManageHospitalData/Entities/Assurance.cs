using System;

namespace ManageHospitalData.Entities
{
    public class Assurance
    {
        public int Id { private set; get; }
        public string Name { set; get; } 
        public Documents Documents { get; set; }
    }


}
