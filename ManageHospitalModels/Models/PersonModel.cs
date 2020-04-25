using System;

namespace  ManageHospitalModels.Models
{
    public abstract class PersonModel
    {
        public Guid Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Sexe { set; get; }
        public Guid? ContactId { set; get; }
        public ContactModel ContactModel { get; set; }
    } 
}
