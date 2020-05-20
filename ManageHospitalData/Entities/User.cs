using System; 

namespace ManageHospitalData.Entities
{
    public class User : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; } 

        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}
