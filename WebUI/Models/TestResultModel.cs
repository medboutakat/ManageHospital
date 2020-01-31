using System;
using System.Collections.Generic;
using System.Text;

namespace   ManageHospital.WebUI.Models
{
    public class TestResultModel
    {
        public TestResultModel()
        {
            DoctorsModel = new HashSet<DoctorModel>();
        }

        public Guid Id { private set; get; }

        public DateTime DatePublish { set; get; }
        public DocumentsModel DocumentsModel { get; set; }
        public TestModel TestModel { get; set; }
        public string SentTo { get; set; }
        ICollection<DoctorModel> DoctorsModel { get; set; }
    }
}
