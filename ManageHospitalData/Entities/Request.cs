using System;

namespace ManageHospitalData.Entities
{
    public class Request
    {
        public Guid Id { get; set; } 

        public string Subject { get; set; } // subject appointement (test,stay,radio, etc) 
        public string Description { get; set; } //DateAppointement
        public string ReservationTimeStamp { get; set; } //Date Resesrvation
        
        public Guid? StatusId { get; set; }
        public RequestStatus Status { get; set; } //Accepted,NotAccepted,DelyedToAnnotherAppointement,Passed  

        public Guid? Materialid { get; set; }
        public Material Material { get; set; } 
    }
}
