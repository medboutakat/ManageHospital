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

        public Guid Id { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }


        public decimal TotalAmont { get; set; }
        public decimal Expedition { get; set; }
        public decimal Livraison { get; set; }
        public decimal Remise { get; set; }


        public ICollection<InvoiceDetail> InvoiceDetails { get; set; } 
    }
}
