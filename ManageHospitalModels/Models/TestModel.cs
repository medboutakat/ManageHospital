using System;
using System.Collections.Generic;
using System.Text;

namespace   ManageHospitalModels.Models
{
    public class TestModel
    {
        public TestModel()
        {
            DoctorsModel = new HashSet<DoctorModel>();
        }
        public Guid Id { private set; get; }

        public string Name { set; get; }
        public string Decription { set; get; }
        public string AnalyzeResult { set; get; }

        ICollection<DoctorModel> DoctorsModel { get; set; } 
    }


}
