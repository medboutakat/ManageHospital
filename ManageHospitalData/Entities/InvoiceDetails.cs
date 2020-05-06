﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ManageHospitalData.Entities
{
    public class InvoiceDetail
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; } 
        public decimal Qte { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { set; get; }
        public Guid InvoiceId { set; get; }

        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; } 
    }
}
