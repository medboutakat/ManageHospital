namespace ManageHospitalApi.Models
{
    public class PatientModel : PersonModel
    {
        public int Age { get; set; }
        public string IdentityNo { get; set; }
        public string Assurance { get; set; }
    }

}
