﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace   ManageHospital.WebUI.Models
{
    public class HospitalModel
    {
        public HospitalModel()
        {
            //Materials = new HashSet<Material>();
            //Doctors = new HashSet<Doctor>();
            //Rooms = new HashSet<Room>();
            //Patients = new HashSet<Patient>();
            //Assutances = new HashSet<Assutance>();
            //Operations = new HashSet<Operation>();
            //Appointements = new HashSet<Appointement>();
            //Users = new HashSet<User>();
            //Roles = new HashSet<Role>();
            //Tests = new HashSet<Test>();
            //TestResults = new HashSet<TestResult>();
        }

        public Guid Id { get; set; }
        public string CountryHealthId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Remark { get; set; }
        public string History { get; set; }
        [Required]
        public Guid HospitalCategoryId { get; set; }
        public string CategoryName { get; set; }
        public HospitalCategoryModel HospitalCategoryModel { get; set; }

        public Guid ContactId { get; set; }

        [Required]
        public ContactModel ContactModel { get; set; }

        public IFormFile ImageProfile { get; set; }

        public IFormFile ImageCover { get; set; }

        //public ICollection<Material> Materials { get; set; }
        //public ICollection<Doctor> Doctors { get; set; }
        //public ICollection<Room> Rooms { get; set; }
        //public ICollection<Patient> Patients { get; set; }
        //public ICollection<Assutance> Assutances { get; set; }
        //public ICollection<Operation> Operations { get; set; }
        //public ICollection<Appointement> Appointements { get; set; }
        //public ICollection<Test> Tests { get; set; }
        //public ICollection<TestResult> TestResults { get; set; }
        //public ICollection<User> Users { get; set; }
        //public ICollection<Role> Roles { get; set; }

    }
}
