using System;
using System.Collections.Generic;
using System.Text;

namespace ManageHospitalData.Entities
{
    public class Invoice
    {
        public Invoice()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        public Guid id { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }

        public double TotalAmont { get; set; }
        public decimal Expedition { get; set; }
        public decimal Livraison { get; set; }
        public decimal Remise { get; set; }


        public ICollection<InvoiceDetail> InvoiceDetails { get; set; } 
    }
}
