using System;

namespace ManageHospitalModels.Models
{
    public abstract class NameValueModel
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
    } 
}
