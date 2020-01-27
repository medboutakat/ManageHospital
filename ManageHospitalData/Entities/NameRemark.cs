using System;

namespace ManageHospitalData.Entities
{
    public abstract class NameRemark
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public string Remark { set; get; }
    } 
}
