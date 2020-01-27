using System;

namespace ManageHospitalApi.Models
{
    public class DocumentsModel
    {
        public Guid Id { private set; get; }
        public string Subject { set; get; }
        public string FileName { set; get; }
        public byte[] File { set; get; }
    } 
}
