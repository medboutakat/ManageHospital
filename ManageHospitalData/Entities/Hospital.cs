using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class Hospital
    {
        public Hospital()
        {
            //Materials = new HashSet<Material>();
            //Doctors = new HashSet<Doctor>();
            //Rooms = new HashSet<Room>();
            //Patients = new HashSet<Patient>();
            //Assutances = new HashSet<Assutance>();
            //Operations = new HashSet<Operation>();
            //Appointements = new HashSet<Appointement>();
            //Users = new HashSet<User>();
            //Roles = new HashSet<Role>();
            //Tests = new HashSet<Test>();
            //TestResults = new HashSet<TestResult>();
        }

        public int Id { get; set; }
        public string CountryHealthId { get; set; } 
        public string Name { get; set; }
        public string Remark { get; set; }
        public string History { get; set; }

        public int CategoryId { get; set; }
        public HospitalCategory Category { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }


        //public ICollection<Material> Materials { get; set; }
        //public ICollection<Doctor> Doctors { get; set; }
        //public ICollection<Room> Rooms { get; set; }
        //public ICollection<Patient> Patients { get; set; }
        //public ICollection<Assutance> Assutances { get; set; }
        //public ICollection<Operation> Operations { get; set; }
        //public ICollection<Appointement> Appointements { get; set; }
        //public ICollection<Test> Tests { get; set; }
        //public ICollection<TestResult> TestResults { get; set; }
        //public ICollection<User> Users { get; set; }
        //public ICollection<Role> Roles { get; set; }

    }
}
