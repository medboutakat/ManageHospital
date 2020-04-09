using System;
using System.Collections.Generic;

namespace ManageHospitalModels.Models
{
    public class ResponseModel
    {
        public ResponseModel()
        {
            RequestModels = new HashSet<RequestModel>();
        }
        public ICollection<RequestModel> RequestModels { get; set; }

        public Guid Id { get; set; }

        public string Subject { get; set; } // subject appointement (test,stay,radio, etc) 
        public string Replay { get; set; } //Date Resesrvation

        public Guid? UserId { get; set; }
        public UserModel UserModel { get; set; }
    }
}
