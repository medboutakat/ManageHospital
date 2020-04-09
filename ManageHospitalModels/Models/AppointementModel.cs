using System;

namespace  ManageHospitalModels.Models
{
    public class AppointementModel
    {
        public Guid Id { get; set; }
        public string IdentityNo { get; set; }
        public string Assurance { get; set; }
        public string CallTimeStamp { get; set; } //DateAppointement
        public string ReservationTimeStamp { get; set; } //Date Resesrvation
        public string Subject { get; set; } // subject appointement (test,stay,radio, etc) 
        
        public int? StatusId { get; set; }
        public AppointementStatusModel Status { get; set; } //Accepted,NotAccepted,DelyedToAnnotherAppointement,Passed 
        public int? PatienceId { get; set; }
        public int? AssutanceId { get; set; }
        public AssutanceModel AssutanceModel { get; set; }

        public Guid? HospitalId { get; set; }
        public HospitalModel HospitalModel { get; set; } 
    }
}
