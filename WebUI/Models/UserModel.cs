using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace   ManageHospital.WebUI.Models
{
    public class UserModel : PersonModel
    { 
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; } 

        public string Token { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; } 

        public Guid RoleId { get; set; }

        public RoleModel RoleModel { get; set; }

    }
}
