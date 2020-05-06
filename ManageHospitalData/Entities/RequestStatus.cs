using System;
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{
    public class RequestStatus
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }

        public RequestStatus()
        {
            Requests = new HashSet<Request>();
        }

        public ICollection<Request> Requests { get; set; }
    }


}
