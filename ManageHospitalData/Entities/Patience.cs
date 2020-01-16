namespace ManageHospitalData.Entities
{
    public class Patient : Person
    {
        public int Age { get; set; }
        public string IdentityNo { get; set; }
        public string Assurance { get; set; }
    }

}
