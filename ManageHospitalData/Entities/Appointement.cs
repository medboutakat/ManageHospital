using System;

namespace ManageHospitalData.Entities
{
    public class Appointement
    {
        public Guid Id { get; set; }
        public string IdentityNo { get; set; }
        public string Assurance { get; set; }
        public string CallTimeStamp { get; set; } //DateAppointement
        public string ReservationTimeStamp { get; set; } //Date Resesrvation
        public string Subject { get; set; } // subject appointement (test,stay,radio, etc) 
        
        public Guid? StatusId { get; set; }
        public AppointementStatus Status { get; set; } //Accepted,NotAccepted,DelyedToAnnotherAppointement,Passed 
        public Guid? PatienceId { get; set; }
        public Patient Patience { get; set; }
        public Guid? AssutanceId { get; set; }
        public Assutance Assutance { get; set; }
    }
}
