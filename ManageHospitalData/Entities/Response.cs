using System;
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class Response
    { 
        public Response()
        { 
            Requests = new HashSet<Request>();
        }

        public ICollection<Request> Requests { get; set; }

        public Guid Id { get; set; }

        public string Subject { get; set; } // subject appointement (test,stay,radio, etc) 
        public string Replay { get; set; } //Date Resesrvation
         
        public Guid? UserId { get; set; }
        public User User { get; set; }
    }
}
