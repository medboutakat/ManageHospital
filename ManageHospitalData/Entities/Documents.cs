using System;

namespace ManageHospitalData.Entities
{
    public class Documents
    {
        public Guid Id { private set; get; }
        public string Subject { set; get; }
        public string FileName { set; get; }
        public byte[] File { set; get; }
    } 
}
