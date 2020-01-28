using System;

namespace ManageHospital.WebUI.Models
{
    public class ContactModel
    {
        public Guid Id { private set; get; }

        public string Email { set; get; }
        public string Phone1 { set; get; }
        public string Phone2 { set; get; }
        public string WhatsApp { set; get; }
        public string Fax { set; get; }
        public string Adress1 { set; get; }
        public string Adress2 { set; get; }
        public string Other { set; get; }

        public int? CityId { get; set; }
        public CityModel CityModel { get; set; }
    }

    public class CityModel  
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Remark { set; get; }
        public RegionModel RegionModel { get; set; }
    }

    public class RegionModel  
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Remark { set; get; }
    }
}