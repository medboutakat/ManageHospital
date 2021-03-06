﻿using System.Collections.Generic;

namespace   ManageHospitalModels.Models
{
    public class HospitalCategoryModel : NameRemarkModel
    { 
        public HospitalCategoryModel()
        {
            HospitalsModel = new HashSet<HospitalModel>();
        }
          
        public ICollection<HospitalModel> HospitalsModel { get; set; }
    } 

}
