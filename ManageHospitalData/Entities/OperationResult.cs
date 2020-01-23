using System;
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class OperationResult
    {
        public OperationResult()
        { 
        }

        public int Id { private set; get; }

        public DateTime DatePublish { set; get; }
        public Documents Documents { get; set; }
        public Test Test { get; set; }
        public string SentTo { get; set; }
        public Doctor Doctors { get; set; }

        public string PatienceState { get; set; }
    }

}
