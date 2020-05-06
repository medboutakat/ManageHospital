using SysManage.Domain.Common;
using System;
using System.Collections.Generic;

namespace ManageHospitalData.Entities
{ 

    public class Product : AuditableEntity
    {
        public Product()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
            ProductImages = new HashSet<ProductImage>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? SupplierId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public Guid? ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public ICollection<InvoiceDetail> InvoiceDetails { get; private set; } 
        public ICollection<ProductImage> ProductImages { get; private set; }
    }
}
