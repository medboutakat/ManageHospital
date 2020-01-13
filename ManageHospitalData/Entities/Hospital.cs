namespace ManageHospitalData.Entities
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Assurance { get; set; }

        public HospitalCategory Category { get; set; }
        public Contact contact { get; set; }
    }


}
