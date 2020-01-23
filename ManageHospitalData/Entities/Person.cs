using System;

namespace ManageHospitalData.Entities
{
    public abstract class Person
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Sexe { set; get; }
        public int? ContactId { set; get; }
        public Contact contact { get; set; }
    }


}
