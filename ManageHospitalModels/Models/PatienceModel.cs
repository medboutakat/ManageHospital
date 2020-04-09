namespace  ManageHospitalModels.Models
{
    public class PatientModel : UserModel
    {
        public int Age { get; set; }
        public string IdentityNo { get; set; }
        public string Assurance { get; set; }
    }

}
