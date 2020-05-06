using System;
using System.Collections.Generic;

namespace ManageHospitalModels.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
            InvoiceDetails = new HashSet<InvoiceDetailModel>();
            ProductImages = new HashSet<ProductImageModel>();
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
        public ProductCategoryModel ProductCategory  { get; set; }

        public ICollection<InvoiceDetailModel> InvoiceDetails { get; private set; }
        public ICollection<ProductImageModel> ProductImages { get; private set; }
    }
}
