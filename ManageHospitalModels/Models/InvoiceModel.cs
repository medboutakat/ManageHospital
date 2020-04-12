using System;
using System.Collections.Generic;
using System.Text;

namespace ManageHospitalModels.Models
{
    public class InvoiceModel
    {  
        public Guid Id { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }

        public decimal TotalAmont { get; set; }
        public decimal Expedition { get; set; }
        public decimal Livraison { get; set; }
        public decimal Remise { get; set; }


        public ICollection<InvoiceDetailModel> InvoiceDetails { get; set; }
    }
}
