﻿using System;

namespace ManageHospitalData.Entities
{
    public abstract class Settings
    {
        public Guid Id { private set; get; }
        public string Name { set; get; }
        public string Remark { set; get; }
    } 
}
