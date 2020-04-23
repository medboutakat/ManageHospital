using System;
using System.Collections.Generic;
using System.Text;

namespace ManageHospitalData.Entities
{
    public class Settings
    {
        public Guid Id { get; set; }
        public string Group { get; set; }
        public string Key { get; set; }
        public string Display { get; set; }
        public string ParseType { get; set; }
        public string Value { get; set; }
    }
}
