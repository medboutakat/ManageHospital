using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace   ManageHospital.WebUI.Models
{
    public class HospitalModel
    {
        public HospitalModel()
        { 
        }

        public Guid Id { get; set; }
        public string CountryHealthId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Remark { get; set; }
        public string History { get; set; }
        [Required]
        public Guid HospitalCategoryId { get; set; }
        public HospitalCategoryModel HospitalCategoryModel { get; set; } 
        public string CategoryName { get; set; }

        public Guid ContactId { get; set; }

        [Required]
        public ContactModel ContactModel { get; set; }

        public IFormFile ImageProfile { get; set; }

        public IFormFile ImageCover { get; set; } 

    }
}
