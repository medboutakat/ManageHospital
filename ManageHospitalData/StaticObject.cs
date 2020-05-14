using System;
using System.Collections.Generic;
using System.Text;

namespace ManageHospitalData
{
    public class StaticObject
    {


        private static Guid companyId = new Guid("252161AC-17DA-453E-894C-B993C0D21925");
        private static Guid patientId = new Guid("252161AC-17DA-453E-894C-B993C0D21925");
        //private static Guid ssusstanceId = new Guid("252161AC-17DA-453E-894C-B993C0D21925");
        //private static Guid doctorId = new Guid("252161AC-17DA-453E-894C-B993C0D21925");

        public static Guid CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }

        public static Guid PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }
    }
}
