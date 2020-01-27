using System;
using System.Collections.Generic;

namespace  ManageHospitalApi.Models
{
    public class OperationResultModel
    {
        public OperationResultModel()
        { 
        }

        public Guid Id { private set; get; }

        public DateTime DatePublish { set; get; }
        public DocumentsModel DocumentsModel { get; set; }
        public TestModel TestModel { get; set; }
        public string SentTo { get; set; }
        public DoctorModel DoctorsModel { get; set; }

        public string PatienceState { get; set; }
    }

}
