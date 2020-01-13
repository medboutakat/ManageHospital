using System;
using System.Collections.Generic;
using System.Text;

namespace ManageHospitalData.Entities
{
    public class TestResult
    {
        public TestResult()
        {
            Doctors = new HashSet<Doctor>();
        }

        public Guid Id { private set; get; }

        public DateTime DatePublish { set; get; }
        public Documents Documents { get; set; }
        public Test Test { get; set; }
        public string SentTo { get; set; }
        ICollection<Doctor> Doctors { get; set; }
    }
}
