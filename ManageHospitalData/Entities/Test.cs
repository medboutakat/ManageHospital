using System;
using System.Collections.Generic;
using System.Text;

namespace ManageHospitalData.Entities
{
    public class Test
    {
        public Test()
        {
            Doctors = new HashSet<Doctors>();
        }
        public Guid Id { private set; get; }

        public string Name { set; get; }
        public string Decription { set; get; }
        public string AnalyzeResult { set; get; }

        ICollection<Doctors> Doctors { get; set; } 
    }


}
