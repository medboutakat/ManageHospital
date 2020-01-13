using System;
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class Operation
    {
        public Operation()
        {
            Doctors = new HashSet<Doctors>();
        }
        public Guid Id { private set; get; }

        public DateTime Date { set; get; }
        public string Price { set; get; } 
        public string TotalStayNight { set; get; } 

        ICollection<Doctors> Doctors { get; set; }

        OperationRoom OperationRoom { get; set; }
    }


}
