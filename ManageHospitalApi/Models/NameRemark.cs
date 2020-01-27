using System;

namespace  ManageHospitalApi.Models
{
    public abstract class NameRemarkModel
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public string Remark { set; get; }
    } 
}
