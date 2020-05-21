﻿using System;

namespace ManageHospitalData.Entities
{
    public abstract class NameValue
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }
    } 
}
