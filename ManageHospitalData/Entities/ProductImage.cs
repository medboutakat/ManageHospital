using SysManage.Domain.Common;
using System; 

namespace ManageHospitalData.Entities
{
    public class ProductImage : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public Guid ProductId { get; set; } 
    }
}
