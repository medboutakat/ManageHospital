using System;
using System.Collections.Generic;

namespace ManageHospital.WebUI.Models
{
    public class OperationModel
    {
        public OperationModel()
        {
            DoctorsModel = new HashSet<DoctorModel>();
        }

        public Guid Id { set; get; }

        public DateTime Date { set; get; }
        public string Price { set; get; }
        public string TotalStayNight { set; get; }

        public ICollection<DoctorModel> DoctorsModel { get; set; }

        public Guid? OperationCategoryId { get; set; }
        public OperationCategoryModel OperationCategoryModel { get; set; }
        public RoomModel RoomModel { get; set; }
    }
}
