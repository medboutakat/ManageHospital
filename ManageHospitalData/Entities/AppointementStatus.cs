using System;
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
   
    public class AppointementStatus
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }

        public AppointementStatus()
        {
            Appointements = new HashSet<Appointement>();
        }

        public ICollection<Appointement> Appointements { get; set; }
    }

}
