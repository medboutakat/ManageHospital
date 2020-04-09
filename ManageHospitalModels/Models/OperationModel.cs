using System;
using System.Collections.Generic;

namespace ManageHospitalModels.Models
{
    public class OperationModel
    {
        public OperationModel()
        {
            DoctorIds = new HashSet<Guid>();
        }

        public Guid Id { set; get; }

        public DateTime Date { set; get; }
        public string Price { set; get; }
        public string TotalStayNight { set; get; }

        public ICollection<Guid> DoctorIds { get; set; }

        public Guid? OperationCategoryId { get; set; }
        public OperationCategoryModel OperationCategoryModel { get; set; }
        public RoomModel RoomModel { get; set; }
    }
}
