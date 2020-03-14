using System;

namespace ManageHospital.WebUI.Models
{
    public class RequestModel
    {

        public Guid Id { get; set; }

        public string Subject { get; set; } // subject appointement (test,stay,radio, etc) 
        public string Description { get; set; } //DateAppointement
        public string ReservationTimeStamp { get; set; } //Date Resesrvation

        public Guid? StatusId { get; set; }

        public RequestStatusModel Status { get; set; } //Accepted,NotAccepted,DelyedToAnnotherAppointement,Passed  

        public Guid? Materialid { get; set; }

        public MaterialModel MaterialModel { get; set; }

    }
}
