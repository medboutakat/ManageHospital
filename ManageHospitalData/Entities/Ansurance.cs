using System;

namespace ManageHospitalData.Entities
{
    public class Ansurance
    {
        public int Id { private set; get; }
        public string Name { set; get; } 
        public Documents Documents { get; set; }
    }
}
