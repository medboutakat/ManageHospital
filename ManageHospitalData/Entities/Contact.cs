﻿using System;

namespace ManageHospitalData.Entities
{
    public class Contact
    {
        public int Id { private set; get; }

        public string Email { set; get; }
        public string Phone1 { set; get; }
        public string Phone2 { set; get; }
        public string WhatsApp { set; get; }
        public string Fax { set; get; }
        public string City { set; get; }
        public string Adress1 { set; get; }
        public string Adress2 { set; get; }
        public string Other { set; get; }
    }


}
