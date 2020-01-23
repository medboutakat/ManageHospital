namespace ManageHospitalData.Entities
{
    public class Appointement
    {
        public int Id { get; set; }
        public string IdentityNo { get; set; }
        public string Assurance { get; set; }
        public string CallTimeStamp { get; set; } //DateAppointement
        public string ReservationTimeStamp { get; set; } //Date Resesrvation
        public string Subject { get; set; } // subject appointement (test,stay,radio, etc) 
        
        public int? StatusId { get; set; }
        public AppointementStatus Status { get; set; } //Accepted,NotAccepted,DelyedToAnnotherAppointement,Passed 
        public int? PatienceId { get; set; }
        public Patient Patience { get; set; }
        public int? AssutanceId { get; set; }
        public Assutance Assutance { get; set; }
    }
}
