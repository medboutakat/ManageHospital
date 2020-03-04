namespace ManageHospitalData.Entities
{
    public class Patient : User
    {
        public int Age { get; set; }
        public string IdentityNo { get; set; }
        public string Assurance { get; set; }
    } 
}
