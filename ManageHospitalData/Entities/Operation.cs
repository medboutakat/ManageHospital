using System;
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class Operation
    {
        public Operation()
        {
            Doctors = new HashSet<Doctor>();
        }

        public int Id { private set; get; }

        public DateTime Date { set; get; }
        public string Price { set; get; }
        public string TotalStayNight { set; get; }

        public ICollection<Doctor> Doctors { get; set; }

        public OperationCategory OperationCategory { get; set; }
        public Room Room { get; set; }
    }


}
