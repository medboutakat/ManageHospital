using System;
using System.Collections.Generic;

namespace ManageHospital.WebUI.Models
{
    public class RequestStatusModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }

        //public RequestStatusModel()
        //{
        //    RequestModels = new HashSet<RequestModels>();
        //}

        //public ICollection<RequestModel> RequestModels { get; set; }
    }


}
