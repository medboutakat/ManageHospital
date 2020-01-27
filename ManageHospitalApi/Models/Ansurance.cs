using System;

namespace ManageHospitalApi.Models
{
    public class AnsuranceModel
    {
        public Guid Id { private set; get; }
        public string Name { set; get; } 
        public DocumentsModel DocumentsModel { get; set; }
    }
}