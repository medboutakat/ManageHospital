
using System; 
using System.ComponentModel.DataAnnotations;

namespace   ManageHospitalModels.Models
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

        public string CovePath { get; set; }

        public string PictureProfilePath { get; set; }

    }
}
