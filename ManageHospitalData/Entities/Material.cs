namespace ManageHospitalData.Entities
{
    public class Material : Settings
    {
        public int Quantity { get; set; }
        public MaterialStatus MaterialStatus { get; set; }
        public MaterialCategory MaterialCategory { get; set; }
    }

}
