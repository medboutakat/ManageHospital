using System;
using System.Collections.Generic;

namespace  ManageHospitalModels.Models
{
    public class AppointementStatusModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }

        public AppointementStatusModel()
        {
            AppointementModels = new List<AppointementModel>();
        }

        public List<AppointementModel> AppointementModels { get; set; }
    } 
}
