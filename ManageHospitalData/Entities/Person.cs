using System;

namespace ManageHospitalData.Entities
{
    public abstract class Person
    {
        public Guid Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Sexe { set; get; }
        public Guid? ContactId { set; get; }
        public Contact contact { get; set; }
    }


}
